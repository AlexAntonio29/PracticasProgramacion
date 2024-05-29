public class Personaje {//creacion de personaje
    int id;
    String name;
    String clase;
    String fuerza;
    String resistencia;
    String vitalidad;
    String inteligencia;

    public Personaje(int id, String clase, String fuerza, String resistencia, String vitalidad, String inteligencia) {
    this.id=id;
    this.clase=clase;
    this.fuerza=fuerza;
    this.resistencia=resistencia;
    this.vitalidad=vitalidad;
    this.inteligencia=inteligencia;
    }

    public Personaje() {

    }


}