public class Futbolista extends SeleccionFutbol{
    private int dorsal;
    private String demarcacion;
    public Futbolista(int id, String Nombre, String Apellidos, int Edad, String demarcacion, int dorsal) {
        super(id, Nombre, Apellidos, Edad);
    }
    public Futbolista(){}

    public void setDemarcacion(String demarcacion) {
        this.demarcacion = demarcacion;
    }

    public void setDorsal(int dorsal) {
        this.dorsal = dorsal;
    }

    public int getDorsal() {
        return dorsal;
    }

    public String getDemarcacion() {
        return demarcacion;
    }

    public void jugarPartido(){
        System.out.println("Estoy jugando un partido");

    }
    public void entrenar(){
        System.out.println("Estoy entrenando");
    }
}
