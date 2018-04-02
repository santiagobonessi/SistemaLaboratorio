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
                int position_xy_mouse_row = dgvAnalisis.HitTest(e.X, e.Y).RowIndex;

                foreach (DataGridViewRow dr in dgvAnalisis.SelectedRows)
                {
                    dr.Selected = false;

                }
                

                if (position_xy_mouse_row >= 0)
                {
                    dgvAnalisis.Rows[position_xy_mouse_row].Selected = true;

                    miMenu.Items.Add("Nueva Práctica").Name = "NuevaPractica";
                    miMenu.Items.Add("Eliminar Práctica").Name = "EliminarPractica";
                    miMenu.Items.Add("Agregar o Modificar Items de la Práctica").Name = "AgregarModificarItemsPractica";

                }

                miMenu.Show(dgvAnalisis, new Point(e.X, e.Y));

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
                    Forms.Transaccion.NuevoAnalisis nuevoAnalisis = new Forms.Transaccion.NuevoAnalisis();
                    nuevoAnalisis.Show();
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
                int position_xy_mouse_row = dgvItems.HitTest(e.X, e.Y).RowIndex;

                foreach (DataGridViewRow dr in dgvItems.SelectedRows)
                {
                    dr.Selected = false;

                }
                

                if (position_xy_mouse_row >= 0)
                {
                    dgvItems.Rows[position_xy_mouse_row].Selected = true;
                    miMenu.Items.Add("Eliminar Item").Name = "EliminarItem";
                }

                miMenu.Show(dgvItems, new Point(e.X, e.Y));

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
            this.gbNuevoProtocolo.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.gbNuevoProtocolo.Enabled = true;
            this.btnAceptar.Enabled = true;
            this.btnModificar.Enabled = false;
        }



    }
}
