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

        //Variable de la posicion seleccionada en la grilla dgvPacientesAdheridos
        public static Int32 posSelecPA;

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
                    //Falta validar que se lleno el text box de precio Unid Bioq
                    this.gbInfoMutual.Enabled = false;
                    this.gbPacientesAdheridos.Enabled = true;

                    //Llenar el combo box con los pacientes adheridos a la mutual seleccionada
                    int idMutual = int.Parse(this.cboMutual.SelectedValue.ToString());
                    blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();

                    this.cboPacientesAdheridos.SelectedIndex = -1;
                    this.cboPacientesAdheridos.DataSource = null;
                    this.cboPacientesAdheridos.DataSource = blPaciente.dataTablePaciente(null, null, null, null, idMutual);
                    this.cboPacientesAdheridos.ValueMember = "idPaciente";
                    this.cboPacientesAdheridos.DisplayMember = "nomape";
                    this.cboPacientesAdheridos.SelectedIndex = -1;

                    // cargo la lista de items para el autocomplete dle combobox
                    this.cboPacientesAdheridos.AutoCompleteCustomSource = AutocompletePaciente();
                    this.cboPacientesAdheridos.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboPacientesAdheridos.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para cargar la coleccion de datos para el autocomplete de pacientes
        public AutoCompleteStringCollection AutocompletePaciente()
        {
            int idMutual = int.Parse(this.cboMutual.SelectedValue.ToString());

            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            DataTable dt = blPaciente.dataTablePaciente(null, null, null, null, idMutual);

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nomape"]));
            }

            return coleccion;
        }

        private void cboPacientesAdheridos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filaSelec = this.cboPacientesAdheridos.SelectedIndex;
            String valueMember = this.cboPacientesAdheridos.ValueMember.ToString();

            if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboPacientesAdheridos.SelectedValue != null)
            {

                int idPaciente = int.Parse(this.cboPacientesAdheridos.SelectedValue.ToString());

                this.dgvProtocolosXPaciente.Rows.Clear();
                this.dgvProtocolosXPaciente.Refresh();

                blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
                blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, null, null, idPaciente, null);

                foreach (blLabBioquimica.bl_PROTOCOLOEntidad ent in col)
                {
                    dgvProtocolosXPaciente.Rows.Add(ent.ID_PROTOCOLO, ent.NRO_PROTOCOLO, ent.FECHA.Value.ToShortDateString(), ent.N_PROFESIONAL);
                }
            }



        }

    }
}
