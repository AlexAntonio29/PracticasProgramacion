import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class eventoPulsado implements ActionListener {
    String cadena;
    String cadenaRes;
    JTextField resultado;

    eventoPulsado(String cadena, String cadenaRes, JTextField resultado){
        this.cadena = cadena;
        this.cadenaRes = cadenaRes;
        this.resultado = resultado;

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

    public void actionPerformed(ActionEvent e) {


        switch(cadena){
            case "+": break;
            case "-": break;
            case "*": break;
            case ".": break;
            case "C": break;
            case "/": break;
            case "MR": break;
            case "ML": break;
            case "X^n": break;
            case "RAIZ": break;
            case "M+": break;
            case "M-": break;
            case "=": break;

            default :
                cadenaRes=cadenaRes+cadena;
                resultado.setText(cadenaRes);
                break;
        }

    }

    public void eventoSuma(){}
    public void eventoResta(){}
    public void eventoMultiplicacion(){}
    public void eventoPunto(){}
    public void eventoC(){}
    public void eventoDiagonal(){}
    public void eventoMR(){}
    public void eventoML(){}
    public void eventoXn(){}
    public void eventoRaiz(){}
    public void eventoMSuma(){}
    public void eventoMResta(){}
    public void eventoIgual(){}



}
