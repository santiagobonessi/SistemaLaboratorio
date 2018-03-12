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
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            //CARGAR TODOS LOS PACIENTES EN LA GRILLA
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            blLabBioquimica.bl_PACIENTEEntidadColeccion col = blPaciente.Buscar(null, null, null, null);

            foreach (blLabBioquimica.bl_PACIENTEEntidad ent in col)
            {
                dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.CALLE, ent.NRO_CALLE);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            blLabBioquimica.bl_PACIENTEEntidad ent = blPaciente.BuscarPorPK(4);

            dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.CALLE, ent.NRO_CALLE);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            blLabBioquimica.bl_PACIENTEEntidadColeccion col = blPaciente.Buscar(null, "BONE", null, null);

            foreach (blLabBioquimica.bl_PACIENTEEntidad ent in col)
            {
                dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.CALLE, ent.NRO_CALLE);
            }
        }

        private void btnConsultaDNI_Click(object sender, EventArgs e)
        {
            if(txtConsulta.Text != "")
            {
                blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
                blLabBioquimica.bl_PACIENTEEntidadColeccion col = blPaciente.Buscar(null, null, null, txtConsulta.Text);

                foreach (blLabBioquimica.bl_PACIENTEEntidad ent in col)
                {
                    dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.CALLE, ent.NRO_CALLE);
                }
            }
        }

        private void btnConsultaApe_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text != "")
            {
                blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
                blLabBioquimica.bl_PACIENTEEntidadColeccion col = blPaciente.Buscar(null, txtConsulta.Text, null, null);

                foreach (blLabBioquimica.bl_PACIENTEEntidad ent in col)
                {
                    dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.CALLE, ent.NRO_CALLE);
                }
            }
        }

        private void dgvPacientes_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();
                
                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvPacientes.HitTest(e.X, e.Y).RowIndex;

                foreach (DataGridViewRow dr in dgvPacientes.SelectedRows)
                {
                    dr.Selected = false;

                }
                dgvPacientes.Rows[position_xy_mouse_row].Selected = true;

                if (position_xy_mouse_row >= 0)
                {
                    miMenu.Items.Add("Nuevo").Name = "Nuevo";
                    miMenu.Items.Add("Modificar").Name = "Modificar";
                    miMenu.Items.Add("Eliminar").Name = "Eliminar";
                    miMenu.Items.Add("Salir").Name = "Salir";

                }
                
                miMenu.Show(dgvPacientes, new Point(e.X, e.Y));

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
                case "Nuevo":
                    MessageBox.Show("Nuevo");
                    break;

                case "Modificar":
                    MessageBox.Show("Modificar");
                    break;

                case "Eliminar":
                    MessageBox.Show("Eliminar");
                    break;

                case "Salir":
                    MessageBox.Show("Salir");
                    break;

                default:
                    break;
            }

        }
    }
}
