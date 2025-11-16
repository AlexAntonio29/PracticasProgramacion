package practica1;

public class HiloInterfaz implements Runnable {

    @Override
    public void run() {
        //System.out.println("Hilo interfaz Numeros pares");
        for(int i=2; i<=10; i=i+2){
            System.out.println("Hilo Interfaz: " + i);
        }

        //System.out.println("\n\nHilo Herencia Numeros impares");
    }
}
