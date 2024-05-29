
import java.util.*;

public class Exception extends Throwable {


    Exception() {
    }

    public Exception(String s) {
    }

    public void ExceptionArray() {
        try {
            String[] array_string = new String[25];
            System.out.println(array_string[3].length());
        } catch (NullPointerException e) {
            System.out.println(e.getMessage());
        }


    }

    public void ExceptionStringToInt() {
        try {
            String aux = "hola";
            int aux2 = Integer.parseInt(aux);
        } catch (NumberFormatException e) {
            System.out.println(e.getMessage());
        }

    }

    public void CaracterEn(String cadena, int entero) {

        try {
            if (entero <= cadena.length() && entero >= 0) {
                char caracter = cadena.charAt(entero);
                System.out.println(caracter);
            } else {
                throw new RuntimeException();
            }
        } catch (RuntimeException e) {
            System.out.println("Has intentado recuperar una posición de la cadena de caracteres que no existe");
        }


    }

    public static double acceso_por_indice(double[] v, int j) throws Exception{
        try {
            if ((0 <= j) && (j <= v.length)) {
                return v[j];
            } else {

                throw new RuntimeException("El indice " + j + " no existe en el vector");
            }



        }catch (RuntimeException exc){
            throw exc;
        }


    }







}
