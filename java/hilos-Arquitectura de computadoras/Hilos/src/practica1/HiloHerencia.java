package practica1;

public class HiloHerencia extends Thread {

    public void run(){

        for(int i=1; i<=10; i=i+2){
            System.out.println("Hilo Herencia: " + i);
        }

    }
}
