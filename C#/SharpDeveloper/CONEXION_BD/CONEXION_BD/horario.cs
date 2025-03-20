/*
 * Creado por SharpDevelop.
 * Usuario: Alexis
 * Fecha: 19/03/2025
 * Hora: 11:20 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace CONEXION_BD
{
	/// <summary>
	/// Description of horario.
	/// </summary>
	public class horario
	{
		
		string id="";
		string nombreAlumno="";
		string nombreProfesor="";
		string nombreMateria="";
		string dia="";
		string hora="";
		public horario(string id="", string nombreAlumno="", string nombreProfesor="", string nombreMateria="",string dia="",string hora="")
		{
			this.id=id;
			this.nombreAlumno=nombreAlumno;
			this.nombreProfesor=nombreProfesor;
			this.nombreMateria=nombreMateria;
			this.dia=dia;
			this.hora=hora;
			
		}
		
		public string getID(){
			return id;
		}
		
		public string getNombreAlumno(){
			
			return nombreAlumno;
		}
		
		public string getNombreProfesor(){
			return nombreProfesor;
		}
		
		public string getNombreMateria(){
			
			return nombreMateria;
		}
		public string getDia(){
			return dia;
		}
		public string getHora(){
			return hora;
		}
		
		
		public void setID(string id){
			this.id=id;
		}
		
		public void  setNombreAlumno(string nombreAlumno){
			
			this.nombreAlumno=nombreAlumno;
		}
		
		public void setNombreProfesor(string nombreProfesor){
			this.nombreProfesor=nombreProfesor;
		}
		
		
		public void setNombreMateria(string nombreMateria){
			
			this.nombreMateria=nombreMateria;
		}
		
		public void setDia(string dia){
			this.dia=dia;
		}
		public void setHora(string hora){
			this.hora=hora;
		}
	}
}
