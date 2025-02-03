import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Objects;

public class eventoPulsado {
    String cadena;
    String cadenaRes;
    eventoOperacionInterna operacion=new eventoOperacionInterna();



    eventoPulsado(String cadena, String cadenaRes){
        this.cadena = cadena;
        this.cadenaRes = cadenaRes;



    }

    public String getCadena() {
        return cadena;
    }

    public String getCadenaRes() {
        return cadenaRes;
    }

    public void setCadenaRes(String cadenaRes) {
        this.cadenaRes = cadenaRes;
    }


    public void setCadena(String cadena) {
        this.cadena = cadena;
    }

    public void action() {
        String apuntador="";

    if(cadenaRes!=null&& !cadenaRes.isEmpty()) apuntador=String.valueOf(cadenaRes.charAt(cadenaRes.length()-1));
     //   System.out.println("");
      //  System.out.println(apuntador);

        switch(cadena){
            case "+": eventoSuma(apuntador); break;
            case "-": eventoResta(apuntador); break;
            case "x": eventoMultiplicacion(apuntador); break;
            case ".": eventoPunto(apuntador); break;
            case "C": eventoC(); break;
            case "/": eventoDiagonal(apuntador); break;
            case "MR": eventoMR(); break;
            case "ML": eventoML(); break;
            case "X^n": eventoXn(); break;
            case "RAIZ": eventoRaiz(); break;
            case "M+": eventoMSuma(); break;
            case "M-": eventoMResta(); break;
            case "=": eventoIgual(); break;

            default :
                cadenaRes=cadenaRes+cadena;
                break;
        }

    }

    public void eventoSuma(String apuntador){
        eventoSignos(apuntador);

    }
    public void eventoResta(String apuntador){
        eventoSignos(apuntador);
    }
    public void eventoMultiplicacion(String apuntador){
        eventoSignos(apuntador);
    }
    public void eventoPunto(String apuntador){
        eventoSignos(apuntador);
    }
    public void eventoC(){
        cadenaRes="";
    }

    public void eventoDiagonal(String apuntador){
        eventoSignos(apuntador);
    }
    public void eventoMR(){
        String cadenaTemporal= operacion.operation(cadenaRes);

        if (cadenaTemporal.isEmpty())  JOptionPane.showMessageDialog(null,"Datos mal implementados");
        else JOptionPane.showMessageDialog(null,"");
    }
    public void eventoML(){}
    public void eventoXn(){}
    public void eventoRaiz(){}
    public void eventoMSuma(){}
    public void eventoMResta(){}
    public void eventoIgual(){
        cadenaRes= operacion.operation(cadenaRes);

    }


public void eventoSignos(String apuntador){
    if (!cadenaRes.isEmpty() &&!Objects.equals(apuntador, "+") && !Objects.equals(apuntador, "-")
            && !Objects.equals(apuntador, "x") && !Objects.equals(apuntador, "/")&&
            !Objects.equals(apuntador, ".")) cadenaRes=cadenaRes+cadena;
}
}
