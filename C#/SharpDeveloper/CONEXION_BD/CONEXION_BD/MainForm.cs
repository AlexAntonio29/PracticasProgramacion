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
		//INICIAR BD DE ESTE TRABAJO DESDE TERMINAL 
//C:\Program Files\MySQL\MySQL Server 9.2\bin>mysql -u root -p --port=3307 IMPORTANTE PARA SABER COMO ESTA ACTUANDO LA BD
		
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
		if(fNacimiento=="--")fNacimiento="";
		if(conect.tipoTabla()==3){fNacimiento=tbDia.Text; id="1";}
		
		//conect.consultarData(id, nombre, paterno,materno,fNacimiento,calle,telefono);
		
		if(conect.tipoTabla()==2) {  if(nombre=="") nombre=conect.consultarData(id, nombre, paterno,materno,calle,fNacimiento,telefono); }
		else {
						if(nombre=="") 
							nombre=conect.consultarData(id, nombre, paterno,materno,calle,fNacimiento,telefono);
						if(paterno=="")
							paterno=conect.consultarData(id, nombre, paterno,materno,calle,fNacimiento,telefono);
						if(materno=="") 
							materno=conect.consultarData(id, nombre, paterno,materno,calle,fNacimiento,telefono);
						if(calle=="")
							calle=conect.consultarData(id, nombre, paterno,materno,calle,fNacimiento,telefono);
						if(fNacimiento=="")
							fNacimiento=conect.consultarData(id, nombre, paterno,materno,calle,fNacimiento,telefono);
						if(telefono=="") 
							telefono=conect.consultarData(id, nombre, paterno,materno,calle,fNacimiento,telefono);
		}
		
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
					lbTelefono.Text="Telefono";
					lbTelefono.Visible=true;
					tbTelefono.Visible=true;
					
					lbApMaterno.Text="Apellido Paterno:";
					lbApPaterno.Visible=true;
					tbPaterno.Visible=true;
					
					lbApMaterno.Text="Apellido Materno:";
					lbApMaterno.Visible=true;
					tbMaterno.Visible=true;
					
					lbCalle.Text="Calle: ";
					lbCalle.Visible=true;
					tbCalle.Visible=true;
					
					lbNacimiento.Text="F.Nacimiento";
					lbNacimiento.Visible=true;
					
					
					lbdia.Visible=true;
					tbDia.Visible=true;
					tbDia.Width=30;
					
					
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
					case 3: 
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
					
					
					
			}
			
		}
	}
}
