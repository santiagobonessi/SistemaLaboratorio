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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analisis));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvAnalisis = new System.Windows.Forms.DataGridView();
            this.idAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidBioq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantFilas = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(650, 10);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(291, 15);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(98, 13);
            this.lblBusqueda.TabIndex = 13;
            this.lblBusqueda.Text = "Búsqueda Nombre:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsulta.Location = new System.Drawing.Point(395, 12);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(249, 20);
            this.txtConsulta.TabIndex = 12;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // dgvAnalisis
            // 
            this.dgvAnalisis.AllowUserToAddRows = false;
            this.dgvAnalisis.AllowUserToDeleteRows = false;
            this.dgvAnalisis.AllowUserToResizeColumns = false;
            this.dgvAnalisis.AllowUserToResizeRows = false;
            this.dgvAnalisis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnalisis,
            this.codigo,
            this.nombre,
            this.metodo,
            this.unidBioq});
            this.dgvAnalisis.Location = new System.Drawing.Point(4, 39);
            this.dgvAnalisis.Name = "dgvAnalisis";
            this.dgvAnalisis.ReadOnly = true;
            this.dgvAnalisis.RowHeadersVisible = false;
            this.dgvAnalisis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalisis.Size = new System.Drawing.Size(1177, 557);
            this.dgvAnalisis.TabIndex = 15;
            this.dgvAnalisis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAnalisis_MouseClick);
            // 
            // idAnalisis
            // 
            this.idAnalisis.HeaderText = "ID";
            this.idAnalisis.Name = "idAnalisis";
            this.idAnalisis.ReadOnly = true;
            this.idAnalisis.Visible = false;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 51.30358F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 216.1707F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // metodo
            // 
            this.metodo.FillWeight = 81.76434F;
            this.metodo.HeaderText = "Método";
            this.metodo.Name = "metodo";
            this.metodo.ReadOnly = true;
            // 
            // unidBioq
            // 
            this.unidBioq.FillWeight = 50.76143F;
            this.unidBioq.HeaderText = "Unidad Bioquimica";
            this.unidBioq.Name = "unidBioq";
            this.unidBioq.ReadOnly = true;
            // 
            // lblCantFilas
            // 
            this.lblCantFilas.AutoSize = true;
            this.lblCantFilas.Location = new System.Drawing.Point(1164, 23);
            this.lblCantFilas.Name = "lblCantFilas";
            this.lblCantFilas.Size = new System.Drawing.Size(0, 13);
            this.lblCantFilas.TabIndex = 17;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(1088, 23);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(76, 13);
            this.lblCant.TabIndex = 16;
            this.lblCant.Text = "Cantidad Filas:";
            // 
            // Analisis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1192, 601);
            this.Controls.Add(this.lblCantFilas);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.dgvAnalisis);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Analisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis";
            this.Load += new System.EventHandler(this.Analisis_Load);
            this.Resize += new System.EventHandler(this.Analisis_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvAnalisis;
        private System.Windows.Forms.Label lblCantFilas;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidBioq;
    }
}