/*
 * Creado por SharpDevelop.
 * Usuario: Alexis
 * Fecha: 05/03/2025
 * Hora: 08:05 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;

namespace GUI_MATRICES
{
	/// <summary>
	/// Description of alerta.
	/// </summary>
	public class alerta : Form
	{
		public alerta()
		{
			   // Configurar la ventana
        this.Text = "ALERTA!!!";
        
        this.Size = new System.Drawing.Size(400, 300);
        this.StartPosition = FormStartPosition.CenterScreen;
		
        // Agregar un botón
        Button btnCerrar = new Button();
        btnCerrar.Text = "Cerrar";
        btnCerrar.Location = new System.Drawing.Point(150, 100);
        btnCerrar.Click += (sender, e) => this.Close(); // Evento para cerrar la ventana
		//Agregar label Texto
		
		Label texto = new Label();
	
		texto.Text="Error de Matriz";
		this.Controls.Add(texto);
		texto.Location = new System.Drawing.Point(150, btnCerrar.Top+30);
        // Agregar el botón a la ventana
        this.Controls.Add(btnCerrar);
        
       
		}
		
		public void accion(String cadena)
		{
			   
        
        
        
		}
	}
}
