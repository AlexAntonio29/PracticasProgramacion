/*
 * Creado por SharpDevelop.
 * Usuario: Alexis
 * Fecha: 07/03/2025
 * Hora: 07:46 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CONEXION_BD
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lbNombre = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.lbId = new System.Windows.Forms.Label();
			this.bBorrar = new System.Windows.Forms.Button();
			this.bActualizar = new System.Windows.Forms.Button();
			this.bAgregar = new System.Windows.Forms.Button();
			this.tbDia = new System.Windows.Forms.TextBox();
			this.lbNacimiento = new System.Windows.Forms.Label();
			this.tbPaterno = new System.Windows.Forms.TextBox();
			this.lbApPaterno = new System.Windows.Forms.Label();
			this.tbMaterno = new System.Windows.Forms.TextBox();
			this.lbApMaterno = new System.Windows.Forms.Label();
			this.tbCalle = new System.Windows.Forms.TextBox();
			this.lbCalle = new System.Windows.Forms.Label();
			this.tbTelefono = new System.Windows.Forms.TextBox();
			this.lbTelefono = new System.Windows.Forms.Label();
			this.cbNombre = new System.Windows.Forms.ComboBox();
			this.tbAno = new System.Windows.Forms.TextBox();
			this.tbMes = new System.Windows.Forms.TextBox();
			this.lbdia = new System.Windows.Forms.Label();
			this.lbMes = new System.Windows.Forms.Label();
			this.lbAno = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(44, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(505, 232);
			this.dataGridView1.TabIndex = 0;
			// 
			// lbNombre
			// 
			this.lbNombre.Location = new System.Drawing.Point(47, 283);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(132, 23);
			this.lbNombre.TabIndex = 1;
			this.lbNombre.Text = "Nombre";
			this.lbNombre.Click += new System.EventHandler(this.Label1Click);
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(200, 280);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(91, 26);
			this.tbNombre.TabIndex = 2;
			this.tbNombre.TextChanged += new System.EventHandler(this.TbNombreTextChanged);
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(732, 169);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(188, 26);
			this.tbId.TabIndex = 4;
			// 
			// lbId
			// 
			this.lbId.Location = new System.Drawing.Point(579, 172);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(90, 23);
			this.lbId.TabIndex = 3;
			this.lbId.Text = "No. Control";
			// 
			// bBorrar
			// 
			this.bBorrar.Location = new System.Drawing.Point(592, 91);
			this.bBorrar.Name = "bBorrar";
			this.bBorrar.Size = new System.Drawing.Size(108, 45);
			this.bBorrar.TabIndex = 5;
			this.bBorrar.Text = "Borrar";
			this.bBorrar.UseVisualStyleBackColor = true;
			this.bBorrar.Click += new System.EventHandler(this.BBorrarClick);
			// 
			// bActualizar
			// 
			this.bActualizar.Location = new System.Drawing.Point(732, 91);
			this.bActualizar.Name = "bActualizar";
			this.bActualizar.Size = new System.Drawing.Size(108, 46);
			this.bActualizar.TabIndex = 6;
			this.bActualizar.Text = "Actualizar";
			this.bActualizar.UseVisualStyleBackColor = true;
			this.bActualizar.Click += new System.EventHandler(this.BActualizarClick);
			// 
			// bAgregar
			// 
			this.bAgregar.Location = new System.Drawing.Point(864, 91);
			this.bAgregar.Name = "bAgregar";
			this.bAgregar.Size = new System.Drawing.Size(108, 46);
			this.bAgregar.TabIndex = 7;
			this.bAgregar.Text = "Agregar";
			this.bAgregar.UseVisualStyleBackColor = true;
			this.bAgregar.Click += new System.EventHandler(this.BAgregarClick);
			// 
			// tbDia
			// 
			this.tbDia.Location = new System.Drawing.Point(829, 280);
			this.tbDia.Name = "tbDia";
			this.tbDia.Size = new System.Drawing.Size(40, 26);
			this.tbDia.TabIndex = 11;
			// 
			// lbNacimiento
			// 
			this.lbNacimiento.Location = new System.Drawing.Point(676, 283);
			this.lbNacimiento.Name = "lbNacimiento";
			this.lbNacimiento.Size = new System.Drawing.Size(132, 23);
			this.lbNacimiento.TabIndex = 10;
			this.lbNacimiento.Text = "F. Nacimiento";
			// 
			// tbPaterno
			// 
			this.tbPaterno.Location = new System.Drawing.Point(501, 283);
			this.tbPaterno.Name = "tbPaterno";
			this.tbPaterno.Size = new System.Drawing.Size(91, 26);
			this.tbPaterno.TabIndex = 15;
			// 
			// lbApPaterno
			// 
			this.lbApPaterno.Location = new System.Drawing.Point(348, 286);
			this.lbApPaterno.Name = "lbApPaterno";
			this.lbApPaterno.Size = new System.Drawing.Size(140, 23);
			this.lbApPaterno.TabIndex = 14;
			this.lbApPaterno.Text = "Apellido Paterno";
			// 
			// tbMaterno
			// 
			this.tbMaterno.Location = new System.Drawing.Point(501, 332);
			this.tbMaterno.Name = "tbMaterno";
			this.tbMaterno.Size = new System.Drawing.Size(91, 26);
			this.tbMaterno.TabIndex = 13;
			// 
			// lbApMaterno
			// 
			this.lbApMaterno.Location = new System.Drawing.Point(348, 335);
			this.lbApMaterno.Name = "lbApMaterno";
			this.lbApMaterno.Size = new System.Drawing.Size(147, 23);
			this.lbApMaterno.TabIndex = 12;
			this.lbApMaterno.Text = "Apellido Materno";
			// 
			// tbCalle
			// 
			this.tbCalle.Location = new System.Drawing.Point(829, 332);
			this.tbCalle.Name = "tbCalle";
			this.tbCalle.Size = new System.Drawing.Size(91, 26);
			this.tbCalle.TabIndex = 19;
			// 
			// lbCalle
			// 
			this.lbCalle.Location = new System.Drawing.Point(676, 335);
			this.lbCalle.Name = "lbCalle";
			this.lbCalle.Size = new System.Drawing.Size(90, 23);
			this.lbCalle.TabIndex = 18;
			this.lbCalle.Text = "Calle";
			// 
			// tbTelefono
			// 
			this.tbTelefono.Location = new System.Drawing.Point(200, 335);
			this.tbTelefono.Name = "tbTelefono";
			this.tbTelefono.Size = new System.Drawing.Size(91, 26);
			this.tbTelefono.TabIndex = 17;
			this.tbTelefono.TextChanged += new System.EventHandler(this.TbTelefonoTextChanged);
			// 
			// lbTelefono
			// 
			this.lbTelefono.Location = new System.Drawing.Point(47, 335);
			this.lbTelefono.Name = "lbTelefono";
			this.lbTelefono.Size = new System.Drawing.Size(90, 23);
			this.lbTelefono.TabIndex = 16;
			this.lbTelefono.Text = "Telefono";
			// 
			// cbNombre
			// 
			this.cbNombre.DisplayMember = "(Colección)";
			this.cbNombre.FormattingEnabled = true;
			this.cbNombre.Items.AddRange(new object[] {
									"alumnos",
									"maestros",
									"materia"});
			this.cbNombre.Location = new System.Drawing.Point(592, 25);
			this.cbNombre.Name = "cbNombre";
			this.cbNombre.Size = new System.Drawing.Size(121, 28);
			this.cbNombre.TabIndex = 20;
			this.cbNombre.Tag = "alumnos";
			this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.CbNombreSelectedIndexChanged);
			// 
			// tbAno
			// 
			this.tbAno.Location = new System.Drawing.Point(932, 280);
			this.tbAno.Name = "tbAno";
			this.tbAno.Size = new System.Drawing.Size(40, 26);
			this.tbAno.TabIndex = 21;
			// 
			// tbMes
			// 
			this.tbMes.Location = new System.Drawing.Point(880, 280);
			this.tbMes.Name = "tbMes";
			this.tbMes.Size = new System.Drawing.Size(40, 26);
			this.tbMes.TabIndex = 22;
			// 
			// lbdia
			// 
			this.lbdia.Location = new System.Drawing.Point(829, 254);
			this.lbdia.Name = "lbdia";
			this.lbdia.Size = new System.Drawing.Size(37, 23);
			this.lbdia.TabIndex = 23;
			this.lbdia.Text = "Dia";
			// 
			// lbMes
			// 
			this.lbMes.Location = new System.Drawing.Point(880, 254);
			this.lbMes.Name = "lbMes";
			this.lbMes.Size = new System.Drawing.Size(40, 23);
			this.lbMes.TabIndex = 24;
			this.lbMes.Text = "Mes";
			// 
			// lbAno
			// 
			this.lbAno.Location = new System.Drawing.Point(935, 254);
			this.lbAno.Name = "lbAno";
			this.lbAno.Size = new System.Drawing.Size(49, 23);
			this.lbAno.TabIndex = 25;
			this.lbAno.Text = "Año";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 388);
			this.Controls.Add(this.lbAno);
			this.Controls.Add(this.lbMes);
			this.Controls.Add(this.lbdia);
			this.Controls.Add(this.tbMes);
			this.Controls.Add(this.tbAno);
			this.Controls.Add(this.cbNombre);
			this.Controls.Add(this.tbCalle);
			this.Controls.Add(this.lbCalle);
			this.Controls.Add(this.tbTelefono);
			this.Controls.Add(this.lbTelefono);
			this.Controls.Add(this.tbPaterno);
			this.Controls.Add(this.lbApPaterno);
			this.Controls.Add(this.tbMaterno);
			this.Controls.Add(this.lbApMaterno);
			this.Controls.Add(this.tbDia);
			this.Controls.Add(this.lbNacimiento);
			this.Controls.Add(this.bAgregar);
			this.Controls.Add(this.bActualizar);
			this.Controls.Add(this.bBorrar);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.lbId);
			this.Controls.Add(this.tbNombre);
			this.Controls.Add(this.lbNombre);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "CONEXION_BD";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox tbDia;
		private System.Windows.Forms.Label lbAno;
		private System.Windows.Forms.Label lbMes;
		private System.Windows.Forms.Label lbdia;
		private System.Windows.Forms.TextBox tbMes;
		private System.Windows.Forms.TextBox tbAno;
		private System.Windows.Forms.ComboBox cbNombre;
		private System.Windows.Forms.Label lbTelefono;
		private System.Windows.Forms.TextBox tbTelefono;
		private System.Windows.Forms.Label lbCalle;
		private System.Windows.Forms.TextBox tbCalle;
		private System.Windows.Forms.Label lbApMaterno;
		private System.Windows.Forms.TextBox tbMaterno;
		private System.Windows.Forms.Label lbApPaterno;
		private System.Windows.Forms.TextBox tbPaterno;
		private System.Windows.Forms.Label lbNacimiento;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Label lbId;
		private System.Windows.Forms.Button bAgregar;
		private System.Windows.Forms.Button bActualizar;
		private System.Windows.Forms.Button bBorrar;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
