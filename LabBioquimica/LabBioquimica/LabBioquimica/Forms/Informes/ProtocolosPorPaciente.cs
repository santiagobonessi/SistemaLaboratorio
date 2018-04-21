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
    public partial class ProtocolosPorPaciente : Form
    {

        public static Int32 posSelec;

        public ProtocolosPorPaciente()
        {
            InitializeComponent();
            cargarComboPacientes();
        }

        public void cargarComboPacientes()
        {
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();

            this.cboPaciente.SelectedIndex = -1;
            this.cboPaciente.DataSource = null;
            this.cboPaciente.DataSource = blPaciente.dataTablePaciente();
            this.cboPaciente.ValueMember = "idPaciente";
            this.cboPaciente.DisplayMember = "nomape";
            this.cboPaciente.SelectedIndex = -1;

            // cargo la lista de items para el autocomplete dle combobox
            this.cboPaciente.AutoCompleteCustomSource = AutocompletePaciente();
            this.cboPaciente.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Método para cargar la coleccion de datos para el autocomplete de pacientes
        public AutoCompleteStringCollection AutocompletePaciente()
        {
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            DataTable dt = blPaciente.dataTablePaciente();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nomape"]));
            }

            return coleccion;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dgvProtocoloPorPaciente_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvProtocoloPorPaciente.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvProtocoloPorPaciente.SelectedRows)
                {
                    dr.Selected = false;
                }


                if (position_xy_mouse_row >= 0)
                {
                    dgvProtocoloPorPaciente.Rows[position_xy_mouse_row].Selected = true;

                    miMenu.Items.Add("Detalle Protocolo").Name = "Detalle Protocolo";
                    ToolStripSeparator tss = new ToolStripSeparator();
                    miMenu.Items.Add(tss);
                    miMenu.Items.Add("Salir").Name = "Salir";

                }

                miMenu.Show(dgvProtocoloPorPaciente, new Point(e.X, e.Y));

                //Evento menu click
                miMenu.ItemClicked += new ToolStripItemClickedEventHandler(MiMenu_ItemClicked);

            }
        }

        private void MiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            //Evento seleccionado, para luego realizar la operación necesaria
            String eventoSelec = e.ClickedItem.Name.ToString();

            switch (eventoSelec)
            {
                case "Detalle Protocolo":
                    Forms.Transaccion.NuevoProtocolo detalleProtocolo = new Forms.Transaccion.NuevoProtocolo();
                    detalleProtocolo.ShowDialog();
                    detalleProtocolo.Dispose();
                    break;

                case "Salir":
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filaSelec = this.cboPaciente.SelectedIndex;
            String valueMember = this.cboPaciente.ValueMember.ToString();

            if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboPaciente.SelectedValue != null)
            {

                int idPaciente = int.Parse(this.cboPaciente.SelectedValue.ToString());

                this.dgvProtocoloPorPaciente.Rows.Clear();
                this.dgvProtocoloPorPaciente.Refresh();

                blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
                blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, null, null, idPaciente, null);

                foreach (blLabBioquimica.bl_PROTOCOLOEntidad ent in col)
                {
                    dgvProtocoloPorPaciente.Rows.Add(ent.ID_PROTOCOLO, ent.NRO_PROTOCOLO, ent.FECHA.Value.ToShortDateString(), ent.N_PROFESIONAL);
                }
            }
        }
    }
}
