/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 06/02/2025
 * Time: 07:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GUI_CALCULADORA
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbResultado = new System.Windows.Forms.Label();
			this.b7 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbResultado
			// 
			this.lbResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbResultado.Location = new System.Drawing.Point(22, 9);
			this.lbResultado.Name = "lbResultado";
			this.lbResultado.Size = new System.Drawing.Size(367, 82);
			this.lbResultado.TabIndex = 0;
			this.lbResultado.Text = "0";
			this.lbResultado.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.lbResultado.Click += new System.EventHandler(this.Label1Click);
			// 
			// b7
			// 
			this.b7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b7.ForeColor = System.Drawing.Color.White;
			this.b7.Location = new System.Drawing.Point(22, 94);
			this.b7.Name = "b7";
			this.b7.Size = new System.Drawing.Size(87, 87);
			this.b7.TabIndex = 3;
			this.b7.Text = "7";
			this.b7.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(302, 94);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 87);
			this.button1.TabIndex = 4;
			this.button1.Text = "+";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(211, 94);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 87);
			this.button3.TabIndex = 5;
			this.button3.Text = "9";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(118, 94);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(87, 87);
			this.button4.TabIndex = 6;
			this.button4.Text = "8";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(118, 185);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(87, 87);
			this.button5.TabIndex = 10;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(211, 185);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(87, 87);
			this.button6.TabIndex = 9;
			this.button6.Text = "4";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(302, 185);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(87, 87);
			this.button7.TabIndex = 8;
			this.button7.Text = "-";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Location = new System.Drawing.Point(22, 185);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(87, 87);
			this.button8.TabIndex = 7;
			this.button8.Text = "6";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.ForeColor = System.Drawing.Color.White;
			this.button9.Location = new System.Drawing.Point(118, 278);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(87, 87);
			this.button9.TabIndex = 14;
			this.button9.Text = "2";
			this.button9.UseVisualStyleBackColor = false;
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.ForeColor = System.Drawing.Color.White;
			this.button10.Location = new System.Drawing.Point(211, 278);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(87, 87);
			this.button10.TabIndex = 13;
			this.button10.Text = "1";
			this.button10.UseVisualStyleBackColor = false;
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button11.ForeColor = System.Drawing.Color.White;
			this.button11.Location = new System.Drawing.Point(302, 278);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(87, 87);
			this.button11.TabIndex = 12;
			this.button11.Text = "*";
			this.button11.UseVisualStyleBackColor = false;
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button12.ForeColor = System.Drawing.Color.White;
			this.button12.Location = new System.Drawing.Point(22, 278);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(87, 87);
			this.button12.TabIndex = 11;
			this.button12.Text = "3";
			this.button12.UseVisualStyleBackColor = false;
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button13.ForeColor = System.Drawing.Color.White;
			this.button13.Location = new System.Drawing.Point(118, 371);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(87, 87);
			this.button13.TabIndex = 18;
			this.button13.Text = "7";
			this.button13.UseVisualStyleBackColor = false;
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button14.ForeColor = System.Drawing.Color.White;
			this.button14.Location = new System.Drawing.Point(211, 371);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(87, 87);
			this.button14.TabIndex = 17;
			this.button14.Text = "7";
			this.button14.UseVisualStyleBackColor = false;
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button15.ForeColor = System.Drawing.Color.White;
			this.button15.Location = new System.Drawing.Point(302, 371);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(87, 87);
			this.button15.TabIndex = 16;
			this.button15.Text = "/";
			this.button15.UseVisualStyleBackColor = false;
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button16.ForeColor = System.Drawing.Color.White;
			this.button16.Location = new System.Drawing.Point(22, 371);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(87, 87);
			this.button16.TabIndex = 15;
			this.button16.Text = "7";
			this.button16.UseVisualStyleBackColor = false;
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button17.ForeColor = System.Drawing.Color.White;
			this.button17.Location = new System.Drawing.Point(118, 464);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(87, 87);
			this.button17.TabIndex = 22;
			this.button17.Text = "7";
			this.button17.UseVisualStyleBackColor = false;
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button19.ForeColor = System.Drawing.Color.White;
			this.button19.Location = new System.Drawing.Point(211, 464);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(178, 87);
			this.button19.TabIndex = 20;
			this.button19.Text = "=";
			this.button19.UseVisualStyleBackColor = false;
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button20.ForeColor = System.Drawing.Color.White;
			this.button20.Location = new System.Drawing.Point(22, 464);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(87, 87);
			this.button20.TabIndex = 19;
			this.button20.Text = "7";
			this.button20.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(416, 563);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.b7);
			this.Controls.Add(this.lbResultado);
			this.Name = "MainForm";
			this.Text = "GUI_CALCULADORA";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button b7;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lbResultado;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
	}
}
