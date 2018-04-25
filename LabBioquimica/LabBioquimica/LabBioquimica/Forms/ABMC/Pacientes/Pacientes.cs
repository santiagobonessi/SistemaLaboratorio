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

        public static Int32 posSelec;

        public Pacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            cargarPacientes();
        }

        public void cargarPacientes()
        {
            this.dgvPacientes.Rows.Clear();
            this.dgvPacientes.Refresh();

            //CARGAR TODOS LOS PACIENTES EN LA GRILLA
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            blLabBioquimica.bl_PACIENTEEntidadColeccion col = blPaciente.Buscar(null, null, null, null);

            foreach (blLabBioquimica.bl_PACIENTEEntidad ent in col)
            {
                if (ent.FECHA_NACIMIENTO != null)
                {
                    dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO.Value.ToShortDateString(), ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.DIRECCION);
                }
                else
                {
                    dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.DIRECCION);
                }
            }

            this.lblCantFilas.Text = col.Count.ToString();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                this.dgvPacientes.Rows.Clear();
                this.dgvPacientes.Refresh();

                String apellido = txtConsulta.Text;
                blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
                blLabBioquimica.bl_PACIENTEEntidadColeccion col = blPaciente.Buscar(null, apellido, null, null);

                foreach (blLabBioquimica.bl_PACIENTEEntidad ent in col)
                {
                    if (ent.FECHA_NACIMIENTO != null)
                    {
                        dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO.Value.ToShortDateString(), ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.DIRECCION);
                    }
                    else
                    {
                        dgvPacientes.Rows.Add(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.N_TIPO_DOC, ent.N_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.N_MUTUAL, ent.N_LOCALIDAD, ent.DIRECCION);
                    }
                }
                this.lblCantFilas.Text = col.Count.ToString();
            }
            else
            {
                cargarPacientes();
            }

        }

        
        private void dgvPacientes_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();
                
                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvPacientes.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvPacientes.SelectedRows)
                {
                    dr.Selected = false;
                }
                

                if (position_xy_mouse_row >= 0)
                {
                    dgvPacientes.Rows[position_xy_mouse_row].Selected = true;

                    miMenu.Items.Add("Nuevo").Name = "Nuevo";
                    miMenu.Items.Add("Modificar").Name = "Modificar";
                    miMenu.Items.Add("Eliminar").Name = "Eliminar";
                    ToolStripSeparator tss = new ToolStripSeparator();
                    miMenu.Items.Add(tss);
                    miMenu.Items.Add("Salir").Name = "Salir";

                }
                else
                {
                    miMenu.Items.Add("Nuevo").Name = "Nuevo";
                    ToolStripSeparator tss = new ToolStripSeparator();
                    miMenu.Items.Add(tss);
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
                    Forms.ABMC.AltaPacientes altaPacientes = new Forms.ABMC.AltaPacientes(this);
                    altaPacientes.ShowDialog();
                    altaPacientes.Dispose();
                    break;

                case "Modificar":
                    String idPacienteMod = dgvPacientes.Rows[posSelec].Cells[0].Value.ToString();
                    int idModificar = int.Parse(idPacienteMod);
                    Forms.ABMC.AltaPacientes modPacientes = new Forms.ABMC.AltaPacientes(this);
                    modPacientes.traerParaEditar(idModificar);
                    modPacientes.ShowDialog();
                    modPacientes.Dispose();
                    break;

                case "Eliminar":
                    String idPacienteBaja = dgvPacientes.Rows[posSelec].Cells[0].Value.ToString();
                    String apeBaja = dgvPacientes.Rows[posSelec].Cells[1].Value.ToString();
                    String nomBaja = dgvPacientes.Rows[posSelec].Cells[2].Value.ToString();
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el paciente?", "Eliminar Paciente", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Baja(idPacienteBaja);
                        MessageBox.Show("El paciente " + apeBaja + ", " + nomBaja + " ha sido eliminado");
                        cargarPacientes();
                    }
                    break;

                case "Salir":
                    Close();
                    break;

                default:
                    break;
            }

        }

        private void Baja(String idPaciente)
        {
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            blLabBioquimica.bl_PACIENTEEntidad ent = new blLabBioquimica.bl_PACIENTEEntidad();

            ent.ID_PACIENTE = int.Parse(idPaciente);
            ent.USR_BAJA = "ADMIN";
            ent.FEC_BAJA = DateTime.Now;

            blPaciente.Baja(ent);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtConsulta.Text = "";
        }


    }
}
