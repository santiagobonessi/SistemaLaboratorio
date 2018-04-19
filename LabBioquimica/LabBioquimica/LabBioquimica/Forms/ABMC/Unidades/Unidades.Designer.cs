namespace LabBioquimica.Forms.ABMC
{
    partial class Unidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unidades));
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.idUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AllowUserToAddRows = false;
            this.dgvUnidades.AllowUserToDeleteRows = false;
            this.dgvUnidades.AllowUserToResizeColumns = false;
            this.dgvUnidades.AllowUserToResizeRows = false;
            this.dgvUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUnidades,
            this.nombre});
            this.dgvUnidades.Location = new System.Drawing.Point(12, 12);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.ReadOnly = true;
            this.dgvUnidades.RowHeadersVisible = false;
            this.dgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidades.Size = new System.Drawing.Size(228, 297);
            this.dgvUnidades.TabIndex = 21;
            this.dgvUnidades.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUnidades_MouseClick);
            // 
            // idUnidades
            // 
            this.idUnidades.HeaderText = "Número";
            this.idUnidades.Name = "idUnidades";
            this.idUnidades.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(250, 321);
            this.Controls.Add(this.dgvUnidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Unidades";
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.Unidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}