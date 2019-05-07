namespace LabBioquimica.Forms.Transaccion
{
    partial class NuevoProtocolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProtocolo));
            this.lblProtocolo = new System.Windows.Forms.Label();
            this.txtNroProtocolo = new System.Windows.Forms.TextBox();
            this.gbNuevoProtocolo = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnProfesional = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.cboProfesional = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvProtocoloDetalle = new System.Windows.Forms.DataGridView();
            this.idProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProtocoloDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPracticas = new System.Windows.Forms.DataGridView();
            this.idProtocoloDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPractica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoPractica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnConsultaProtocolo = new System.Windows.Forms.Button();
            this.txtConsultaProtocolo = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbNuevoProtocolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocoloDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticas)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProtocolo
            // 
            this.lblProtocolo.AutoSize = true;
            this.lblProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtocolo.Location = new System.Drawing.Point(58, 25);
            this.lblProtocolo.Name = "lblProtocolo";
            this.lblProtocolo.Size = new System.Drawing.Size(70, 13);
            this.lblProtocolo.TabIndex = 0;
            this.lblProtocolo.Text = "Protocolo Nº:";
            // 
            // txtNroProtocolo
            // 
            this.txtNroProtocolo.Location = new System.Drawing.Point(134, 20);
            this.txtNroProtocolo.Name = "txtNroProtocolo";
            this.txtNroProtocolo.Size = new System.Drawing.Size(200, 21);
            this.txtNroProtocolo.TabIndex = 1;
            this.txtNroProtocolo.TextChanged += new System.EventHandler(this.txtProtocolo_TextChanged);
            this.txtNroProtocolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProtocolo_KeyPress);
            // 
            // gbNuevoProtocolo
            // 
            this.gbNuevoProtocolo.BackColor = System.Drawing.Color.Transparent;
            this.gbNuevoProtocolo.Controls.Add(this.lblMensaje);
            this.gbNuevoProtocolo.Controls.Add(this.btnProfesional);
            this.gbNuevoProtocolo.Controls.Add(this.btnPaciente);
            this.gbNuevoProtocolo.Controls.Add(this.cboProfesional);
            this.gbNuevoProtocolo.Controls.Add(this.label1);
            this.gbNuevoProtocolo.Controls.Add(this.cboPaciente);
            this.gbNuevoProtocolo.Controls.Add(this.label3);
            this.gbNuevoProtocolo.Controls.Add(this.dtpFecha);
            this.gbNuevoProtocolo.Controls.Add(this.lblFecha);
            this.gbNuevoProtocolo.Controls.Add(this.txtNroProtocolo);
            this.gbNuevoProtocolo.Controls.Add(this.lblProtocolo);
            this.gbNuevoProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevoProtocolo.Location = new System.Drawing.Point(57, 2);
            this.gbNuevoProtocolo.Name = "gbNuevoProtocolo";
            this.gbNuevoProtocolo.Size = new System.Drawing.Size(717, 132);
            this.gbNuevoProtocolo.TabIndex = 0;
            this.gbNuevoProtocolo.TabStop = false;
            this.gbNuevoProtocolo.Text = "Nuevo Protocolo";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(338, 23);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(180, 15);
            this.lblMensaje.TabIndex = 12;
            this.lblMensaje.Text = "El protocolo ingresado ya existe";
            // 
            // btnProfesional
            // 
            this.btnProfesional.Location = new System.Drawing.Point(582, 101);
            this.btnProfesional.Name = "btnProfesional";
            this.btnProfesional.Size = new System.Drawing.Size(66, 23);
            this.btnProfesional.TabIndex = 6;
            this.btnProfesional.Text = "...";
            this.btnProfesional.UseVisualStyleBackColor = true;
            this.btnProfesional.Click += new System.EventHandler(this.btnProfesional_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(582, 72);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(66, 23);
            this.btnPaciente.TabIndex = 4;
            this.btnPaciente.Text = "...";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // cboProfesional
            // 
            this.cboProfesional.FormattingEnabled = true;
            this.cboProfesional.Location = new System.Drawing.Point(134, 102);
            this.cboProfesional.Name = "cboProfesional";
            this.cboProfesional.Size = new System.Drawing.Size(442, 23);
            this.cboProfesional.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profesional:";
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(134, 73);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(442, 23);
            this.cboPaciente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paciente:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(134, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(267, 21);
            this.dtpFecha.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(88, 52);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(778, 94);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(870, 94);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 40);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.dgvProtocoloDetalle.Location = new System.Drawing.Point(13, 140);
            this.dgvProtocoloDetalle.Name = "dgvProtocoloDetalle";
            this.dgvProtocoloDetalle.ReadOnly = true;
            this.dgvProtocoloDetalle.RowHeadersVisible = false;
            this.dgvProtocoloDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProtocoloDetalle.Size = new System.Drawing.Size(943, 214);
            this.dgvProtocoloDetalle.TabIndex = 3;
            this.dgvProtocoloDetalle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProtocoloDetalle_KeyUp);
            this.dgvProtocoloDetalle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProtocoloDetalle_MouseClick);
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
            // dgvPracticas
            // 
            this.dgvPracticas.AllowUserToAddRows = false;
            this.dgvPracticas.AllowUserToDeleteRows = false;
            this.dgvPracticas.AllowUserToResizeColumns = false;
            this.dgvPracticas.AllowUserToResizeRows = false;
            this.dgvPracticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProtocoloDet,
            this.idPractica,
            this.idItem,
            this.conceptoItem,
            this.resultadoPractica,
            this.valorRef,
            this.conceptoUnidad});
            this.dgvPracticas.Enabled = false;
            this.dgvPracticas.Location = new System.Drawing.Point(11, 360);
            this.dgvPracticas.Name = "dgvPracticas";
            this.dgvPracticas.RowHeadersVisible = false;
            this.dgvPracticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPracticas.Size = new System.Drawing.Size(945, 197);
            this.dgvPracticas.TabIndex = 4;
            this.dgvPracticas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPracticas_CellValueChanged);
            this.dgvPracticas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPracticas_MouseClick);
            // 
            // idProtocoloDet
            // 
            this.idProtocoloDet.HeaderText = "ID PROTOCOLO DETALLE";
            this.idProtocoloDet.Name = "idProtocoloDet";
            this.idProtocoloDet.Visible = false;
            // 
            // idPractica
            // 
            this.idPractica.HeaderText = "ID PRACTICA";
            this.idPractica.Name = "idPractica";
            this.idPractica.Visible = false;
            // 
            // idItem
            // 
            this.idItem.HeaderText = "IDITEM";
            this.idItem.Name = "idItem";
            this.idItem.Visible = false;
            // 
            // conceptoItem
            // 
            this.conceptoItem.FillWeight = 131.9797F;
            this.conceptoItem.HeaderText = "Item";
            this.conceptoItem.Name = "conceptoItem";
            this.conceptoItem.ReadOnly = true;
            this.conceptoItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // resultadoPractica
            // 
            this.resultadoPractica.FillWeight = 89.3401F;
            this.resultadoPractica.HeaderText = "Resultado";
            this.resultadoPractica.Name = "resultadoPractica";
            this.resultadoPractica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // valorRef
            // 
            this.valorRef.FillWeight = 89.3401F;
            this.valorRef.HeaderText = "Valor Referencia";
            this.valorRef.Name = "valorRef";
            this.valorRef.ReadOnly = true;
            this.valorRef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // conceptoUnidad
            // 
            this.conceptoUnidad.FillWeight = 89.3401F;
            this.conceptoUnidad.HeaderText = "Unidad";
            this.conceptoUnidad.Name = "conceptoUnidad";
            this.conceptoUnidad.ReadOnly = true;
            this.conceptoUnidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btnConsultaProtocolo);
            this.gbBusqueda.Controls.Add(this.txtConsultaProtocolo);
            this.gbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(126, 563);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(524, 52);
            this.gbBusqueda.TabIndex = 5;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Localizar Examen por Nº de Protocolo";
            // 
            // btnConsultaProtocolo
            // 
            this.btnConsultaProtocolo.Location = new System.Drawing.Point(262, 13);
            this.btnConsultaProtocolo.Name = "btnConsultaProtocolo";
            this.btnConsultaProtocolo.Size = new System.Drawing.Size(240, 31);
            this.btnConsultaProtocolo.TabIndex = 1;
            this.btnConsultaProtocolo.Text = "Buscar Examen por Nº de Protocolo";
            this.btnConsultaProtocolo.UseVisualStyleBackColor = true;
            this.btnConsultaProtocolo.Click += new System.EventHandler(this.btnConsultaProtocolo_Click);
            // 
            // txtConsultaProtocolo
            // 
            this.txtConsultaProtocolo.Location = new System.Drawing.Point(19, 19);
            this.txtConsultaProtocolo.Name = "txtConsultaProtocolo";
            this.txtConsultaProtocolo.Size = new System.Drawing.Size(236, 20);
            this.txtConsultaProtocolo.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(807, 563);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(149, 52);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir Informe";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(13, 563);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 52);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // NuevoProtocolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(968, 627);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.dgvPracticas);
            this.Controls.Add(this.dgvProtocoloDetalle);
            this.Controls.Add(this.gbNuevoProtocolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoProtocolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Examenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoProtocolo_FormClosing);
            this.gbNuevoProtocolo.ResumeLayout(false);
            this.gbNuevoProtocolo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocoloDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticas)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProtocolo;
        private System.Windows.Forms.TextBox txtNroProtocolo;
        private System.Windows.Forms.GroupBox gbNuevoProtocolo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.Button btnProfesional;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvProtocoloDetalle;
        private System.Windows.Forms.DataGridView dgvPracticas;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnConsultaProtocolo;
        private System.Windows.Forms.TextBox txtConsultaProtocolo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocoloDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPractica;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoPractica;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoUnidad;
        private System.Windows.Forms.Button btnSalir;
    }
}