public class Autor {


    int id;//
    String nombre;
    String aPaterno;
    String aMaterno;
    String ciudad;


    public Autor(int id, String nombre, String aPaterno, String aMaterno, String ciudad) {

        this.id = id;//los this se utiliza para hacer el llamado fild
        this.nombre = nombre;
        this.aPaterno = aPaterno;
        this.aMaterno = aMaterno;
        this.ciudad = ciudad;
    }


    public Autor() {

    }

    public int getId(){
        return id;
    }
    public String getNombre(){
        return nombre;
    }
    public String getaPaterno(){
        return aPaterno;
    }
    public String getaMaterno(){
        return aMaterno;
    }
    public String getCiudad(){
        return ciudad;
    }
    //Los set
    public void setId(int id){
        this.id=id;

    }
    public void setNombre(String nombre){
        this.nombre=nombre;

    }
    public void setaPaterno(String aPaterno){
        this.aPaterno=aPaterno;

    }
    public void setaMaterno(String aMaterno){
        this.aMaterno=aMaterno;

    }
    public void setCiudad(String ciudad){
        this.ciudad=ciudad;

    }



}