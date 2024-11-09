import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;



public class SJFArrayList {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Número de procesos: ");
        int n = scanner.nextInt();

        ArrayList<Proceso> procesos = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            System.out.print("Nombre del proceso: ");
            String nombre = scanner.next();
            System.out.print("Tiempo de llegada: ");
            int tiempoLlegada = scanner.nextInt();
            System.out.print("Ráfaga de CPU: ");
            int rafagaCPU = scanner.nextInt();
            procesos.add(new Proceso(nombre, tiempoLlegada, rafagaCPU));
        }

        // Ordenar por ráfaga de CPU primero y luego por tiempo de llegada si hay empate
        Collections.sort(procesos, new Comparator<Proceso>() {
            @Override
            public int compare(Proceso p1, Proceso p2) {
                if (p1.rafagaCPU != p2.rafagaCPU) {
                    return p1.rafagaCPU - p2.rafagaCPU; // Prioridad a menor ráfaga
                }
                return p1.tiempoLlegada - p2.tiempoLlegada; // En caso de empate, por tiempo de llegada
            }
        });

        int tiempoActual = 0;

        // Calcular los tiempos de inicio, finalización, espera y respuesta para cada proceso
        for (Proceso p : procesos) {
            if (tiempoActual < p.tiempoLlegada) {
                tiempoActual = p.tiempoLlegada;
            }
            p.tiempoInicio = tiempoActual;
            p.tiempoFinalizacion = p.tiempoInicio + p.rafagaCPU;
            p.tiempoEspera = p.tiempoInicio - p.tiempoLlegada;
            p.tiempoRespuesta = p.tiempoEspera;
            tiempoActual = p.tiempoFinalizacion;
        }

        // Imprimir resultados
        System.out.println("\nResultados:");
        System.out.printf("%-10s %-15s %-15s %-15s %-15s %-15s\n", "Proceso", "Inicio", "Finalización", "Espera", "Respuesta", "Ráfaga");
        for (Proceso p : procesos) {
            System.out.printf("%-10s %-15d %-15d %-15d %-15d %-15d\n", p.nombre, p.tiempoInicio, p.tiempoFinalizacion, p.tiempoEspera, p.tiempoRespuesta, p.rafagaCPU);
        }

        scanner.close();
    }
}
