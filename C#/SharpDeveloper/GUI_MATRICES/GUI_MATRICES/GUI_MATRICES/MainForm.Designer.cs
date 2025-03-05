/*
 * Created by SharpDevelop.
 * User: Alexis
 * Date: 27/02/2025
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GUI_MATRICES
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
			this.lbTabla1 = new System.Windows.Forms.Label();
			this.lbColumnasTabla2 = new System.Windows.Forms.Label();
			this.lbTabla2 = new System.Windows.Forms.Label();
			this.blFilaTabla1 = new System.Windows.Forms.Label();
			this.lbColumnaTabla1 = new System.Windows.Forms.Label();
			this.lbFilasTabla2 = new System.Windows.Forms.Label();
			this.tbColumnasTabla1 = new System.Windows.Forms.TextBox();
			this.tbFilasTabla1 = new System.Windows.Forms.TextBox();
			this.tbFilasTabla2 = new System.Windows.Forms.TextBox();
			this.tbColumnasTabla2 = new System.Windows.Forms.TextBox();
			this.bGenerar = new System.Windows.Forms.Button();
			this.cbTipoOperacionTabla = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTabla1
			// 
			this.lbTabla1.AutoSize = true;
			this.lbTabla1.Location = new System.Drawing.Point(31, 58);
			this.lbTabla1.Name = "lbTabla1";
			this.lbTabla1.Size = new System.Drawing.Size(61, 20);
			this.lbTabla1.TabIndex = 0;
			this.lbTabla1.Text = "Tabla 1";
			this.lbTabla1.Click += new System.EventHandler(this.LbTabla1Click);
			// 
			// lbColumnasTabla2
			// 
			this.lbColumnasTabla2.AutoSize = true;
			this.lbColumnasTabla2.Location = new System.Drawing.Point(369, 94);
			this.lbColumnasTabla2.Name = "lbColumnasTabla2";
			this.lbColumnasTabla2.Size = new System.Drawing.Size(80, 20);
			this.lbColumnasTabla2.TabIndex = 1;
			this.lbColumnasTabla2.Text = "Columnas";
			// 
			// lbTabla2
			// 
			this.lbTabla2.AutoSize = true;
			this.lbTabla2.Location = new System.Drawing.Point(369, 58);
			this.lbTabla2.Name = "lbTabla2";
			this.lbTabla2.Size = new System.Drawing.Size(61, 20);
			this.lbTabla2.TabIndex = 2;
			this.lbTabla2.Text = "Tabla 2";
			// 
			// blFilaTabla1
			// 
			this.blFilaTabla1.AutoSize = true;
			this.blFilaTabla1.Location = new System.Drawing.Point(31, 137);
			this.blFilaTabla1.Name = "blFilaTabla1";
			this.blFilaTabla1.Size = new System.Drawing.Size(42, 20);
			this.blFilaTabla1.TabIndex = 3;
			this.blFilaTabla1.Text = "Filas";
			// 
			// lbColumnaTabla1
			// 
			this.lbColumnaTabla1.AutoSize = true;
			this.lbColumnaTabla1.Location = new System.Drawing.Point(31, 97);
			this.lbColumnaTabla1.Name = "lbColumnaTabla1";
			this.lbColumnaTabla1.Size = new System.Drawing.Size(80, 20);
			this.lbColumnaTabla1.TabIndex = 4;
			this.lbColumnaTabla1.Text = "Columnas";
			// 
			// lbFilasTabla2
			// 
			this.lbFilasTabla2.AutoSize = true;
			this.lbFilasTabla2.Location = new System.Drawing.Point(369, 131);
			this.lbFilasTabla2.Name = "lbFilasTabla2";
			this.lbFilasTabla2.Size = new System.Drawing.Size(42, 20);
			this.lbFilasTabla2.TabIndex = 5;
			this.lbFilasTabla2.Text = "Filas";
			// 
			// tbColumnasTabla1
			// 
			this.tbColumnasTabla1.Location = new System.Drawing.Point(117, 91);
			this.tbColumnasTabla1.Name = "tbColumnasTabla1";
			this.tbColumnasTabla1.Size = new System.Drawing.Size(100, 26);
			this.tbColumnasTabla1.TabIndex = 6;
			this.tbColumnasTabla1.TextChanged += new System.EventHandler(this.TbColumnasTabla1TextChanged);
			// 
			// tbFilasTabla1
			// 
			this.tbFilasTabla1.Location = new System.Drawing.Point(117, 131);
			this.tbFilasTabla1.Name = "tbFilasTabla1";
			this.tbFilasTabla1.Size = new System.Drawing.Size(100, 26);
			this.tbFilasTabla1.TabIndex = 7;
			// 
			// tbFilasTabla2
			// 
			this.tbFilasTabla2.Location = new System.Drawing.Point(455, 128);
			this.tbFilasTabla2.Name = "tbFilasTabla2";
			this.tbFilasTabla2.Size = new System.Drawing.Size(100, 26);
			this.tbFilasTabla2.TabIndex = 8;
			// 
			// tbColumnasTabla2
			// 
			this.tbColumnasTabla2.Location = new System.Drawing.Point(455, 91);
			this.tbColumnasTabla2.Name = "tbColumnasTabla2";
			this.tbColumnasTabla2.Size = new System.Drawing.Size(100, 26);
			this.tbColumnasTabla2.TabIndex = 9;
			// 
			// bGenerar
			// 
			this.bGenerar.Location = new System.Drawing.Point(862, 86);
			this.bGenerar.Name = "bGenerar";
			this.bGenerar.Size = new System.Drawing.Size(89, 43);
			this.bGenerar.TabIndex = 10;
			this.bGenerar.Text = "Generar";
			this.bGenerar.UseVisualStyleBackColor = true;
			this.bGenerar.Click += new System.EventHandler(this.BGenerarClick);
			// 
			// cbTipoOperacionTabla
			// 
			this.cbTipoOperacionTabla.Text="Suma";
			this.cbTipoOperacionTabla.Items.AddRange(new object[] {
									"Suma",
									"Resta ",
									"Multiplicacion",
									"Division"});
			this.cbTipoOperacionTabla.Location = new System.Drawing.Point(682, 94);
			this.cbTipoOperacionTabla.Name = "cbTipoOperacionTabla";
			this.cbTipoOperacionTabla.Size = new System.Drawing.Size(121, 28);
			this.cbTipoOperacionTabla.TabIndex = 11;
			this.cbTipoOperacionTabla.SelectedIndexChanged += new System.EventHandler(this.CbTipoOperacionTablaSelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(41, 249);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(271, 210);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(357, 249);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 28;
			this.dataGridView2.Size = new System.Drawing.Size(271, 210);
			this.dataGridView2.TabIndex = 13;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(680, 249);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.RowTemplate.Height = 28;
			this.dataGridView3.Size = new System.Drawing.Size(271, 210);
			this.dataGridView3.TabIndex = 16;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 696);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.bGenerar);
			this.Controls.Add(this.tbColumnasTabla2);
			this.Controls.Add(this.tbFilasTabla2);
			this.Controls.Add(this.tbFilasTabla1);
			this.Controls.Add(this.tbColumnasTabla1);
			this.Controls.Add(this.lbFilasTabla2);
			this.Controls.Add(this.lbColumnaTabla1);
			this.Controls.Add(this.blFilaTabla1);
			this.Controls.Add(this.lbTabla2);
			this.Controls.Add(this.lbColumnasTabla2);
			this.Controls.Add(this.lbTabla1);
			this.Controls.Add(this.cbTipoOperacionTabla);
			this.Name = "MainForm";
			this.Text = "GUI_MATRICES";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button bGenerar;
		private System.Windows.Forms.Label lbTabla1;
		private System.Windows.Forms.TextBox tbColumnasTabla2;
		private System.Windows.Forms.TextBox tbFilasTabla2;
		private System.Windows.Forms.TextBox tbFilasTabla1;
		private System.Windows.Forms.TextBox tbColumnasTabla1;
		private System.Windows.Forms.Label lbFilasTabla2;
		private System.Windows.Forms.Label lbColumnaTabla1;
		private System.Windows.Forms.Label blFilaTabla1;
		private System.Windows.Forms.Label lbTabla2;
		private System.Windows.Forms.Label lbColumnasTabla2;
		private System.Windows.Forms.ComboBox cbOpcionesTabla;
		
		void CbTipoOperacionTablaSelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
		
	void BGenerarClick(object sender, System.EventArgs e)
{
    dataGridView1.Rows.Clear();
    dataGridView1.Columns.Clear();
    dataGridView2.Rows.Clear();
    dataGridView2.Columns.Clear();
    dataGridView3.Rows.Clear();
    dataGridView3.Columns.Clear();

    alerta alerta = new alerta();

    int columnaTabla1 = int.Parse(tbColumnasTabla1.Text);
    int columnaTabla2 = int.Parse(tbColumnasTabla2.Text);
    int filaTabla1 = int.Parse(tbFilasTabla1.Text);
    int filaTabla2 = int.Parse(tbFilasTabla2.Text);

    for (int i = 0; i < columnaTabla1; i++)
        dataGridView1.Columns.Add("c", "c" + (i + 1));
    for (int i = 0; i < filaTabla1; i++)
        dataGridView1.Rows.Add();

    for (int i = 0; i < columnaTabla2; i++)
        dataGridView2.Columns.Add("c", "c" + (i + 1));
    for (int i = 0; i < filaTabla2; i++)
        dataGridView2.Rows.Add();

    int contador = 0;
    for (int i = 0; i < filaTabla1; i++)
    {
        for (int j = 0; j < columnaTabla1; j++)
        {
            dataGridView1.Rows[i].Cells[j].Value = contador.ToString();
            contador++;
        }
    }

    for (int i = 0; i < filaTabla2; i++)
    {
        for (int j = 0; j < columnaTabla2; j++)
        {
            dataGridView2.Rows[i].Cells[j].Value = contador.ToString();
            contador++;
        }
    }

    int filas = dataGridView1.RowCount;
    int columnas = dataGridView1.ColumnCount;

    // Validaciones para las operaciones de matrices
    string operacion = cbTipoOperacionTabla.Text.ToString();

    // Suma, Resta y División: Ambas matrices deben tener las mismas dimensiones (m × n)
    if (operacion == "Suma" || operacion == "Resta" || operacion == "Division")
    {
        if (filas != dataGridView2.RowCount || columnas != dataGridView2.ColumnCount)
        {
            alerta.ShowDialog();
            return;
        }

        dataGridView3.RowCount = filas;
        dataGridView3.ColumnCount = columnas;

        for (int i = 0; i < filas - 1; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                double valor1 = double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                double valor2 = double.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                double resultado = 0;

                switch (operacion)
                {
                    case "Suma":
                        resultado = valor1 + valor2;
                        break;
                    case "Resta":
                        resultado = valor1 - valor2;
                        break;
                    case "Division":
                        if (valor2 != 0)
                            resultado = valor1 / valor2;
                        else
                            resultado = 0; // Evitar división por cero
                        break;
                }

                dataGridView3.Rows[i].Cells[j].Value = resultado;
            }
        }
    }
    // Multiplicación: La matriz 1 debe ser de (m × n) y la matriz 2 de (n × p) para generar (m × p)
    else if (operacion == "Multiplicacion")
    {
        if (columnaTabla1 != filaTabla2)  // n debe ser igual en ambas matrices
        {
            alerta.ShowDialog();
            return;
        }

        dataGridView3.RowCount = filaTabla1;
        dataGridView3.ColumnCount = columnaTabla2;

        for (int i = 0; i < filaTabla1; i++)
        {
            for (int j = 0; j < columnaTabla2; j++)
            {
                double resultado = 0;

                for (int k = 0; k < columnaTabla1; k++) // n veces
                {
                    double valor1 = double.Parse(dataGridView1.Rows[i].Cells[k].Value.ToString());
                    double valor2 = double.Parse(dataGridView2.Rows[k].Cells[j].Value.ToString());
                    resultado += valor1 * valor2;
                }

                dataGridView3.Rows[i].Cells[j].Value = resultado;
            }
        }
    }
    else
    {
        alerta.ShowDialog();
    }
}

		
		void TbColumnasTabla1TextChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
