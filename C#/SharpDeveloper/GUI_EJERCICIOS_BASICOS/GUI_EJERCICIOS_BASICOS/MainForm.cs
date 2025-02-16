/*este es mi codigo no modifiques las estructura solo dale ese diseño inigualable /*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 11/02/2025
 * Time: 12:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_EJERCICIOS_BASICOS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SdsToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void CalcularAreaToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized; // Maximiza la ventana
    this.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
    
          this.BackColor = Color.FromArgb(30, 144, 255);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Estilo del MenuStrip
            menuStrip1.BackColor = Color.FromArgb(14, 5, 213);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            
		}
		
		void EjercicioEmpresaToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Venta Comision","Venta");
			ventana.ventaComision();
			
			
		}
		
		void CirculoToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			ventana ventana= new ventana("Area Circulo","Radio");
			ventana.areaCirculo();
			
		}
		
		void TrianguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Area Triangulo","Base", "Altura");
			ventana.areaTriangulo();
		}
		
		void ConvertidorGradosToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Convertidor Grados","Grados Farenheint", "Grados Celcius");
			ventana.calcularGrados();
		}
		
		void EjercicioAumentoSalarioToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			ventana ventana= new ventana("Aumento de Salario","Sindicalizado", "De confianza","Alto directivo","Ejecutivo");
			ventana.aumentoSalario();
		}
		
		void Ejercicio3ToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			ventana ventana= new ventana("Valor Mayor");
			ventana.valorMayor();
			
		}
		
		void Ejercico4ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Descuento VideoClub", "Producto 1","Producto 2","Producto 3");
			ventana.descuentoPrecio();
		}
		
		void Ejercicio5ToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			ventana ventana= new ventana("Aprobacion de un Alumno", "Calificacion");
			ventana.calificacionAprobatoria();
		}
		
		void Ejercicio6ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Clasificacion de un Alumno", "Calificacion");
			ventana.clasificacionAlumno();
			
		}
		
		void Ejercicio7ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Trabajo por Horas", "Horas","Salario por Hora ");
			ventana.trabajoHoras();
		}
		
		void Ejercicio8ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Clasificacion de Tiempo", "Minutos");
			ventana.calcularTiempo();
			
		}
		
		void Ejercicio1ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Mayor de Dos numeros", "A","B");
			ventana.ejercicio1();
		}
		
		void Ejercicio2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Mayor de Tres numeros", "Numero 1","Numero 2","Numero 3");
			ventana.ejercicio2();
		}
		
		void Ejercicio3ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Positivo o Negativo", "Numero");
			ventana.ejercicio3();
		}
		
		void Ejercicio4ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Conversion ", "Metros: ");
			ventana.ejercicio4();
		}
		
		void Ejercicio5ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Convertidor Grados","Grados Farenheint", "Grados Celcius");
			ventana.calcularGrados();
			
			
		}
		
		
		
		void Ejercicio6ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Servicio Militar","Edad", "Nacionalidad","Genero");
			ventana.ejercicio6();
			
		}
		
		void Ejercicio7ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Prestamo Mas Interes","Cantidad a Prestar");
			ventana.ejercicio7();
			
		}
		
		void Ejercicio8ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Calcular Comision","Venta");
			ventana.ejercicio8();
		}
		
		void Ejercicio9ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Aumento de Salario","Sindicalizado", "De confianza","Alto directivo","Ejecutivo");
			ventana.aumentoSalario();
		}
		
		void Ejercicio10ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Calcular x","x");
			ventana.ejercicio10();
			
		}
		
		void Ejercicio1ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Sumatoria de 1 al 10");
			ventana.ciclo1();
			
		}
		
		void Ejercicio2ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Multiplo de 5");
			ventana.ciclo2();
			
		}
		
		void Ejercicio3ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Tabla de Multiplicar","Numero");
			ventana.ciclo3();
			
		}
		
		void Ejercicio4ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Numeros Primos","Numero");
			ventana.ciclo4();
		}
		
		void Ejercicio5ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Factorial","Numero");
			ventana.ciclo5();
		}
		
		void Ejercicio6ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Numeros Impares","Numero");
			ventana.ciclo6();
		}
		
		void CiclosToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void Ejercicio7ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Numero Perfecto","Numero");
			ventana.ciclo7();
			
		}
		
		void Ejercicio8ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Numeros Amigos","Numero 1","Numero 2");
			ventana.ciclo8();
		}
		
		void Ejercicio9ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Elevacion de Potencia","Numero","Potencia");
			ventana.ciclo9();
		}
		
		void Ejercicio10ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ventana ventana= new ventana("Calcular Exponencial","Numero");
			ventana.ciclo10();
		}
	}
	
	
}