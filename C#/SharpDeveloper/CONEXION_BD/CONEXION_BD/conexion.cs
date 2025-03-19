/*
 * Creado por SharpDevelop.
 * Usuario: Alexis
 * Fecha: 07/03/2025
 * Hora: 07:46 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace CONEXION_BD
{
	/// <summary>
	/// Description of conexion.
	/// </summary>
	public class conexion
	{
		static string STRCONEXION ="server=localhost;port=3307;Database=escuela;User Id=root;Password=Alexis292001;";
		MySqlConnection conection= new MySqlConnection(STRCONEXION);
		Advertencia ventana = new Advertencia();
		MySqlCommand cmd;
		MySqlDataReader lectorCmd;
		String nameTabla="";
		
		
		
		public conexion(String nameTabla)
		{
			this.nameTabla=nameTabla;
			
			try{
				conection.Open();
				
			}catch(Exception e){
				ventana.start("ERROR CONSTRUCTOR: "+e);
			}
		
		}
		
		
		public bool startConexion(DataGridView tabla){
			
			
			try{
				Console.WriteLine("Conexion Exitosa");				 
                 
                 updateTabla(tabla);
                 
        
				return true;
			}
			catch(Exception e){
				
				ventana.start("ERROR startConexion: "+e);
				return false;
			}
			return false;
		}
		
		
		public void updateTabla(DataGridView tabla){
			
			tabla.Rows.Clear();
			tabla.Columns.Clear();
				 
			try{
				string queryFilas= "SELECT * FROM "+nameTabla+";";
				string queryColumnas = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"+nameTabla+"';";;
			
				
				 
               cmd = new MySqlCommand(queryColumnas, conection);
               lectorCmd = cmd.ExecuteReader();
                 //ventana.start("Conexion Exitosa");
                 while(lectorCmd.Read()){
                 	//columna+=" "+Convert.ToString(readerColumnas["COLUMN_NAME"]);
                 	tabla.Columns.Add(Convert.ToString(lectorCmd["COLUMN_NAME"])+"_columna",Convert.ToString(lectorCmd["COLUMN_NAME"]));
                 	
                 }
                 
                 if(tipoTabla()==2)tabla.Columns[1].Width=250;
                 else
                 	tabla.Columns[1].Width=100;
                 
                 
                
                 
                 
                 
                 
                 lectorCmd.Close(); 	
				 	
				cmd= new MySqlCommand(queryFilas,conection);
                 lectorCmd= cmd.ExecuteReader();
                 int contador=0;
                 
                 switch(tipoTabla()){
                 		case 0: 
                 			while(lectorCmd.Read()){
                 	tabla.Rows.Add();
                 	tabla.Rows[contador].Cells[0].Value=lectorCmd["id"];
                 	tabla.Rows[contador].Cells[1].Value=lectorCmd["nombre"];
                 	tabla.Rows[contador].Cells[2].Value=lectorCmd["Apellido_Paterno"];
                 	tabla.Rows[contador].Cells[3].Value=lectorCmd["Apellido_Materno"];
                 	tabla.Rows[contador].Cells[4].Value=lectorCmd["Calle"];
                 	tabla.Rows[contador].Cells[5].Value=lectorCmd["Fecha_Nacimiento"];
                 	tabla.Rows[contador].Cells[6].Value=lectorCmd["Telefono"];
                 	contador++;
                 }
                 		break;
                 		
                 		case 1:
                 		while(lectorCmd.Read()){
                 	tabla.Rows.Add();
                 	tabla.Rows[contador].Cells[0].Value=lectorCmd["id"];
                 	tabla.Rows[contador].Cells[1].Value=lectorCmd["nombre"];
                 	tabla.Rows[contador].Cells[2].Value=lectorCmd["Apellido_Paterno"];
                 	tabla.Rows[contador].Cells[3].Value=lectorCmd["Apellido_Materno"];
                 	tabla.Rows[contador].Cells[4].Value=lectorCmd["Calle"];
                 	tabla.Rows[contador].Cells[5].Value=lectorCmd["Fecha_Nacimiento"];
                 	tabla.Rows[contador].Cells[6].Value=lectorCmd["Telefono"];
                 	contador++;
                 }
                 		
                 		break;
                 		
                 		case 2:
                 		while(lectorCmd.Read()){
                 	tabla.Rows.Add();
                 	tabla.Rows[contador].Cells[0].Value=lectorCmd["id"];
                 	tabla.Rows[contador].Cells[1].Value=lectorCmd["nombre"];
                 	contador++;
                 }
                 		break;
                 		case 3://HORARIOS
                 		while(lectorCmd.Read()){
                 	tabla.Rows.Add();
                 	tabla.Rows[contador].Cells[0].Value=lectorCmd["id_horario"];
                 	tabla.Rows[contador].Cells[1].Value=lectorCmd["id_alumno"];
                 	tabla.Rows[contador].Cells[2].Value=lectorCmd["id_maestro"];
                 	tabla.Rows[contador].Cells[3].Value=lectorCmd["id_materia"];
                 	tabla.Rows[contador].Cells[4].Value=lectorCmd["hora_inicio"];
                 	tabla.Rows[contador].Cells[4].Value=lectorCmd["hora_salida"];
                 	tabla.Rows[contador].Cells[6].Value=lectorCmd["dia"];
                 	contador++;
                 }
                 		break;
                 		
                 		
                 		
                 	default:
                 		ventana.start("tabla Desconocida");
                 		break;
                 }
                 
                 lectorCmd.Close();
			}catch(Exception e){
				ventana.start("ERROR Agregar Datos Tabla: "+e);
			}
			
			
		}
		
		public void deleteData(DataGridView tabla, string id){//con el id se identifica la fila a eliminar
		
			try{
				string query="";
				if(tipoTabla()==3) query="DELETE FROM "+nameTabla+" WHERE id_horario= "+id+";";
				else  query="DELETE FROM "+nameTabla+" WHERE id= "+id+";";
				
		
		MySqlCommand cmd= new MySqlCommand(query,conection);
		MySqlDataReader lectorCmd= cmd.ExecuteReader();
		
		lectorCmd.Close();
		updateTabla(tabla);
		
	
			}catch(Exception e){
				ventana.start("ERROR deleteData: "+e);
			}
		
	}
	
	public void updateData(DataGridView tabla, string id, string nombre, string apellidoPaterno=""
		                   , string apellidoMaterno="", string calle="", string fechaNacimiento="", string telefono=""){
		
		
		try{
				
				
				string query="UPDATE "+nameTabla+"";
				
				if(tipoTabla()==2) query+="SET nombre="+nombre;
				else if(tipoTabla()==3) query+=" SET id_alumno="+nombre+", id_maestro="+apellidoPaterno+", id_materia="+apellidoMaterno+
						", hora_inicio="+ calle+", hora_salida="+ fechaNacimiento+", dia="+ telefono;
					
					
					else query+=" SET nombre="+nombre+", Apellido_Paterno="+apellidoPaterno+", Apellido_Materno="+apellidoMaterno+
						", Calle="+ calle+", Fecha_Nacimiento="+ fechaNacimiento+", Telefono="+telefono;
					
				if(tipoTabla()==3) query+=" WHERE id_horario="+id+";";
					else query+=" WHERE id="+id+";";
		MySqlCommand cmd= new MySqlCommand(query,conection);
		MySqlDataReader lectorCmd= cmd.ExecuteReader();
		lectorCmd.Close();
		updateTabla(tabla);
			}catch(Exception e){
				ventana.start("DATOS MAL IMPLEMENTADOS");
			}
	}
	
	public void addData(DataGridView tabla, string id, string nombre, string apellidoPaterno=""
		                   , string apellidoMaterno="", string calle="", string fechaNacimiento="", string telefono=""){
		
		try{
				string query="";
				
				if(tipoTabla()==3) {
					query+="INSERT INTO "+nameTabla+"(id_alumno,id_maestro, id_materia, hora_inicio,hora_salida, dia) " +
					"VALUES ("+nombre+","+apellidoPaterno+","+apellidoMaterno+","+calle+","+fechaNacimiento+","+telefono+");";
				}
				else{
				
				query+="INSERT INTO "+nameTabla+" ";
				
				if(tipoTabla()==2) query+="(id, nombre) " +
					"VALUES ("+id+","+nombre+");";
				else query+="(id, nombre, Apellido_Paterno, Apellido_Materno, Calle, Fecha_Nacimiento, Telefono) " +
					"VALUES ("+id+","+nombre+","+apellidoPaterno+","+apellidoMaterno+","+calle+","+fechaNacimiento+","+telefono+");";
				}
		MySqlCommand cmd= new MySqlCommand(query,conection);
		MySqlDataReader lectorCmd= cmd.ExecuteReader();
		
		lectorCmd.Close();
		updateTabla(tabla);
		
			}catch(Exception e){
				ventana.start("DATOS MAL IMPLEMENTADOS O NO RELLENADOS");
				
				
			}
			
	}
		
		public string consultarData(string id, string nombre, string apellidoPaterno=""
		                   , string apellidoMaterno="", string calle="", string fechaNacimiento="", string telefono=""){
			string query="SELECT ";
			
			try{
				if(tipoTabla()==2) query+="id, nombre FROM '"+nameTabla+"' WHERE id ="+id;
				else if(tipoTabla()==3){ query+="id_horario, id_alumno, id_maestro, id_materia, hora_inicio, hora_salida, dia FROM "+nameTabla+" WHERE id_horario ="+id.ToString();
				}
				
				else query+="id, nombre, Apellido_Paterno, Apellido_Materno, Calle, Fecha_Nacimiento, Telefono FROM "+nameTabla+" WHERE id ="+id.ToString();
				
				cmd= new MySqlCommand(query,conection);
				using (MySqlDataReader read= cmd.ExecuteReader())
				{
					if(read.Read()){
						
						if(nombre=="") 
							return nombre=read["nombre"].ToString();
						if(apellidoPaterno=="")
							return apellidoPaterno=read["Apellido_Paterno"].ToString();
						if(apellidoMaterno=="")
							return apellidoMaterno=read["Apellido_Materno"].ToString();
						if(calle=="")
							return calle=read["Calle"].ToString();
						if(fechaNacimiento=="")
							return fechaNacimiento = read.GetDateTime(read.GetOrdinal("Fecha_Nacimiento")).ToString("yyyy-MM-dd");

						if(telefono=="")
							return telefono=read["Telefono"].ToString();
						
						
					}
				}
				
		
	
                  
                
			}catch(Exception e){
				
				ventana.start("NO SE HA ASIGNADO EL ID");
			}
                return ""; 
                
		}
		
		
		//metodos secundarios
	
	public int tipoTabla(){
		if(nameTabla=="alumnos")return 0;
		if(nameTabla=="maestros") return 1;
		if(nameTabla=="materia") return 2;
		if(nameTabla=="horarios") return 3;
		return 3;
	}
		
		
	}
	
	
	
	
}