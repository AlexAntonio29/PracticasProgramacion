package practica2;

public class HiloSumaCuadradoVector implements Runnable {
   int[] vector;
    HiloSumaCuadradoVector(int[]vector){
        this.vector = vector;
    }
    @Override
    public void run() {
            int suma = 0;
        for (int i = 0; i < vector.length; i++) {
            suma += Math.pow(vector[i], 2);
        }
        System.out.println("Suma Cuadrada Vector: "+suma);
    }
}
