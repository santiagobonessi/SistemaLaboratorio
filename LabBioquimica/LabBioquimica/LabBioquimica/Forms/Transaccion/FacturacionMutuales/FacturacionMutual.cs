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

        //Variable de la posicion seleccionada en la grilla dgvProtocolosXPaciente
        public static Int32 posSelecPP;

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
                if (txtPrecioUnidBioq.Text == "") { return; }
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
            try
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
            catch (Exception)
            {

                throw;
            }
            
        }

        private void cboPacientesAdheridos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Limpio la grilla de analisis por protocolo
                this.dgvAnalisisXProtocolo.Rows.Clear();

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

                        //Saco el select de la primer fila por defecto en la grilla
                        foreach (DataGridViewRow dr in dgvProtocolosXPaciente.SelectedRows)
                        {
                            dr.Selected = false;
                        }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvProtocolosXPaciente_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Cargar Practicas del Protocolo Detalle seleccionado
                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvProtocolosXPaciente.HitTest(e.X, e.Y).RowIndex;
                posSelecPP = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvProtocolosXPaciente.SelectedRows)
                {
                    dr.Selected = false;
                }

                dgvAnalisisXProtocolo.Rows.Clear();
                dgvAnalisisXProtocolo.Refresh();

                //Si selecciona un protocolo detalle
                if (position_xy_mouse_row >= 0)
                {
                    dgvAnalisisXProtocolo.Enabled = true;

                    dgvProtocolosXPaciente.Rows[position_xy_mouse_row].Selected = true;

                    //Cargar Practicas del Protocolo Detalle seleccionado
                    String idProtGrilla = dgvProtocolosXPaciente.Rows[posSelecPP].Cells[0].Value.ToString();
                    int idProt = int.Parse(idProtGrilla);

                    //Traer datos del protocolo detalle
                    blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
                    blLabBioquimica.bl_PROTOCOLO_DETALLEEntidadColeccion colDet = blProtocoloDet.Buscar(null, idProt, null);

                    
                    foreach (blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad ent in colDet)
                    {
                        dgvAnalisisXProtocolo.Rows.Add(ent.ID_PROTOCOLO, ent.ID_PROTOCOLO_DETALLE, ent.ID_ANALISIS, ent.NOMBRE_ANALISIS, ent.METODO_ANALISIS, ent.CODIGO_ANALISIS, ent.UNIDAD_BIOQ_ANALISIS);
                    }

                }
            }
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Recorro los analisis seleccionados
            int contador = 0;
            foreach (DataGridViewRow row in dgvAnalisisXProtocolo.Rows)
            {
                if (row.Cells[7].Value.Equals(true))//Columna de checks
                {
                    contador++;
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //TO DO : Limpiar todos los campos
        }

    }
}
