public class SeleccionFutbol {
    protected int id;
    protected String Nombre;

    protected String Apellidos;
    protected int Edad;


    public SeleccionFutbol(int id, String Nombre, String Apellidos, int Edad) {

        this.id = id;
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
        this.Edad = Edad;
    }

    public SeleccionFutbol() {

    }

    public void Concentrarse() {
        System.out.println("Estamos concentrados");
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setNombre(String nombre) {
        this.Nombre = nombre;
    }

    public void setApellidos(String apellidos) {
        this.Apellidos = apellidos;
    }

    public void setEdad(int edad) {
        this.Edad = edad;
    }

    public int getId() {
        return id;
    }

    public String getNombre() {
        return Nombre;
    }

    public String getApellidos() {
        return Apellidos;
    }

    public int getEdad() {
        return Edad;
    }


    public void Viajar() {

    }


}
