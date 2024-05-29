


public class CuentaInversion extends CuentaBancaria {

    int interes;
    int plazo;


    public CuentaInversion(long numeroCuenta, double saldo, String fechaAlta, Cliente cliente, int plazo, int interes) {
        super(numeroCuenta, saldo, fechaAlta, cliente);
        this.plazo = plazo;
        this.interes = interes;
    }

    public void proyectarInversion() {

        System.out.println("Proyectar Inversion");

        //Ocupamos la formula acumulada a traves del tiempo
        System.out.println("LA INVERSION ACUMULADA ES: ");
        double interesDecimal =(interes*.01) ;
        double inversion=1+ interesDecimal* plazo;
        System.out.println(saldo *inversion);


    }
}
