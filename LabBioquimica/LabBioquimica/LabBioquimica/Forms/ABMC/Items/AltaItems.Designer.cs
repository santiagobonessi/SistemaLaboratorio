namespace LabBioquimica.Forms.ABMC
{
    partial class AltaItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaItems));
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.txtValorRef = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAnalisis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(143, 207);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cboUnidad
            // 
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(72, 171);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(356, 21);
            this.cboUnidad.TabIndex = 3;
            // 
            // txtValorRef
            // 
            this.txtValorRef.Location = new System.Drawing.Point(75, 113);
            this.txtValorRef.Multiline = true;
            this.txtValorRef.Name = "txtValorRef";
            this.txtValorRef.Size = new System.Drawing.Size(353, 52);
            this.txtValorRef.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(353, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(156, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 25);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Nuevo Item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Unidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Valor \r\nReferencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre*:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(143, 207);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 53;
            this.btnInsertar.Text = "Aceptar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Análisis*:";
            // 
            // cboAnalisis
            // 
            this.cboAnalisis.FormattingEnabled = true;
            this.cboAnalisis.Location = new System.Drawing.Point(75, 45);
            this.cboAnalisis.Name = "cboAnalisis";
            this.cboAnalisis.Size = new System.Drawing.Size(353, 21);
            this.cboAnalisis.TabIndex = 0;
            // 
            // AltaItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(440, 242);
            this.Controls.Add(this.cboAnalisis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cboUnidad);
            this.Controls.Add(this.txtValorRef);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInsertar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaItems";
            this.Text = "Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.TextBox txtValorRef;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAnalisis;
    }
}