package practica2;

public class HiloMediaVector implements Runnable{
    int[] vector;
    HiloMediaVector(int[] vector){
        this.vector = vector;
    }
    @Override
    public void run() {
        int suma = 0;

        for (int i = 0; i < vector.length; i++) {
            suma += vector[i];
        }
        System.out.println("Media Aritmetica Vector " + suma/vector.length);

    }
}
