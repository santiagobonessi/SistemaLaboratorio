namespace LabBioquimica.Forms.Informes
{
    partial class FacturacionPorMutuales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionPorMutuales));
            this.lblTitulos = new System.Windows.Forms.Label();
            this.cboMutual = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvFacturacionesPorMutual = new System.Windows.Forms.DataGridView();
            this.idFacturacionMutual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacionesPorMutual)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulos
            // 
            this.lblTitulos.AutoSize = true;
            this.lblTitulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulos.Location = new System.Drawing.Point(12, 9);
            this.lblTitulos.Name = "lblTitulos";
            this.lblTitulos.Size = new System.Drawing.Size(526, 18);
            this.lblTitulos.TabIndex = 7;
            this.lblTitulos.Text = "Seleccione el nombre de la Mutual que desea ver las Facturaciones realizadas:";
            // 
            // cboMutual
            // 
            this.cboMutual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMutual.FormattingEnabled = true;
            this.cboMutual.Location = new System.Drawing.Point(163, 39);
            this.cboMutual.Name = "cboMutual";
            this.cboMutual.Size = new System.Drawing.Size(210, 21);
            this.cboMutual.TabIndex = 8;
            this.cboMutual.SelectedIndexChanged += new System.EventHandler(this.cboMutual_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 33);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvFacturacionesPorMutual
            // 
            this.dgvFacturacionesPorMutual.AllowUserToAddRows = false;
            this.dgvFacturacionesPorMutual.AllowUserToDeleteRows = false;
            this.dgvFacturacionesPorMutual.AllowUserToResizeColumns = false;
            this.dgvFacturacionesPorMutual.AllowUserToResizeRows = false;
            this.dgvFacturacionesPorMutual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturacionesPorMutual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturacionesPorMutual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFacturacionMutual,
            this.anioFacturacion,
            this.mesFacturacion,
            this.total});
            this.dgvFacturacionesPorMutual.Location = new System.Drawing.Point(15, 66);
            this.dgvFacturacionesPorMutual.Name = "dgvFacturacionesPorMutual";
            this.dgvFacturacionesPorMutual.ReadOnly = true;
            this.dgvFacturacionesPorMutual.RowHeadersVisible = false;
            this.dgvFacturacionesPorMutual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturacionesPorMutual.Size = new System.Drawing.Size(510, 280);
            this.dgvFacturacionesPorMutual.TabIndex = 9;
            this.dgvFacturacionesPorMutual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFacturacionesPorMutual_MouseClick);
            // 
            // idFacturacionMutual
            // 
            this.idFacturacionMutual.HeaderText = "ID_FACTURACION_MUTUAL";
            this.idFacturacionMutual.Name = "idFacturacionMutual";
            this.idFacturacionMutual.ReadOnly = true;
            this.idFacturacionMutual.Visible = false;
            // 
            // anioFacturacion
            // 
            this.anioFacturacion.HeaderText = "AÑO";
            this.anioFacturacion.Name = "anioFacturacion";
            this.anioFacturacion.ReadOnly = true;
            // 
            // mesFacturacion
            // 
            this.mesFacturacion.HeaderText = "MES";
            this.mesFacturacion.Name = "mesFacturacion";
            this.mesFacturacion.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL FACTURADO";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // FacturacionPorMutuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(546, 391);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvFacturacionesPorMutual);
            this.Controls.Add(this.cboMutual);
            this.Controls.Add(this.lblTitulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturacionPorMutuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda Facturacion de Mutuales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacionesPorMutual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulos;
        private System.Windows.Forms.ComboBox cboMutual;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvFacturacionesPorMutual;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacturacionMutual;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}