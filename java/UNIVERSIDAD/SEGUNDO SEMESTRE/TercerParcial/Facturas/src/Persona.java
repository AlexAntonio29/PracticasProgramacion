public class Persona {
  String nombre;
  String apellidoPaterno;
  String apellidoMaterno;
  Fecha fechaNacimiento;
  public Persona(){}
    public Persona(String nombre,String apellidoPaterno,String apellidoMaterno,Fecha fechaNacimiento){
      this.nombre=nombre;
      this.apellidoPaterno=apellidoPaterno;
      this.apellidoMaterno=apellidoMaterno;
      this.fechaNacimiento=fechaNacimiento;
    }

    public Fecha getFechaNacimiento() {
        return fechaNacimiento;
    }

    public String getApellidoMaterno() {
        return apellidoMaterno;
    }

    public String getApellidoPaterno() {
        return apellidoPaterno;
    }

    public String getNombre() {
        return nombre;
    }

    public void setApellidoMaterno(String apellidoMaterno) {
        this.apellidoMaterno = apellidoMaterno;
    }

    public void setApellidoPaterno(String apellidoPaterno) {
        this.apellidoPaterno = apellidoPaterno;
    }

    public void setFechaNacimiento(Fecha fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}
