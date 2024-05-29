public class Calculadora {

    //Funcion operacion que realiza la operacion Numero primo, Numero perfecto y Numero amigo para
    //ahorrar memoria
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


        return sumando;
    }


    public Calculadora() {
    }

    public double sumar(double n1, double n2) {
        return n1 + n2;

    }

    public double restar(double n1, double n2) {
        return n1 - n2;

    }

    public double dividir(double n1, double n2) {
        return n1 / n2;

    }

    public double multiplicar(double n1, double n2) {
        return n1 * n2;

    }

    public boolean par(int num1) {
        if (num1 % 2 == 0) return true;
        else return false;
    }

    //caracteristicas numeros primos: No se pueden dividir en numeros enteros
    //                              El numero 1 tambien es primo
    //Forma mas sencilla: Usar un for del 2 al 9 donde se modula el numero entre de 2 al 9, si el resultado
    //da al menos una vez 0, no es primo
    public boolean numeroPrimo(int num1) {
        boolean n = false;
        int num = operacion(num1, 2);
        if (num == 1) n = true;


        return n;


    }

    //Factorial es multiplicacion de un numero n(n-1).. 5!= 5*4*3*2*1=120
    public int factorial(double num1) {
        int res = 1;


        for (int i = (int) num1; i >= 1; i--)
            res *= i;

        return res;

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


}
