package practica1;
import  practica1.HiloHerencia;
import  practica1.HiloInterfaz;


public class MainPractica1 {

    public static void main(String[] args) {
        //System.out.println("Hilo Herencia Numeros impares");
        new Thread(new HiloInterfaz()).start();

        (new HiloHerencia()).start();
        // System.out.println("\n\nHilo interfaz Numeros pares");
    }
}
