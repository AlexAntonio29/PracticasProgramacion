import java.util.Scanner;

public class TestCiclos {

    public static void main(String[] args) {

        Scanner lector = new Scanner(System.in);

        int select = 1;


        int num1, num2, resultado;

        Ciclos operacion = new Ciclos();

        //Menu principal


        do {

            System.out.println("************MENU PRINCIPAL***************");
            System.out.println("1)Algoritmo suma");//int
            System.out.println("2)Algoritmo suma multiplo de 5");//int
            System.out.println("3)Tabla multiplicar N");//int
            System.out.println("4)Numeros primos N");//String
            System.out.println("5)Numero Factorial");//String
            System.out.println("6)Numeros impares");//String
            System.out.println("7)Numero Perfecto");//Boolean
            System.out.println("8)Numeros amigos");//Boolean
            System.out.println("9)Elevar Potencia");//Int
            System.out.println("10)Serie de Taylor ");//Int
            System.out.println("0)Salir");
            System.out.println("**********************************************");
            System.out.println("SELECCIONA UNA OPCION");
            select = lector.nextInt();

            switch (select) {
                case 0:
                    System.out.println("Saliendo del programa..");

                    break;
                case 1:
                    System.out.println("************ SUMATORIA DE 1 A 10 **************");
                    resultado = operacion.SumatoriaEnteros();
                    System.out.println("El resultado es " + resultado);
                    System.out.println("***************************************");
                    break;
                case 2:
                    System.out.println("************ SUMATORIA MULTIPLO 5 **************");


                    resultado = operacion.SumatoriaMultiploCinco();
                    System.out.println("= " + resultado);
                    System.out.println("***************************************");
                    break;
                case 3:
                    System.out.println("************TABLA MUTLIPLICAR**************");

                    System.out.println("Numero N:");
                    num1 = lector.nextInt();

                    int[][] tabla = operacion.TablaMultiplicar(num1);
                    for (int i = 0; i <= num1; i++) {
                        for (int j = 0; j <= num1; j++) {
                            System.out.print(tabla[i][j] + " ");
                            if ((tabla[i][j])<10) System.out.print(" ");
                        }
                        System.out.println();
                    }

                    System.out.println("***************************************");

                    break;
                case 4:
                    System.out.println("************NUMERO PRIMO**************");
                    System.out.println("Introuduce un numero");
                    System.out.println("Numero :");
                    num1 = lector.nextInt();


                    for (int i=2;i<num1;i++)
                        if (operacion.NumerosPrimos(i)==false) System.out.print(i+" ");
                    System.out.println();
                    System.out.println("***************************************");
                    break;
                case 5://Factorial
                    System.out.println("************FACTORIAL**************");
                    System.out.println("Introuduce un numero");
                    System.out.println("Numero :");
                    num1 = lector.nextInt();

                    System.out.println("El factorial es =" + operacion.Factorial(num1));
                    System.out.println("***************************************");
                    break;

                case 6:
                    System.out.println("************NUMERO IMPAR**************");
                    System.out.println("Introuduce un numero");
                    System.out.println("Numero :");
                    num1 = lector.nextInt();


                     System.out.println("Los numeros impares son: "+ operacion.NumerosImpares(num1));

                    System.out.println("***************************************");

                    break;
                case 7:
                    //Numero Perfecto
                    System.out.println("************NUMERO PERFECTO**************");
                    System.out.println("Introuduce un numero");
                    System.out.println("Numero :");
                    num1 = lector.nextInt();

                    if (operacion.numeroPerfecto((int) num1)) System.out.println("El numero SI es perfecto");
                    else System.out.println("El numero NO es perfecto");
                    System.out.println("***************************************");
                    break;

                case 8:
                    //Numero Amigo
                    System.out.println("************NUMERO AMIGO**************");
                    System.out.println("Introuduce dos numeros");
                    System.out.println("Numero :");
                    num1 = lector.nextInt();
                    System.out.println("Numero :");
                    num2 = lector.nextInt();


                    if (operacion.numerosAmigos((int) num1, (int) num2))
                        System.out.println("Los numeros SI son Amigos");
                    else System.out.println("Los numeros NO son amigos");

                    System.out.println("***************************************");
                    break;
                case 9://potencia
                    System.out.println("Agrega el valor :");
                    num1 = lector.nextInt();
                    System.out.println("Agrega el valor de potencia:");
                    num2 = lector.nextInt();

                    System.out.println("El resultado es " + (operacion.NumeroPotencia(num1,num2)));
                    break;
                case 10:
                    System.out.println("************SERIE DE TAYLOR**************");
                    System.out.println("Agrega el valor de x" );
                    num1 = lector.nextInt();
                    System.out.println("Agrega la aproximacion x :");
                    num2 = lector.nextInt();
                    System.out.println("La serie de Taylor con respecto a su aproximacion es " + (operacion.SerieTaylor(num1, num2-1)));
                    break;
                default:
                    System.out.println("Dato no encontrado en el menu. Intente nuevamente....");
                    System.out.println("***************************************");
                    break;
            }
        } while (select != 0);
    }
}
