public class Vendedor  extends Persona{
    int id;
    String area;
    float porcentajeComision;
    int sueldoBase;
Vendedor(){}
    public Vendedor(String nombre, String apellidoPaterno,String apellidomaterno, Fecha fechaNacimiento, int id, String area, float porcentajeComision,int sueldoBase) {
        super(nombre,apellidoPaterno,apellidomaterno,fechaNacimiento);
        this.id = id;
        this.area = area;
        this.porcentajeComision = porcentajeComision;
        this.sueldoBase = sueldoBase;
    }



    public float calcularComision() {

        System.out.println( "Area: "+area);
        float calcularComision=porcentajeComision*sueldoBase;
        System.out.println( "comision: "+calcularComision);
        return calcularComision;

    }

    public int getId() {
        return id;
    }

    public String getArea() {
        return area;
    }

    public float getPorcentajeComision() {
        return porcentajeComision;
    }

    public int getSueldoBase() {
        return sueldoBase;
    }
}
