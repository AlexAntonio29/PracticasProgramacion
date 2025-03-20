/*
 * Creado por SharpDevelop.
 * Usuario: Alexis
 * Fecha: 19/03/2025
 * Hora: 10:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CONEXION_BD
{
	/// <summary>
	/// Description of conexionHorarios.
	/// </summary>
	public class conexionHorarios: conexion
	{
		static string STRCONEXION ="server=localhost;port=3307;Database=escuela;User Id=root;Password=Alexis292001;";
		MySqlConnection conection= new MySqlConnection(STRCONEXION);
		Advertencia ventana = new Advertencia();
		MySqlCommand cmd;
		MySqlDataReader lectorCmd;
		String nameTabla="";
	
		public conexionHorarios(String nameTabla) : base(nameTabla)
			
		{
			this.nameTabla=nameTabla;
			
			try{
				conection.Open();
				
			}catch(Exception e){
				ventana.start("ERROR CONSTRUCTOR: "+e);
			}
			
			
		}
		
		
		public void addAlumnos(ComboBox cb){
			
			string query= "SELECT * FROM "+nameTabla;
			
			cmd= new MySqlCommand(query,conection);
			
			lectorCmd= cmd.ExecuteReader();
			
			while(lectorCmd.Read()){
				
				cb.Items.Add(lectorCmd["id"].ToString()+"-"+lectorCmd["nombre"].ToString()+"  "+lectorCmd["Apellido_Paterno"].ToString()+"  "+lectorCmd["Apellido_Materno"].ToString());
			}
			lectorCmd.Close();
			
			
			
			
		}
		
		public List<horario> getHorarioAlumno(string idAlumno)
        {
            List<horario> lista = new List<horario>();

            string query = @"
                SELECT horarios.id_horario AS id, 
                       CONCAT(alumnos.nombre, ' ', alumnos.Apellido_Paterno, ' ', alumnos.Apellido_Materno) AS Alumno, 
                       CONCAT(maestros.nombre, ' ', maestros.Apellido_Paterno, ' ', maestros.Apellido_Materno) AS Profesor, 
                       materia.nombre AS Materia, 
                       horarios.dia, 
                       CONCAT(horarios.hora_inicio, ' - ', horarios.hora_salida) AS Horario
                FROM horarios
                INNER JOIN alumnos ON horarios.id_alumno = alumnos.id
                INNER JOIN maestros ON horarios.id_maestro = maestros.id
                INNER JOIN materia ON horarios.id_materia = materia.id
                WHERE alumnos.id = @idAlumno;
            ";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conection))
                {
                    // Agregar parámetro para evitar inyecciones SQL
                    cmd.Parameters.AddWithValue("@idAlumno", idAlumno);

                   

                    using (MySqlDataReader lectorCmd = cmd.ExecuteReader())
                    {
                        // Leer los datos y agregarlos a la lista
                        while (lectorCmd.Read())
                        {
                            horario registro = new horario(
                                lectorCmd["id"].ToString(),                          // ID del horario
                                lectorCmd["Alumno"].ToString(),                      // Nombre completo del alumno
                                lectorCmd["Profesor"].ToString(),                    // Nombre completo del profesor
                                lectorCmd["Materia"].ToString(),                     // Nombre de la materia
                                lectorCmd["dia"].ToString(),                         // Día del horario
                                lectorCmd["Horario"].ToString()                      // Hora (inicio y fin)
                            );

                            lista.Add(registro);
                        }
                    }

                    // Cerrar la conexión
                    conection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al obtener el horario del alumno: " + e.Message);
            }

            return lista;
        }
	
	
	}
}
