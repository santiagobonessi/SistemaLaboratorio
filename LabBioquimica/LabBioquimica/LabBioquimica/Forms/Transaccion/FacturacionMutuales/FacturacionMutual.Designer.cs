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
            this.idProtocoloAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProtocoloDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadBioquimica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkCargar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvProtocolosXPaciente = new System.Windows.Forms.DataGridView();
            this.idProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomapeProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPacAdheridos = new System.Windows.Forms.Label();
            this.lblProtocolosPaciente = new System.Windows.Forms.Label();
            this.lblAnalisPorProtocolo = new System.Windows.Forms.Label();
            this.gbInfoMutual = new System.Windows.Forms.GroupBox();
            this.cboMesFact = new System.Windows.Forms.ComboBox();
            this.lblMesFact = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblPrecioUnidBioq = new System.Windows.Forms.Label();
            this.txtPrecioUnidBioq = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvPacientesXAnalisisFacturados = new System.Windows.Forms.DataGridView();
            this.lblAnalisisFacturados = new System.Windows.Forms.Label();
            this.cboPacientesAdheridos = new System.Windows.Forms.ComboBox();
            this.gbPacientesAdheridos = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.chActoBioquimico = new System.Windows.Forms.CheckBox();
            this.lblTotalFacturacion = new System.Windows.Forms.Label();
            this.txtTotalFacturacion = new System.Windows.Forms.TextBox();
            this.idFacturacionOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaCodAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalUnidBioq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisisXProtocolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocolosXPaciente)).BeginInit();
            this.gbInfoMutual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesXAnalisisFacturados)).BeginInit();
            this.gbPacientesAdheridos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMutual
            // 
            this.cboMutual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMutual.FormattingEnabled = true;
            this.cboMutual.Location = new System.Drawing.Point(82, 21);
            this.cboMutual.Name = "cboMutual";
            this.cboMutual.Size = new System.Drawing.Size(240, 21);
            this.cboMutual.TabIndex = 0;
            // 
            // lblMutualBusq
            // 
            this.lblMutualBusq.AutoSize = true;
            this.lblMutualBusq.Location = new System.Drawing.Point(34, 24);
            this.lblMutualBusq.Name = "lblMutualBusq";
            this.lblMutualBusq.Size = new System.Drawing.Size(42, 13);
            this.lblMutualBusq.TabIndex = 1;
            this.lblMutualBusq.Text = "Mutual:";
            // 
            // btnAceptarMutual
            // 
            this.btnAceptarMutual.Location = new System.Drawing.Point(930, 10);
            this.btnAceptarMutual.Name = "btnAceptarMutual";
            this.btnAceptarMutual.Size = new System.Drawing.Size(64, 46);
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
            this.dgvAnalisisXProtocolo.Size = new System.Drawing.Size(982, 120);
            this.dgvAnalisisXProtocolo.TabIndex = 6;
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
            this.dgvProtocolosXPaciente.Size = new System.Drawing.Size(982, 120);
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
            this.lblPacAdheridos.Location = new System.Drawing.Point(211, 22);
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
            this.gbInfoMutual.Controls.Add(this.cboMesFact);
            this.gbInfoMutual.Controls.Add(this.lblMesFact);
            this.gbInfoMutual.Controls.Add(this.lblPesos);
            this.gbInfoMutual.Controls.Add(this.lblPrecioUnidBioq);
            this.gbInfoMutual.Controls.Add(this.txtPrecioUnidBioq);
            this.gbInfoMutual.Controls.Add(this.cboMutual);
            this.gbInfoMutual.Controls.Add(this.lblMutualBusq);
            this.gbInfoMutual.Location = new System.Drawing.Point(12, 3);
            this.gbInfoMutual.Name = "gbInfoMutual";
            this.gbInfoMutual.Size = new System.Drawing.Size(842, 55);
            this.gbInfoMutual.TabIndex = 11;
            this.gbInfoMutual.TabStop = false;
            this.gbInfoMutual.Text = "Información General";
            // 
            // cboMesFact
            // 
            this.cboMesFact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesFact.FormattingEnabled = true;
            this.cboMesFact.Location = new System.Drawing.Point(388, 20);
            this.cboMesFact.Name = "cboMesFact";
            this.cboMesFact.Size = new System.Drawing.Size(142, 21);
            this.cboMesFact.TabIndex = 10;
            // 
            // lblMesFact
            // 
            this.lblMesFact.AutoSize = true;
            this.lblMesFact.Location = new System.Drawing.Point(352, 24);
            this.lblMesFact.Name = "lblMesFact";
            this.lblMesFact.Size = new System.Drawing.Size(30, 13);
            this.lblMesFact.TabIndex = 9;
            this.lblMesFact.Text = "Mes:";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(707, 23);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(13, 13);
            this.lblPesos.TabIndex = 8;
            this.lblPesos.Text = "$";
            // 
            // lblPrecioUnidBioq
            // 
            this.lblPrecioUnidBioq.AutoSize = true;
            this.lblPrecioUnidBioq.Location = new System.Drawing.Point(570, 24);
            this.lblPrecioUnidBioq.Name = "lblPrecioUnidBioq";
            this.lblPrecioUnidBioq.Size = new System.Drawing.Size(131, 13);
            this.lblPrecioUnidBioq.TabIndex = 7;
            this.lblPrecioUnidBioq.Text = "Precio Unidad Bioquimica:";
            // 
            // txtPrecioUnidBioq
            // 
            this.txtPrecioUnidBioq.Location = new System.Drawing.Point(726, 20);
            this.txtPrecioUnidBioq.Name = "txtPrecioUnidBioq";
            this.txtPrecioUnidBioq.Size = new System.Drawing.Size(79, 20);
            this.txtPrecioUnidBioq.TabIndex = 6;
            this.txtPrecioUnidBioq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioUnidBioq_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(860, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 46);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(906, 398);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(88, 46);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar Orden";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
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
            this.idFacturacionOrden,
            this.paciente,
            this.listaCodAnalisis,
            this.subtotalUnidBioq,
            this.subtotal});
            this.dgvPacientesXAnalisisFacturados.Location = new System.Drawing.Point(13, 447);
            this.dgvPacientesXAnalisisFacturados.Name = "dgvPacientesXAnalisisFacturados";
            this.dgvPacientesXAnalisisFacturados.ReadOnly = true;
            this.dgvPacientesXAnalisisFacturados.RowHeadersVisible = false;
            this.dgvPacientesXAnalisisFacturados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientesXAnalisisFacturados.Size = new System.Drawing.Size(981, 157);
            this.dgvPacientesXAnalisisFacturados.TabIndex = 13;
            this.dgvPacientesXAnalisisFacturados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPacientesXAnalisisFacturados_MouseClick);
            // 
            // lblAnalisisFacturados
            // 
            this.lblAnalisisFacturados.AutoSize = true;
            this.lblAnalisisFacturados.Location = new System.Drawing.Point(12, 431);
            this.lblAnalisisFacturados.Name = "lblAnalisisFacturados";
            this.lblAnalisisFacturados.Size = new System.Drawing.Size(172, 13);
            this.lblAnalisisFacturados.TabIndex = 14;
            this.lblAnalisisFacturados.Text = "Pacientes con Analisis Facturados:";
            // 
            // cboPacientesAdheridos
            // 
            this.cboPacientesAdheridos.FormattingEnabled = true;
            this.cboPacientesAdheridos.Location = new System.Drawing.Point(324, 19);
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
            this.gbPacientesAdheridos.Size = new System.Drawing.Size(982, 50);
            this.gbPacientesAdheridos.TabIndex = 16;
            this.gbPacientesAdheridos.TabStop = false;
            this.gbPacientesAdheridos.Text = "Información Pacientes Adheridos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 610);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 37);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(668, 610);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(149, 37);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Exportar a Excel";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // chActoBioquimico
            // 
            this.chActoBioquimico.AutoSize = true;
            this.chActoBioquimico.Checked = true;
            this.chActoBioquimico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chActoBioquimico.Location = new System.Drawing.Point(744, 424);
            this.chActoBioquimico.Name = "chActoBioquimico";
            this.chActoBioquimico.Size = new System.Drawing.Size(156, 17);
            this.chActoBioquimico.TabIndex = 20;
            this.chActoBioquimico.Text = "Cargar ACTO BIOQUIMICO";
            this.chActoBioquimico.UseVisualStyleBackColor = true;
            // 
            // lblTotalFacturacion
            // 
            this.lblTotalFacturacion.AutoSize = true;
            this.lblTotalFacturacion.Location = new System.Drawing.Point(823, 615);
            this.lblTotalFacturacion.Name = "lblTotalFacturacion";
            this.lblTotalFacturacion.Size = new System.Drawing.Size(49, 13);
            this.lblTotalFacturacion.TabIndex = 0;
            this.lblTotalFacturacion.Text = "Total:   $";
            // 
            // txtTotalFacturacion
            // 
            this.txtTotalFacturacion.Enabled = false;
            this.txtTotalFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFacturacion.Location = new System.Drawing.Point(878, 610);
            this.txtTotalFacturacion.Name = "txtTotalFacturacion";
            this.txtTotalFacturacion.Size = new System.Drawing.Size(116, 22);
            this.txtTotalFacturacion.TabIndex = 1;
            // 
            // idFacturacionOrden
            // 
            this.idFacturacionOrden.HeaderText = "ID_FACTURACION_ORDEN";
            this.idFacturacionOrden.Name = "idFacturacionOrden";
            this.idFacturacionOrden.ReadOnly = true;
            this.idFacturacionOrden.Visible = false;
            // 
            // paciente
            // 
            this.paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.paciente.FillWeight = 19.38164F;
            this.paciente.HeaderText = "Paciente";
            this.paciente.Name = "paciente";
            this.paciente.ReadOnly = true;
            this.paciente.Width = 250;
            // 
            // listaCodAnalisis
            // 
            this.listaCodAnalisis.FillWeight = 19.38164F;
            this.listaCodAnalisis.HeaderText = "Analisis";
            this.listaCodAnalisis.Name = "listaCodAnalisis";
            this.listaCodAnalisis.ReadOnly = true;
            // 
            // subtotalUnidBioq
            // 
            this.subtotalUnidBioq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.subtotalUnidBioq.FillWeight = 259.7139F;
            this.subtotalUnidBioq.HeaderText = "Unidades Bioq";
            this.subtotalUnidBioq.Name = "subtotalUnidBioq";
            this.subtotalUnidBioq.ReadOnly = true;
            this.subtotalUnidBioq.Width = 120;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.subtotal.FillWeight = 101.5228F;
            this.subtotal.HeaderText = "Costo";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 120;
            // 
            // FacturacionMutual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.chActoBioquimico);
            this.Controls.Add(this.txtTotalFacturacion);
            this.Controls.Add(this.lblTotalFacturacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbPacientesAdheridos);
            this.Controls.Add(this.lblAnalisisFacturados);
            this.Controls.Add(this.dgvPacientesXAnalisisFacturados);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnAceptarMutual);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadBioquimica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chActoBioquimico;
        private System.Windows.Forms.Label lblTotalFacturacion;
        private System.Windows.Forms.TextBox txtTotalFacturacion;
        private System.Windows.Forms.ComboBox cboMesFact;
        private System.Windows.Forms.Label lblMesFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacturacionOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaCodAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalUnidBioq;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}