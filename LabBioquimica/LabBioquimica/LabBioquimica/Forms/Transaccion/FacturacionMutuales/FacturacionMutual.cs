using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBioquimica.Forms.Transaccion.FacturacionMutuales
{
    public partial class FacturacionMutual : Form
    {
        public FacturacionMutual()
        {
            InitializeComponent();
            cargarComboMutual();
        }

        public void cargarComboMutual()
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

        
        private void btnAceptarMutual_Click(object sender, EventArgs e)
        {
            //Busca todos los pacientes que esten adheridos a la mutual seleccionada
            try
            {
                int filaSelec = this.cboMutual.SelectedIndex;
                String valueMember = this.cboMutual.ValueMember.ToString();

                if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboMutual.SelectedValue != null)
                {

                    int idMutual = int.Parse(this.cboMutual.SelectedValue.ToString());

                    this.dgvPacientesAdheridos.Rows.Clear();
                    this.dgvPacientesAdheridos.Refresh();

                    blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
                    blLabBioquimica.bl_PACIENTEEntidadColeccion col = blPaciente.Buscar(null, null, null, null, idMutual);

                    foreach (blLabBioquimica.bl_PACIENTEEntidad ent in col)
                    {
                        dgvPacientesAdheridos.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.TELEFONO, ent.DIRECCION);
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
