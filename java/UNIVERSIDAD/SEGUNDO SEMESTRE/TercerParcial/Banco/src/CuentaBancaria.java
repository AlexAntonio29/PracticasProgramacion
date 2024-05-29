import java.util.Date;

public class CuentaBancaria {


    long numeroCuenta;
    double saldo;
    String fechaAlta;
    Cliente cliente;
    public CuentaBancaria(long numeroCuenta, double saldo, String fechaAlta, Cliente cliente){
        this.numeroCuenta=numeroCuenta;
        this.saldo=saldo;
        this.fechaAlta=fechaAlta;
        this.cliente=cliente;
    }

    public void setNumeroCuenta(long numeroCuenta) {
        this.numeroCuenta = numeroCuenta;
    }

    public void setFechaAlta(String fechaAlta) {
        this.fechaAlta = fechaAlta;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public String getFechaAlta() {
        return fechaAlta;
    }

    public double getSaldo() {
        return saldo;
    }

    public long getNumeroCuenta() {
        return numeroCuenta;
    }
}
