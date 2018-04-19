namespace LabBioquimica.Forms.Transaccion
{
    partial class NuevoAnalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoAnalisis));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProtocolo = new System.Windows.Forms.TextBox();
            this.cboAnalisis = new System.Windows.Forms.ComboBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvItemsAnalisis = new System.Windows.Forms.DataGridView();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarTodos = new System.Windows.Forms.Button();
            this.btnCargarComp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análisis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Protocolo Nº:";
            // 
            // txtProtocolo
            // 
            this.txtProtocolo.Enabled = false;
            this.txtProtocolo.Location = new System.Drawing.Point(88, 12);
            this.txtProtocolo.Name = "txtProtocolo";
            this.txtProtocolo.Size = new System.Drawing.Size(200, 20);
            this.txtProtocolo.TabIndex = 2;
            // 
            // cboAnalisis
            // 
            this.cboAnalisis.FormattingEnabled = true;
            this.cboAnalisis.Location = new System.Drawing.Point(88, 37);
            this.cboAnalisis.Name = "cboAnalisis";
            this.cboAnalisis.Size = new System.Drawing.Size(354, 21);
            this.cboAnalisis.TabIndex = 3;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(448, 37);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(52, 21);
            this.btnAnalisis.TabIndex = 4;
            this.btnAnalisis.Text = "...";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(309, 64);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(198, 64);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(87, 64);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvItemsAnalisis
            // 
            this.dgvItemsAnalisis.AllowUserToAddRows = false;
            this.dgvItemsAnalisis.AllowUserToDeleteRows = false;
            this.dgvItemsAnalisis.AllowUserToResizeColumns = false;
            this.dgvItemsAnalisis.AllowUserToResizeRows = false;
            this.dgvItemsAnalisis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsAnalisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.conceptoItem});
            this.dgvItemsAnalisis.Location = new System.Drawing.Point(7, 93);
            this.dgvItemsAnalisis.Name = "dgvItemsAnalisis";
            this.dgvItemsAnalisis.RowHeadersVisible = false;
            this.dgvItemsAnalisis.Size = new System.Drawing.Size(493, 208);
            this.dgvItemsAnalisis.TabIndex = 6;
            // 
            // idItem
            // 
            this.idItem.HeaderText = "ID_ITEM";
            this.idItem.Name = "idItem";
            this.idItem.Visible = false;
            // 
            // conceptoItem
            // 
            this.conceptoItem.HeaderText = "Item";
            this.conceptoItem.Name = "conceptoItem";
            this.conceptoItem.ReadOnly = true;
            // 
            // btnCargarTodos
            // 
            this.btnCargarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarTodos.Location = new System.Drawing.Point(249, 307);
            this.btnCargarTodos.Name = "btnCargarTodos";
            this.btnCargarTodos.Size = new System.Drawing.Size(154, 23);
            this.btnCargarTodos.TabIndex = 7;
            this.btnCargarTodos.Text = "Cargar Todos";
            this.btnCargarTodos.UseVisualStyleBackColor = true;
            this.btnCargarTodos.Click += new System.EventHandler(this.btnCargarTodos_Click);
            // 
            // btnCargarComp
            // 
            this.btnCargarComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarComp.Location = new System.Drawing.Point(89, 307);
            this.btnCargarComp.Name = "btnCargarComp";
            this.btnCargarComp.Size = new System.Drawing.Size(154, 23);
            this.btnCargarComp.TabIndex = 8;
            this.btnCargarComp.Text = "Cargar Componente";
            this.btnCargarComp.UseVisualStyleBackColor = true;
            this.btnCargarComp.Click += new System.EventHandler(this.btnCargarComp_Click);
            // 
            // NuevoAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(506, 334);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarComp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargarTodos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvItemsAnalisis);
            this.Controls.Add(this.cboAnalisis);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProtocolo);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoAnalisis";
            this.Text = "Insertar Nueva Práctica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsAnalisis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProtocolo;
        private System.Windows.Forms.ComboBox cboAnalisis;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvItemsAnalisis;
        private System.Windows.Forms.Button btnCargarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoItem;
        private System.Windows.Forms.Button btnCargarComp;
    }
}