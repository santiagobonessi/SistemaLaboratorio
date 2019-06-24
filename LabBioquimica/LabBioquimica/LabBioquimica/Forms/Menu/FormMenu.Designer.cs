namespace LabBioquimica.Forms.Menu
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuSistema = new System.Windows.Forms.MenuStrip();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.análisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePrácticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProtocolosPorPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturacionesPorMutualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónMutualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictLaboratorio = new System.Windows.Forms.PictureBox();
            this.menuSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLaboratorio)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSistema
            // 
            this.menuSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.registroDePrácticasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.facturaciónMutualesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuSistema.Location = new System.Drawing.Point(0, 0);
            this.menuSistema.Name = "menuSistema";
            this.menuSistema.Size = new System.Drawing.Size(954, 24);
            this.menuSistema.TabIndex = 0;
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.profesionalesToolStripMenuItem,
            this.mutualesToolStripMenuItem,
            this.toolStripSeparator1,
            this.análisisToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.unidadToolStripMenuItem,
            this.toolStripSeparator2,
            this.localidadesToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // profesionalesToolStripMenuItem
            // 
            this.profesionalesToolStripMenuItem.Name = "profesionalesToolStripMenuItem";
            this.profesionalesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.profesionalesToolStripMenuItem.Text = "Profesionales";
            this.profesionalesToolStripMenuItem.Click += new System.EventHandler(this.profesionalesToolStripMenuItem_Click);
            // 
            // mutualesToolStripMenuItem
            // 
            this.mutualesToolStripMenuItem.Name = "mutualesToolStripMenuItem";
            this.mutualesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mutualesToolStripMenuItem.Text = "Mutuales";
            this.mutualesToolStripMenuItem.Click += new System.EventHandler(this.mutualesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // análisisToolStripMenuItem
            // 
            this.análisisToolStripMenuItem.Name = "análisisToolStripMenuItem";
            this.análisisToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.análisisToolStripMenuItem.Text = "Análisis";
            this.análisisToolStripMenuItem.Click += new System.EventHandler(this.análisisToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // unidadToolStripMenuItem
            // 
            this.unidadToolStripMenuItem.Name = "unidadToolStripMenuItem";
            this.unidadToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.unidadToolStripMenuItem.Text = "Unidad";
            this.unidadToolStripMenuItem.Click += new System.EventHandler(this.unidadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // registroDePrácticasToolStripMenuItem
            // 
            this.registroDePrácticasToolStripMenuItem.Name = "registroDePrácticasToolStripMenuItem";
            this.registroDePrácticasToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.registroDePrácticasToolStripMenuItem.Text = "Registro de Prácticas";
            this.registroDePrácticasToolStripMenuItem.Click += new System.EventHandler(this.registroDePrácticasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProtocolosPorPacienteToolStripMenuItem,
            this.buscarFacturacionesPorMutualToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // buscarProtocolosPorPacienteToolStripMenuItem
            // 
            this.buscarProtocolosPorPacienteToolStripMenuItem.Name = "buscarProtocolosPorPacienteToolStripMenuItem";
            this.buscarProtocolosPorPacienteToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.buscarProtocolosPorPacienteToolStripMenuItem.Text = "Buscar Protocolos por Paciente";
            this.buscarProtocolosPorPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarProtocolosPorPacienteToolStripMenuItem_Click);
            // 
            // buscarFacturacionesPorMutualToolStripMenuItem
            // 
            this.buscarFacturacionesPorMutualToolStripMenuItem.Name = "buscarFacturacionesPorMutualToolStripMenuItem";
            this.buscarFacturacionesPorMutualToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.buscarFacturacionesPorMutualToolStripMenuItem.Text = "Buscar Facturaciones por Mutual";
            this.buscarFacturacionesPorMutualToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturacionesPorMutualToolStripMenuItem_Click);
            // 
            // facturaciónMutualesToolStripMenuItem
            // 
            this.facturaciónMutualesToolStripMenuItem.Name = "facturaciónMutualesToolStripMenuItem";
            this.facturaciónMutualesToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.facturaciónMutualesToolStripMenuItem.Text = "Facturación Mutuales";
            this.facturaciónMutualesToolStripMenuItem.Click += new System.EventHandler(this.facturaciónMutualesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictLaboratorio
            // 
            this.pictLaboratorio.Image = ((System.Drawing.Image)(resources.GetObject("pictLaboratorio.Image")));
            this.pictLaboratorio.InitialImage = null;
            this.pictLaboratorio.Location = new System.Drawing.Point(0, 24);
            this.pictLaboratorio.Name = "pictLaboratorio";
            this.pictLaboratorio.Size = new System.Drawing.Size(954, 432);
            this.pictLaboratorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictLaboratorio.TabIndex = 1;
            this.pictLaboratorio.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 451);
            this.Controls.Add(this.pictLaboratorio);
            this.Controls.Add(this.menuSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuSistema;
            this.Name = "FormMenu";
            this.Text = "SISTEMA LABORATORIO BIOQUIMICA";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Resize += new System.EventHandler(this.FormMenu_Resize);
            this.menuSistema.ResumeLayout(false);
            this.menuSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLaboratorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSistema;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictLaboratorio;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem análisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePrácticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónMutualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProtocolosPorPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturacionesPorMutualToolStripMenuItem;
    }
}