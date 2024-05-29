//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.


public class Ciclos {

    public String sum = "";

    int operacion(int n, int cond) {

        int i = 1, sumando = 1, numero = n;
        if (cond == 1) {
            while (numero > (2 * i) || numero <= 0) {
                if (numero % 2 == 0) {

                    sumando += numero / 2 + Math.pow(2, i);


                }
                numero /= 2;

                i++;

            }
        }

        if (cond == 2) {
            System.out.print(sumando);
            for (i = 2; i < n; i++) {
                if (n % i == 0) {
                    System.out.print(" + " + (n / i));
                    sumando += (n / i);

                }
                ;
            }

            System.out.println("= " + sumando);

        }
        //la tercera condicion es para la factorial
        if (cond == 3) {
            //la factorial se opera con !n=n(n-1)(n-2)....por tanto

            int acum = n;

            for (i = 1; i < n; i++) {
                //va agregando cadenas a cada posicion para que sea mejor represenatado

                acum *= (n - i);
            }

            return acum;
        }


        return sumando;
    }


    public int SumatoriaEnteros() {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
            sum += i;

        return sum;
    }


    public int SumatoriaMultiploCinco() {
        int sum = 0;
        for (int i = 0; i <= 100; i = i + 5) {

            sum += i;
            System.out.println(sum + "  ");
        }


        return sum;


    }

    public int[][] TablaMultiplicar(int n) {

        int[][] tabla = new int[n+1][n+1];
        for (int i = 0; i <= n; i ++) {
            for (int j = 0; j <= n; j++) {
                tabla[i][j] = i * j;

            }
            System.out.println();
        }


        return tabla;
    }

    public boolean NumerosPrimos(int n) {


        boolean acum = false;
        for (int i = 2; i < n; i++) {
            if ((n % i) == 0) {

                acum = true;
            }
        }


        return acum;
    }

    public int Factorial(int n) {


        return operacion(n, 3);
    }

    public String NumerosImpares(int n) {
        String sum = "";

        for (int i = 1; i <= n; i += 2) {

            sum = sum + String.valueOf(" -" + i + "- ");

        }

        //convierte los valores int en cadenas
        sum += String.valueOf("->" + n);


        return sum;
    }

    public boolean numeroPerfecto(int num1) {//El while termina si sumando es igual a n1 o n1=0;
        int i = 1, n;
        boolean res = false;

        n = operacion(num1, 1);
        System.out.println(n);
        if (n == num1) res = true;
        return res;


    }//NP= si modulo de 2 es 0 entonces sumando=numero/2 + 2i donde i se esta sumando ++

    public boolean numerosAmigos(int num1, int num2) {
        boolean res = false;
        int op1, op2;
        System.out.print("Numero 1: " + num1 + " ->");
        op1 = operacion(num1, 2);
        System.out.print("Numero 1: " + num2 + " ->");
        op2 = operacion(num2, 2);
        if (op1 == num2 && op2 == num1) res = true;

        return res;
    }

    public int NumeroPotencia(int n, int p) {

        int pot = 1;
        for (int i = 1; i <= p; i++) pot *= n;

        return pot;
    }

    public Double SerieTaylor(int n,int p) {//n representa la cantidad de acuerdoa a su aproximacion

        Double e = 1.0;

        for (int i = 1; i <= p; i++)

            e +=  (double)this.NumeroPotencia(n,i) / operacion(i, 3);



        return e;
    }


}
