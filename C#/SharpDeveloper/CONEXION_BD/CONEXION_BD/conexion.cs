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
				Console.WriteLine("ERROR CONEXION "
				                +e);
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
				
				
				string query="DELETE FROM "+nameTabla+" WHERE id= "+id+";";
		
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
					else query+=" SET nombre="+nombre+", Apellido_Paterno="+apellidoPaterno+", Apellido_Materno="+apellidoMaterno+
						", Calle="+ calle+", Fecha_Nacimiento="+ fechaNacimiento+", Telefono="+telefono;
					
				query+=" WHERE id="+id+";";
		MySqlCommand cmd= new MySqlCommand(query,conection);
		MySqlDataReader lectorCmd= cmd.ExecuteReader();
		lectorCmd.Close();
		updateTabla(tabla);
			}catch(Exception e){
				ventana.start("ERROR ModifiquedData "+e);
			}
	}
	
	public void addData(DataGridView tabla, string id, string nombre, string apellidoPaterno=""
		                   , string apellidoMaterno="", string calle="", string fechaNacimiento="", string telefono=""){
		
		try{
				
				
				string query="INSERT INTO "+nameTabla+" ";
				
				if(tipoTabla()==2) query+="(id, nombre) " +
					"VALUES ("+id+","+nombre+");";
				else query+="(id, nombre, Apellido_Paterno, Apellido_Materno, Calle, Fecha_Nacimiento, Telefono) " +
					"VALUES ("+id+","+nombre+","+apellidoPaterno+","+apellidoMaterno+","+calle+","+fechaNacimiento+","+telefono+");";
		
		MySqlCommand cmd= new MySqlCommand(query,conection);
		MySqlDataReader lectorCmd= cmd.ExecuteReader();
		
		lectorCmd.Close();
		updateTabla(tabla);
		
			}catch(Exception e){
				ventana.start("ERROR addData "+e);
			}
	}
		
		//metodos secundarios
	
	public int tipoTabla(){
		if(nameTabla=="alumnos")return 0;
		if(nameTabla=="maestros") return 1;
		if(nameTabla=="materia") return 2;
		return 3;
	}
		
		
	}
	
	
	
	
}