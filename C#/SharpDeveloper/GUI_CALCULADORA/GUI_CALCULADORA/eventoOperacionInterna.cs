/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 10/02/2025
 * Time: 12:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

public class eventoOperacionInterna
{
    public eventoOperacionInterna() {}

    public string operation(string resultado)
    {
        if (string.IsNullOrEmpty(resultado)) return "";
        List<string> signos = new List<string>();
        bool p = true;
        List<string> numeros = new List<string>();
        List<string> SumaReales = new List<string>();
        string num = resultado;
        string editNum = "0";
        string caracteresNumeros = "";
        
        for (int i = 0; i < num.Length; i++)
        {
            char caracter = num[i];
            if (EsNumero(caracter) || caracter == '.')
            {
                if (i == 0) signos.Add("+");
                caracteresNumeros += caracter;
                if (i == num.Length - 1)
                    numeros.Add(caracteresNumeros);
            }
            else
            {
            	
            	if ("x/+\u221A^-".Contains(caracter.ToString()))
                    signos.Add(caracter.ToString());
                if (i != 0)
                    numeros.Add(caracteresNumeros);
                caracteresNumeros = "";
            }
        }
        if (num[num.Length - 1] == '.') return "";
        
        int index = 0;
        string n = "1";
        foreach (string signo in signos)
        {
            char ultimoCaracter = num[num.Length - 1];
            switch (signo)
            {
                case "x":
                    if (ultimoCaracter == 'x') return "";
                    p = false;
                    editNum = Multiplicacion(n, numeros[index]);
                    break;
                case "/":
                    if (ultimoCaracter == '/') return "";
                    p = false;
                    editNum = Division(n, numeros[index]);
                    break;
                case "+":
                    if (ultimoCaracter == '+') return "";
                    p = false;
                    if (index != 0) SumaReales.Add(editNum);
                    n = numeros[index];
                    editNum = Suma(n);
                    break;
                case "-":
                    if (ultimoCaracter == '-') return "";
                    p = false;
                    if (index != 0) SumaReales.Add(editNum);
                    n = numeros[index];
                    editNum = Resta(n);
                    break;
                case "^":
                    if (ultimoCaracter == '^') return "";
                    p = false;
                    editNum = Potencia(n, numeros[index]);
                    break;
                case "\u221A":
                    if (p)
                    {
                        p = false;
                        SumaReales.Add(Raiz(numeros[index]));
                    }
                    else
                        p = true;
                    break;
            }
            if (EsNumero(ultimoCaracter))
            {
                if (index == signos.Count - 1) SumaReales.Add(editNum);
                else n = editNum;
            }
            index++;
        }
        double sumT = 0;
        foreach (string sumaT in SumaReales)
        {
            sumT += double.Parse(sumaT);
        }
        return sumT % 1 != 0 ? sumT.ToString() : ((int)sumT).ToString();
    }

    public string Suma(string n1) { return (double.Parse(n1) * 1).ToString();}
    public string Resta(string n1) {return (double.Parse(n1) * -1).ToString();}
    
    public string Multiplicacion(string n1, string n2)
    {
        double r = Math.Round(double.Parse(n1) * double.Parse(n2), 2);
        return r.ToString();
    }
    
    public string Division(string n1, string n2)
    {
        if (double.Parse(n2) == 0) return n2;
        double r = Math.Round(double.Parse(n1) / double.Parse(n2), 2);
        return r.ToString();
    }
    
    public string Potencia(string n1, string n2)
    {
        double r = Math.Round(Math.Pow(double.Parse(n1), double.Parse(n2)), 2);
        return r.ToString();
    }
    
    public string Raiz(string n1)
    {
        return Math.Sqrt(double.Parse(n1)).ToString();
    }
    
    public bool EsNumero(char str)
{
    return char.IsDigit(str) || str == '.';
}

    public string Factorial(string n)
    {
        int resultado = int.Parse(n);
        for (int i = resultado - 1; i > 1; i--)
        {
            resultado *= i;
        }
        return resultado.ToString();
    }
}

