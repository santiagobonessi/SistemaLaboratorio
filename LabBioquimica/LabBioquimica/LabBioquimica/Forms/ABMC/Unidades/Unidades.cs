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
    public partial class Unidades : Form
    {

        public static Int32 posSelec;

        public Unidades()
        {
            InitializeComponent();
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            cargarUnidades();
            this.dgvUnidades.Width = this.Width - 40;
            this.dgvUnidades.Height = this.Height - 40;
        }

        private void Unidades_Resize(object sender, EventArgs e)
        {
            this.dgvUnidades.Width = this.Width - 40;
            this.dgvUnidades.Height = this.Height - 40;
        }

        public void cargarUnidades()
        {
            this.dgvUnidades.Rows.Clear();
            this.dgvUnidades.Refresh();

            //CARGAR TODAS LAS UNIDADES EN LA GRILLA

            blLabBioquimica.bl_UNIDAD blUnidad = new blLabBioquimica.bl_UNIDAD();
            blLabBioquimica.bl_UNIDADEntidadColeccion col = blUnidad.Buscar(null);

            foreach (blLabBioquimica.bl_UNIDADEntidad ent in col)
            {
                dgvUnidades.Rows.Add(ent.ID_UNIDAD, ent.NOMBRE);
            }
        }

        private void dgvUnidades_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvUnidades.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvUnidades.SelectedRows)
                {
                    dr.Selected = false;
                }

                if (position_xy_mouse_row >= 0)
                {
                    dgvUnidades.Rows[position_xy_mouse_row].Selected = true;

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

                miMenu.Show(dgvUnidades, new Point(e.X, e.Y));

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
                    Forms.ABMC.AltaUnidades altaUnidades = new Forms.ABMC.AltaUnidades(this);
                    altaUnidades.ShowDialog();
                    altaUnidades.Dispose();
                    break;

                case "Modificar":
                    String idUnidadMod = dgvUnidades.Rows[posSelec].Cells[0].Value.ToString();
                    int idModificar = int.Parse(idUnidadMod);
                    Forms.ABMC.AltaUnidades modUnidades = new Forms.ABMC.AltaUnidades(this);
                    modUnidades.traerParaEditar(idModificar);
                    modUnidades.ShowDialog();
                    modUnidades.Dispose();

                    break;

                case "Eliminar":
                    String idUnidadBaja = dgvUnidades.Rows[posSelec].Cells[0].Value.ToString();
                    String nomBaja = dgvUnidades.Rows[posSelec].Cells[1].Value.ToString();
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la unidad?", "Eliminar Unidad", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Baja(idUnidadBaja);
                        MessageBox.Show("La unidad " + nomBaja + " ha sido eliminado");
                        cargarUnidades();
                    }
                    break;

                case "Salir":
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void Baja(String idUnidad)
        {
            blLabBioquimica.bl_UNIDAD blUnidad = new blLabBioquimica.bl_UNIDAD();
            blLabBioquimica.bl_UNIDADEntidad ent = new blLabBioquimica.bl_UNIDADEntidad();

            ent.ID_UNIDAD = int.Parse(idUnidad);
            ent.USR_BAJA = "ADMIN";
            ent.FEC_BAJA = DateTime.Now;

            blUnidad.Baja(ent);
        }


    }
}
