/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 15/02/2025
 * Time: 09:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GUI_EJERCICIOS_BASICOS
{
	/// <summary>
	/// Description of ciclos.
	/// </summary>
	public class ciclos
	{
		public ciclos()
		{
		}
		
		
	public string SumatoriaUnoADiez()
    {
        int suma = 0;
        
        String cadena="";
        for (int i = 1; i <= 10; i++){ 
        	
        	if(i==10)cadena+=i+" = ";
        	else cadena+= i+" + ";
        	suma += i;}
        return cadena + suma.ToString();
    }

    public string SumatoriaMultiplosDeCinco()
    {
        int suma = 0;
        string result = "Numeros: ";
        for (int i = 5; i <= 100; i += 5)
        {
            result += i + " ";
            suma += i;
        }
        result += "\nSumatoria: " + suma;
        return result;
    }

    public string TablaMultiplicar(int n)
    {
        string result = "";
        for (int i = 1; i <= 100; i++)
        {
            result += n+"    x     "+ i+"     =     "+n * i+Environment.NewLine;
        }
        return result;
    }

    public string NumerosPrimos(int n)
    {
        string result = "";
        int contador=0;
       
        int count = 0, num = 2;
        while (count < n)
        {
        	
            bool esPrimo = true;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
            	contador++;
                result +=contador+".- "+ num + Environment.NewLine;
                count++;
            }
            num++;
        }
        return result;
    }

    public string Factorial(int n)
    {
        long fact = 1;
        string cadena="";
        for (int i = 1; i <= n; i++) {
        	fact *= i;
        	if(i==n) cadena+=i+" = "+fact;
        	else cadena+=i+" *";
        	
        	
        		
        }
        return cadena ;
    }

    public string NumerosImpares(int n)
    {
        string result = "";
        int count = 0, num = 1;
        while (count < n)
        {
            result += num + Environment.NewLine;
            num += 2;
            count++;
        }
        return result;
    }

    public string EsNumeroPerfecto(int num)
    {
        int suma = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0) suma += i;
        }
        return suma == num ? "Es perfecto" : "No es perfecto";
    }

    public string SonNumerosAmigos(int a, int b)
    {
        int sumaA = 0, sumaB = 0;
        for (int i = 1; i < a; i++) if (a % i == 0) sumaA += i;
        for (int i = 1; i < b; i++) if (b % i == 0) sumaB += i;
        return (sumaA == b && sumaB == a) ? "Son amigos" : "No son amigos";
    }

    public string ElevarNumero(int n, int p)
    {
    	
    	double num=1;
    	for(int i=0;i<p;i++){
    	num*=n;
    	}
        return num.ToString();
    }

    public string CalcularEx(int x)
    {
        double resultado = 1.0;
        double factorial = 1.0;
        for (int i = 1; i < 100; i++)
        {
            factorial *= i;
            resultado += Math.Pow(x, i) / factorial;
        }
        return resultado.ToString("F10");
    }
	}

	}

