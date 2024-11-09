import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;

class Proceso {
    String nombre;
    int tiempoLlegada;
    int rafagaCPU;
    int tiempoInicio;
    int tiempoFinalizacion;
    int tiempoEspera;
    int tiempoRespuesta;

    public Proceso(String nombre, int tiempoLlegada, int rafagaCPU) {
        this.nombre = nombre;
        this.tiempoLlegada = tiempoLlegada;
        this.rafagaCPU = rafagaCPU;
    }
}
