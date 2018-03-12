namespace LabBioquimica.Forms.ABMC
{
    partial class Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConsultaDNI = new System.Windows.Forms.Button();
            this.btnConsultaApe = new System.Windows.Forms.Button();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.dgvPacientes);
            this.panelConsulta.Location = new System.Drawing.Point(12, 12);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(1118, 451);
            this.panelConsulta.TabIndex = 0;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.apellido,
            this.nombre,
            this.documento,
            this.tipoDoc,
            this.sexo,
            this.fechaNacimiento,
            this.telefono,
            this.mutual,
            this.localidad,
            this.calle,
            this.nroCalle});
            this.dgvPacientes.Location = new System.Drawing.Point(14, 21);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(1086, 407);
            this.dgvPacientes.TabIndex = 0;
            this.dgvPacientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPacientes_MouseClick);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(208, 480);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(189, 20);
            this.txtConsulta.TabIndex = 1;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(144, 483);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(58, 13);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Búsqueda:";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(984, 483);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(128, 28);
            this.cmdRegistrar.TabIndex = 3;
            this.cmdRegistrar.Text = "Nuevo Paciente";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "BuscarPorPK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(892, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultaDNI
            // 
            this.btnConsultaDNI.Location = new System.Drawing.Point(413, 480);
            this.btnConsultaDNI.Name = "btnConsultaDNI";
            this.btnConsultaDNI.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaDNI.TabIndex = 6;
            this.btnConsultaDNI.Text = "Buscar DNI";
            this.btnConsultaDNI.UseVisualStyleBackColor = true;
            this.btnConsultaDNI.Click += new System.EventHandler(this.btnConsultaDNI_Click);
            // 
            // btnConsultaApe
            // 
            this.btnConsultaApe.Location = new System.Drawing.Point(494, 480);
            this.btnConsultaApe.Name = "btnConsultaApe";
            this.btnConsultaApe.Size = new System.Drawing.Size(109, 23);
            this.btnConsultaApe.TabIndex = 7;
            this.btnConsultaApe.Text = "Buscar Apellido";
            this.btnConsultaApe.UseVisualStyleBackColor = true;
            this.btnConsultaApe.Click += new System.EventHandler(this.btnConsultaApe_Click);
            // 
            // idPaciente
            // 
            this.idPaciente.HeaderText = "ID";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            this.idPaciente.Visible = false;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "APELLIDO";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.HeaderText = "DOC";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "TIPO DOC";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "SEXO";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "FECHA NACIMIENTO";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // mutual
            // 
            this.mutual.HeaderText = "MUTUAL";
            this.mutual.Name = "mutual";
            this.mutual.ReadOnly = true;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "LOCALIDAD";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.HeaderText = "CALLE";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // nroCalle
            // 
            this.nroCalle.HeaderText = "Nº CALLE";
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.ReadOnly = true;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 534);
            this.Controls.Add(this.btnConsultaApe);
            this.Controls.Add(this.btnConsultaDNI);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.panelConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.panelConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConsultaDNI;
        private System.Windows.Forms.Button btnConsultaApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn mutual;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
    }
}