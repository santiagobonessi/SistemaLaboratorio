namespace LabBioquimica.Reportes
{
    partial class RPT_EXAMENES
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
            this.crvExamenes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvExamenes
            // 
            this.crvExamenes.ActiveViewIndex = -1;
            this.crvExamenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvExamenes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvExamenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvExamenes.Location = new System.Drawing.Point(0, 0);
            this.crvExamenes.Name = "crvExamenes";
            this.crvExamenes.Size = new System.Drawing.Size(768, 548);
            this.crvExamenes.TabIndex = 0;
            this.crvExamenes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RPT_EXAMENES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 548);
            this.Controls.Add(this.crvExamenes);
            this.Name = "RPT_EXAMENES";
            this.Text = "RPT_EXAMENES";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvExamenes;
    }
}