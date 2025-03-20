/*
 * Creado por SharpDevelop.
 * Usuario: Alexis
 * Fecha: 19/03/2025
 * Hora: 09:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CONEXION_BD
{
	partial class horarios
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hORARIOSALUMNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hORARIOSMAESTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbBuscarHorario = new System.Windows.Forms.Label();
			this.dgvHorario = new System.Windows.Forms.DataGridView();
			this.cHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cLunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMartes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMiercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cJueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cViernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbBuscar = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.hORARIOSALUMNOSToolStripMenuItem,
									this.hORARIOSMAESTROSToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1878, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hORARIOSALUMNOSToolStripMenuItem
			// 
			this.hORARIOSALUMNOSToolStripMenuItem.Name = "hORARIOSALUMNOSToolStripMenuItem";
			this.hORARIOSALUMNOSToolStripMenuItem.Size = new System.Drawing.Size(204, 29);
			this.hORARIOSALUMNOSToolStripMenuItem.Text = "HORARIOS ALUMNOS";
			// 
			// hORARIOSMAESTROSToolStripMenuItem
			// 
			this.hORARIOSMAESTROSToolStripMenuItem.Name = "hORARIOSMAESTROSToolStripMenuItem";
			this.hORARIOSMAESTROSToolStripMenuItem.Size = new System.Drawing.Size(210, 29);
			this.hORARIOSMAESTROSToolStripMenuItem.Text = "HORARIOS MAESTROS";
			// 
			// lbBuscarHorario
			// 
			this.lbBuscarHorario.Location = new System.Drawing.Point(32, 56);
			this.lbBuscarHorario.Name = "lbBuscarHorario";
			this.lbBuscarHorario.Size = new System.Drawing.Size(100, 23);
			this.lbBuscarHorario.TabIndex = 1;
			this.lbBuscarHorario.Text = "Buscar:";
			// 
			// dgvHorario
			// 
			this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.cHora,
									this.cLunes,
									this.cMartes,
									this.cMiercoles,
									this.cJueves,
									this.cViernes});
			this.dgvHorario.Location = new System.Drawing.Point(100, 200);
			this.dgvHorario.Name = "dgvHorario";
			this.dgvHorario.RowTemplate.Height = 28;
			this.dgvHorario.Size = new System.Drawing.Size(1520, 620);
			this.dgvHorario.TabIndex = 2;
			// 
			// cHora
			// 
			this.cHora.HeaderText = "Hora";
			this.cHora.Name = "cHora";
			this.cHora.Width = 120;
			// 
			// cLunes
			// 
			this.cLunes.HeaderText = "Lunes";
			this.cLunes.Name = "cLunes";
			this.cLunes.Width = 170;
			// 
			// cMartes
			// 
			this.cMartes.HeaderText = "Martes";
			this.cMartes.Name = "cMartes";
			this.cMartes.Width = 170;
			// 
			// cMiercoles
			// 
			this.cMiercoles.HeaderText = "Miercoles";
			this.cMiercoles.Name = "cMiercoles";
			this.cMiercoles.Width = 170;
			// 
			// cJueves
			// 
			this.cJueves.HeaderText = "Jueves";
			this.cJueves.Name = "cJueves";
			this.cJueves.Width = 170;
			// 
			// cViernes
			// 
			this.cViernes.HeaderText = "Viernes";
			this.cViernes.Name = "cViernes";
			this.cViernes.Width = 170;
			// 
			// cbBuscar
			// 
			this.cbBuscar.FormattingEnabled = true;
			this.cbBuscar.Location = new System.Drawing.Point(99, 56);
			this.cbBuscar.Name = "cbBuscar";
			this.cbBuscar.Size = new System.Drawing.Size(499, 28);
			this.cbBuscar.TabIndex = 3;
			this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.CbBuscarSelectedIndexChanged);
			// 
			// horarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1878, 1050);
			this.Controls.Add(this.cbBuscar);
			this.Controls.Add(this.dgvHorario);
			this.Controls.Add(this.lbBuscarHorario);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "horarios";
			this.Text = "horarios";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cbBuscar;
		private System.Windows.Forms.DataGridView dgvHorario;
		private System.Windows.Forms.DataGridViewTextBoxColumn cViernes;
		private System.Windows.Forms.DataGridViewTextBoxColumn cJueves;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMiercoles;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMartes;
		private System.Windows.Forms.DataGridViewTextBoxColumn cLunes;
		private System.Windows.Forms.DataGridViewTextBoxColumn cHora;
		private System.Windows.Forms.Label lbBuscarHorario;
		private System.Windows.Forms.ToolStripMenuItem hORARIOSMAESTROSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hORARIOSALUMNOSToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
