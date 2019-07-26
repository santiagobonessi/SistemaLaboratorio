namespace LabBioquimica.Forms.ABMC
{
    partial class Localidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localidades));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblCantFilas = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.idLocalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(380, 10);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(81, 15);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(98, 13);
            this.lblBusqueda.TabIndex = 16;
            this.lblBusqueda.Text = "Búsqueda Nombre:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsulta.Location = new System.Drawing.Point(185, 12);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(189, 20);
            this.txtConsulta.TabIndex = 15;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // lblCantFilas
            // 
            this.lblCantFilas.AutoSize = true;
            this.lblCantFilas.Location = new System.Drawing.Point(627, 23);
            this.lblCantFilas.Name = "lblCantFilas";
            this.lblCantFilas.Size = new System.Drawing.Size(0, 13);
            this.lblCantFilas.TabIndex = 19;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(551, 23);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(76, 13);
            this.lblCant.TabIndex = 18;
            this.lblCant.Text = "Cantidad Filas:";
            // 
            // dgvLocalidades
            // 
            this.dgvLocalidades.AllowUserToAddRows = false;
            this.dgvLocalidades.AllowUserToDeleteRows = false;
            this.dgvLocalidades.AllowUserToResizeColumns = false;
            this.dgvLocalidades.AllowUserToResizeRows = false;
            this.dgvLocalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLocalidades,
            this.nombre,
            this.codPostal});
            this.dgvLocalidades.Location = new System.Drawing.Point(12, 39);
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.ReadOnly = true;
            this.dgvLocalidades.RowHeadersVisible = false;
            this.dgvLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalidades.Size = new System.Drawing.Size(630, 315);
            this.dgvLocalidades.TabIndex = 20;
            this.dgvLocalidades.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLocalidades_MouseClick);
            // 
            // idLocalidades
            // 
            this.idLocalidades.HeaderText = "ID";
            this.idLocalidades.Name = "idLocalidades";
            this.idLocalidades.ReadOnly = true;
            this.idLocalidades.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // codPostal
            // 
            this.codPostal.HeaderText = "Código Postal";
            this.codPostal.Name = "codPostal";
            this.codPostal.ReadOnly = true;
            // 
            // Localidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(651, 361);
            this.Controls.Add(this.dgvLocalidades);
            this.Controls.Add(this.lblCantFilas);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Localidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.Localidades_Load);
            this.Resize += new System.EventHandler(this.Localidades_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblCantFilas;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.DataGridView dgvLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostal;
    }
}