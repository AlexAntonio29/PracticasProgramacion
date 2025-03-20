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
			
			dgvHorario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		
			dgvHorario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

			//this.FormBorderStyle = FormBorderStyle.None; // Sin bordes
this.WindowState = FormWindowState.Maximized; // Pantalla completa
this.MaximizeBox = false; // Desactiva el botón de maximizar
this.MinimizeBox = false; // Desactiva el botón de minimizar
//this.ControlBox = false; // Oculta los controles estándar de la ventana
this.SizeGripStyle = SizeGripStyle.Hide; 
			
			
			conect.addAlumnos(cbBuscar);
			cbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
			cbBuscar.SelectedIndex=0;
			
			dgvHorario.ReadOnly=true;
			updateTable();
			
			
			
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
				dgvHorario.Rows.Add(filaHorasInicio[i]+" - "+filaHorasFinal[i]);
			}
			
		}
		
		public void updateTable(){
			listaHorario= conect.getHorarioAlumno(getIDcomboBox(cbBuscar.Text));
			dgvHorario.Rows.Clear();
			addHora();
			
			foreach(horario hora in listaHorario){
				string dia = "c"+hora.getDia();
					int columna = dgvHorario.Columns[dia].Index;
					int fila = getRowHour(hora.getHora());
				
					dgvHorario.Rows[fila].Cells[columna].Value=(hora.getNombreMateria())+"\nDocente: "+(hora.getNombreProfesor());
					dgvHorario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			}
			
		}
		public int getRowHour(string hora){
			
			switch(hora){
			case "07:00:00 - 08:00:00": return 0; break;
			case "08:00:00 - 09:00:00": return 1;break;
			case "09:00:00 - 10:00:00": return 2;break;
			case "10:00:00 - 11:00:00": return 3;break;
			case "11:00:00 - 12:00:00": return 4;break;
			case "12:00:00 - 13:00:00": return 5;break;
			case "13:00:00 - 14:00:00": return 6;break;
			case "14:00:00 - 15:00:00": return 7;break;
			case "15:00:00 - 16:00:00": return 8;break;
			case "16:00:00 - 17:00:00": return 9;break;
			case "17:00:00 - 18:00:00": return 10;break;
			case "18:00:00 - 19:00:00": return 11;break;
			case "19:00:00 - 20:00:00": return 12;break;
			case "20:00:00 - 21:00:00": return 13;break;
			case "21:00:00 - 22:00:00": return 14;break;
			case "22:00:00 - 23:00:00": return 15;break;
			
			
			}
			
			return 0;
				
			
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
		
		void CbBuscarSelectedIndexChanged(object sender, EventArgs e)
		{
			updateTable();
		}
	}
}
