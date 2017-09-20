using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBioquimica.Forms.Transaccion
{
    public partial class NuevoProtocolo : Form
    {

        public NuevoProtocolo()
        {
            InitializeComponent();
        }

        private void btnNueoAnalisis_Click(object sender, EventArgs e)
        {
            Forms.Transaccion.NuevoAnalisis nuevoAnalisis = new Forms.Transaccion.NuevoAnalisis();
            nuevoAnalisis.Show();
        }
    }
}
