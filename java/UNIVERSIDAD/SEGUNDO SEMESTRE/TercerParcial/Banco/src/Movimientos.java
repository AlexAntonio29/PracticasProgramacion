import java.util.Date;

public class Movimientos {
    String tipo;
    String fecha;
    double monto;
    double SaldoAnterior;
    double SaldoActual;

    public Movimientos(String tipo, String fecha, double monto, double SaldoAnterior, double SaldoActual){
        this.tipo=tipo;
        this.fecha=fecha;
        this.monto=monto;
        this.SaldoAnterior=SaldoAnterior;
        this.SaldoActual=SaldoActual;

    }

    public String getFecha() {
        return fecha;
    }

    public double getMonto() {
        return monto;
    }

    public double getSaldoActual() {
        return SaldoActual;
    }

    public double getSaldoAnterior() {
        return SaldoAnterior;
    }

    public String getTipo() {
        return tipo;
    }


}
