using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBioquimica.Forms.Informes
{
    public partial class FacturacionPorMutuales : Form
    {
        public FacturacionPorMutuales()
        {
            InitializeComponent();
            cargarComboMutuales();
        }

        public void cargarComboMutuales()
        {
            blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();

            DataTable dt = blMutual.dataTableMutual();
            DataRow nuevaFila = dt.NewRow();

            nuevaFila["idMutual"] = 0;
            nuevaFila["nombre"] = "--SELECCIONE--";
            dt.Rows.InsertAt(nuevaFila, 0);

            this.cboMutual.DataSource = null;
            this.cboMutual.DataSource = dt;
            this.cboMutual.ValueMember = "idMutual";
            this.cboMutual.DisplayMember = "nombre";
            this.cboMutual.SelectedIndex = 0;
        }



        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboMutual_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvFacturacionesPorMutual.Rows.Clear();

                int filaSelec = this.cboMutual.SelectedIndex;
                String valueMember = this.cboMutual.ValueMember.ToString();

                if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboMutual.SelectedValue != null)
                {
                    int idMutual = int.Parse(this.cboMutual.SelectedValue.ToString());

                    blLabBioquimica.bl_FACTURACION_MUTUAL blFacturacionMutual = new blLabBioquimica.bl_FACTURACION_MUTUAL();
                    blLabBioquimica.bl_FACTURACION_MUTUALEntidadColeccion col = blFacturacionMutual.BuscarConTotal(null, idMutual, null, null);

                    foreach (var ent in col)
                    {
                        decimal totalFacturado = Math.Round((decimal)ent.PRECIO_UNID_BIOQ * (decimal)ent.TOTAL_UNID_BIOQ, 2);
                        dgvFacturacionesPorMutual.Rows.Add(ent.ID_FACTURACION_MUTUAL, ent.ANIO, ent.N_FACTURACION_MES, totalFacturado);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
