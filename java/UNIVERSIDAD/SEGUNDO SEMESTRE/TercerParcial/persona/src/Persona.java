public class Persona {
    public Persona(){
    }
    int id;
    String nombre;
    String apellidoP;
    String apellidoM;
    String ciudad;
    public Persona(int id, String nombre, String apellidoP, String apellidoM, String ciudad){

        this.id=id;
        this.nombre=nombre;
        this.apellidoP=apellidoP;
        this.apellidoM=apellidoM;
        this.ciudad=ciudad;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setApellidoP(String apellidoP) {
        this.apellidoP = apellidoP;
    }

    public void setApellidoM(String apellidoM) {
        this.apellidoM = apellidoM;
    }

    public void setCiudad(String ciudad) {
        this.ciudad = ciudad;
    }

    public int getId(int id) {
        return id;
    }

    public String getNombre(String nombre) {
        return nombre;
    }

    public String getApellidoP(String apellidoP) {
        return apellidoP;
    }

    public String getApellidoM(String apellidoM) {
        return apellidoM;
    }

    public String getCiudad(String ciudad) {
        return ciudad;
    }
}


