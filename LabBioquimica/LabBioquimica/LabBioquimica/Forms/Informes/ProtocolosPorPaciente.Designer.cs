namespace LabBioquimica.Forms.Informes
{
    partial class ProtocolosPorPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtocolosPorPaciente));
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProtocoloPorPaciente = new System.Windows.Forms.DataGridView();
            this.idProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProtocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocoloPorPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(81, 38);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(360, 21);
            this.cboPaciente.TabIndex = 5;
            this.cboPaciente.SelectedIndexChanged += new System.EventHandler(this.cboPaciente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione el nombre del Paciente que desea ver los Examenes realizados:";
            // 
            // dgvProtocoloPorPaciente
            // 
            this.dgvProtocoloPorPaciente.AllowUserToAddRows = false;
            this.dgvProtocoloPorPaciente.AllowUserToDeleteRows = false;
            this.dgvProtocoloPorPaciente.AllowUserToResizeColumns = false;
            this.dgvProtocoloPorPaciente.AllowUserToResizeRows = false;
            this.dgvProtocoloPorPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProtocoloPorPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocoloPorPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProtocolo,
            this.nroProtocolo,
            this.fechaProtocolo,
            this.nombreProfesional});
            this.dgvProtocoloPorPaciente.Location = new System.Drawing.Point(15, 65);
            this.dgvProtocoloPorPaciente.Name = "dgvProtocoloPorPaciente";
            this.dgvProtocoloPorPaciente.ReadOnly = true;
            this.dgvProtocoloPorPaciente.RowHeadersVisible = false;
            this.dgvProtocoloPorPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProtocoloPorPaciente.Size = new System.Drawing.Size(510, 280);
            this.dgvProtocoloPorPaciente.TabIndex = 7;
            this.dgvProtocoloPorPaciente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProtocoloPorPaciente_MouseClick);
            // 
            // idProtocolo
            // 
            this.idProtocolo.HeaderText = "ID PROCOLO";
            this.idProtocolo.Name = "idProtocolo";
            this.idProtocolo.ReadOnly = true;
            this.idProtocolo.Visible = false;
            // 
            // nroProtocolo
            // 
            this.nroProtocolo.FillWeight = 73.85789F;
            this.nroProtocolo.HeaderText = "Nro Protocolo";
            this.nroProtocolo.Name = "nroProtocolo";
            this.nroProtocolo.ReadOnly = true;
            // 
            // fechaProtocolo
            // 
            this.fechaProtocolo.FillWeight = 73.85789F;
            this.fechaProtocolo.HeaderText = "Fecha realización";
            this.fechaProtocolo.Name = "fechaProtocolo";
            this.fechaProtocolo.ReadOnly = true;
            // 
            // nombreProfesional
            // 
            this.nombreProfesional.FillWeight = 152.2843F;
            this.nombreProfesional.HeaderText = "Solicitado por el Doctor/a";
            this.nombreProfesional.Name = "nombreProfesional";
            this.nombreProfesional.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 33);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ProtocolosPorPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(534, 391);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvProtocoloPorPaciente);
            this.Controls.Add(this.cboPaciente);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProtocolosPorPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Protocolo por Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocoloPorPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProtocoloPorPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProfesional;
        private System.Windows.Forms.Button btnSalir;
    }
}