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
            this.btnAceptarMutual = new System.Windows.Forms.Button();
            this.dgvAnalisisXProtocolo = new System.Windows.Forms.DataGridView();
            this.dgvProtocolosXPaciente = new System.Windows.Forms.DataGridView();
            this.idProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomapeProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPacAdheridos = new System.Windows.Forms.Label();
            this.lblProtocolosPaciente = new System.Windows.Forms.Label();
            this.lblAnalisPorProtocolo = new System.Windows.Forms.Label();
            this.gbInfoMutual = new System.Windows.Forms.GroupBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblPrecioUnidBioq = new System.Windows.Forms.Label();
            this.txtPrecioUnidBioq = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvPacientesXAnalisisFacturados = new System.Windows.Forms.DataGridView();
            this.ID_PACIENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaCodAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAnalisisFacturados = new System.Windows.Forms.Label();
            this.cboPacientesAdheridos = new System.Windows.Forms.ComboBox();
            this.gbPacientesAdheridos = new System.Windows.Forms.GroupBox();
            this.idProtocoloAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProtocoloDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadBioquimica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCargar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisisXProtocolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocolosXPaciente)).BeginInit();
            this.gbInfoMutual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesXAnalisisFacturados)).BeginInit();
            this.gbPacientesAdheridos.SuspendLayout();
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
            // btnAceptarMutual
            // 
            this.btnAceptarMutual.Location = new System.Drawing.Point(733, 17);
            this.btnAceptarMutual.Name = "btnAceptarMutual";
            this.btnAceptarMutual.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMutual.TabIndex = 5;
            this.btnAceptarMutual.Text = "Aceptar";
            this.btnAceptarMutual.UseVisualStyleBackColor = true;
            this.btnAceptarMutual.Click += new System.EventHandler(this.btnAceptarMutual_Click);
            // 
            // dgvAnalisisXProtocolo
            // 
            this.dgvAnalisisXProtocolo.AllowUserToAddRows = false;
            this.dgvAnalisisXProtocolo.AllowUserToDeleteRows = false;
            this.dgvAnalisisXProtocolo.AllowUserToResizeColumns = false;
            this.dgvAnalisisXProtocolo.AllowUserToResizeRows = false;
            this.dgvAnalisisXProtocolo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalisisXProtocolo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisisXProtocolo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProtocoloAnalisis,
            this.idProtocoloDetalle,
            this.idAnalisis,
            this.nombreAnalisis,
            this.metodoAnalisis,
            this.codigoAnalisis,
            this.unidadBioquimica,
            this.checkCargar});
            this.dgvAnalisisXProtocolo.Location = new System.Drawing.Point(12, 273);
            this.dgvAnalisisXProtocolo.Name = "dgvAnalisisXProtocolo";
            this.dgvAnalisisXProtocolo.RowHeadersVisible = false;
            this.dgvAnalisisXProtocolo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalisisXProtocolo.Size = new System.Drawing.Size(814, 125);
            this.dgvAnalisisXProtocolo.TabIndex = 6;
            this.dgvAnalisisXProtocolo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAnalisisXProtocolo_MouseClick);
            // 
            // dgvProtocolosXPaciente
            // 
            this.dgvProtocolosXPaciente.AllowUserToAddRows = false;
            this.dgvProtocolosXPaciente.AllowUserToDeleteRows = false;
            this.dgvProtocolosXPaciente.AllowUserToResizeColumns = false;
            this.dgvProtocolosXPaciente.AllowUserToResizeRows = false;
            this.dgvProtocolosXPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProtocolosXPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocolosXPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProtocolo,
            this.nroProtocolo,
            this.fechaProtocolo,
            this.nomapeProfesional});
            this.dgvProtocolosXPaciente.Location = new System.Drawing.Point(12, 133);
            this.dgvProtocolosXPaciente.Name = "dgvProtocolosXPaciente";
            this.dgvProtocolosXPaciente.ReadOnly = true;
            this.dgvProtocolosXPaciente.RowHeadersVisible = false;
            this.dgvProtocolosXPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProtocolosXPaciente.Size = new System.Drawing.Size(814, 118);
            this.dgvProtocolosXPaciente.TabIndex = 7;
            this.dgvProtocolosXPaciente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProtocolosXPaciente_MouseClick);
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
            this.lblPacAdheridos.Location = new System.Drawing.Point(84, 22);
            this.lblPacAdheridos.Name = "lblPacAdheridos";
            this.lblPacAdheridos.Size = new System.Drawing.Size(107, 13);
            this.lblPacAdheridos.TabIndex = 8;
            this.lblPacAdheridos.Text = "Pacientes Adheridos:";
            // 
            // lblProtocolosPaciente
            // 
            this.lblProtocolosPaciente.AutoSize = true;
            this.lblProtocolosPaciente.Location = new System.Drawing.Point(9, 117);
            this.lblProtocolosPaciente.Name = "lblProtocolosPaciente";
            this.lblProtocolosPaciente.Size = new System.Drawing.Size(122, 13);
            this.lblProtocolosPaciente.TabIndex = 9;
            this.lblProtocolosPaciente.Text = "Protocolos del Paciente:";
            // 
            // lblAnalisPorProtocolo
            // 
            this.lblAnalisPorProtocolo.AutoSize = true;
            this.lblAnalisPorProtocolo.Location = new System.Drawing.Point(12, 257);
            this.lblAnalisPorProtocolo.Name = "lblAnalisPorProtocolo";
            this.lblAnalisPorProtocolo.Size = new System.Drawing.Size(110, 13);
            this.lblAnalisPorProtocolo.TabIndex = 10;
            this.lblAnalisPorProtocolo.Text = "Analisis del Protocolo:";
            // 
            // gbInfoMutual
            // 
            this.gbInfoMutual.Controls.Add(this.lblPesos);
            this.gbInfoMutual.Controls.Add(this.lblPrecioUnidBioq);
            this.gbInfoMutual.Controls.Add(this.txtPrecioUnidBioq);
            this.gbInfoMutual.Controls.Add(this.cboMutual);
            this.gbInfoMutual.Controls.Add(this.lblMutualBusq);
            this.gbInfoMutual.Controls.Add(this.btnAceptarMutual);
            this.gbInfoMutual.Location = new System.Drawing.Point(12, 10);
            this.gbInfoMutual.Name = "gbInfoMutual";
            this.gbInfoMutual.Size = new System.Drawing.Size(814, 48);
            this.gbInfoMutual.TabIndex = 11;
            this.gbInfoMutual.TabStop = false;
            this.gbInfoMutual.Text = "Información Mutual";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(596, 22);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(13, 13);
            this.lblPesos.TabIndex = 8;
            this.lblPesos.Text = "$";
            // 
            // lblPrecioUnidBioq
            // 
            this.lblPrecioUnidBioq.AutoSize = true;
            this.lblPrecioUnidBioq.Location = new System.Drawing.Point(453, 22);
            this.lblPrecioUnidBioq.Name = "lblPrecioUnidBioq";
            this.lblPrecioUnidBioq.Size = new System.Drawing.Size(131, 13);
            this.lblPrecioUnidBioq.TabIndex = 7;
            this.lblPrecioUnidBioq.Text = "Precio Unidad Bioquimica:";
            // 
            // txtPrecioUnidBioq
            // 
            this.txtPrecioUnidBioq.Location = new System.Drawing.Point(615, 19);
            this.txtPrecioUnidBioq.Name = "txtPrecioUnidBioq";
            this.txtPrecioUnidBioq.Size = new System.Drawing.Size(79, 20);
            this.txtPrecioUnidBioq.TabIndex = 6;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(751, 404);
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
            this.dgvPacientesXAnalisisFacturados.Location = new System.Drawing.Point(12, 445);
            this.dgvPacientesXAnalisisFacturados.Name = "dgvPacientesXAnalisisFacturados";
            this.dgvPacientesXAnalisisFacturados.ReadOnly = true;
            this.dgvPacientesXAnalisisFacturados.RowHeadersVisible = false;
            this.dgvPacientesXAnalisisFacturados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientesXAnalisisFacturados.Size = new System.Drawing.Size(813, 120);
            this.dgvPacientesXAnalisisFacturados.TabIndex = 13;
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
            // lblAnalisisFacturados
            // 
            this.lblAnalisisFacturados.AutoSize = true;
            this.lblAnalisisFacturados.Location = new System.Drawing.Point(11, 429);
            this.lblAnalisisFacturados.Name = "lblAnalisisFacturados";
            this.lblAnalisisFacturados.Size = new System.Drawing.Size(172, 13);
            this.lblAnalisisFacturados.TabIndex = 14;
            this.lblAnalisisFacturados.Text = "Pacientes con Analisis Facturados:";
            // 
            // cboPacientesAdheridos
            // 
            this.cboPacientesAdheridos.FormattingEnabled = true;
            this.cboPacientesAdheridos.Location = new System.Drawing.Point(197, 19);
            this.cboPacientesAdheridos.Name = "cboPacientesAdheridos";
            this.cboPacientesAdheridos.Size = new System.Drawing.Size(387, 21);
            this.cboPacientesAdheridos.TabIndex = 15;
            this.cboPacientesAdheridos.SelectedIndexChanged += new System.EventHandler(this.cboPacientesAdheridos_SelectedIndexChanged);
            // 
            // gbPacientesAdheridos
            // 
            this.gbPacientesAdheridos.Controls.Add(this.cboPacientesAdheridos);
            this.gbPacientesAdheridos.Controls.Add(this.lblPacAdheridos);
            this.gbPacientesAdheridos.Enabled = false;
            this.gbPacientesAdheridos.Location = new System.Drawing.Point(12, 64);
            this.gbPacientesAdheridos.Name = "gbPacientesAdheridos";
            this.gbPacientesAdheridos.Size = new System.Drawing.Size(814, 48);
            this.gbPacientesAdheridos.TabIndex = 16;
            this.gbPacientesAdheridos.TabStop = false;
            this.gbPacientesAdheridos.Text = "Información Pacientes Adheridos";
            // 
            // idProtocoloAnalisis
            // 
            this.idProtocoloAnalisis.HeaderText = "ID PROTOCOLO";
            this.idProtocoloAnalisis.Name = "idProtocoloAnalisis";
            this.idProtocoloAnalisis.Visible = false;
            // 
            // idProtocoloDetalle
            // 
            this.idProtocoloDetalle.HeaderText = "ID PROCOLO DET";
            this.idProtocoloDetalle.Name = "idProtocoloDetalle";
            this.idProtocoloDetalle.Visible = false;
            // 
            // idAnalisis
            // 
            this.idAnalisis.HeaderText = "ID ANALISIS";
            this.idAnalisis.Name = "idAnalisis";
            this.idAnalisis.Visible = false;
            // 
            // nombreAnalisis
            // 
            this.nombreAnalisis.FillWeight = 119.5432F;
            this.nombreAnalisis.HeaderText = "Análisis";
            this.nombreAnalisis.Name = "nombreAnalisis";
            this.nombreAnalisis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // metodoAnalisis
            // 
            this.metodoAnalisis.FillWeight = 119.5432F;
            this.metodoAnalisis.HeaderText = "Método";
            this.metodoAnalisis.Name = "metodoAnalisis";
            this.metodoAnalisis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // codigoAnalisis
            // 
            this.codigoAnalisis.FillWeight = 60.9137F;
            this.codigoAnalisis.HeaderText = "Código";
            this.codigoAnalisis.Name = "codigoAnalisis";
            this.codigoAnalisis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // unidadBioquimica
            // 
            this.unidadBioquimica.HeaderText = "Unid. Bioquimica";
            this.unidadBioquimica.Name = "unidadBioquimica";
            // 
            // checkCargar
            // 
            this.checkCargar.HeaderText = "Facturar";
            this.checkCargar.Name = "checkCargar";
            this.checkCargar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkCargar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FacturacionMutual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(835, 575);
            this.Controls.Add(this.gbPacientesAdheridos);
            this.Controls.Add(this.lblAnalisisFacturados);
            this.Controls.Add(this.dgvPacientesXAnalisisFacturados);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.gbInfoMutual);
            this.Controls.Add(this.lblAnalisPorProtocolo);
            this.Controls.Add(this.lblProtocolosPaciente);
            this.Controls.Add(this.dgvProtocolosXPaciente);
            this.Controls.Add(this.dgvAnalisisXProtocolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturacionMutual";
            this.Text = "Facturacion Mutual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisisXProtocolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocolosXPaciente)).EndInit();
            this.gbInfoMutual.ResumeLayout(false);
            this.gbInfoMutual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesXAnalisisFacturados)).EndInit();
            this.gbPacientesAdheridos.ResumeLayout(false);
            this.gbPacientesAdheridos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMutual;
        private System.Windows.Forms.Label lblMutualBusq;
        private System.Windows.Forms.Button btnAceptarMutual;
        private System.Windows.Forms.DataGridView dgvAnalisisXProtocolo;
        private System.Windows.Forms.DataGridView dgvProtocolosXPaciente;
        private System.Windows.Forms.Label lblPacAdheridos;
        private System.Windows.Forms.Label lblProtocolosPaciente;
        private System.Windows.Forms.Label lblAnalisPorProtocolo;
        private System.Windows.Forms.GroupBox gbInfoMutual;
        private System.Windows.Forms.Label lblPrecioUnidBioq;
        private System.Windows.Forms.TextBox txtPrecioUnidBioq;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvPacientesXAnalisisFacturados;
        private System.Windows.Forms.Label lblAnalisisFacturados;
        private System.Windows.Forms.ComboBox cboPacientesAdheridos;
        private System.Windows.Forms.GroupBox gbPacientesAdheridos;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomapeProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PACIENTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn apePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaCodAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadBioquimica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCargar;
    }
}