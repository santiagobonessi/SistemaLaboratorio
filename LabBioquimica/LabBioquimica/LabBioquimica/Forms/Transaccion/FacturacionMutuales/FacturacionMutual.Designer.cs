namespace LabBioquimica.Forms.Transaccion.FacturacionMutuales
{
    partial class FacturacionMutual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionMutual));
            this.cboMutual = new System.Windows.Forms.ComboBox();
            this.lblMutualBusq = new System.Windows.Forms.Label();
            this.dgvProtocoloDetalle = new System.Windows.Forms.DataGridView();
            this.idProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProtocoloDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocoloDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMutual
            // 
            this.cboMutual.FormattingEnabled = true;
            this.cboMutual.Location = new System.Drawing.Point(286, 12);
            this.cboMutual.Name = "cboMutual";
            this.cboMutual.Size = new System.Drawing.Size(241, 21);
            this.cboMutual.TabIndex = 0;
            // 
            // lblMutualBusq
            // 
            this.lblMutualBusq.AutoSize = true;
            this.lblMutualBusq.Location = new System.Drawing.Point(238, 15);
            this.lblMutualBusq.Name = "lblMutualBusq";
            this.lblMutualBusq.Size = new System.Drawing.Size(42, 13);
            this.lblMutualBusq.TabIndex = 1;
            this.lblMutualBusq.Text = "Mutual:";
            // 
            // dgvProtocoloDetalle
            // 
            this.dgvProtocoloDetalle.AllowUserToAddRows = false;
            this.dgvProtocoloDetalle.AllowUserToDeleteRows = false;
            this.dgvProtocoloDetalle.AllowUserToResizeColumns = false;
            this.dgvProtocoloDetalle.AllowUserToResizeRows = false;
            this.dgvProtocoloDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProtocoloDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocoloDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProtocolo,
            this.idProtocoloDetalle,
            this.idAnalisis,
            this.nombreAnalisis,
            this.metodoAnalisis,
            this.codigoAnalisis});
            this.dgvProtocoloDetalle.Enabled = false;
            this.dgvProtocoloDetalle.Location = new System.Drawing.Point(12, 64);
            this.dgvProtocoloDetalle.Name = "dgvProtocoloDetalle";
            this.dgvProtocoloDetalle.ReadOnly = true;
            this.dgvProtocoloDetalle.RowHeadersVisible = false;
            this.dgvProtocoloDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProtocoloDetalle.Size = new System.Drawing.Size(943, 214);
            this.dgvProtocoloDetalle.TabIndex = 4;
            // 
            // idProtocolo
            // 
            this.idProtocolo.HeaderText = "ID PROTOCOLO";
            this.idProtocolo.Name = "idProtocolo";
            this.idProtocolo.ReadOnly = true;
            this.idProtocolo.Visible = false;
            // 
            // idProtocoloDetalle
            // 
            this.idProtocoloDetalle.HeaderText = "ID PROCOLO DET";
            this.idProtocoloDetalle.Name = "idProtocoloDetalle";
            this.idProtocoloDetalle.ReadOnly = true;
            this.idProtocoloDetalle.Visible = false;
            // 
            // idAnalisis
            // 
            this.idAnalisis.HeaderText = "ID ANALISIS";
            this.idAnalisis.Name = "idAnalisis";
            this.idAnalisis.ReadOnly = true;
            this.idAnalisis.Visible = false;
            // 
            // nombreAnalisis
            // 
            this.nombreAnalisis.FillWeight = 119.5432F;
            this.nombreAnalisis.HeaderText = "Análisis";
            this.nombreAnalisis.Name = "nombreAnalisis";
            this.nombreAnalisis.ReadOnly = true;
            this.nombreAnalisis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // metodoAnalisis
            // 
            this.metodoAnalisis.FillWeight = 119.5432F;
            this.metodoAnalisis.HeaderText = "Método";
            this.metodoAnalisis.Name = "metodoAnalisis";
            this.metodoAnalisis.ReadOnly = true;
            this.metodoAnalisis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // codigoAnalisis
            // 
            this.codigoAnalisis.FillWeight = 60.9137F;
            this.codigoAnalisis.HeaderText = "Código";
            this.codigoAnalisis.Name = "codigoAnalisis";
            this.codigoAnalisis.ReadOnly = true;
            this.codigoAnalisis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FacturacionMutual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(968, 627);
            this.Controls.Add(this.dgvProtocoloDetalle);
            this.Controls.Add(this.lblMutualBusq);
            this.Controls.Add(this.cboMutual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturacionMutual";
            this.Text = "Facturacion Mutual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocoloDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMutual;
        private System.Windows.Forms.Label lblMutualBusq;
        private System.Windows.Forms.DataGridView dgvProtocoloDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAnalisis;
    }
}