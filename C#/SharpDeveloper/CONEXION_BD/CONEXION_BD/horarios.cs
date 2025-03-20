/*
 * Creado por SharpDevelop.
 * Usuario: Alexis
 * Fecha: 19/03/2025
 * Hora: 09:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CONEXION_BD
{
	/// <summary>
	/// Description of horarios.
	/// </summary>
	public partial class horarios : Form
	{
		
		public List<horario> listaHorario = new List<horario>();
		
		conexionHorarios conect= new conexionHorarios("alumnos");
		public horarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			addHora();
			conect.addAlumnos(cbBuscar);
			cbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
			cbBuscar.SelectedIndex=0;
			
			dgvHorario.ReadOnly=true;
			
			listaHorario= conect.getHorarioAlumno(getIDcomboBox(cbBuscar.Text));
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void addHora(){
			
			string[] filaHorasInicio={"07:00:00","08:00:00","09:00:00","10:00:00","11:00:00","12:00:00",
			"13:00:00","14:00:00","15:00:00","16:00:00","17:00:00","18:00:00","19:00:00","20:00:00",
			"21:00:00","22:00:00"};
			string[] filaHorasFinal={"08:00:00","09:00:00","10:00:00","11:00:00","12:00:00",
			"13:00:00","14:00:00","15:00:00","16:00:00","17:00:00","18:00:00","19:00:00","20:00:00",
			"21:00:00","22:00:00","23:00:00"};
				
				for(int i=0;i<=15;i++){
				dgvHorario.Rows.Add(filaHorasInicio[i]+"-"+filaHorasFinal[i]);
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
	}
}
