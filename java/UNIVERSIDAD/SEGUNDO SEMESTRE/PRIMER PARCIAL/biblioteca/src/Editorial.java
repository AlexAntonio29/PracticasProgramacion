public class Editorial {

    private int id;
    private String nombre;
    private String direccion;
    private String telefono;
    private String ciudad;

    public Editorial(int id, String nombre, String direccion, String telefono, String ciudad) {
        this.id = id;
        this.nombre=nombre;
        this.direccion =direccion;
        this.telefono=telefono;
        this.ciudad=ciudad;
    }
    public Editorial(){

    }

    public int getId() {


        return id;
    }
    public String getNombre(){
        return nombre;
    }
    public String getDireccion(){
        return direccion;
    }
    public String getTelefono(){
        return telefono;
    }
    public String getCiudad(){
        return ciudad;
    }


    public void setId(int id) {
        this.id = id;
    }
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }
    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }
    public void setCiudad(String ciudad) {
        this.ciudad = ciudad;
    }

}
