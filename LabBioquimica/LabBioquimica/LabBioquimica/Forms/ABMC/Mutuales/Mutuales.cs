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
    public partial class Mutuales : Form
    {

        public static Int32 posSelec;

        public Mutuales()
        {
            InitializeComponent();
        }

        private void Mutuales_Load(object sender, EventArgs e)
        {
            cargarMutuales();
        }

        public void cargarMutuales()
        {
            this.dgvMutuales.Rows.Clear();
            this.dgvMutuales.Refresh();

            //CARGAR TODAS LAS MUTUALES EN LA GRILLA
           
            blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();
            blLabBioquimica.bl_MUTUALEntidadColeccion col = blMutual.Buscar(null, null);

            foreach (blLabBioquimica.bl_MUTUALEntidad ent in col)
            {
                dgvMutuales.Rows.Add(ent.ID_MUTUAL, ent.NOMBRE, ent.TELEFONO, ent.DIRECCION, ent.EMAIL);
            }

            this.lblCantFilas.Text = col.Count.ToString();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                this.dgvMutuales.Rows.Clear();
                this.dgvMutuales.Refresh();

                String nombre = txtConsulta.Text;
                blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();
                blLabBioquimica.bl_MUTUALEntidadColeccion col = blMutual.Buscar(null, nombre);

                foreach (blLabBioquimica.bl_MUTUALEntidad ent in col)
                {
                    dgvMutuales.Rows.Add(ent.ID_MUTUAL, ent.NOMBRE, ent.TELEFONO, ent.DIRECCION, ent.EMAIL);
                }

                this.lblCantFilas.Text = col.Count.ToString();
            }
            else
            {
                cargarMutuales();
            }
        }

        private void dgvMutuales_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvMutuales.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvMutuales.SelectedRows)
                {
                    dr.Selected = false;
                }


                if (position_xy_mouse_row >= 0)
                {
                    dgvMutuales.Rows[position_xy_mouse_row].Selected = true;

                    miMenu.Items.Add("Nuevo").Name = "Nuevo";
                    miMenu.Items.Add("Modificar").Name = "Modificar";
                    miMenu.Items.Add("Eliminar").Name = "Eliminar";
                    ToolStripSeparator tss = new ToolStripSeparator();
                    miMenu.Items.Add(tss);
                    miMenu.Items.Add("Salir").Name = "Salir";

                }

                miMenu.Show(dgvMutuales, new Point(e.X, e.Y));

                //Evento menu click
                miMenu.ItemClicked += new ToolStripItemClickedEventHandler(MiMenu_ItemClicked);

            }
        }

        private void MiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Evento seleccionado, para luego realizar la operación necesaria
            String eventoSelec = e.ClickedItem.Name.ToString();

            String idMutualSelec = dgvMutuales.Rows[posSelec].Cells[0].Value.ToString();
            String nombre = dgvMutuales.Rows[posSelec].Cells[1].Value.ToString();

            switch (eventoSelec)
            {
                case "Nuevo":
                    Forms.ABMC.AltaMutuales altaMutuales = new Forms.ABMC.AltaMutuales(this);
                    altaMutuales.ShowDialog();
                    altaMutuales.Dispose();
                    break;

                case "Modificar":
                    Forms.ABMC.AltaMutuales modMutuales = new Forms.ABMC.AltaMutuales(this);
                    int idModificar = int.Parse(idMutualSelec);
                    modMutuales.traerParaEditar(idModificar);
                    modMutuales.ShowDialog();
                    modMutuales.Dispose();

                    break;

                case "Eliminar":
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el profesional?", "Eliminar Profesional", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Baja(idMutualSelec);
                        MessageBox.Show("La mutual " + nombre + " ha sido eliminado");
                        cargarMutuales();
                    }
                    break;

                case "Salir":
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void Baja(String idMutual)
        {
            blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();
            blLabBioquimica.bl_MUTUALEntidad ent = new blLabBioquimica.bl_MUTUALEntidad();

            ent.ID_MUTUAL = int.Parse(idMutual);
            ent.USR_BAJA = "ADMIN";
            ent.FEC_BAJA = DateTime.Now;

            blMutual.Baja(ent);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtConsulta.Text = "";
        }
    }
}
