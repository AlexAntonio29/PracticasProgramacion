public class PRUEBA {

    int number;
    int fecha;
    int papas;

    public PRUEBA(int number, int papas, int fecha) {
        this.number = number;
        this.papas = papas;
        this.fecha = fecha;
    }

    public PRUEBA() {
    }

    public void setNumber(int number) {
        this.number = number;
    }

    public void setFecha(int fecha) {
        this.fecha = fecha;
    }

    public void setPapas(int papas) {
        this.papas = papas;
    }

    public int getNumber() {
        return number;
    }

    public int getFecha() {
        return fecha;
    }

    public int getPapas() {
        return papas;
    }
}
