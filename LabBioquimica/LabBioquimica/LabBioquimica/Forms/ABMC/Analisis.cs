using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBioquimica.Forms.ABMC
{
    public partial class Analisis : Form
    {
        public Analisis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
            blLabBioquimica.bl_ANALISISEntidad ent = blAnalisis.BuscarPorPK(1);

            dgvAnalisis.Rows.Add(ent.ID_ANALISIS, ent.CODIGO, ent.NOMBRE, ent.METODO, ent.UNID_BIOQ);
        }
    }
}
