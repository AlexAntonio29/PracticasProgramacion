﻿/*
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbIdAlumno = new System.Windows.Forms.ComboBox();
			this.cbDia = new System.Windows.Forms.ComboBox();
			this.cbIdMaestro = new System.Windows.Forms.ComboBox();
			this.cbIdMateria = new System.Windows.Forms.ComboBox();
			this.cbHoraInicio = new System.Windows.Forms.ComboBox();
			this.lbHoraSalida = new System.Windows.Forms.Label();
			this.lbIdHorario = new System.Windows.Forms.Label();
			this.cbIdHorario = new System.Windows.Forms.ComboBox();
			this.bVerHorario = new System.Windows.Forms.Button();
			this.lbDescripcionAlumno = new System.Windows.Forms.Label();
			this.lbDescripcionMateria = new System.Windows.Forms.Label();
			this.lbDescripcionMaestro = new System.Windows.Forms.Label();
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
			this.tbDia.Location = new System.Drawing.Point(822, 396);
			this.tbDia.Name = "tbDia";
			this.tbDia.Size = new System.Drawing.Size(40, 26);
			this.tbDia.TabIndex = 11;
			// 
			// lbNacimiento
			// 
			this.lbNacimiento.Location = new System.Drawing.Point(669, 399);
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
			this.tbMaterno.Location = new System.Drawing.Point(494, 393);
			this.tbMaterno.Name = "tbMaterno";
			this.tbMaterno.Size = new System.Drawing.Size(91, 26);
			this.tbMaterno.TabIndex = 13;
			// 
			// lbApMaterno
			// 
			this.lbApMaterno.Location = new System.Drawing.Point(341, 396);
			this.lbApMaterno.Name = "lbApMaterno";
			this.lbApMaterno.Size = new System.Drawing.Size(147, 23);
			this.lbApMaterno.TabIndex = 12;
			this.lbApMaterno.Text = "Apellido Materno";
			// 
			// tbCalle
			// 
			this.tbCalle.Location = new System.Drawing.Point(829, 277);
			this.tbCalle.Name = "tbCalle";
			this.tbCalle.Size = new System.Drawing.Size(91, 26);
			this.tbCalle.TabIndex = 19;
			// 
			// lbCalle
			// 
			this.lbCalle.Location = new System.Drawing.Point(676, 280);
			this.lbCalle.Name = "lbCalle";
			this.lbCalle.Size = new System.Drawing.Size(132, 23);
			this.lbCalle.TabIndex = 18;
			this.lbCalle.Text = "Calle";
			this.lbCalle.Click += new System.EventHandler(this.LbCalleClick);
			// 
			// tbTelefono
			// 
			this.tbTelefono.Location = new System.Drawing.Point(193, 396);
			this.tbTelefono.Name = "tbTelefono";
			this.tbTelefono.Size = new System.Drawing.Size(91, 26);
			this.tbTelefono.TabIndex = 17;
			this.tbTelefono.TextChanged += new System.EventHandler(this.TbTelefonoTextChanged);
			// 
			// lbTelefono
			// 
			this.lbTelefono.Location = new System.Drawing.Point(40, 396);
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
									"materia",
									"horarios"});
			this.cbNombre.Location = new System.Drawing.Point(567, 40);
			this.cbNombre.Name = "cbNombre";
			this.cbNombre.Size = new System.Drawing.Size(146, 28);
			this.cbNombre.TabIndex = 20;
			this.cbNombre.Tag = "alumnos";
			this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.CbNombreSelectedIndexChanged);
			// 
			// tbAno
			// 
			this.tbAno.Location = new System.Drawing.Point(925, 396);
			this.tbAno.Name = "tbAno";
			this.tbAno.Size = new System.Drawing.Size(40, 26);
			this.tbAno.TabIndex = 21;
			// 
			// tbMes
			// 
			this.tbMes.Location = new System.Drawing.Point(873, 396);
			this.tbMes.Name = "tbMes";
			this.tbMes.Size = new System.Drawing.Size(40, 26);
			this.tbMes.TabIndex = 22;
			// 
			// lbdia
			// 
			this.lbdia.Location = new System.Drawing.Point(822, 370);
			this.lbdia.Name = "lbdia";
			this.lbdia.Size = new System.Drawing.Size(37, 23);
			this.lbdia.TabIndex = 23;
			this.lbdia.Text = "Dia";
			// 
			// lbMes
			// 
			this.lbMes.Location = new System.Drawing.Point(873, 370);
			this.lbMes.Name = "lbMes";
			this.lbMes.Size = new System.Drawing.Size(40, 23);
			this.lbMes.TabIndex = 24;
			this.lbMes.Text = "Mes";
			// 
			// lbAno
			// 
			this.lbAno.Location = new System.Drawing.Point(928, 370);
			this.lbAno.Name = "lbAno";
			this.lbAno.Size = new System.Drawing.Size(49, 23);
			this.lbAno.TabIndex = 25;
			this.lbAno.Text = "Año";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(567, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 23);
			this.label1.TabIndex = 26;
			this.label1.Text = "Seleccionar Tabla:";
			// 
			// cbIdAlumno
			// 
			this.cbIdAlumno.FormattingEnabled = true;
			this.cbIdAlumno.Location = new System.Drawing.Point(200, 277);
			this.cbIdAlumno.Name = "cbIdAlumno";
			this.cbIdAlumno.Size = new System.Drawing.Size(121, 28);
			this.cbIdAlumno.TabIndex = 27;
			this.cbIdAlumno.SelectedIndexChanged += new System.EventHandler(this.CbIdAlumnoSelectedIndexChanged);
			// 
			// cbDia
			// 
			this.cbDia.AutoCompleteCustomSource.AddRange(new string[] {
									"Lunes",
									"Martes",
									"Miercoles",
									"Jueves",
									"Viernes"});
			this.cbDia.FormattingEnabled = true;
			this.cbDia.Items.AddRange(new object[] {
									"Lunes",
									"Martes",
									"Miercoles",
									"Jueves",
									"Viernes"});
			this.cbDia.Location = new System.Drawing.Point(193, 396);
			this.cbDia.Name = "cbDia";
			this.cbDia.Size = new System.Drawing.Size(121, 28);
			this.cbDia.TabIndex = 28;
			// 
			// cbIdMaestro
			// 
			this.cbIdMaestro.AutoCompleteCustomSource.AddRange(new string[] {
									"Lunes",
									"Martes",
									"Miercoles",
									"Jueves",
									"Viernes"});
			this.cbIdMaestro.FormattingEnabled = true;
			this.cbIdMaestro.Location = new System.Drawing.Point(494, 281);
			this.cbIdMaestro.Name = "cbIdMaestro";
			this.cbIdMaestro.Size = new System.Drawing.Size(121, 28);
			this.cbIdMaestro.TabIndex = 29;
			this.cbIdMaestro.SelectedIndexChanged += new System.EventHandler(this.CbIdMaestroSelectedIndexChanged);
			// 
			// cbIdMateria
			// 
			this.cbIdMateria.AutoCompleteCustomSource.AddRange(new string[] {
									"Lunes",
									"Martes",
									"Miercoles",
									"Jueves",
									"Viernes"});
			this.cbIdMateria.FormattingEnabled = true;
			this.cbIdMateria.Location = new System.Drawing.Point(487, 393);
			this.cbIdMateria.Name = "cbIdMateria";
			this.cbIdMateria.Size = new System.Drawing.Size(121, 28);
			this.cbIdMateria.TabIndex = 30;
			this.cbIdMateria.SelectedIndexChanged += new System.EventHandler(this.CbIdMateriaSelectedIndexChanged);
			// 
			// cbHoraInicio
			// 
			this.cbHoraInicio.AutoCompleteCustomSource.AddRange(new string[] {
									"Lunes",
									"Martes",
									"Miercoles",
									"Jueves",
									"Viernes"});
			this.cbHoraInicio.FormattingEnabled = true;
			this.cbHoraInicio.Items.AddRange(new object[] {
									"07:00:00",
									"08:00:00",
									"09:00:00",
									"10:00:00",
									"11:00:00",
									"12:00:00",
									"13:00:00",
									"14:00:00",
									"15:00:00",
									"16:00:00",
									"17:00:00",
									"18:00:00",
									"19:00:00",
									"20:00:00",
									"21:00:00",
									"22:00:00"});
			this.cbHoraInicio.Location = new System.Drawing.Point(829, 275);
			this.cbHoraInicio.Name = "cbHoraInicio";
			this.cbHoraInicio.Size = new System.Drawing.Size(121, 28);
			this.cbHoraInicio.TabIndex = 31;
			this.cbHoraInicio.SelectedIndexChanged += new System.EventHandler(this.CbHoraInicioSelectedIndexChanged);
			// 
			// lbHoraSalida
			// 
			this.lbHoraSalida.Location = new System.Drawing.Point(822, 396);
			this.lbHoraSalida.Name = "lbHoraSalida";
			this.lbHoraSalida.Size = new System.Drawing.Size(143, 28);
			this.lbHoraSalida.TabIndex = 32;
			this.lbHoraSalida.Text = "label2";
			// 
			// lbIdHorario
			// 
			this.lbIdHorario.Location = new System.Drawing.Point(579, 169);
			this.lbIdHorario.Name = "lbIdHorario";
			this.lbIdHorario.Size = new System.Drawing.Size(90, 23);
			this.lbIdHorario.TabIndex = 33;
			this.lbIdHorario.Text = "ID Horario";
			// 
			// cbIdHorario
			// 
			this.cbIdHorario.AutoCompleteCustomSource.AddRange(new string[] {
									"Lunes",
									"Martes",
									"Miercoles",
									"Jueves",
									"Viernes"});
			this.cbIdHorario.FormattingEnabled = true;
			this.cbIdHorario.Location = new System.Drawing.Point(732, 169);
			this.cbIdHorario.Name = "cbIdHorario";
			this.cbIdHorario.Size = new System.Drawing.Size(121, 28);
			this.cbIdHorario.TabIndex = 34;
			// 
			// bVerHorario
			// 
			this.bVerHorario.Location = new System.Drawing.Point(761, 25);
			this.bVerHorario.Name = "bVerHorario";
			this.bVerHorario.Size = new System.Drawing.Size(159, 43);
			this.bVerHorario.TabIndex = 35;
			this.bVerHorario.Text = "Ver Horarios";
			this.bVerHorario.UseVisualStyleBackColor = true;
			this.bVerHorario.Click += new System.EventHandler(this.BVerHorarioClick);
			// 
			// lbDescripcionAlumno
			// 
			this.lbDescripcionAlumno.Location = new System.Drawing.Point(47, 327);
			this.lbDescripcionAlumno.Name = "lbDescripcionAlumno";
			this.lbDescripcionAlumno.Size = new System.Drawing.Size(424, 23);
			this.lbDescripcionAlumno.TabIndex = 37;
			this.lbDescripcionAlumno.Text = "label2";
			// 
			// lbDescripcionMateria
			// 
			this.lbDescripcionMateria.Location = new System.Drawing.Point(487, 436);
			this.lbDescripcionMateria.Name = "lbDescripcionMateria";
			this.lbDescripcionMateria.Size = new System.Drawing.Size(391, 23);
			this.lbDescripcionMateria.TabIndex = 38;
			this.lbDescripcionMateria.Text = "label3";
			// 
			// lbDescripcionMaestro
			// 
			this.lbDescripcionMaestro.Location = new System.Drawing.Point(494, 327);
			this.lbDescripcionMaestro.Name = "lbDescripcionMaestro";
			this.lbDescripcionMaestro.Size = new System.Drawing.Size(438, 23);
			this.lbDescripcionMaestro.TabIndex = 39;
			this.lbDescripcionMaestro.Text = "label4";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1032, 479);
			this.Controls.Add(this.lbDescripcionMaestro);
			this.Controls.Add(this.lbDescripcionMateria);
			this.Controls.Add(this.lbDescripcionAlumno);
			this.Controls.Add(this.bVerHorario);
			this.Controls.Add(this.cbIdHorario);
			this.Controls.Add(this.lbIdHorario);
			this.Controls.Add(this.lbHoraSalida);
			this.Controls.Add(this.cbHoraInicio);
			this.Controls.Add(this.cbIdMateria);
			this.Controls.Add(this.cbIdMaestro);
			this.Controls.Add(this.cbDia);
			this.Controls.Add(this.cbIdAlumno);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label lbDescripcionMaestro;
		private System.Windows.Forms.Label lbDescripcionMateria;
		private System.Windows.Forms.Label lbDescripcionAlumno;
		private System.Windows.Forms.Button bVerHorario;
		private System.Windows.Forms.ComboBox cbIdHorario;
		private System.Windows.Forms.Label lbIdHorario;
		private System.Windows.Forms.Label lbHoraSalida;
		private System.Windows.Forms.ComboBox cbHoraInicio;
		private System.Windows.Forms.ComboBox cbIdMateria;
		private System.Windows.Forms.ComboBox cbIdMaestro;
		private System.Windows.Forms.ComboBox cbDia;
		private System.Windows.Forms.ComboBox cbIdAlumno;
		private System.Windows.Forms.Label label1;
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
