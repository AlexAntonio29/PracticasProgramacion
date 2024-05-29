public class Productos {
    int id;
    String descripcion;
    float precio;

    public Productos(int id, String descripcion, float precio) {
        this.id = id;
        this.descripcion = descripcion;
        this.precio = precio;
    }

    public Productos(){}

    public boolean agregar(int id,String descripcion,float precio){

        return true;


    }

    public Productos buscar(int id){
        if (id==this.id) return this;
        else return null;


    }

    public float getPrecio() {
        return precio;
    }

    public int getId() {
        return id;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setPrecio(float precio) {
        this.precio = precio;
    }
}
