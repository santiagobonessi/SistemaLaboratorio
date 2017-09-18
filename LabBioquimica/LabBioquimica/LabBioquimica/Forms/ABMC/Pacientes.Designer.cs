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
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmdEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.dgvPacientes);
            this.panelConsulta.Location = new System.Drawing.Point(23, 79);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(915, 364);
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
            this.telefono,
            this.mutual,
            this.localidad,
            this.calle,
            this.nroCalle,
            this.cmdModificar,
            this.cmdEliminar});
            this.dgvPacientes.Location = new System.Drawing.Point(3, 3);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(909, 358);
            this.dgvPacientes.TabIndex = 0;
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
            // cmdModificar
            // 
            this.cmdModificar.HeaderText = "MODIFICAR";
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.ReadOnly = true;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.HeaderText = "BORRAR";
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(285, 39);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(55, 13);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Busqueda";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(578, 31);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(128, 28);
            this.cmdRegistrar.TabIndex = 3;
            this.cmdRegistrar.Text = "Nuevo Paciente";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 661);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelConsulta);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn mutual;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewButtonColumn cmdModificar;
        private System.Windows.Forms.DataGridViewButtonColumn cmdEliminar;
    }
}