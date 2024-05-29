import java.awt.geom.Area;
import java.util.Scanner;

public class TestFigura {
    public static void main(String[] args) {
        Scanner lector = new Scanner(System.in);
        Figura figura = new Figura() {

            @Override
            public double Area() {
                return 0;
            }

            @Override
            public double Perimetro() {
                return 0;
            }


        };

        double x, y, area, perimetro;

        int opc;

        do {

            System.out.println("*********************MENU*********************");
            System.out.println("1) Cuadrado ");
            System.out.println("2) Circulo");
            System.out.println("3) Triangulo");
            System.out.println("4)Pentagono");
            System.out.println("0)Salir");
            System.out.println("************************************************");
            opc = lector.nextInt();
            switch (opc) {
                case 1:
                    Cuadrado fig = new Cuadrado();
                    System.out.println("Inserta el lado del cuadrado");
                    x = lector.nextDouble();
                    fig.x = x;
                    area = fig.Area();
                    perimetro = fig.Perimetro();
                    System.out.println("El Area es " + area);
                    System.out.println("El Perimetro es " + perimetro);

                    break;
                case 2:
                    Circulo fig1 = new Circulo();
                    System.out.println("Inserta el radio del circulo");
                    x = lector.nextDouble();
                    fig1.radio = x;
                    area = fig1.Area();
                    perimetro = fig1.Perimetro();
                    System.out.println("El Area es " + area);
                    System.out.println("El Perimetro es " + perimetro);
                    break;
                case 3:
                    Triangulo fig2 = new Triangulo();
                    System.out.println("Inserta la base");
                    x = lector.nextDouble();
                    System.out.println("Inserta la altura");
                    y = lector.nextDouble();
                    fig2.x = x;
                    fig2.y = y;
                    double l = 0;
                    System.out.println("Ingrese el lado 1");
                    l = lector.nextDouble();
                    fig2.l1 = l;
                    System.out.println("Ingrese el lado 1");
                    l = lector.nextDouble();
                    fig2.l2 = l;
                    System.out.println("Ingrese el lado 1");
                    l = lector.nextDouble();
                    fig2.l3 = l;
                    area = fig2.Area();
                    perimetro = fig2.Perimetro();
                    System.out.println("El Area es " + area);
                    System.out.println("El Perimetro es " + perimetro);
                    break;
                case 4:
                    Pentagono fig3 = new Pentagono();
                    System.out.println("Inserta el lado");
                    x = lector.nextDouble();
                    fig3.x = x;
                    System.out.println("Inserta el apotema");
                    y = lector.nextDouble();
                    fig3.apotema = y;
                    area = fig3.Area();
                    perimetro = fig3.Perimetro();
                    System.out.println("El Area es " + area);
                    System.out.println("El Perimetro es " + perimetro);
                    break;


                case 0:
                    System.out.println("Saliendo");
                    break;

            }


        } while (opc != 0);


    }
}