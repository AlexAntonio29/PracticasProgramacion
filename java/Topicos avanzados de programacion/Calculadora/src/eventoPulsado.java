import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.Objects;

public class eventoPulsado {
    String cadena;
    String cadenaRes;//regresa un resultado
    private static ArrayList<String> conjuntoEventosM=new ArrayList<>();
    private static Boolean punto=true;
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


        System.out.println(punto);
        switch(cadena){
            case "+": eventoSuma(apuntador); break;
            case "-": eventoResta(apuntador); break;
            case "x": eventoMultiplicacion(apuntador); break;
            case ".": eventoPunto(apuntador); break;
            case "C": eventoC(); break;
            case "/": eventoDiagonal(apuntador); break;
            case "MR": eventoMR(); break;
            case "ML": eventoML(); break;
            case "X^n": eventoXn(apuntador); break;
            case "√": eventoRaiz(apuntador); break;
            case "M+": eventoMSuma(apuntador); break;
            case "M-": eventoMResta(apuntador); break;
            case "=": eventoIgual(); break;

            default :
                cadenaRes=cadenaRes+cadena;
                break;
        }
        if (Objects.equals(cadena, ".")) punto=false;
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
        if (punto) eventoSignos(apuntador);
    }
    public void eventoC(){

        punto=true;
        cadenaRes="";
    }

    public void eventoDiagonal(String apuntador){
        eventoSignos(apuntador);
    }
    public void eventoMR(){
      //  String cadenaTemporal= operacion.operation(cadenaRes);
        String cadenaTemporal="";
        for (String evento: conjuntoEventosM){
            //System.out.printf(cadenaTemporal);
            cadenaTemporal+=evento;
        }
        /*  if (cadenaTemporal.isEmpty())  JOptionPane.showMessageDialog(null,"Datos mal implementados");
        else JOptionPane.showMessageDialog(null,cadenaTemporal+"\nResultado="+resultadoM);*/
        cadenaRes= operacion.operation(cadenaTemporal);
      //  conjuntoEventosM.clear();
    }
    public void eventoML(){
        if (eventosM(cadenaRes)) JOptionPane.showMessageDialog(null,operacion.factorial(cadenaRes));

    }
    public void eventoXn(String apuntador){

        if (eventosM(apuntador)) cadenaRes=cadenaRes+"^";


    }
    public void eventoRaiz(String apuntador){
        //√
        if (!Objects.equals(apuntador, "+") && !Objects.equals(apuntador, "-")
                && !Objects.equals(apuntador, "x") && !Objects.equals(apuntador, "/")&&
                !Objects.equals(apuntador, ".")&& !Objects.equals(apuntador, "^")&& !Objects.equals(apuntador, "√"))
            cadenaRes=cadenaRes+"√";



    }
    public void eventoMSuma(String apuntador){
        String cadenaTemporal="";
        if (eventosM(apuntador)) {
            if (conjuntoEventosM.isEmpty()) cadenaTemporal=operacion.operation(cadenaRes);
            else cadenaTemporal="+"+operacion.operation(cadenaRes);

           // System.out.printf(cadenaTemporal);
            conjuntoEventosM.add(cadenaTemporal);
        }

    }
    public void eventoMResta(String apuntador){
        String cadenaTemporal="";
        if (eventosM(apuntador)) {

            cadenaTemporal="-"+operacion.operation(cadenaRes);
           // System.out.printf(cadenaTemporal);
            conjuntoEventosM.add(cadenaTemporal);
        }
    }
    public void eventoIgual(){
        cadenaRes= operacion.operation(cadenaRes);
      //  punto=true;



    }


public void eventoSignos(String apuntador){



    if (!cadenaRes.isEmpty() &&!Objects.equals(apuntador, "+") && !Objects.equals(apuntador, "-")
            && !Objects.equals(apuntador, "x") && !Objects.equals(apuntador, "/")&&
            !Objects.equals(apuntador, ".")&& !Objects.equals(apuntador, "^")&& !Objects.equals(apuntador, "√")) cadenaRes=cadenaRes+cadena;
}

public boolean eventosM(String apuntador){
    if (!cadenaRes.isEmpty() &&!Objects.equals(apuntador, "+") && !Objects.equals(apuntador, "-")
            && !Objects.equals(apuntador, "x") && !Objects.equals(apuntador, "/")&&
            !Objects.equals(apuntador, ".")&& !Objects.equals(apuntador, "^")&& !Objects.equals(apuntador, "√"))
        return true;
else return false;
    }
}
