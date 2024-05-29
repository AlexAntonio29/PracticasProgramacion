
import java.util.*;
public class Main {
    public static void main(String[] args) {

       String palabras="hola_como,estas";

       String[] conjuntoPalabras=palabras.split(",");


        for (String palabra: conjuntoPalabras){
            System.out.println(palabra);
            System.out.println();
        }




    }
}