import java.util.Scanner;
public class Main {
    public static Scanner lector=new Scanner(System.in);
    public static void main(String[] args) throws Exception {

        System.out.println("Excepciones");
        Exception excepcion = new Exception();
        excepcion.ExceptionArray();
        excepcion.ExceptionStringToInt();

        String lect_teclado=lector.next();
        int entero=7;
        System.out.println(lect_teclado+" "+entero);


        excepcion.CaracterEn(lect_teclado,entero);


        double [] v = new double [15];




        excepcion.acceso_por_indice (v, 16);



    }
}



