using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace LabBioquimica.Forms.Transaccion
{
    public partial class NuevoProtocolo : Form
    {

        public NuevoProtocolo()
        {
            InitializeComponent();
            lblMensaje.Visible = false;
            cargarComboPacientes();
            cargarComboProfesionales();
            this.btnModificar.Enabled = false;
            
        }

        private void btnNueoAnalisis_Click(object sender, EventArgs e)
        {
            Forms.Transaccion.NuevoAnalisis nuevoAnalisis = new Forms.Transaccion.NuevoAnalisis();
            nuevoAnalisis.ShowDialog();
            nuevoAnalisis.Dispose();

        }

        private void dgvAnalisis_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvProtocoloDetalle.HitTest(e.X, e.Y).RowIndex;

                foreach (DataGridViewRow dr in dgvProtocoloDetalle.SelectedRows)
                {
                    dr.Selected = false;
                }
                

                if (position_xy_mouse_row >= 0)
                {
                    dgvProtocoloDetalle.Rows[position_xy_mouse_row].Selected = true;

                    miMenu.Items.Add("Nueva Práctica").Name = "NuevaPractica";
                    miMenu.Items.Add("Eliminar Práctica").Name = "EliminarPractica";
                    miMenu.Items.Add("Agregar o Modificar Items de la Práctica").Name = "AgregarModificarItemsPractica";
                }
                else
                {
                    miMenu.Items.Add("Nueva Práctica").Name = "NuevaPractica";
                }

                miMenu.Show(dgvProtocoloDetalle, new Point(e.X, e.Y));

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
                case "NuevaPractica":
                    String numProtocolo = this.txtProtocolo.Text;
                    Forms.Transaccion.NuevoAnalisis nuevoAnalisis = new Forms.Transaccion.NuevoAnalisis(this, numProtocolo);
                    nuevoAnalisis.ShowDialog();
                    nuevoAnalisis.Dispose();
                    break;

                case "EliminarPractica":
                    MessageBox.Show("EliminarPractica");
                    break;

                case "AgregarModificarItemsPractica":
                    MessageBox.Show("AgregarModificarItemsPractica");
                    break;

                default:
                    break;
            }

        }

        private void dgvItems_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvPractica.HitTest(e.X, e.Y).RowIndex;

                foreach (DataGridViewRow dr in dgvPractica.SelectedRows)
                {
                    dr.Selected = false;

                }
                

                if (position_xy_mouse_row >= 0)
                {
                    dgvPractica.Rows[position_xy_mouse_row].Selected = true;
                    miMenu.Items.Add("Eliminar Item").Name = "EliminarItem";
                }

                miMenu.Show(dgvPractica, new Point(e.X, e.Y));

                //Evento menu click
                miMenu.ItemClicked += new ToolStripItemClickedEventHandler(MiMenu_ItemClicked1); ;

            }
        }

        private void MiMenu_ItemClicked1(object sender, ToolStripItemClickedEventArgs e)
        {
            //Evento seleccionado, para luego realizar la operación necesaria
            String eventoSelec = e.ClickedItem.Name.ToString();

            switch (eventoSelec)
            {
                case "EliminarItem":
                    MessageBox.Show("EliminarItem");
                    break;

                default:
                    break;
            }
        }

        public void cargarComboPacientes()
        {
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();

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

        public void cargarComboProfesionales()
        {
            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();

            this.cboProfesional.DataSource = null;
            this.cboProfesional.DataSource = blProfesional.dataTableProfesional();
            this.cboProfesional.ValueMember = "idProfesional";
            this.cboProfesional.DisplayMember = "nomape";
            this.cboProfesional.SelectedIndex = -1;

            // cargo la lista de items para el autocomplete dle combobox
            this.cboProfesional.AutoCompleteCustomSource = AutocompleteProfesional();
            this.cboProfesional.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboProfesional.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Método para cargar la coleccion de datos para el autocomplete de profesionales
        public AutoCompleteStringCollection AutocompleteProfesional()
        {
            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();
            DataTable dt = blProfesional.dataTableProfesional();
            
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nomape"]));
            }

            return coleccion;
        }

        public void cargarNomApeAltaPaciente(String nomape)
        {
            this.cboPaciente.Text = nomape;
        }

        public void cargarNomApeAltaProfesionales(String nomape)
        {
            this.cboProfesional.Text = nomape;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            Forms.ABMC.AltaPacientes altaPacientes = new Forms.ABMC.AltaPacientes(this);
            altaPacientes.ShowDialog();
            altaPacientes.Dispose();
        }

        private void btnProfesional_Click(object sender, EventArgs e)
        {
            Forms.ABMC.AltaProfesional altaProfesionales = new Forms.ABMC.AltaProfesional(this);
            altaProfesionales.ShowDialog();
            altaProfesionales.Dispose();
        }

        //Insertar los datos del protocolo
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtProtocolo.Text))
            {
                MessageBox.Show("Debe ingresar el número de protocolo");
                this.txtProtocolo.Focus();
                return;
            }
            if (this.cboPaciente.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el paciente");
                this.cboPaciente.Focus();
                return;
            }
            if (this.cboProfesional.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el profesional");
                this.cboProfesional.Focus();
                return;
            }
            blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
            //Validar que Nº de Protocolo no esté repetido
            blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, int.Parse(this.txtProtocolo.Text), null, null, null);
            if (col.Count > 0)
            {
                this.lblMensaje.Visible = true;
                this.txtProtocolo.Focus();
                return;
            }
            else
            {
                this.lblMensaje.Visible = false;
            }

            this.gbNuevoProtocolo.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.dgvProtocoloDetalle.Enabled = true;

            //Insertar nuevo protocolo en base de datos
            blLabBioquimica.bl_PROTOCOLOEntidad ent = new blLabBioquimica.bl_PROTOCOLOEntidad();

            //Datos
            ent.NRO_PROTOCOLO = int.Parse(this.txtProtocolo.Text);
            ent.FECHA = DateTime.Parse(this.dtpFecha.Text);
            ent.ID_PACIENTE = int.Parse(this.cboPaciente.SelectedValue.ToString());
            ent.ID_PROFESIONAL = int.Parse(this.cboProfesional.SelectedValue.ToString());

            int idProtocolo = (int)blProtocolo.Insertar(ent).ID_PROTOCOLO;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.gbNuevoProtocolo.Enabled = true;
            this.btnAceptar.Enabled = true;
            this.btnModificar.Enabled = false;
        }

        private void txtProtocolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Busqueda de protocolo por nro de protocolo
        private void btnConsultaProtocolo_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtConsultaProtocolo.Text))
            {
                MessageBox.Show("Debe ingresar el número de protocolo a buscar");
                this.txtConsultaProtocolo.Focus();
                return;
            }

            //Traer datos del protocolo 
            blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
            blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, int.Parse(this.txtConsultaProtocolo.Text), null, null, null);

            //Validar que Nº de Protocolo exista
            if (col.Count > 0)
            {
                int idProtocolo = 0;

                foreach (blLabBioquimica.bl_PROTOCOLOEntidad ent in col)
                {
                    idProtocolo = (int)ent.ID_PROTOCOLO;
                    this.txtProtocolo.Text = ent.NRO_PROTOCOLO.ToString();
                    this.dtpFecha.Text = ent.FECHA.ToString();
                    this.cboPaciente.Text = ent.N_PACIENTE;
                    this.cboProfesional.Text = ent.N_PROFESIONAL;
                }
                this.gbNuevoProtocolo.Enabled = false;
                this.btnAceptar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.dgvProtocoloDetalle.Enabled = true;

                if (idProtocolo != 0)
                {
                    //Traer datos del protocolo detalle
                    blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
                    blLabBioquimica.bl_PROTOCOLO_DETALLEEntidadColeccion colDet = blProtocoloDet.Buscar(null, idProtocolo, null);

                    int idProtocoloDet = 0;
                    foreach (blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad ent in colDet)
                    {
                        idProtocoloDet = (int)ent.ID_PROTOCOLO_DETALLE;
                        dgvProtocoloDetalle.Rows.Add(ent.ID_PROTOCOLO, ent.ID_PROTOCOLO_DETALLE, ent.ID_ANALISIS, ent.NOMBRE_ANALISIS, ent.METODO_ANALISIS, ent.CODIGO_ANALISIS);
                    }

                    if (idProtocoloDet != 0)
                    {
                        //Traer datos de la/s practica/s
                        blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                        blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idProtocoloDet, null);

                        foreach (blLabBioquimica.bl_PRACTICAEntidad ent in colPrac)
                        {
                            dgvPractica.Rows.Add(ent.ID_PROTOCOLO_DETALLE, ent.ID_PRACTICA, ent.ID_ITEM, ent.NOMBRE_ITEM, ent.RESULTADO, ent.VALOR_REF_ITEM, ent.NOMBRE_UNIDAD);
                        }
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Protocolo inexistente");
                this.txtConsultaProtocolo.Focus();
                return;
            }


        }
    }
}
