package practica2;

public class MainPractica2 {
    public static void main(String[] args) {

        int n=5;

        int[] vector= new AsignarValores(n).addValores();

        new Thread(new HiloSumaVector(vector)).start();
        new Thread(new HiloSumaCuadradoVector(vector)).start();
        new Thread(new HiloMediaVector(vector)).start();




    }
}
