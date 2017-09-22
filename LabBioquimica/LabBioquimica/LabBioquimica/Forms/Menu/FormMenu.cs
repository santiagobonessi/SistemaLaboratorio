using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBioquimica.Forms.Menu
{
    public partial class FormMenu : Form
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.pictLaboratorio.Width = this.Width;
            this.pictLaboratorio.Height = this.Height;
        }

        private void FormMenu_Resize(object sender, EventArgs e)
        {
            this.pictLaboratorio.Width = this.Width;
            this.pictLaboratorio.Height = this.Height;
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC.Pacientes pacientes = new ABMC.Pacientes();
            pacientes.Show();
        }

        private void análisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC.Analisis analisis = new ABMC.Analisis();
            analisis.Show();
        }

        private void registroDePrácticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaccion.NuevoProtocolo nuevoProtocolo = new Transaccion.NuevoProtocolo();
            nuevoProtocolo.Show();
        }

        
    }
}
