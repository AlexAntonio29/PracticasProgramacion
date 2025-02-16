/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 12/02/2025
 * Time: 10:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace GUI_EJERCICIOS_BASICOS
{
	/// <summary>
	/// Description of ventana.
	/// </summary>
	public class ventana : Form
	{
		
		public condicionales c = new condicionales();
		
		public ciclos ciclo = new ciclos();
		//DECLARACION DE OBJETOS
		private Label lbTextContext= new Label();
		private Label lbTextContext2= new Label();
		private Label lbTextContext3= new Label();
		private Label lbTextContext4= new Label();
		
		private TextBox tbContext = new TextBox();
		private TextBox tbContext2 = new TextBox();
		private TextBox tbContext3 = new TextBox();
		private TextBox tbContext4 = new TextBox();
		
		private Button bResultado= new Button();
		private Label lbcontextoResultado=new Label();
		private Label lbResultado=new Label();
		
		private RadioButton rb1 = new RadioButton();
		private RadioButton rb2 = new RadioButton();
		
		private ComboBox  cb1  = new ComboBox();
		private ComboBox  cb2  = new ComboBox();
		//private TrackBar  trackBar2  = new TrackBar();
		
		
		
		//DECLARACION DE STRING
		private String tituloString;
		
		private String Context1String;
		private String Context2String;
		private String Context3String;
		private String Context4String;
		
		
		
		private String lbcontextoResultadoString;
		private String lbResultadoString;
		
		
		
		public ventana(String titulo, String Context1String="Opcion1", String Context2String="Opcion2", String Context3String="Opcion3",
		               String Context4String= "Opcion4",String lbcontextoResultadoString="Resultado", String lbResultadoString ="0"				 )
		{
			//agregar datos variables
			this.tituloString= titulo;
			
			this.Context1String= Context1String;
			this.Context2String= Context2String;
			this.Context3String= Context3String;
			this.Context4String= Context4String;
			
			this.lbcontextoResultadoString=lbcontextoResultadoString;
			this.lbResultadoString=lbResultadoString;
			
			
			
			
			
		}
		
		public void ventanaGeneral(){
			this.Size= new System.Drawing.Size(620,300);
		
		//AGREGAR LABEL A OBJETOS
			this.Text=tituloString;
			this.bResultado.Text="Resultado";
			this.lbResultado.Text="0";
			
			this.lbTextContext.Text=Context1String;
			this.lbTextContext2.Text=Context2String;
			this.lbTextContext3.Text=Context3String;
			this.lbTextContext4.Text=Context4String;
			
			this.rb1.Text=Context1String;
			this.rb2.Text=Context2String;
			
			
			
			this.lbcontextoResultado.Text = lbcontextoResultadoString;
			
			
			
			
			//MODIFICAR LABEL1
			this.lbTextContext.AutoSize = true;
			this.lbTextContext.Location = new System.Drawing.Point(10, 30);
			this.lbTextContext.Margin = new Padding();
			
			//MODIFICA LABEL2
			this.lbTextContext2.AutoSize = true;
			this.lbTextContext2.Location = new System.Drawing.Point(10, lbTextContext.Bottom+30);
			this.lbTextContext2.Margin = new Padding();
			
			
			//MODIFICA LABEL3
			this.lbTextContext3.AutoSize = true;
			this.lbTextContext3.Location = new System.Drawing.Point(10, lbTextContext2.Bottom+30);
			this.lbTextContext3.Margin = new Padding();
			
			//MODIFICA LABEL4
			this.lbTextContext4.AutoSize = true;
			this.lbTextContext4.Location = new System.Drawing.Point(10, lbTextContext3.Bottom+30);
			this.lbTextContext4.Margin = new Padding();
			
			//MODIFICA TRACKLABEL
			
        cb1.Location = new System.Drawing.Point(lbTextContext.Right+30, 30);
        //cb1.Width = 200;
			
			
			//MODIFICAR  TEXT BOX
			this.tbContext.AutoSize =true;
			this.tbContext.Location= new System.Drawing.Point(lbTextContext.Right+30, 30);
			
			//MODIFICAR TEXT BOX 2
			this.tbContext2.AutoSize =true;
			this.tbContext2.Location= new System.Drawing.Point(lbTextContext.Right+30, tbContext.Bottom+30);
			//MODIFICAR TEXT BOX 3
			this.tbContext3.AutoSize =true;
			this.tbContext3.Location= new System.Drawing.Point(lbTextContext.Right+30, tbContext2.Bottom+30);
			//MODIFICAR TEXT BOX 4
			this.tbContext4.AutoSize =true;
			this.tbContext4.Location= new System.Drawing.Point(lbTextContext.Right+30, tbContext3.Bottom+30);
			
			
			//MODIFICA RADIO BUTTON 1
			this.rb1.AutoSize = true;
			this.rb1.Location= new System.Drawing.Point(tbContext.Right+30, 30);
			this.rb1.AutoSize=true;
			
			//MODIFICA RADIO BUTTON 2
			this.rb2.AutoSize = true;
			this.rb2.Location= new System.Drawing.Point(tbContext.Right+30, tbContext.Bottom+30);
			this.rb2.AutoSize=true;
			
			//MODIFICA RADIO BUTTON 3
			
			
			//MODIFICAR BUTTON
			//this.bResultado.Location= new System.Drawing.Point(lbTextContext.Right-50, Bottom);
			this.bResultado.AutoSize =true;
			
			this.bResultado.Dock = DockStyle.Bottom;
			
			//MODIFICAR LABEL RESULTADO CONTEXTO
		
			this.lbcontextoResultado.AutoSize=true;
			this.lbcontextoResultado.Location= new System.Drawing.Point(lbTextContext.Right-50, tbContext4.Bottom+20);
			
			
			//MODIFICAR LABEL RESULTADO
			this.lbResultado.AutoSize= true;
			this.lbResultado.Text=lbResultadoString;
			this.lbResultado.Location= new System.Drawing.Point(lbTextContext.Right+40, tbContext4.Bottom+20);
			
		}

		
		public void areaCirculo(){
			
			
			
			this.ventanaGeneral();
			
			this.bResultado.Click+= (sender, e) =>
       			 {
				
				if(tbContext.Text=="") tbContext.Text="0";
			double radio= double.Parse(tbContext.Text);
			double PI= 3.14159;
			
			
			double area= PI*(radio*radio);
			
			lbResultadoString=area.ToString();
			
			lbResultado.Text=lbResultadoString;
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			this.Controls.Add(bResultado);
			
			this.ShowDialog();
			
			
		}
		
		public void areaTriangulo(){
			
			this.ventanaGeneral();
			
			
			
			this.bResultado.Click+= (sender, e)=>{
			double basee= double.Parse(tbContext.Text);
			double altura= double.Parse(tbContext2.Text);
			
			
			double area= (basee*altura)/2;
			
			lbResultadoString=area.ToString();
			
			lbResultado.Text=lbResultadoString;
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
			
		}
		
		public void calcularGrados(){
			this.ventanaGeneral();
			
			double resultado= 0;
			this.rb1.Click+= (sender, e) =>{
	if(tbContext.Text=="") tbContext.Text="0";
				
				
				if(rb1.Checked){
					if(tbContext.Text=="") tbContext.Text="0";
					lbTextContext.Text=Context2String;
					resultado= (double.Parse(tbContext.Text)*9/5)+32;} 
	else if(rb2.Checked){
					
					lbTextContext.Text=Context1String;
					resultado=(double.Parse(tbContext.Text)-32)*5/9;
				}
				
			};
			
			this.rb2.Click+= (sender, e)=>{
				
				if(tbContext.Text=="") tbContext.Text="0";
				if(rb2.Checked){
					
					lbTextContext.Text=Context1String;
					resultado=(double.Parse(tbContext.Text)-32)*5/9;
				} else if(rb1.Checked){
					lbTextContext.Text=Context1String;
					resultado= (double.Parse(tbContext.Text)*(9/5))+32;} 
			};
			this.bResultado.Click+= (sender, e)=>{
				if(rb1.Checked){
					if(tbContext.Text=="") tbContext.Text="0";
					lbTextContext.Text=Context2String;
					resultado= (double.Parse(tbContext.Text)*9/5)+32;} 
	else if(rb2.Checked){
					
					lbTextContext.Text=Context1String;
					resultado=(double.Parse(tbContext.Text)-32)*5/9;
				}
			lbResultadoString=resultado.ToString();
			
			lbResultado.Text=lbResultadoString;
			
			};
			
			
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			this.Controls.Add(rb1);
			this.Controls.Add(rb2);
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
			
			
			
		}
		
		public void ventaComision(){
				this.ventanaGeneral();
			
			
			
			this.bResultado.Click+= (sender, e)=>{
					if(tbContext.Text=="") tbContext.Text="0";
					double comision=0;
					
					double numero=double.Parse(tbContext.Text);
					if(numero>=1000) comision=numero*.05;
						else comision=numero*.03;
						
			
			lbResultadoString=comision.ToString();
			
			lbResultado.Text=lbResultadoString;
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		
		public void aumentoSalario(){
			this.ventanaGeneral();
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
				if(tbContext.Text=="") tbContext.Text="0";
			double sindicalizado= double.Parse(tbContext.Text)*.2;
			double deConfianza= double.Parse(tbContext2.Text)*.1;
			double altoDirectivo= double.Parse(tbContext3.Text)*.05;
			double ejecutivo= double.Parse(tbContext4.Text)*.02;
			
			
			
			
			//lbResultadoString="Sindicalizado: "+sindicalizado.ToString()+"De Confianza: "+deConfianza.ToString()+"Alto Directivo"+altoDirectivo.ToString()+"Ejecutivo: "+ejecutivo.ToString();
			lbResultadoString= string.Concat("Sindicalizado: ", sindicalizado.ToString(), " De Confianza: ",deConfianza.ToString()," Alto Directivo :",altoDirectivo.ToString(), " Ejecutivo: ", ejecutivo.ToString());
			lbResultado.Text=lbResultadoString;
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
			
			this.Controls.Add(lbTextContext3);
			this.Controls.Add(tbContext3);
			
			this.Controls.Add(lbTextContext4);
			this.Controls.Add(tbContext4);
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		public void valorMayor(){
			
			this.ventanaGeneral();
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
				if(tbContext.Text=="") tbContext.Text="0";
				
				double a=double.Parse(tbContext.Text);
				double b=double.Parse(tbContext2.Text);
				double c=double.Parse(tbContext3.Text);
				int n= 3;
				double[] array= { a,b,c};
				
				Array.Sort(array);
				Array.Reverse(array);
				
			
				
				lbResultadoString="";
				
				
				if(a==b||b==c||c==a){
					
					
					Form form = new Form(); form.Text="VALORES IGUALES"; 
					Label textoRapido= new Label(); textoRapido.AutoSize=true ; textoRapido.Text="VALORES_IGUALES";
					form.Size= new System.Drawing.Size(150,150);
					form.Controls.Add(textoRapido);
					
					form.ShowDialog() ;
				
				}
				
				for(int i=0; i< n;i++)
						lbResultadoString+="  "+array[i];
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
			
			this.Controls.Add(lbTextContext3);
			this.Controls.Add(tbContext3);
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();

		}
		
		public void descuentoPrecio(){
			
			this.ventanaGeneral();
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
				if(tbContext.Text=="") tbContext.Text="0";
				
				double a=double.Parse(tbContext.Text);
				double b=double.Parse(tbContext2.Text);
				double c=double.Parse(tbContext3.Text);
				int n= 3;
				double[] array= { a,b,c};
				
				Array.Sort(array);
				Array.Reverse(array);
				
			
				
				lbResultadoString="";
				
				
				double precio=0;
				
				for(int i=0; i< n;i++)
					if(i!=0) precio += array[i];
				
				lbResultadoString="Descuento Total: "+ (precio).ToString();
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
			
			this.Controls.Add(lbTextContext3);
			this.Controls.Add(tbContext3);
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
			
		}
		
		public void calificacionAprobatoria(){
			
			this.ventanaGeneral();
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
				if(tbContext.Text=="") tbContext.Text="0";
				
				if(double.Parse(tbContext.Text)>=7) lbResultadoString="Aprobado"; else lbResultadoString="Reprobado";
				
				
				
				if(double.Parse(tbContext.Text)>=11||double.Parse(tbContext.Text)<0) {
				Form form = new Form(); form.Text="DATOS ERRONEOS"; 
					Label textoRapido= new Label(); textoRapido.AutoSize=true ; textoRapido.Text="DEBE DE INGRESAR UNA CALIFICACION";
					form.Size= new System.Drawing.Size(200,150);
					form.Controls.Add(textoRapido);
					
					form.ShowDialog() ;
				}
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
			
		}
		
		
		public void clasificacionAlumno(){
		
		this.ventanaGeneral();
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
				if(tbContext.Text=="") tbContext.Text="0";
				
				if(double.Parse(tbContext.Text)>=19) lbResultadoString="A"; else 
					if(double.Parse(tbContext.Text)>=16) lbResultadoString="B	"; else 
						if(double.Parse(tbContext.Text)>=13) lbResultadoString="C"; else 
							if(double.Parse(tbContext.Text)>=10) lbResultadoString="D"; else 
								if(double.Parse(tbContext.Text)>=1) lbResultadoString="E"; else 
					
				
				
				
				if(double.Parse(tbContext.Text)>=21||double.Parse(tbContext.Text)<0) {
				Form form = new Form(); form.Text="DATOS ERRONEOS"; 
					Label textoRapido= new Label(); textoRapido.AutoSize=true ; textoRapido.Text="DEBE DE INGRESAR UNA CALIFICACION";
					form.Size= new System.Drawing.Size(200,150);
					form.Controls.Add(textoRapido);
					
					form.ShowDialog() ;
				}
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		
		public void trabajoHoras(){
			
			this.ventanaGeneral();
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
				if(tbContext.Text=="") tbContext.Text="0";
				
				
				if(double.Parse(tbContext.Text)<=40) lbResultadoString= (double.Parse(tbContext.Text)*double.Parse(tbContext2.Text)).ToString();
					else{
					
					double horasExtra= double.Parse(tbContext.Text)-40;
					
					double salarioExtra= double.Parse(tbContext2.Text)+double.Parse(tbContext2.Text)/2;
					
					double salarioExtraTotal= salarioExtra*horasExtra;
					
					lbResultadoString=((40*double.Parse(tbContext2.Text))+salarioExtra).ToString();
				}
				
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
			
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
			
		}
		
		
		public void calcularTiempo(){
			
			this.ventanaGeneral();
			
			
			this.bResultado.Click+= (sender, e)=>{
				
				if(tbContext.Text=="") tbContext.Text="0";
				
				double dias=0;
				double horas=0;
				double minutos=0;
				
				double tiempo= double.Parse(tbContext.Text);
				
				
				if(tiempo>=1440){ dias = tiempo/1440;  tiempo= tiempo%1440;} 
					if(tiempo>=60)horas = tiempo/60;  tiempo= tiempo%60; 
						minutos= tiempo;
						
						
						
						
						lbResultadoString= string.Concat("Dias: ", ((int)dias).ToString(), " Horas: ",((int)horas).ToString()," Minutos :",minutos.ToString());
			
							
					
	
				
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
			
		}
		
		
		public void ejercicio1(){
		
		this.ventanaGeneral();
		
		
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			if(tbContext2.Text=="") tbContext2.Text="0";
			
			lbResultadoString= c.DeterminarMayorDeDos(tbContext.Text,tbContext2.Text);
			
			
				
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		
		public void ejercicio2(){
		
		this.ventanaGeneral();
		
		
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			if(tbContext2.Text=="") tbContext2.Text="0";
			if(tbContext3.Text=="") tbContext3.Text="0";
			
			lbResultadoString= c.DeterminarMayorDeTres(tbContext.Text,tbContext2.Text,tbContext3.Text);
			
			
				
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
			
			this.Controls.Add(lbTextContext3);
			this.Controls.Add(tbContext3);
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		
		public void ejercicio3(){
		
		this.ventanaGeneral();
		
		
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			lbResultadoString= c.EsPositivoONegativo(tbContext.Text);
			
			
				
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		
		public void ejercicio4(){
		
		this.ventanaGeneral();
		
		
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			lbResultadoString= c.ConvertirMetros(tbContext.Text);
			
			
				
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		
		public void ejercicio6(){
		
		this.ventanaGeneral();
		
		
		string[] nacionalidad= {"mexicana","venezolana","Colombiano","Brazileño","Gringo"};
		
		cb1.Location=new System.Drawing.Point(lbTextContext.Right+30, tbContext.Bottom+30);
        cb1.Items.AddRange(nacionalidad);
        cb1.DropDownStyle = ComboBoxStyle.DropDownList;
        
        cb2.Location=new System.Drawing.Point(lbTextContext.Right+30, tbContext2.Bottom+30);
        cb2.Items.AddRange(new String[] {"femenino","masculino","Delfin"});
		cb2.DropDownStyle = ComboBoxStyle.DropDownList;
       
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			
			
			
			
			
			lbResultadoString= c.ServicioMilitar(tbContext.Text,cb1.Text,cb2.Text);
			
			
				
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(cb1);
			
			this.Controls.Add(lbTextContext3);
			this.Controls.Add(cb2);
			
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		public void ejercicio7(){
		
		this.ventanaGeneral();
		
		
		
       
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			
			lbResultadoString= c.CalcularInteres(tbContext.Text);
			
			
				
				
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		public void ejercicio8(){
		
		this.ventanaGeneral();
		
		
		
       
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			
			lbResultadoString= c.CalcularComision(tbContext.Text);
			
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		public void ejercicio10(){
		
		this.ventanaGeneral();
		
		
		
       
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			
			lbResultadoString= c.CalcularX(tbContext.Text);
			
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		
		public void ciclo1(){
		
		this.ventanaGeneral();
		
		this.lbResultado.Location = new System.Drawing.Point(10, 30);
			this.bResultado.Click+= (sender, e)=>{

			lbResultadoString= ciclo.SumatoriaUnoADiez();
		
				lbResultado.Text=lbResultadoString;
			};
				
			this.Controls.Add(bResultado);
			
			//this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		public void ciclo2(){
		
		this.ventanaGeneral();
		
		this.lbResultado.Location = new System.Drawing.Point(10, 30);
			this.bResultado.Click+= (sender, e)=>{

			lbResultadoString= ciclo.SumatoriaMultiplosDeCinco();
		
				lbResultado.Text=lbResultadoString;
			};
				
			this.Controls.Add(bResultado);
			
			//this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		public void ciclo3(){
		
		this.ventanaGeneral();
		
		String[] numero={"1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20"};
		
		cb1.Location=new System.Drawing.Point(lbTextContext.Right+30, 30);
        cb1.Items.AddRange(numero);
        cb1.DropDownStyle = ComboBoxStyle.DropDownList;
		
		this.lbResultado.Location = new System.Drawing.Point(10, 30);
		
		
		
		tbContext.Multiline=true;
		tbContext.ScrollBars= ScrollBars.Vertical;
		tbContext.ReadOnly = true;
		
		
		
			this.bResultado.Click+= (sender, e)=>{

			
		
				lbResultadoString= ciclo.TablaMultiplicar(int.Parse(cb1.Text));
				tbContext.Text=lbResultadoString;
			
			};
		
		tbContext.SetBounds(10, lbTextContext.Bottom+10, 300, 100);
		
			this.Controls.Add(lbTextContext);
			this.Controls.Add(cb1);
			
			this.Controls.Add(tbContext);
			this.Controls.Add(bResultado);
			
			
			
			
			
			this.ShowDialog();
		}
		
		public void ciclo4(){
		
		this.ventanaGeneral();
		
		
		int n=100;
			string[] numero= new string[n+1];
			
		
		
		
		
		
		for (int i=0;i<=n;i++){
				
				numero[i]=i.ToString();
		}
		
		cb1.Location=new System.Drawing.Point(lbTextContext.Right+30, 30);
		cb1.Items.AddRange(numero);
        cb1.DropDownStyle = ComboBoxStyle.DropDownList;
		
		this.lbResultado.Location = new System.Drawing.Point(10, 30);
		
		
		
		tbContext.Multiline=true;
		tbContext.ScrollBars= ScrollBars.Vertical;
		tbContext.ReadOnly = true;
		
		
		
			this.bResultado.Click+= (sender, e)=>{

			
		
				lbResultadoString= ciclo.NumerosPrimos(int.Parse(cb1.Text));
				tbContext.Text=lbResultadoString;
			
			};
		
		tbContext.SetBounds(10, lbTextContext.Bottom+10, 300, 100);
		
			this.Controls.Add(lbTextContext);
			this.Controls.Add(cb1);
			
			this.Controls.Add(tbContext);
			this.Controls.Add(bResultado);
			
			
			
			
			this.ShowDialog();
		}
		
		public void ciclo5(){
		
		this.ventanaGeneral();
		
		
		int n=20;
			string[] numero= new string[n+1];
			
		
		
		
		
		
		for (int i=0;i<=n;i++){
				
				numero[i]=i.ToString();
		}
		
		cb1.Location=new System.Drawing.Point(lbTextContext.Right+30, 30);
		cb1.Items.AddRange(numero);
        cb1.DropDownStyle = ComboBoxStyle.DropDownList;
		
		
		
	
		
		
			this.bResultado.Click+= (sender, e)=>{

			
		
				lbResultadoString= ciclo.Factorial(int.Parse(cb1.Text));
				lbResultado.Text=lbResultadoString;
			
			};
		
		
		
			this.Controls.Add(lbTextContext);
			this.Controls.Add(cb1);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			this.Controls.Add(bResultado);
			
			
			
			
			this.ShowDialog();
		}
		
		public void ciclo6(){
			
			this.ventanaGeneral();
		
		
		int n=1000;
			string[] numero= new string[n+1];
			
		
		
		
		
		
		for (int i=0;i<=n;i++){
				
				numero[i]=i.ToString();
		}
		
		cb1.Location=new System.Drawing.Point(lbTextContext.Right+30, 30);
		cb1.Items.AddRange(numero);
        cb1.DropDownStyle = ComboBoxStyle.DropDownList;
		
		this.lbResultado.Location = new System.Drawing.Point(10, 30);
		
		
		
		tbContext.Multiline=true;
		tbContext.ScrollBars= ScrollBars.Vertical;
		tbContext.ReadOnly = true;
		
		
		
			this.bResultado.Click+= (sender, e)=>{

			
		
				lbResultadoString= ciclo.NumerosImpares(int.Parse(cb1.Text));
				tbContext.Text=lbResultadoString;
			
			};
		
		tbContext.SetBounds(10, lbTextContext.Bottom+10, 300, 100);
		
			this.Controls.Add(lbTextContext);
			this.Controls.Add(cb1);
			
			this.Controls.Add(tbContext);
			this.Controls.Add(bResultado);
			
			
			
			
			this.ShowDialog();
		}
		
		
		public void ciclo7(){
		
		this.ventanaGeneral();
		
		
		
       
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			
			lbResultadoString= ciclo.EsNumeroPerfecto(int.Parse(tbContext.Text));
			
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		
		public void ciclo8(){
		
		this.ventanaGeneral();
		
		
		
       
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			
			lbResultadoString= ciclo.SonNumerosAmigos(int.Parse(tbContext.Text),int.Parse(tbContext2.Text));
			
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		public void ciclo9(){
		
		this.ventanaGeneral();
		
		
		
       
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			
			lbResultadoString= ciclo.ElevarNumero(int.Parse(tbContext.Text),int.Parse(tbContext2.Text));
			
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(tbContext);
			
			
			this.Controls.Add(lbTextContext2);
			this.Controls.Add(tbContext2);
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		
		public void ciclo10(){
		
		this.ventanaGeneral();
		
		
			int n=65;
			string[] numero= new string[n+1];
			
		
		
		
		
		
		for (int i=0;i<=n;i++){
				
				numero[i]=i.ToString();
		}
		
		cb1.Location=new System.Drawing.Point(lbTextContext.Right+30, 30);
		cb1.Items.AddRange(numero);
        cb1.DropDownStyle = ComboBoxStyle.DropDownList;
		
		
		
		
		
		tbContext.Multiline=true;
		tbContext.ScrollBars= ScrollBars.Vertical;
		tbContext.ReadOnly = true;
       
			
			
			
			this.bResultado.Click+= (sender, e)=>{
				
			if(tbContext.Text=="") tbContext.Text="0";
			
			
			
			lbResultadoString= ciclo.CalcularEx(int.Parse(cb1.Text));
			
				
				
				lbResultado.Text=lbResultadoString;
			
			
			};
			
			this.Controls.Add(lbTextContext);
			this.Controls.Add(cb1);
			
		
			
			
			this.Controls.Add(bResultado);
			
			this.Controls.Add(lbcontextoResultado);
			this.Controls.Add(lbResultado);
			
			
			this.ShowDialog();
		}
		

		
		}
	
	
		
		
		
			
			
			
			
			
			
			
			
		
		
		
	
}
