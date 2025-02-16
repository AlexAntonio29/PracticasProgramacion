/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 11/02/2025
 * Time: 12:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GUI_EJERCICIOS_BASICOS
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.calcularAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertidorGradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicioEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicioAumentoSalarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercico4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.condicionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio6ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio7ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio8ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ciclosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio4ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio5ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio6ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio7ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio8ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio9ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio10ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.calcularAreaToolStripMenuItem,
									this.convertidorGradosToolStripMenuItem,
									this.ejercicioEmpresaToolStripMenuItem,
									this.ejercicioAumentoSalarioToolStripMenuItem,
									this.ejercicio3ToolStripMenuItem,
									this.ejercico4ToolStripMenuItem,
									this.ejercicio5ToolStripMenuItem,
									this.ejercicio6ToolStripMenuItem,
									this.ejercicio7ToolStripMenuItem,
									this.ejercicio8ToolStripMenuItem,
									this.condicionalesToolStripMenuItem,
									this.ciclosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1459, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// calcularAreaToolStripMenuItem
			// 
			this.calcularAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.circuloToolStripMenuItem,
									this.trianguloToolStripMenuItem});
			this.calcularAreaToolStripMenuItem.Name = "calcularAreaToolStripMenuItem";
			this.calcularAreaToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
			this.calcularAreaToolStripMenuItem.Text = "Calcular Area";
			// 
			// circuloToolStripMenuItem
			// 
			this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
			this.circuloToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
			this.circuloToolStripMenuItem.Text = "Circulo";
			this.circuloToolStripMenuItem.Click += new System.EventHandler(this.CirculoToolStripMenuItemClick);
			// 
			// trianguloToolStripMenuItem
			// 
			this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
			this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
			this.trianguloToolStripMenuItem.Text = "Triangulo";
			this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.TrianguloToolStripMenuItemClick);
			// 
			// convertidorGradosToolStripMenuItem
			// 
			this.convertidorGradosToolStripMenuItem.Name = "convertidorGradosToolStripMenuItem";
			this.convertidorGradosToolStripMenuItem.Size = new System.Drawing.Size(180, 29);
			this.convertidorGradosToolStripMenuItem.Text = "Convertidor Grados";
			this.convertidorGradosToolStripMenuItem.Click += new System.EventHandler(this.ConvertidorGradosToolStripMenuItemClick);
			// 
			// ejercicioEmpresaToolStripMenuItem
			// 
			this.ejercicioEmpresaToolStripMenuItem.Name = "ejercicioEmpresaToolStripMenuItem";
			this.ejercicioEmpresaToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
			this.ejercicioEmpresaToolStripMenuItem.Text = "Venta";
			this.ejercicioEmpresaToolStripMenuItem.Click += new System.EventHandler(this.EjercicioEmpresaToolStripMenuItemClick);
			// 
			// ejercicioAumentoSalarioToolStripMenuItem
			// 
			this.ejercicioAumentoSalarioToolStripMenuItem.Name = "ejercicioAumentoSalarioToolStripMenuItem";
			this.ejercicioAumentoSalarioToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
			this.ejercicioAumentoSalarioToolStripMenuItem.Text = "Aumento";
			this.ejercicioAumentoSalarioToolStripMenuItem.Click += new System.EventHandler(this.EjercicioAumentoSalarioToolStripMenuItemClick);
			// 
			// ejercicio3ToolStripMenuItem
			// 
			this.ejercicio3ToolStripMenuItem.Name = "ejercicio3ToolStripMenuItem";
			this.ejercicio3ToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
			this.ejercicio3ToolStripMenuItem.Text = "Orden";
			this.ejercicio3ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio3ToolStripMenuItemClick);
			// 
			// ejercico4ToolStripMenuItem
			// 
			this.ejercico4ToolStripMenuItem.Name = "ejercico4ToolStripMenuItem";
			this.ejercico4ToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
			this.ejercico4ToolStripMenuItem.Text = "Descuento";
			this.ejercico4ToolStripMenuItem.Click += new System.EventHandler(this.Ejercico4ToolStripMenuItemClick);
			// 
			// ejercicio5ToolStripMenuItem
			// 
			this.ejercicio5ToolStripMenuItem.Name = "ejercicio5ToolStripMenuItem";
			this.ejercicio5ToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
			this.ejercicio5ToolStripMenuItem.Text = "Calificacion";
			this.ejercicio5ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio5ToolStripMenuItemClick);
			// 
			// ejercicio6ToolStripMenuItem
			// 
			this.ejercicio6ToolStripMenuItem.Name = "ejercicio6ToolStripMenuItem";
			this.ejercicio6ToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
			this.ejercicio6ToolStripMenuItem.Text = "Clasificacion";
			this.ejercicio6ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio6ToolStripMenuItemClick);
			// 
			// ejercicio7ToolStripMenuItem
			// 
			this.ejercicio7ToolStripMenuItem.Name = "ejercicio7ToolStripMenuItem";
			this.ejercicio7ToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
			this.ejercicio7ToolStripMenuItem.Text = "Trabajo";
			this.ejercicio7ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio7ToolStripMenuItemClick);
			// 
			// ejercicio8ToolStripMenuItem
			// 
			this.ejercicio8ToolStripMenuItem.Name = "ejercicio8ToolStripMenuItem";
			this.ejercicio8ToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
			this.ejercicio8ToolStripMenuItem.Text = "Minutos";
			this.ejercicio8ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio8ToolStripMenuItemClick);
			// 
			// condicionalesToolStripMenuItem
			// 
			this.condicionalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ejercicio1ToolStripMenuItem,
									this.ejercicio2ToolStripMenuItem,
									this.ejercicio3ToolStripMenuItem1,
									this.ejercicio4ToolStripMenuItem,
									this.ejercicio5ToolStripMenuItem1,
									this.ejercicio6ToolStripMenuItem1,
									this.ejercicio7ToolStripMenuItem1,
									this.ejercicio8ToolStripMenuItem1,
									this.ejercicio9ToolStripMenuItem,
									this.ejercicio10ToolStripMenuItem});
			this.condicionalesToolStripMenuItem.Name = "condicionalesToolStripMenuItem";
			this.condicionalesToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
			this.condicionalesToolStripMenuItem.Text = "Condicionales";
			// 
			// ejercicio1ToolStripMenuItem
			// 
			this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
			this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
			this.ejercicio1ToolStripMenuItem.Text = "Ejercicio 1";
			this.ejercicio1ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio1ToolStripMenuItemClick);
			// 
			// ejercicio2ToolStripMenuItem
			// 
			this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
			this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
			this.ejercicio2ToolStripMenuItem.Text = "Ejercicio 2";
			this.ejercicio2ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio2ToolStripMenuItemClick);
			// 
			// ejercicio3ToolStripMenuItem1
			// 
			this.ejercicio3ToolStripMenuItem1.Name = "ejercicio3ToolStripMenuItem1";
			this.ejercicio3ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio3ToolStripMenuItem1.Text = "Ejercicio 3";
			this.ejercicio3ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio3ToolStripMenuItem1Click);
			// 
			// ejercicio4ToolStripMenuItem
			// 
			this.ejercicio4ToolStripMenuItem.Name = "ejercicio4ToolStripMenuItem";
			this.ejercicio4ToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
			this.ejercicio4ToolStripMenuItem.Text = "Ejercicio 4";
			this.ejercicio4ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio4ToolStripMenuItemClick);
			// 
			// ejercicio5ToolStripMenuItem1
			// 
			this.ejercicio5ToolStripMenuItem1.Name = "ejercicio5ToolStripMenuItem1";
			this.ejercicio5ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio5ToolStripMenuItem1.Text = "Ejercicio 5";
			this.ejercicio5ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio5ToolStripMenuItem1Click);
			// 
			// ejercicio6ToolStripMenuItem1
			// 
			this.ejercicio6ToolStripMenuItem1.Name = "ejercicio6ToolStripMenuItem1";
			this.ejercicio6ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio6ToolStripMenuItem1.Text = "Ejercicio 6";
			this.ejercicio6ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio6ToolStripMenuItem1Click);
			// 
			// ejercicio7ToolStripMenuItem1
			// 
			this.ejercicio7ToolStripMenuItem1.Name = "ejercicio7ToolStripMenuItem1";
			this.ejercicio7ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio7ToolStripMenuItem1.Text = "Ejercicio 7";
			this.ejercicio7ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio7ToolStripMenuItem1Click);
			// 
			// ejercicio8ToolStripMenuItem1
			// 
			this.ejercicio8ToolStripMenuItem1.Name = "ejercicio8ToolStripMenuItem1";
			this.ejercicio8ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio8ToolStripMenuItem1.Text = "Ejercicio 8";
			this.ejercicio8ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio8ToolStripMenuItem1Click);
			// 
			// ejercicio9ToolStripMenuItem
			// 
			this.ejercicio9ToolStripMenuItem.Name = "ejercicio9ToolStripMenuItem";
			this.ejercicio9ToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
			this.ejercicio9ToolStripMenuItem.Text = "Ejercicio 9";
			this.ejercicio9ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio9ToolStripMenuItemClick);
			// 
			// ejercicio10ToolStripMenuItem
			// 
			this.ejercicio10ToolStripMenuItem.Name = "ejercicio10ToolStripMenuItem";
			this.ejercicio10ToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
			this.ejercicio10ToolStripMenuItem.Text = "Ejercicio 10";
			this.ejercicio10ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio10ToolStripMenuItemClick);
			// 
			// ciclosToolStripMenuItem
			// 
			this.ciclosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ejercicio1ToolStripMenuItem1,
									this.ejercicio2ToolStripMenuItem1,
									this.ejercicio3ToolStripMenuItem2,
									this.ejercicio4ToolStripMenuItem1,
									this.ejercicio5ToolStripMenuItem2,
									this.ejercicio6ToolStripMenuItem2,
									this.ejercicio7ToolStripMenuItem2,
									this.ejercicio8ToolStripMenuItem2,
									this.ejercicio9ToolStripMenuItem1,
									this.ejercicio10ToolStripMenuItem1});
			this.ciclosToolStripMenuItem.Name = "ciclosToolStripMenuItem";
			this.ciclosToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
			this.ciclosToolStripMenuItem.Text = "Ciclos";
			this.ciclosToolStripMenuItem.Click += new System.EventHandler(this.CiclosToolStripMenuItemClick);
			// 
			// ejercicio1ToolStripMenuItem1
			// 
			this.ejercicio1ToolStripMenuItem1.Name = "ejercicio1ToolStripMenuItem1";
			this.ejercicio1ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio1ToolStripMenuItem1.Text = "Ejercicio 1";
			this.ejercicio1ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio1ToolStripMenuItem1Click);
			// 
			// ejercicio2ToolStripMenuItem1
			// 
			this.ejercicio2ToolStripMenuItem1.Name = "ejercicio2ToolStripMenuItem1";
			this.ejercicio2ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio2ToolStripMenuItem1.Text = "Ejercicio 2";
			this.ejercicio2ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio2ToolStripMenuItem1Click);
			// 
			// ejercicio3ToolStripMenuItem2
			// 
			this.ejercicio3ToolStripMenuItem2.Name = "ejercicio3ToolStripMenuItem2";
			this.ejercicio3ToolStripMenuItem2.Size = new System.Drawing.Size(172, 30);
			this.ejercicio3ToolStripMenuItem2.Text = "Ejercicio 3";
			this.ejercicio3ToolStripMenuItem2.Click += new System.EventHandler(this.Ejercicio3ToolStripMenuItem2Click);
			// 
			// ejercicio4ToolStripMenuItem1
			// 
			this.ejercicio4ToolStripMenuItem1.Name = "ejercicio4ToolStripMenuItem1";
			this.ejercicio4ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio4ToolStripMenuItem1.Text = "Ejercicio 4";
			this.ejercicio4ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio4ToolStripMenuItem1Click);
			// 
			// ejercicio5ToolStripMenuItem2
			// 
			this.ejercicio5ToolStripMenuItem2.Name = "ejercicio5ToolStripMenuItem2";
			this.ejercicio5ToolStripMenuItem2.Size = new System.Drawing.Size(172, 30);
			this.ejercicio5ToolStripMenuItem2.Text = "Ejercicio 5";
			this.ejercicio5ToolStripMenuItem2.Click += new System.EventHandler(this.Ejercicio5ToolStripMenuItem2Click);
			// 
			// ejercicio6ToolStripMenuItem2
			// 
			this.ejercicio6ToolStripMenuItem2.Name = "ejercicio6ToolStripMenuItem2";
			this.ejercicio6ToolStripMenuItem2.Size = new System.Drawing.Size(172, 30);
			this.ejercicio6ToolStripMenuItem2.Text = "Ejercicio 6";
			this.ejercicio6ToolStripMenuItem2.Click += new System.EventHandler(this.Ejercicio6ToolStripMenuItem2Click);
			// 
			// ejercicio7ToolStripMenuItem2
			// 
			this.ejercicio7ToolStripMenuItem2.Name = "ejercicio7ToolStripMenuItem2";
			this.ejercicio7ToolStripMenuItem2.Size = new System.Drawing.Size(172, 30);
			this.ejercicio7ToolStripMenuItem2.Text = "Ejercicio 7";
			this.ejercicio7ToolStripMenuItem2.Click += new System.EventHandler(this.Ejercicio7ToolStripMenuItem2Click);
			// 
			// ejercicio8ToolStripMenuItem2
			// 
			this.ejercicio8ToolStripMenuItem2.Name = "ejercicio8ToolStripMenuItem2";
			this.ejercicio8ToolStripMenuItem2.Size = new System.Drawing.Size(172, 30);
			this.ejercicio8ToolStripMenuItem2.Text = "Ejercicio 8";
			this.ejercicio8ToolStripMenuItem2.Click += new System.EventHandler(this.Ejercicio8ToolStripMenuItem2Click);
			// 
			// ejercicio9ToolStripMenuItem1
			// 
			this.ejercicio9ToolStripMenuItem1.Name = "ejercicio9ToolStripMenuItem1";
			this.ejercicio9ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio9ToolStripMenuItem1.Text = "Ejercicio 9";
			this.ejercicio9ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio9ToolStripMenuItem1Click);
			// 
			// ejercicio10ToolStripMenuItem1
			// 
			this.ejercicio10ToolStripMenuItem1.Name = "ejercicio10ToolStripMenuItem1";
			this.ejercicio10ToolStripMenuItem1.Size = new System.Drawing.Size(172, 30);
			this.ejercicio10ToolStripMenuItem1.Text = "Ejercicio 10";
			this.ejercicio10ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio10ToolStripMenuItem1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1459, 594);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "GUI_EJERCICIOS_BASICOS";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem ejercicio10ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio9ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio8ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ejercicio7ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ejercicio6ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ejercicio5ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ejercicio4ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ciclosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio10ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio9ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio8ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio7ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio6ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio5ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem condicionalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio8ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio7ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio6ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio5ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercico4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicioAumentoSalarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicioEmpresaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem convertidorGradosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calcularAreaToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
