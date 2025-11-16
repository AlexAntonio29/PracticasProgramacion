package practica2;

public class AsignarValores {
    int n;

    AsignarValores(int n) {
        this.n = n;
    }

    public int[] addValores() {

        int[] valores = new int[n];

        for (int i = 0; i < n; i++)
            valores[i] = (int) (Math.random()*10)+1;

        for(int n: valores)
            System.out.print(n+" ");
        System.out.println();
        return valores;

    }
}
