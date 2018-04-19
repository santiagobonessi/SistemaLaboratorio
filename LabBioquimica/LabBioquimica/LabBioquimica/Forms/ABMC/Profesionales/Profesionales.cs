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
    public partial class Profesionales : Form
    {

        public static Int32 posSelec;

        public Profesionales()
        {
            InitializeComponent();
        }

        private void Profesionales_Load(object sender, EventArgs e)
        {
            cargarProfesionales();
        }

        public void cargarProfesionales()
        {
            this.dgvProfesionales.Rows.Clear();
            this.dgvProfesionales.Refresh();

            //CARGAR TODOS LOS PROFESIONALES EN LA GRILLA
            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();
            blLabBioquimica.bl_PROFESIONALEntidadColeccion col = blProfesional.Buscar(null, null, null, null);

            foreach (blLabBioquimica.bl_PROFESIONALEntidad ent in col)
            {
                dgvProfesionales.Rows.Add(ent.ID_PROFESIONAL, ent.APELLIDO, ent.NOMBRE, ent.MATRICULA, ent.TELEFONO, ent.N_LOCALIDAD, ent.DIRECCION);
            }

            this.lblCantFilas.Text = col.Count.ToString();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                this.dgvProfesionales.Rows.Clear();
                this.dgvProfesionales.Refresh();

                String apellido = txtConsulta.Text;
                blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();
                blLabBioquimica.bl_PROFESIONALEntidadColeccion col = blProfesional.Buscar(null, apellido, null, null);

                foreach (blLabBioquimica.bl_PROFESIONALEntidad ent in col)
                {
                    dgvProfesionales.Rows.Add(ent.ID_PROFESIONAL, ent.APELLIDO, ent.NOMBRE, ent.MATRICULA, ent.TELEFONO, ent.N_LOCALIDAD, ent.DIRECCION);
                }
                this.lblCantFilas.Text = col.Count.ToString();
            }
            else
            {
                cargarProfesionales();
            }
        }

        private void dgvProfesionales_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvProfesionales.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvProfesionales.SelectedRows)
                {
                    dr.Selected = false;
                }


                if (position_xy_mouse_row >= 0)
                {
                    dgvProfesionales.Rows[position_xy_mouse_row].Selected = true;

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

                miMenu.Show(dgvProfesionales, new Point(e.X, e.Y));

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
                    Forms.ABMC.AltaProfesional altaProfesionales = new Forms.ABMC.AltaProfesional(this);
                    altaProfesionales.ShowDialog();
                    altaProfesionales.Dispose();
                    break;

                case "Modificar":
                    String idProfesionalMod = dgvProfesionales.Rows[posSelec].Cells[0].Value.ToString();
                    int idModificar = int.Parse(idProfesionalMod);
                    Forms.ABMC.AltaProfesional modProfesionales = new Forms.ABMC.AltaProfesional(this);
                    modProfesionales.traerParaEditar(idModificar);
                    modProfesionales.ShowDialog();
                    modProfesionales.Dispose();
                    break;

                case "Eliminar":
                    String idProfesionalBaja = dgvProfesionales.Rows[posSelec].Cells[0].Value.ToString();
                    String apeBaja = dgvProfesionales.Rows[posSelec].Cells[1].Value.ToString();
                    String nomBaja = dgvProfesionales.Rows[posSelec].Cells[2].Value.ToString();

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el profesional?", "Eliminar Profesional", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Baja(idProfesionalBaja);
                        MessageBox.Show("El profesional " + apeBaja + ", " + nomBaja + " ha sido eliminado");
                        cargarProfesionales();
                    }
                    break;

                case "Salir":
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void Baja(String idProfesional)
        {
            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();
            blLabBioquimica.bl_PROFESIONALEntidad ent = new blLabBioquimica.bl_PROFESIONALEntidad();

            ent.ID_PROFESIONAL = int.Parse(idProfesional);
            ent.USR_BAJA = "ADMIN";
            ent.FEC_BAJA = DateTime.Now;

            blProfesional.Baja(ent);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtConsulta.Text = "";
        }


    }
}
