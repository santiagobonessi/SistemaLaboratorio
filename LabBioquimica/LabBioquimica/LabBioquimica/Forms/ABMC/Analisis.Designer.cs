namespace LabBioquimica.Forms.ABMC
{
    partial class Analisis
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
            this.dgvAnalisis = new System.Windows.Forms.DataGridView();
            this.idAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidBioq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnalisis
            // 
            this.dgvAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnalisis,
            this.codigo,
            this.nombre,
            this.metodo,
            this.unidBioq});
            this.dgvAnalisis.Location = new System.Drawing.Point(12, 60);
            this.dgvAnalisis.Name = "dgvAnalisis";
            this.dgvAnalisis.Size = new System.Drawing.Size(616, 238);
            this.dgvAnalisis.TabIndex = 0;
            // 
            // idAnalisis
            // 
            this.idAnalisis.HeaderText = "ID_ANALISIS";
            this.idAnalisis.Name = "idAnalisis";
            this.idAnalisis.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // metodo
            // 
            this.metodo.HeaderText = "METODO";
            this.metodo.Name = "metodo";
            this.metodo.ReadOnly = true;
            // 
            // unidBioq
            // 
            this.unidBioq.HeaderText = "UNID BIOQUIMICA";
            this.unidBioq.Name = "unidBioq";
            this.unidBioq.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAnalisis);
            this.Name = "Analisis";
            this.Text = "Analisis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidBioq;
        private System.Windows.Forms.Button button1;
    }
}