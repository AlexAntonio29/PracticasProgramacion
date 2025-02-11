/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 10/02/2025
 * Time: 12:44 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
//using System;

//namespace GUI_CALCULADORA
using System;
using System.Collections.Generic;

public class eventoPulsado
{
    private string cadena;
    private string cadenaRes;
    private static List<string> conjuntoEventosM = new List<string>();
    private static bool punto = true;
  eventoOperacionInterna operacion=new eventoOperacionInterna();

    public eventoPulsado(string cadena, string cadenaRes)
    {
        this.cadena = cadena;
        this.cadenaRes = cadenaRes;
    }

    public string GetCadena() {return cadena;}
    public string GetCadenaRes() {return cadenaRes;}
    public void SetCadena(string value) {cadena = value;}
    public void SetCadenaRes(string value) {cadenaRes = value;}

    public void Action()
    {
        string apuntador ="";

        if(!string.IsNullOrEmpty(cadenaRes)) apuntador = cadenaRes.Substring(cadenaRes.Length - 1, 1);
        Console.WriteLine(punto);
        
        switch (cadena)
        {
            case "+": EventoSuma(apuntador); break;
            case "-": EventoResta(apuntador); break;
            case "x": EventoMultiplicacion(apuntador); break;
            case ".": EventoPunto(apuntador); break;
            case "C": EventoC(); break;
            case "/": EventoDiagonal(apuntador); break;
            case "MR": EventoMR(); break;
            case "ML": EventoML(); break;
            case "X^n": EventoXn(apuntador); break;
            case "√": EventoRaiz(apuntador); break;
            case "M+": EventoMSuma(apuntador); break;
            case "M-": EventoMResta(apuntador); break;
            case "=": EventoIgual(); break;
            default: cadenaRes += cadena; break;
        }
        if (cadena == ".") punto = false;
    }

    private void EventoSuma(string apuntador) { EventoSignos(apuntador);}
    private void EventoResta(string apuntador) { EventoSignos(apuntador);}
    private void EventoMultiplicacion(string apuntador) { EventoSignos(apuntador);}
    private void EventoPunto(string apuntador) { if (punto) EventoSignos(apuntador); }
    private void EventoC() { punto = true; cadenaRes = ""; }
    private void EventoDiagonal(string apuntador) {EventoSignos(apuntador);}
    
    private void EventoMR()
    {
        string cadenaTemporal = string.Join("", conjuntoEventosM);
        cadenaRes = operacion.operation(cadenaTemporal);
    }
    
    private void EventoML()
    {
        if (EventosM(cadenaRes)) cadenaRes=operacion.Factorial(cadenaRes);
    }
    
    private void EventoXn(string apuntador)
    {
        if (EventosM(apuntador)) cadenaRes += "^";
    }
    
    private void EventoRaiz(string apuntador)
    {
         cadenaRes += "√";
    }
    
    private void EventoMSuma(string apuntador)
    {
        if (EventosM(apuntador))
        {
            string cadenaTemporal = conjuntoEventosM.Count == 0 ? operacion.operation(cadenaRes) : "+" + operacion.operation(cadenaRes);
            conjuntoEventosM.Add(cadenaTemporal);
        }
    }
    
    private void EventoMResta(string apuntador)
    {
        if (EventosM(apuntador)) conjuntoEventosM.Add("-" + operacion.operation(cadenaRes));
    }
    
    private void EventoIgual()
    {
        cadenaRes = operacion.operation(cadenaRes);
    }
    
    private void EventoSignos(string apuntador)
    {
        if (!string.IsNullOrEmpty(cadenaRes) && !"+-x/.^".Contains(apuntador)) cadenaRes += cadena;
    }
    
    private bool EventosM(string apuntador)
    {
        return !string.IsNullOrEmpty(cadenaRes) && !"+-x/.^".Contains(apuntador);
    }
}

