/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 06/02/2025
 * Time: 07:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_CALCULADORA
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			String[] cadenaBotones={"7","8","9","+","4","5",
                "6","-","1","2","3","x",".","0","C","/",
                "MR","ML","X^n","√","M+","M-","="};
			
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		
			
			
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void click7(){
			//lbResultado.Text("7");
			
			//Console.Write(7);
		
		}
		
		void B7Click(object sender, EventArgs e)
			
		{
			
			
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(0),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
			
		}
		
		void Button20Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(20),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void LbResultadoClick(object sender, EventArgs e)
		{
			
		}
		
		void B8Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(1),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(2),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
			
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(6),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
		eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(5),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(4),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(10),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(9),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(8),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(13),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button18Click(object sender, EventArgs e)
		{
			
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(14),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(3),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(7),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(11),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button22Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(12),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
			
		}
		
		void Button21Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(15),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(16),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(17),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(18),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(19),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(21),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			eventoPulsado action= new eventoPulsado(new cadenaBotones().getCadena(22),lbResultado.Text);
			action.Action();
			lbResultado.Text=action.GetCadenaRes();
		}
	}
}
