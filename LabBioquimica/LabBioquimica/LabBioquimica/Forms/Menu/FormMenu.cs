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
            pacientes.ShowDialog();
            pacientes.Dispose();
        }

        private void profesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC.Profesionales profesionales = new ABMC.Profesionales();
            profesionales.ShowDialog();
            profesionales.Dispose();
        }

        private void mutualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC.Mutuales mutuales = new ABMC.Mutuales();
            mutuales.ShowDialog();
            mutuales.Dispose();
        }

        private void análisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC.Analisis analisis = new ABMC.Analisis();
            analisis.ShowDialog();
            analisis.Dispose();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC.Items items = new ABMC.Items();
            items.ShowDialog();
            items.Dispose();
        }

        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC.Unidades unidades = new ABMC.Unidades();
            unidades.ShowDialog();
            unidades.Dispose();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC.Localidades localidades = new ABMC.Localidades();
            localidades.ShowDialog();
            localidades.Dispose();
        }

        private void registroDePrácticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaccion.NuevoProtocolo nuevoProtocolo = new Transaccion.NuevoProtocolo();
            nuevoProtocolo.ShowDialog();
            nuevoProtocolo.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarProtocolosPorPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes.ProtocolosPorPaciente protPorPac = new Informes.ProtocolosPorPaciente();
            protPorPac.ShowDialog();
            protPorPac.Dispose();
        }
    }
}
