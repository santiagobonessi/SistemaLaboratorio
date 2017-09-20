﻿namespace LabBioquimica.Forms.Transaccion
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
            this.txtProtocolo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnProfesional = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.cboProfesional = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvAnalisis = new System.Windows.Forms.DataGridView();
            this.idAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarFila = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrarFila = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultaProtocolo = new System.Windows.Forms.Button();
            this.txtConsultaProtocolo = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnNueoAnalisis = new System.Windows.Forms.Button();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoPractica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrarItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProtocolo
            // 
            this.lblProtocolo.AutoSize = true;
            this.lblProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtocolo.Location = new System.Drawing.Point(26, 23);
            this.lblProtocolo.Name = "lblProtocolo";
            this.lblProtocolo.Size = new System.Drawing.Size(79, 13);
            this.lblProtocolo.TabIndex = 0;
            this.lblProtocolo.Text = "Protocolo Nº";
            // 
            // txtProtocolo
            // 
            this.txtProtocolo.Location = new System.Drawing.Point(111, 20);
            this.txtProtocolo.Name = "txtProtocolo";
            this.txtProtocolo.Size = new System.Drawing.Size(157, 21);
            this.txtProtocolo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnProfesional);
            this.groupBox1.Controls.Add(this.btnPaciente);
            this.groupBox1.Controls.Add(this.cboProfesional);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboPaciente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.txtProtocolo);
            this.groupBox1.Controls.Add(this.lblProtocolo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Protocolo";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(274, 20);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(217, 15);
            this.lblMensaje.TabIndex = 12;
            this.lblMensaje.Text = "mensaje si protocolo es repetido";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(371, 131);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 27);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(463, 131);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 27);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnProfesional
            // 
            this.btnProfesional.Location = new System.Drawing.Point(463, 102);
            this.btnProfesional.Name = "btnProfesional";
            this.btnProfesional.Size = new System.Drawing.Size(66, 23);
            this.btnProfesional.TabIndex = 9;
            this.btnProfesional.Text = "...";
            this.btnProfesional.UseVisualStyleBackColor = true;
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(463, 73);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(66, 23);
            this.btnPaciente.TabIndex = 8;
            this.btnPaciente.Text = "...";
            this.btnPaciente.UseVisualStyleBackColor = true;
            // 
            // cboProfesional
            // 
            this.cboProfesional.FormattingEnabled = true;
            this.cboProfesional.Location = new System.Drawing.Point(111, 102);
            this.cboProfesional.Name = "cboProfesional";
            this.cboProfesional.Size = new System.Drawing.Size(346, 23);
            this.cboProfesional.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profesional";
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(111, 73);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(346, 23);
            this.cboPaciente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paciente";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(111, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(302, 21);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(26, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // dgvAnalisis
            // 
            this.dgvAnalisis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnalisis,
            this.conceptoAnalisis,
            this.metodoAnalisis,
            this.codigoAnalisis,
            this.btnModificarFila,
            this.btnBorrarFila});
            this.dgvAnalisis.Location = new System.Drawing.Point(14, 172);
            this.dgvAnalisis.Name = "dgvAnalisis";
            this.dgvAnalisis.RowHeadersVisible = false;
            this.dgvAnalisis.Size = new System.Drawing.Size(573, 168);
            this.dgvAnalisis.TabIndex = 3;
            // 
            // idAnalisis
            // 
            this.idAnalisis.HeaderText = "ID ANALISIS";
            this.idAnalisis.Name = "idAnalisis";
            this.idAnalisis.Visible = false;
            // 
            // conceptoAnalisis
            // 
            this.conceptoAnalisis.HeaderText = "Análisis";
            this.conceptoAnalisis.Name = "conceptoAnalisis";
            this.conceptoAnalisis.ReadOnly = true;
            // 
            // metodoAnalisis
            // 
            this.metodoAnalisis.HeaderText = "Método";
            this.metodoAnalisis.Name = "metodoAnalisis";
            this.metodoAnalisis.ReadOnly = true;
            // 
            // codigoAnalisis
            // 
            this.codigoAnalisis.HeaderText = "Código";
            this.codigoAnalisis.Name = "codigoAnalisis";
            this.codigoAnalisis.ReadOnly = true;
            // 
            // btnModificarFila
            // 
            this.btnModificarFila.HeaderText = "Modificar";
            this.btnModificarFila.Name = "btnModificarFila";
            this.btnModificarFila.Text = "MODIFICAR";
            // 
            // btnBorrarFila
            // 
            this.btnBorrarFila.HeaderText = "Borrar";
            this.btnBorrarFila.Name = "btnBorrarFila";
            this.btnBorrarFila.Text = "BORRAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.conceptoItem,
            this.resultadoPractica,
            this.conceptoUnidad,
            this.valorRef,
            this.btnBorrarItem});
            this.dataGridView1.Location = new System.Drawing.Point(12, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(575, 170);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultaProtocolo);
            this.groupBox2.Controls.Add(this.txtConsultaProtocolo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 555);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda por Nº de Protocolo";
            // 
            // btnConsultaProtocolo
            // 
            this.btnConsultaProtocolo.Location = new System.Drawing.Point(292, 15);
            this.btnConsultaProtocolo.Name = "btnConsultaProtocolo";
            this.btnConsultaProtocolo.Size = new System.Drawing.Size(86, 27);
            this.btnConsultaProtocolo.TabIndex = 12;
            this.btnConsultaProtocolo.Text = "Buscar";
            this.btnConsultaProtocolo.UseVisualStyleBackColor = true;
            // 
            // txtConsultaProtocolo
            // 
            this.txtConsultaProtocolo.Location = new System.Drawing.Point(9, 19);
            this.txtConsultaProtocolo.Name = "txtConsultaProtocolo";
            this.txtConsultaProtocolo.Size = new System.Drawing.Size(277, 20);
            this.txtConsultaProtocolo.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(438, 557);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(149, 52);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir Informe";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 191);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnNueoAnalisis
            // 
            this.btnNueoAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueoAnalisis.Location = new System.Drawing.Point(480, 346);
            this.btnNueoAnalisis.Name = "btnNueoAnalisis";
            this.btnNueoAnalisis.Size = new System.Drawing.Size(107, 27);
            this.btnNueoAnalisis.TabIndex = 12;
            this.btnNueoAnalisis.Text = "Nueva Práctica";
            this.btnNueoAnalisis.UseVisualStyleBackColor = true;
            this.btnNueoAnalisis.Click += new System.EventHandler(this.btnNueoAnalisis_Click);
            // 
            // idItem
            // 
            this.idItem.HeaderText = "IDITEM";
            this.idItem.Name = "idItem";
            this.idItem.Visible = false;
            // 
            // conceptoItem
            // 
            this.conceptoItem.HeaderText = "Item";
            this.conceptoItem.Name = "conceptoItem";
            this.conceptoItem.ReadOnly = true;
            // 
            // resultadoPractica
            // 
            this.resultadoPractica.HeaderText = "Resultado";
            this.resultadoPractica.Name = "resultadoPractica";
            // 
            // conceptoUnidad
            // 
            this.conceptoUnidad.HeaderText = "Unidad";
            this.conceptoUnidad.Name = "conceptoUnidad";
            this.conceptoUnidad.ReadOnly = true;
            // 
            // valorRef
            // 
            this.valorRef.HeaderText = "Valor Referencia";
            this.valorRef.Name = "valorRef";
            this.valorRef.ReadOnly = true;
            // 
            // btnBorrarItem
            // 
            this.btnBorrarItem.HeaderText = "Borrar";
            this.btnBorrarItem.Name = "btnBorrarItem";
            this.btnBorrarItem.ReadOnly = true;
            // 
            // NuevoProtocolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(599, 610);
            this.Controls.Add(this.btnNueoAnalisis);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvAnalisis);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoProtocolo";
            this.Text = "Registro de Examenes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProtocolo;
        private System.Windows.Forms.TextBox txtProtocolo;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridView dgvAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAnalisis;
        private System.Windows.Forms.DataGridViewButtonColumn btnModificarFila;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrarFila;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultaProtocolo;
        private System.Windows.Forms.TextBox txtConsultaProtocolo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnNueoAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoPractica;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorRef;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrarItem;
    }
}