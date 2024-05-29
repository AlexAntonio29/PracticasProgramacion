import java.util.Scanner;

public class TestCalculadora {


    public static void main(String[] args) {
        Scanner lector = new Scanner(System.in);

        int select = 1;
        double num1, num2, resultado;

        Calculadora operacion = new Calculadora();
        ;
        //Menu principal


        do {

            System.out.println("************MENU PRINCIPAL***************");
            System.out.println("1)Sumar");//double
            System.out.println("2)Restar");//double
            System.out.println("3)Dividir");//double
            System.out.println("4)Multiplicar");//double
            System.out.println("5)Par");//boolean
            System.out.println("6)Numero Primo");//boolean
            System.out.println("7)Factorial");//double
            System.out.println("8)Numero Perfecto");//boolean
            System.out.println("9)Numeros Amigos");//boolean
            System.out.println("0)Salir");
            System.out.println("**********************************************");
            System.out.println("SELECCIONA UNA OPCION");
            select = lector.nextInt();

            switch (select) {
                case 0:
                    System.out.println("Saliendo del programa..");

                    break;
                case 1:
                    System.out.println("************SUMA**************");
                    System.out.println("Introuduce dos numeros");
                    System.out.println("Numero :");
                    num1 = lector.nextDouble();
                    System.out.println("Numero :");
                    num2 = lector.nextDouble();


                    resultado = operacion.sumar(num1, num2);
                    System.out.println("El resultado es " + resultado);
                    System.out.println("***************************************");
                    break;
                case 2:
                    System.out.println("************RESTA**************");
                    System.out.println("Introuduce dos numeros");
                    System.out.println("Numero :");
                    num1 = lector.nextDouble();
                    System.out.println("Numero :");
                    num2 = lector.nextDouble();

                    resultado = operacion.restar(num1, num2);
                    System.out.println("El resultado es " + resultado);
                    System.out.println("***************************************");
                    break;
                case 3:
                    System.out.println("************DIVISION**************");
                    System.out.println("Introuduce dos numeros");
                    System.out.println("Numero :");
                    num1 = lector.nextDouble();
                    System.out.println("Numero :");
                    num2 = lector.nextDouble();
                    resultado = operacion.dividir(num1, num2);
                    System.out.println("El resultado es " + resultado);
                    System.out.println("***************************************");

                    break;
                case 4:
                    System.out.println("************MULTIPLICACION**************");
                    System.out.println("Introuduce dos numeros");
                    System.out.println("Numero :");
                    num1 = lector.nextDouble();
                    System.out.println("Numero :");
                    num2 = lector.nextDouble();

                    resultado = operacion.multiplicar(num1, num2);
                    System.out.println("El resultado es " + resultado);
                    System.out.println("***************************************");
                    break;
                case 5:
                    System.out.println("************NUMERO PAR**************");
                    System.out.println("Introuduce un numero");
                    System.out.println("Numero :");
                    num1 = lector.nextInt();

                    if (operacion.par((int) num1)) System.out.println("El numero es par");
                    else System.out.println("El numero no es par");

                    System.out.println("***************************************");
                    break;
                case 6:
                    System.out.println("************NUMERO PRIMO**************");
                    System.out.println("Introuduce un numero");
                    System.out.println("Numero :");
                    num1 = lector.nextInt();

                    if (operacion.numeroPrimo((int) num1)) System.out.println("El numero es primo");
                    else System.out.println("El numero no es primo");
                    System.out.println("***************************************");

                    break;
                case 7://Factorial
                    System.out.println("************FACTORIAL**************");
                    System.out.println("Introuduce un numero");
                    System.out.println("Numero :");
                    num1 = lector.nextDouble();

                    resultado = operacion.factorial(num1);
                    System.out.println("El factorial es " + resultado);
                    System.out.println("***************************************");
                    break;
                case 8://Numero Perfecto
                    System.out.println("************NUMERO PERFECTO**************");
                    System.out.println("Introuduce un numero");
                    System.out.println("Numero :");
                    num1 = lector.nextInt();

                    if (operacion.numeroPerfecto((int) num1)) System.out.println("El numero SI es perfecto");
                    else System.out.println("El numero NO es perfecto");
                    System.out.println("***************************************");

                    break;
                case 9://Numero Amigo
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
                default:
                    System.out.println("Dato no encontrado en el menu. Intente nuevamente....");
                    break;
            }
        } while (select != 0);
    }
}