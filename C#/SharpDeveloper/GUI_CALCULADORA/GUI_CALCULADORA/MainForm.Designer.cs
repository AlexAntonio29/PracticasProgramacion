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
			this.btn7 = new System.Windows.Forms.Button();
			this.btnMas = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btnMenos = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btnMult = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn6ML = new System.Windows.Forms.Button();
			this.btnXN = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.btnMR = new System.Windows.Forms.Button();
			this.btnMMenos = new System.Windows.Forms.Button();
			this.btnIgual = new System.Windows.Forms.Button();
			this.btnMMAs = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnRaiz = new System.Windows.Forms.Button();
			this.btnPunto = new System.Windows.Forms.Button();
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
			this.lbResultado.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.lbResultado.Click += new System.EventHandler(this.LbResultadoClick);
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.ForeColor = System.Drawing.Color.White;
			this.btn7.Location = new System.Drawing.Point(22, 94);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(87, 87);
			this.btn7.TabIndex = 3;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = false;
			this.btn7.Click += new System.EventHandler(this.B7Click);
			// 
			// btnMas
			// 
			this.btnMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMas.ForeColor = System.Drawing.Color.White;
			this.btnMas.Location = new System.Drawing.Point(302, 94);
			this.btnMas.Name = "btnMas";
			this.btnMas.Size = new System.Drawing.Size(87, 87);
			this.btnMas.TabIndex = 4;
			this.btnMas.Text = "+";
			this.btnMas.UseVisualStyleBackColor = false;
			this.btnMas.Click += new System.EventHandler(this.Button1Click);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.ForeColor = System.Drawing.Color.White;
			this.btn9.Location = new System.Drawing.Point(211, 94);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(87, 87);
			this.btn9.TabIndex = 5;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = false;
			this.btn9.Click += new System.EventHandler(this.Button3Click);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.ForeColor = System.Drawing.Color.White;
			this.btn8.Location = new System.Drawing.Point(118, 94);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(87, 87);
			this.btn8.TabIndex = 6;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = false;
			this.btn8.Click += new System.EventHandler(this.B8Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.ForeColor = System.Drawing.Color.White;
			this.btn5.Location = new System.Drawing.Point(118, 185);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(87, 87);
			this.btn5.TabIndex = 10;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.Button5Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.ForeColor = System.Drawing.Color.White;
			this.btn4.Location = new System.Drawing.Point(22, 185);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(87, 87);
			this.btn4.TabIndex = 9;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.Button6Click);
			// 
			// btnMenos
			// 
			this.btnMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenos.ForeColor = System.Drawing.Color.White;
			this.btnMenos.Location = new System.Drawing.Point(302, 185);
			this.btnMenos.Name = "btnMenos";
			this.btnMenos.Size = new System.Drawing.Size(87, 87);
			this.btnMenos.TabIndex = 8;
			this.btnMenos.Text = "-";
			this.btnMenos.UseVisualStyleBackColor = false;
			this.btnMenos.Click += new System.EventHandler(this.Button7Click);
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.ForeColor = System.Drawing.Color.White;
			this.btn6.Location = new System.Drawing.Point(209, 185);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(87, 87);
			this.btn6.TabIndex = 7;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.Button8Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.ForeColor = System.Drawing.Color.White;
			this.btn2.Location = new System.Drawing.Point(118, 278);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(87, 87);
			this.btn2.TabIndex = 14;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.Button9Click);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.ForeColor = System.Drawing.Color.White;
			this.btn1.Location = new System.Drawing.Point(22, 278);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(87, 87);
			this.btn1.TabIndex = 13;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.Button10Click);
			// 
			// btnMult
			// 
			this.btnMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMult.ForeColor = System.Drawing.Color.White;
			this.btnMult.Location = new System.Drawing.Point(302, 278);
			this.btnMult.Name = "btnMult";
			this.btnMult.Size = new System.Drawing.Size(87, 87);
			this.btnMult.TabIndex = 12;
			this.btnMult.Text = "*";
			this.btnMult.UseVisualStyleBackColor = false;
			this.btnMult.Click += new System.EventHandler(this.Button11Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.ForeColor = System.Drawing.Color.White;
			this.btn3.Location = new System.Drawing.Point(209, 278);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(87, 87);
			this.btn3.TabIndex = 11;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.Button12Click);
			// 
			// btn6ML
			// 
			this.btn6ML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn6ML.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6ML.ForeColor = System.Drawing.Color.White;
			this.btn6ML.Location = new System.Drawing.Point(118, 471);
			this.btn6ML.Name = "btn6ML";
			this.btn6ML.Size = new System.Drawing.Size(87, 87);
			this.btn6ML.TabIndex = 18;
			this.btn6ML.Text = "ML";
			this.btn6ML.UseVisualStyleBackColor = false;
			this.btn6ML.Click += new System.EventHandler(this.Button13Click);
			// 
			// btnXN
			// 
			this.btnXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXN.ForeColor = System.Drawing.Color.White;
			this.btnXN.Location = new System.Drawing.Point(211, 471);
			this.btnXN.Name = "btnXN";
			this.btnXN.Size = new System.Drawing.Size(87, 87);
			this.btnXN.TabIndex = 17;
			this.btnXN.Text = "X^n";
			this.btnXN.UseVisualStyleBackColor = false;
			this.btnXN.Click += new System.EventHandler(this.Button14Click);
			// 
			// btnDiv
			// 
			this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiv.ForeColor = System.Drawing.Color.White;
			this.btnDiv.Location = new System.Drawing.Point(302, 471);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(87, 87);
			this.btnDiv.TabIndex = 16;
			this.btnDiv.Text = "√";
			this.btnDiv.UseVisualStyleBackColor = false;
			this.btnDiv.Click += new System.EventHandler(this.Button15Click);
			// 
			// btnMR
			// 
			this.btnMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMR.ForeColor = System.Drawing.Color.White;
			this.btnMR.Location = new System.Drawing.Point(22, 471);
			this.btnMR.Name = "btnMR";
			this.btnMR.Size = new System.Drawing.Size(87, 87);
			this.btnMR.TabIndex = 15;
			this.btnMR.Text = "MR";
			this.btnMR.UseVisualStyleBackColor = false;
			this.btnMR.Click += new System.EventHandler(this.Button16Click);
			// 
			// btnMMenos
			// 
			this.btnMMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnMMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMMenos.ForeColor = System.Drawing.Color.White;
			this.btnMMenos.Location = new System.Drawing.Point(118, 564);
			this.btnMMenos.Name = "btnMMenos";
			this.btnMMenos.Size = new System.Drawing.Size(87, 87);
			this.btnMMenos.TabIndex = 22;
			this.btnMMenos.Text = "M-";
			this.btnMMenos.UseVisualStyleBackColor = false;
			this.btnMMenos.Click += new System.EventHandler(this.Button17Click);
			// 
			// btnIgual
			// 
			this.btnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIgual.ForeColor = System.Drawing.Color.White;
			this.btnIgual.Location = new System.Drawing.Point(211, 564);
			this.btnIgual.Name = "btnIgual";
			this.btnIgual.Size = new System.Drawing.Size(178, 87);
			this.btnIgual.TabIndex = 20;
			this.btnIgual.Text = "=";
			this.btnIgual.UseVisualStyleBackColor = false;
			this.btnIgual.Click += new System.EventHandler(this.Button19Click);
			// 
			// btnMMAs
			// 
			this.btnMMAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnMMAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMMAs.ForeColor = System.Drawing.Color.White;
			this.btnMMAs.Location = new System.Drawing.Point(22, 564);
			this.btnMMAs.Name = "btnMMAs";
			this.btnMMAs.Size = new System.Drawing.Size(87, 87);
			this.btnMMAs.TabIndex = 19;
			this.btnMMAs.Text = "M+";
			this.btnMMAs.UseVisualStyleBackColor = false;
			this.btnMMAs.Click += new System.EventHandler(this.Button20Click);
			// 
			// btn0
			// 
			this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.ForeColor = System.Drawing.Color.White;
			this.btn0.Location = new System.Drawing.Point(118, 371);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(87, 87);
			this.btn0.TabIndex = 26;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = false;
			this.btn0.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnC
			// 
			this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnC.ForeColor = System.Drawing.Color.White;
			this.btnC.Location = new System.Drawing.Point(211, 371);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(87, 87);
			this.btnC.TabIndex = 25;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = false;
			this.btnC.Click += new System.EventHandler(this.Button18Click);
			// 
			// btnRaiz
			// 
			this.btnRaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRaiz.ForeColor = System.Drawing.Color.White;
			this.btnRaiz.Location = new System.Drawing.Point(302, 371);
			this.btnRaiz.Name = "btnRaiz";
			this.btnRaiz.Size = new System.Drawing.Size(87, 87);
			this.btnRaiz.TabIndex = 24;
			this.btnRaiz.Text = "/";
			this.btnRaiz.UseVisualStyleBackColor = false;
			this.btnRaiz.Click += new System.EventHandler(this.Button21Click);
			// 
			// btnPunto
			// 
			this.btnPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPunto.ForeColor = System.Drawing.Color.White;
			this.btnPunto.Location = new System.Drawing.Point(22, 371);
			this.btnPunto.Name = "btnPunto";
			this.btnPunto.Size = new System.Drawing.Size(87, 87);
			this.btnPunto.TabIndex = 23;
			this.btnPunto.Text = ".";
			this.btnPunto.UseVisualStyleBackColor = false;
			this.btnPunto.Click += new System.EventHandler(this.Button22Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(395, 663);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnRaiz);
			this.Controls.Add(this.btnPunto);
			this.Controls.Add(this.btnMMenos);
			this.Controls.Add(this.btnIgual);
			this.Controls.Add(this.btnMMAs);
			this.Controls.Add(this.btn6ML);
			this.Controls.Add(this.btnXN);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnMR);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btnMult);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btnMenos);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btnMas);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.lbResultado);
			this.Name = "MainForm";
			this.Text = "GUI_CALCULADORA";
			this.Click += new System.EventHandler(this.Label1Click);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btnMult;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btnMas;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btnMenos;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn6ML;
		private System.Windows.Forms.Button btnXN;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnMR;
		private System.Windows.Forms.Button btnMMenos;
		private System.Windows.Forms.Button btnIgual;
		private System.Windows.Forms.Button btnMMAs;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnRaiz;
		private System.Windows.Forms.Button btnPunto;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Label lbResultado;
	}
}
