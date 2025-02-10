/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 10/02/2025
 * Time: 01:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GUI_CALCULADORA
{
	/// <summary>
	/// Description of cadenaBotones.
	/// </summary>
	public class cadenaBotones
	{
		public cadenaBotones()
		{
		}
		
		public String getCadena(int i){
			
			String[] cadenaBotones={"7","8","9","+","4","5",
                "6","-","1","2","3","x",".","0","C","/",
                "MR","ML","X^n","√","M+","M-","="};
			
			return cadenaBotones[i];
		}
	}
}
