/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 14/02/2025
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GUI_EJERCICIOS_BASICOS
{
	/// <summary>
	/// Description of condicionales.
	/// </summary>
	public class condicionales
	{
		public condicionales()
		{
		}
		
		 public  string DeterminarMayorDeDos(string num1, string num2)
    {
        double a = double.Parse(num1);
        double b = double.Parse(num2);
        return (a > b) ? "El mayor es {A}" : (a < b) ? "El mayor es {B}" : "Ambos son iguales";
    }

    public  string DeterminarMayorDeTres(string num1, string num2, string num3)
    {
        double a = double.Parse(num1);
        double b = double.Parse(num2);
        double c = double.Parse(num3);
        double mayor = Math.Max(a, Math.Max(b, c));
        return "El mayor es "+ mayor;
    }

    public string EsPositivoONegativo(string num)
    {
        double n = double.Parse(num);
        return (n > 0) ? "Positivo" : (n < 0) ? "Negativo" : "Cero";
    }

    public  string ConvertirMetros(string metros)
    {
        double m = double.Parse(metros);
        return "Centímetros: "+m * 100+", Kilómetros: "+m / 1000+", Pies: "+m * 3.28084+", Pulgadas:"+ m * 39.3701;
    }

    public string ConvertirTemperatura(string celsius)
    {
        double c = double.Parse(celsius);
        double f = (c * 9 / 5) + 32;
        return "{c}°C equivale a {f}°F";
    }

    public  string ServicioMilitar(string edad, string nacionalidad, string genero)
    {
        int e = int.Parse(edad);
        return (e > 18 && e < 25 && nacionalidad.ToLower() == "mexicana" && genero.ToLower() == "masculino") 
            ? "Apto para el servicio militar" 
            : "No apto para el servicio militar";
    }

    public string CalcularInteres(string monto)
    {
        double m = double.Parse(monto);
        double interes = m * (1.8 / 100) * 12;
        return "Interés a pagar: "+interes+" MXN";
    }

    public string CalcularComision(string venta)
    {
        double v = double.Parse(venta);
        double comision = (v < 1000) ? v * 0.03 : v * 0.05;
        return "Comisión: "+ comision +" MXN";
    }
    
     public string CalcularX(string xs)
    {
     	
     	double x= double.Parse(xs);
     	if(x>64) return "0";
     	if(x>33||x<= 64) return (x+6).ToString();
     	if(x>11||x<= 33) return (Math.Pow(x,2)-10).ToString();
     	if(x<= 11) return (3*x+36).ToString();
     	
     	return "0";
     	
     	
     		
    }
    

   
		
	}
}
