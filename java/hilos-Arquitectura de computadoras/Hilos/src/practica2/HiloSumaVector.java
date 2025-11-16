package practica2;

public class HiloSumaVector implements Runnable {

    int[] vector;
    HiloSumaVector(int[] vector){
        this.vector = vector;
    }
    @Override
    public void run() {
        int suma=0;
        for(int i=0; i<vector.length; i++){
            suma += vector[i];
        }

        System.out.println("Suma vector: "+suma);
    }

}
