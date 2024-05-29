public class Fecha {
    int dia;
    int mes;
    int anio;

    public Fecha() {}
    public Fecha(int dia, int mes, int anio) {
        this.dia = dia;
        this.mes = mes;
        this.anio = anio;
    }
    public int getDia() {
        return dia;
    }
    public void setDia(int dia) {
        this.dia = dia;
    }

    public int getAnio() {
        return anio;
    }
    public void setAnio(int anio) {
        this.anio = anio;
    }

    public int getMes() {
        return mes;
    }
    public void setMes(int mes) {
        this.mes = mes;
    }
}
