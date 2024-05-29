public class Masajista extends SeleccionFutbol {
    private String Titulacion;


    public Masajista(int id, String Nombre, String Apellidos, int Edad, String Titulacion) {
        super(id, Nombre, Apellidos, Edad);
    }
    public Masajista(){}


    public void setTitulacion(String titulacion) {
        this.Titulacion = titulacion;
    }

    public String getTitulacion() {
        return Titulacion;
    }

    public void darMasaje(){
        System.out.println("Estoy masajeando");
    }
}