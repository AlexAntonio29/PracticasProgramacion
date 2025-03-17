/*
 * Creado por SharpDevelop.
 * Usuario: Alexis
 * Fecha: 07/03/2025
 * Hora: 07:46 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CONEXION_BD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
		
	{
		
		public string Table="alumnos";
		public conexion conect;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			
		
			//
			
			conect=new conexion(Table);
			InitializeComponent();
			cbNombre.Text=Table;
			cbNombre.DropDownStyle = ComboBoxStyle.DropDownList;
			dataGridView1.ReadOnly=true;
			conect.startConexion(dataGridView1);
			
			//RECUERDA MOVER CODIGO SI LAS COSAS NO SE ACTUALIZAN
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//conexion con= new conexion();
			//con.startConexion();
			//GuardarAlumno Guardar= new GuardarAlumno();
			
		
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void TbNombreTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BAgregarClick(object sender, EventArgs e)
		{
			
		string id=tbId.Text, nombre= tbNombre.Text, paterno= tbPaterno.Text, materno=tbMaterno.Text,
		fNacimiento= tbAno.Text+"-"+tbMes.Text+"-"+tbDia.Text, calle=tbCalle.Text, telefono=tbTelefono.Text ;
		
		conect.addData(dataGridView1,id,"'"+nombre+"'","'"+ paterno+"'","'"+materno+"'","'"+ calle+"'","'"+fNacimiento+"'", telefono);
		tbId.Text="";
		tbNombre.Text="";
		tbPaterno.Text="";
		tbMaterno.Text="";
		tbDia.Text="";
		tbMes.Text="";
		tbAno.Text="";
		tbCalle.Text="";
		tbTelefono.Text="";
		
			
		}
		
		void BActualizarClick(object sender, EventArgs e)
		{
			string id=tbId.Text, nombre= tbNombre.Text, paterno= tbPaterno.Text, materno=tbMaterno.Text,
		fNacimiento=  tbAno.Text+"-"+tbMes.Text+"-"+tbDia.Text, calle=tbCalle.Text, telefono=tbTelefono.Text ;
		
		
		
		
		
		conect.updateData(dataGridView1,id,"'"+nombre+"'","'"+ paterno+"'","'"+materno+"'","'"+ calle+"'","'"+fNacimiento+"'", telefono);
		
		tbId.Text="";
		tbNombre.Text="";
		tbPaterno.Text="";
		tbMaterno.Text="";
		tbDia.Text="";
		tbMes.Text="";
		tbAno.Text="";
		tbCalle.Text="";
		tbTelefono.Text="";
		
			
		}
		
		void BBorrarClick(object sender, EventArgs e)
		{
			string id=tbId.Text;
		conect.deleteData(dataGridView1,id);
		tbId.Text="";
		tbNombre.Text="";
		tbPaterno.Text="";
		tbMaterno.Text="";
		tbDia.Text="";
		tbMes.Text="";
		tbAno.Text="";
		tbCalle.Text="";
		tbTelefono.Text="";
		
		}
		
		void TbTelefonoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CbNombreSelectedIndexChanged(object sender, EventArgs e)
		{
			
			Table=cbNombre.Text;
			conect=new conexion(Table);
			conect.startConexion(dataGridView1);
			
			switch(conect.tipoTabla()){
					
					case 0: 
					lbTelefono.Visible=true;
					tbTelefono.Visible=true;
					
					lbApPaterno.Visible=true;
					tbPaterno.Visible=true;
					
					lbApMaterno.Visible=true;
					tbMaterno.Visible=true;
					
					lbCalle.Visible=true;
					tbCalle.Visible=true;
					
					lbNacimiento.Visible=true;
					lbdia.Visible=true;
					tbDia.Visible=true;
					
					lbMes.Visible=true;
					tbMes.Visible=true;
					
					lbAno.Visible=true;
					tbAno.Visible=true;
					
					break;
					case 1: 
					lbTelefono.Visible=true;
					tbTelefono.Visible=true;
					
					lbApPaterno.Visible=true;
					tbPaterno.Visible=true;
					
					lbApMaterno.Visible=true;
					tbMaterno.Visible=true;
					
					lbCalle.Visible=true;
					tbCalle.Visible=true;
					
					lbNacimiento.Visible=true;
					lbdia.Visible=true;
					tbDia.Visible=true;
					
					lbMes.Visible=true;
					tbMes.Visible=true;
					
					lbAno.Visible=true;
					tbAno.Visible=true;
					
					break;
					case 2: 
					lbTelefono.Visible=false;
					tbTelefono.Visible=false;
					
					lbApPaterno.Visible=false;
					tbPaterno.Visible=false;
					
					lbApMaterno.Visible=false;
					tbMaterno.Visible=false;
					
					lbCalle.Visible=false;
					tbCalle.Visible=false;
					
					lbNacimiento.Visible=false;
					lbdia.Visible=false;
					tbDia.Visible=false;
					
					lbMes.Visible=false;
					tbMes.Visible=false;
					
					lbAno.Visible=false;
					tbAno.Visible=false;
					break;
			}
			
		}
	}
}
