public class Entrenador extends SeleccionFutbol {
    private String idFederacion;

    public Entrenador(int id, String Nombre, String Apellidos, int Edad, String idFederacion) {
        super(id, Nombre, Apellidos, Edad);

    }

    public Entrenador() {

    }


    public void setIdFederacion(String idFederacion) {
        this.idFederacion = idFederacion;
    }

    public String getIdFederacion() {
        return idFederacion;
    }

    public void dirigirPartido() {
        System.out.println("Estoy dirigiendo el partido");
    }

    public void dirigirEntrenamiento() {
        System.out.println("Estoy dirigiendo el Entrenamiento");
    }
}
