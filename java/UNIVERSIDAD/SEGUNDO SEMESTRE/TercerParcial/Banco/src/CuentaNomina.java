import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Date;


public class CuentaNomina extends CuentaBancaria {
    ArrayList<Movimientos> listaMovimeinto = new ArrayList<>();


    public CuentaNomina(long numeroCuenta, double saldo, String fechaAlta, Cliente cliente) {

        super(numeroCuenta, saldo, fechaAlta, cliente);

    }

    public void setListaMovimeinto(ArrayList<Movimientos> listaMovimeinto) {
        this.listaMovimeinto = listaMovimeinto;
    }

    public ArrayList<Movimientos> getListaMovimeinto() {
        return listaMovimeinto;
    }


    public double depositar(double cantidad) {

        String tipo = "DEPOSITO";
        String fecha = String.valueOf(new Date());
        double monto = cantidad;
        double SaldoAnterior = saldo;
        this.saldo += cantidad;

        System.out.println("Deposito Correcto");

        Movimientos movimiento = new Movimientos(tipo, fecha, monto, SaldoAnterior, saldo);

        addMovimeinto(movimiento);
        writeFileMovimiento();

        return this.saldo;


    }

    public double retirar(double cantidad) {

        if (cantidad > saldo) {
            System.out.println("Retiro mayor a saldo disponible");
            return 0;
        } else {
            System.out.println("Retiro Correcto");
            String tipo = "RETIRO";
            String fecha = String.valueOf(new Date());
            double monto = cantidad;
            double SaldoAnterior = saldo;
            this.saldo -= cantidad;


            Movimientos movimiento = new Movimientos(tipo, fecha, monto, SaldoAnterior, saldo);
            addMovimeinto(movimiento);
            writeFileMovimiento();


            return this.saldo;
        }


    }

    public void addMovimeinto(Movimientos m) {
        listaMovimeinto.add(m);
    }

    public void writeFileMovimiento() {

        try {
            PrintWriter pw = new PrintWriter(new PrintWriter(String.valueOf(numeroCuenta) + ".txt"));
            for (Movimientos movimientos : listaMovimeinto) {

                pw.print(movimientos.tipo + ",");
                pw.print(movimientos.fecha + ",");
                pw.print(movimientos.monto + ",");
                pw.print(movimientos.getSaldoAnterior() + ",");
                pw.print(movimientos.getSaldoActual() );


                pw.println();

            }
            pw.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }


}
