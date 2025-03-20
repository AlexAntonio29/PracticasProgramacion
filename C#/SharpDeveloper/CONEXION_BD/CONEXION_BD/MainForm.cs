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
		Advertencia ventana = new Advertencia();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			
		
			//
			
			conect=new conexion(Table);
			InitializeComponent();
			//esconder comboBox de horario y label de horarioSalida
			try{
				
				
			lbDescripcionAlumno.Visible=false;
			lbDescripcionMaestro.Visible=false;
			lbDescripcionMateria.Visible=false;
			
							
			cbIdMateria.Visible=false;
			cbIdMateria.Items.AddRange(conect.consultarDataTablas(false,"materia"));
			cbIdMateria.DropDownStyle = ComboBoxStyle.DropDownList;
			//cbIdMateria.SelectedIndexChanged +=(sender, e) =>{
				
			//};
			
			cbIdHorario.Visible=false;
			cbIdHorario.Items.AddRange(conect.consultarDataTablas(false,"horarios"));
			cbIdHorario.DropDownStyle = ComboBoxStyle.DropDownList;
			
			lbIdHorario.Visible=false;
			
			
			
			
			
			cbIdMaestro.Visible=false;
			cbIdMaestro.Items.AddRange(conect.consultarDataTablas(false,"maestros"));
			cbIdMaestro.DropDownStyle = ComboBoxStyle.DropDownList;
			
			cbIdAlumno.Visible=false;
			cbIdAlumno.Items.AddRange(conect.consultarDataTablas(false,"alumnos"));
			cbIdAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
			
			
			
			cbIdMateria.SelectedIndex=0;
			cbIdMaestro.SelectedIndex=0;
			cbIdAlumno.SelectedIndex=0;
			cbIdHorario.SelectedIndex=0;
			}catch(Exception e){
				ventana.start("SIN DATOS AGREGADOS EN LOS COMBO BOX DE HORARIOS");	
			}
			cbHoraInicio.Visible=false;
			cbHoraInicio.Text="07:00:00";
			cbHoraInicio.DropDownStyle = ComboBoxStyle.DropDownList;
			
			
			lbHoraSalida.Text="08:00:00";
			lbHoraSalida.Visible=false;
			
			
			cbDia.Visible=false;
			cbDia.SelectedIndex=0;
			cbDia.DropDownStyle = ComboBoxStyle.DropDownList;
			
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
			if(accionSiNo()){
			
		string id=tbId.Text, nombre= tbNombre.Text, paterno= tbPaterno.Text, materno=tbMaterno.Text,
		fNacimiento= tbAno.Text+"-"+tbMes.Text+"-"+tbDia.Text, calle=tbCalle.Text, telefono=tbTelefono.Text ;
		if(fNacimiento=="--")fNacimiento="";
		
		if(conect.tipoTabla()==3){
			id="1"; nombre=getIDcomboBox(cbIdAlumno.Text); paterno=getIDcomboBox(cbIdMaestro.Text);
			materno=getIDcomboBox(cbIdMateria.Text); calle= cbHoraInicio.Text;fNacimiento=lbHoraSalida.Text;
			telefono=cbDia.Text;
		}
		if((id==""||nombre==""||paterno==""||materno==""||fNacimiento==""||calle==""||telefono=="")&&conect.tipoTabla()==3) ventana.start("ALERTA: APARTADOS VACIOS, FAVOR DE RELLENAR LOS DATOS");
		else{
		conect.addData(dataGridView1,id,"'"+nombre+"'","'"+ paterno+"'","'"+materno+"'","'"+ calle+"'","'"+fNacimiento+"'", telefono);
		actualizarObjetos();
		}
		
		
		}
		}
		
		void BActualizarClick(object sender, EventArgs e)
		{
			if(accionSiNo()){
				
				
				
			
			string id=tbId.Text, nombre= tbNombre.Text, paterno= tbPaterno.Text, materno=tbMaterno.Text,
		fNacimiento=  tbAno.Text+"-"+tbMes.Text+"-"+tbDia.Text, calle=tbCalle.Text, telefono=tbTelefono.Text ;
		if(fNacimiento=="--")fNacimiento="";
		if(conect.tipoTabla()==3){
			id="1"; nombre=getIDcomboBox(cbIdAlumno.Text); paterno=getIDcomboBox(cbIdMaestro.Text);
			materno=getIDcomboBox(cbIdMateria.Text); calle= cbHoraInicio.Text;fNacimiento=lbHoraSalida.Text;
			telefono=cbDia.Text;
		}
		
		//conect.consultarData(id, nombre, paterno,materno,fNacimiento,calle,telefono);
		if(id!=""){
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
		
		actualizarObjetos();}
		else ventana.start("NO SE HA ASIGNADO UN ID A MODIFICAR");
		}
			
		}
		
		void BBorrarClick(object sender, EventArgs e)
		{
			if(accionSiNo()){
			
			string id=tbId.Text;
			if(conect.tipoTabla()==3) id=cbIdHorario.Text;
		conect.deleteData(dataGridView1,id);
		actualizarObjetos();
			}
			
		}
		
		void TbTelefonoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CbNombreSelectedIndexChanged(object sender, EventArgs e)
		{
			
			Table=cbNombre.Text;
			conect=new conexion(Table);
			conect.startConexion(dataGridView1);
			
			actualizarObjetos();
			
			switch(conect.tipoTabla()){
					
					case 0: 
					tbNombre.Width=60;
					
					lbDescripcionAlumno.Visible=false;
			lbDescripcionMaestro.Visible=false;
			lbDescripcionMateria.Visible=false;
					
					lbIdHorario.Visible=false;
					cbIdHorario.Visible=false;
					
					lbId.Text="No.Control";
					lbId.Visible=true;
					tbId.Visible=true;
					
					lbNombre.Text="Nombre";
					lbNombre.Visible=true;
					tbNombre.Visible=true;
					
					lbTelefono.Text="Telefono";
					lbTelefono.Visible=true;
					tbTelefono.Visible=true;
					
					lbApPaterno.Text="Apellido Paterno:";
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
					
					//cambio CB
					cbIdMateria.Visible=false;
			cbIdMaestro.Visible=false;
			cbIdAlumno.Visible=false;
			cbDia.Visible=false;
			cbHoraInicio.Visible=false;
			lbHoraSalida.Visible=false;
					
					break;
					case 1: 
					tbNombre.Width=60;
					
					lbDescripcionAlumno.Visible=false;
			lbDescripcionMaestro.Visible=false;
			lbDescripcionMateria.Visible=false;
					
					lbIdHorario.Visible=false;
					cbIdHorario.Visible=false;
					
					lbId.Text="No.Control";
					lbId.Visible=true;
					tbId.Visible=true;
					
					lbNombre.Text="Nombre";
					lbNombre.Visible=true;
					tbNombre.Visible=true;
					
					lbTelefono.Text="Telefono";
					lbTelefono.Visible=true;
					tbTelefono.Visible=true;
					
					lbApPaterno.Text="Apellido Paterno:";
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
					
					//cambio CB
					cbIdMateria.Visible=false;
			cbIdMaestro.Visible=false;
			cbIdAlumno.Visible=false;
			cbDia.Visible=false;
			cbHoraInicio.Visible=false;
			lbHoraSalida.Visible=false;
					break;
					
					
					case 2: 
					tbNombre.Width=300;
					
					lbDescripcionAlumno.Visible=false;
			lbDescripcionMaestro.Visible=false;
			lbDescripcionMateria.Visible=false;
					
					lbIdHorario.Visible=false;
					cbIdHorario.Visible=false;
					
					lbId.Text="No.Control";
					lbId.Visible=true;
					tbId.Visible=true;
					
					lbNombre.Text="Nombre";
					lbNombre.Visible=true;
					tbNombre.Visible=true;
					
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
					
					cbIdMateria.Visible=false;
			cbIdMaestro.Visible=false;
			cbIdAlumno.Visible=false;
			cbDia.Visible=false;
			cbHoraInicio.Visible=false;
			lbHoraSalida.Visible=false;
					break;
					
					//cambio CB
					
					case 3:
					tbNombre.Width=60;
					
					lbDescripcionAlumno.Visible=true;
					lbDescripcionAlumno.Text= conect.getFilaTabla("alumnos", cbIdAlumno.Text);
			lbDescripcionMaestro.Visible=true;
			lbDescripcionMaestro.Text= conect.getFilaTabla("maestros", cbIdMaestro.Text);
			lbDescripcionMateria.Visible=true;
			lbDescripcionMateria.Text= conect.getFilaTabla("materia", cbIdMateria.Text);
					
					lbIdHorario.Visible=true;
					cbIdHorario.Visible=true;
					
					lbId.Text="ID";
					lbId.Visible=false;
					tbId.Visible=false;
				
					
					lbNombre.Text="ID ALUMNO:";
					lbNombre.Visible=true;
					tbNombre.Visible=false;
					
					
					
					lbApPaterno.Text="ID_MAESTRO:";
					lbApPaterno.Visible=true;
					tbPaterno.Visible=false;
					
					lbApMaterno.Text="ID_MATERIA:";
					lbApMaterno.Visible=true;
					tbMaterno.Visible=false;
					
					lbCalle.Text="HORA INICIO";
					lbCalle.Visible=true;
					tbCalle.Visible=false;
					
					lbNacimiento.Text="HORA SALIDA";
					lbNacimiento.Visible=true;
					
					
					
					lbdia.Visible=false;
					tbDia.Visible=false;
					tbDia.Width=100;
					
					
					lbMes.Visible=false;
					tbMes.Visible=false;
					
					lbAno.Visible=false;
					tbAno.Visible=false;
					
					lbTelefono.Text="DIA";
					lbTelefono.Visible=true;
					tbTelefono.Visible=false;
					
					cbIdMateria.Visible=true;
			cbIdMaestro.Visible=true;
			cbIdAlumno.Visible=true;
			cbDia.Visible=true;
			cbHoraInicio.Visible=true;
			lbHoraSalida.Visible=true;
			
			
			
			//TOMAR DE BASE DE DATOS LOS DATOS DE LAS TABLAS
			
					break;
					
					
					
					
					
			}
			
		}
		
		void CbHoraInicioSelectedIndexChanged(object sender, EventArgs e)
		{
			
			string horaTexto = cbHoraInicio.Text; // Por ejemplo, 14:30:00
        TimeSpan horaInicial;

        // Convertir el string a TimeSpan
        if (TimeSpan.TryParse(horaTexto, out horaInicial))
        {
          

            // Sumar 1 hora
            TimeSpan horaSumada = horaInicial.Add(new TimeSpan(1, 0, 0)); // Suma 1 hora (1:0:0)
            lbHoraSalida.Text=horaSumada.ToString();
        }
        else
        {
        	ventana.start("Error de Horario");
        }
		}
		
		void LbCalleClick(object sender, EventArgs e)
		{
			
		}
	
		public void actualizarObjetos(){
			
			
		cbIdHorario.Items.Clear();
		cbIdMateria.Items.Clear();
		cbIdMaestro.Items.Clear();
		cbIdAlumno.Items.Clear();
		
		
		
			cbIdMateria.Items.AddRange(conect.consultarDataTablas(false,"materia"));
			cbIdMaestro.Items.AddRange(conect.consultarDataTablas(false,"maestros"));
			cbIdAlumno.Items.AddRange(conect.consultarDataTablas(false,"alumnos"));
			cbIdHorario.Items.AddRange(conect.consultarDataTablas(false,"horarios"));
			
			cbIdHorario.SelectedIndex=0;
			cbIdMateria.SelectedIndex=0;
			cbIdMaestro.SelectedIndex=0;
			cbIdAlumno.SelectedIndex=0;
			
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
	
		
		void BVerHorarioClick(object sender, EventArgs e)
		{
			horarios getHorario= new horarios();
			getHorario.ShowDialog();
			
		}
		
		public bool accionSiNo(){
			
			
        // Mostrar cuadro de confirmación
        DialogResult resultado = MessageBox.Show(
            "¿Está seguro de realizar esta acción?", // Mensaje
            "Confirmación",                         // Título del cuadro
            MessageBoxButtons.YesNo,                // Botones: Sí y No
            MessageBoxIcon.Warning                  // Icono de advertencia
        );

        // Realizar la acción según la respuesta del usuario
        if (resultado == DialogResult.Yes)
        {
            return true;
        }
        else
        {
            return false;
        }
    
		}
		
		
		public string getIDcomboBox(string texto){
				char signo='-';
				string cadena="";
			foreach(char c in texto){
					if(c==signo) break;
					cadena+=c; 
			}
				
			return cadena;	
		}
		
		void CbIdAlumnoSelectedIndexChanged(object sender, EventArgs e)
		{
			
			lbDescripcionAlumno.Text= conect.getFilaTabla("alumnos", cbIdAlumno.Text);
			
		}
		
		void CbIdMaestroSelectedIndexChanged(object sender, EventArgs e)
		{
			lbDescripcionMaestro.Text= conect.getFilaTabla("maestros", cbIdMaestro.Text);
		}
		
		void CbIdMateriaSelectedIndexChanged(object sender, EventArgs e)
		{
			lbDescripcionMateria.Text= conect.getFilaTabla("materia", cbIdMateria.Text);
				
		}
	}
}
