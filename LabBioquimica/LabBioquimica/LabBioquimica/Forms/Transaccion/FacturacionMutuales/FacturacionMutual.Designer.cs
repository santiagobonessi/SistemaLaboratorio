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
            this.dgvPacientesAdheridos = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarMutual = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProtocoloAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProtocoloDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadBioquimica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCargar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomapeProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPacAdheridos = new System.Windows.Forms.Label();
            this.lblProtocolosPaciente = new System.Windows.Forms.Label();
            this.lblAnalisPorProtocolo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrecioUnidBioq = new System.Windows.Forms.Label();
            this.txtPrecioUnidBioq = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvPacientesXAnalisisFacturados = new System.Windows.Forms.DataGridView();
            this.lblAnalisisFacturados = new System.Windows.Forms.Label();
            this.ID_PACIENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaCodAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesAdheridos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesXAnalisisFacturados)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMutual
            // 
            this.cboMutual.FormattingEnabled = true;
            this.cboMutual.Location = new System.Drawing.Point(77, 19);
            this.cboMutual.Name = "cboMutual";
            this.cboMutual.Size = new System.Drawing.Size(302, 21);
            this.cboMutual.TabIndex = 0;
            // 
            // lblMutualBusq
            // 
            this.lblMutualBusq.AutoSize = true;
            this.lblMutualBusq.Location = new System.Drawing.Point(29, 22);
            this.lblMutualBusq.Name = "lblMutualBusq";
            this.lblMutualBusq.Size = new System.Drawing.Size(42, 13);
            this.lblMutualBusq.TabIndex = 1;
            this.lblMutualBusq.Text = "Mutual:";
            // 
            // dgvPacientesAdheridos
            // 
            this.dgvPacientesAdheridos.AllowUserToAddRows = false;
            this.dgvPacientesAdheridos.AllowUserToDeleteRows = false;
            this.dgvPacientesAdheridos.AllowUserToResizeColumns = false;
            this.dgvPacientesAdheridos.AllowUserToResizeRows = false;
            this.dgvPacientesAdheridos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientesAdheridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesAdheridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.apellidoPaciente,
            this.nombrePaciente,
            this.telefonoPaciente,
            this.direccionPaciente});
            this.dgvPacientesAdheridos.Enabled = false;
            this.dgvPacientesAdheridos.Location = new System.Drawing.Point(12, 77);
            this.dgvPacientesAdheridos.Name = "dgvPacientesAdheridos";
            this.dgvPacientesAdheridos.ReadOnly = true;
            this.dgvPacientesAdheridos.RowHeadersVisible = false;
            this.dgvPacientesAdheridos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientesAdheridos.Size = new System.Drawing.Size(943, 97);
            this.dgvPacientesAdheridos.TabIndex = 4;
            // 
            // idPaciente
            // 
            this.idPaciente.HeaderText = "ID PACIENTE";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            this.idPaciente.Visible = false;
            // 
            // apellidoPaciente
            // 
            this.apellidoPaciente.FillWeight = 119.5432F;
            this.apellidoPaciente.HeaderText = "Apellido";
            this.apellidoPaciente.Name = "apellidoPaciente";
            this.apellidoPaciente.ReadOnly = true;
            this.apellidoPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombrePaciente
            // 
            this.nombrePaciente.FillWeight = 119.5432F;
            this.nombrePaciente.HeaderText = "Nombre";
            this.nombrePaciente.Name = "nombrePaciente";
            this.nombrePaciente.ReadOnly = true;
            this.nombrePaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // telefonoPaciente
            // 
            this.telefonoPaciente.FillWeight = 60.9137F;
            this.telefonoPaciente.HeaderText = "Telefono";
            this.telefonoPaciente.Name = "telefonoPaciente";
            this.telefonoPaciente.ReadOnly = true;
            this.telefonoPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // direccionPaciente
            // 
            this.direccionPaciente.HeaderText = "Dirección";
            this.direccionPaciente.Name = "direccionPaciente";
            this.direccionPaciente.ReadOnly = true;
            // 
            // btnAceptarMutual
            // 
            this.btnAceptarMutual.Location = new System.Drawing.Point(716, 16);
            this.btnAceptarMutual.Name = "btnAceptarMutual";
            this.btnAceptarMutual.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMutual.TabIndex = 5;
            this.btnAceptarMutual.Text = "Aceptar";
            this.btnAceptarMutual.UseVisualStyleBackColor = true;
            this.btnAceptarMutual.Click += new System.EventHandler(this.btnAceptarMutual_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProtocoloAnalisis,
            this.idProtocoloDetalle,
            this.idAnalisis,
            this.nombreAnalisis,
            this.metodoAnalisis,
            this.codigoAnalisis,
            this.unidadBioquimica,
            this.checkCargar});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 125);
            this.dataGridView1.TabIndex = 6;
            // 
            // idProtocoloAnalisis
            // 
            this.idProtocoloAnalisis.HeaderText = "ID PROTOCOLO";
            this.idProtocoloAnalisis.Name = "idProtocoloAnalisis";
            this.idProtocoloAnalisis.ReadOnly = true;
            this.idProtocoloAnalisis.Visible = false;
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
            // unidadBioquimica
            // 
            this.unidadBioquimica.HeaderText = "Unid. Bioquimica";
            this.unidadBioquimica.Name = "unidadBioquimica";
            this.unidadBioquimica.ReadOnly = true;
            // 
            // checkCargar
            // 
            this.checkCargar.HeaderText = "Facturar";
            this.checkCargar.Name = "checkCargar";
            this.checkCargar.ReadOnly = true;
            this.checkCargar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkCargar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProtocolo,
            this.nroProtocolo,
            this.fechaProtocolo,
            this.nomapeProfesional});
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(943, 118);
            this.dataGridView2.TabIndex = 7;
            // 
            // idProtocolo
            // 
            this.idProtocolo.HeaderText = "ID PROTOCOLO";
            this.idProtocolo.Name = "idProtocolo";
            this.idProtocolo.ReadOnly = true;
            this.idProtocolo.Visible = false;
            // 
            // nroProtocolo
            // 
            this.nroProtocolo.FillWeight = 119.5432F;
            this.nroProtocolo.HeaderText = "Nro Protocolo";
            this.nroProtocolo.Name = "nroProtocolo";
            this.nroProtocolo.ReadOnly = true;
            this.nroProtocolo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaProtocolo
            // 
            this.fechaProtocolo.FillWeight = 119.5432F;
            this.fechaProtocolo.HeaderText = "Fecha";
            this.fechaProtocolo.Name = "fechaProtocolo";
            this.fechaProtocolo.ReadOnly = true;
            this.fechaProtocolo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nomapeProfesional
            // 
            this.nomapeProfesional.FillWeight = 60.9137F;
            this.nomapeProfesional.HeaderText = "Dr/a Solicitante";
            this.nomapeProfesional.Name = "nomapeProfesional";
            this.nomapeProfesional.ReadOnly = true;
            this.nomapeProfesional.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblPacAdheridos
            // 
            this.lblPacAdheridos.AutoSize = true;
            this.lblPacAdheridos.Location = new System.Drawing.Point(12, 61);
            this.lblPacAdheridos.Name = "lblPacAdheridos";
            this.lblPacAdheridos.Size = new System.Drawing.Size(107, 13);
            this.lblPacAdheridos.TabIndex = 8;
            this.lblPacAdheridos.Text = "Pacientes Adheridos:";
            // 
            // lblProtocolosPaciente
            // 
            this.lblProtocolosPaciente.AutoSize = true;
            this.lblProtocolosPaciente.Location = new System.Drawing.Point(9, 177);
            this.lblProtocolosPaciente.Name = "lblProtocolosPaciente";
            this.lblProtocolosPaciente.Size = new System.Drawing.Size(105, 13);
            this.lblProtocolosPaciente.TabIndex = 9;
            this.lblProtocolosPaciente.Text = "Protocolos Paciente:";
            // 
            // lblAnalisPorProtocolo
            // 
            this.lblAnalisPorProtocolo.AutoSize = true;
            this.lblAnalisPorProtocolo.Location = new System.Drawing.Point(12, 314);
            this.lblAnalisPorProtocolo.Name = "lblAnalisPorProtocolo";
            this.lblAnalisPorProtocolo.Size = new System.Drawing.Size(93, 13);
            this.lblAnalisPorProtocolo.TabIndex = 10;
            this.lblAnalisPorProtocolo.Text = "Analisis Protocolo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrecioUnidBioq);
            this.groupBox1.Controls.Add(this.txtPrecioUnidBioq);
            this.groupBox1.Controls.Add(this.cboMutual);
            this.groupBox1.Controls.Add(this.lblMutualBusq);
            this.groupBox1.Controls.Add(this.btnAceptarMutual);
            this.groupBox1.Location = new System.Drawing.Point(63, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Mutual";
            // 
            // lblPrecioUnidBioq
            // 
            this.lblPrecioUnidBioq.AutoSize = true;
            this.lblPrecioUnidBioq.Location = new System.Drawing.Point(411, 22);
            this.lblPrecioUnidBioq.Name = "lblPrecioUnidBioq";
            this.lblPrecioUnidBioq.Size = new System.Drawing.Size(131, 13);
            this.lblPrecioUnidBioq.TabIndex = 7;
            this.lblPrecioUnidBioq.Text = "Precio Unidad Bioquimica:";
            // 
            // txtPrecioUnidBioq
            // 
            this.txtPrecioUnidBioq.Location = new System.Drawing.Point(548, 19);
            this.txtPrecioUnidBioq.Name = "txtPrecioUnidBioq";
            this.txtPrecioUnidBioq.Size = new System.Drawing.Size(126, 20);
            this.txtPrecioUnidBioq.TabIndex = 6;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(881, 461);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 35);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // dgvPacientesXAnalisisFacturados
            // 
            this.dgvPacientesXAnalisisFacturados.AllowUserToAddRows = false;
            this.dgvPacientesXAnalisisFacturados.AllowUserToDeleteRows = false;
            this.dgvPacientesXAnalisisFacturados.AllowUserToResizeColumns = false;
            this.dgvPacientesXAnalisisFacturados.AllowUserToResizeRows = false;
            this.dgvPacientesXAnalisisFacturados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientesXAnalisisFacturados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesXAnalisisFacturados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PACIENTES,
            this.apePaciente,
            this.nomPaciente,
            this.listaCodAnalisis});
            this.dgvPacientesXAnalisisFacturados.Enabled = false;
            this.dgvPacientesXAnalisisFacturados.Location = new System.Drawing.Point(13, 502);
            this.dgvPacientesXAnalisisFacturados.Name = "dgvPacientesXAnalisisFacturados";
            this.dgvPacientesXAnalisisFacturados.ReadOnly = true;
            this.dgvPacientesXAnalisisFacturados.RowHeadersVisible = false;
            this.dgvPacientesXAnalisisFacturados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientesXAnalisisFacturados.Size = new System.Drawing.Size(943, 120);
            this.dgvPacientesXAnalisisFacturados.TabIndex = 13;
            // 
            // lblAnalisisFacturados
            // 
            this.lblAnalisisFacturados.AutoSize = true;
            this.lblAnalisisFacturados.Location = new System.Drawing.Point(12, 486);
            this.lblAnalisisFacturados.Name = "lblAnalisisFacturados";
            this.lblAnalisisFacturados.Size = new System.Drawing.Size(172, 13);
            this.lblAnalisisFacturados.TabIndex = 14;
            this.lblAnalisisFacturados.Text = "Pacientes con Analisis Facturados:";
            // 
            // ID_PACIENTES
            // 
            this.ID_PACIENTES.HeaderText = "ID PACIENTES";
            this.ID_PACIENTES.Name = "ID_PACIENTES";
            this.ID_PACIENTES.ReadOnly = true;
            this.ID_PACIENTES.Visible = false;
            // 
            // apePaciente
            // 
            this.apePaciente.HeaderText = "Apellido";
            this.apePaciente.Name = "apePaciente";
            this.apePaciente.ReadOnly = true;
            // 
            // nomPaciente
            // 
            this.nomPaciente.HeaderText = "Nombre";
            this.nomPaciente.Name = "nomPaciente";
            this.nomPaciente.ReadOnly = true;
            // 
            // listaCodAnalisis
            // 
            this.listaCodAnalisis.HeaderText = "Códigos Analisis";
            this.listaCodAnalisis.Name = "listaCodAnalisis";
            this.listaCodAnalisis.ReadOnly = true;
            // 
            // FacturacionMutual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(968, 634);
            this.Controls.Add(this.lblAnalisisFacturados);
            this.Controls.Add(this.dgvPacientesXAnalisisFacturados);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAnalisPorProtocolo);
            this.Controls.Add(this.lblProtocolosPaciente);
            this.Controls.Add(this.lblPacAdheridos);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvPacientesAdheridos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturacionMutual";
            this.Text = "Facturacion Mutual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesAdheridos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesXAnalisisFacturados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMutual;
        private System.Windows.Forms.Label lblMutualBusq;
        private System.Windows.Forms.DataGridView dgvPacientesAdheridos;
        private System.Windows.Forms.Button btnAceptarMutual;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomapeProfesional;
        private System.Windows.Forms.Label lblPacAdheridos;
        private System.Windows.Forms.Label lblProtocolosPaciente;
        private System.Windows.Forms.Label lblAnalisPorProtocolo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrecioUnidBioq;
        private System.Windows.Forms.TextBox txtPrecioUnidBioq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadBioquimica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCargar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvPacientesXAnalisisFacturados;
        private System.Windows.Forms.Label lblAnalisisFacturados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PACIENTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn apePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaCodAnalisis;
    }
}