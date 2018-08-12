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
    public partial class Localidades : Form
    {
        public static Int32 posSelec;

        public Localidades()
        {
            InitializeComponent();
        }

        private void Localidades_Load(object sender, EventArgs e)
        {
            cargarLocalidades();
            this.dgvLocalidades.Width = this.Width - 40;
            this.dgvLocalidades.Height = this.Height - 40;
        }

        private void Localidades_Resize(object sender, EventArgs e)
        {
            this.dgvLocalidades.Width = this.Width - 40;
            this.dgvLocalidades.Height = this.Height - 40;
        }

        public void cargarLocalidades()
        {
            this.dgvLocalidades.Rows.Clear();
            this.dgvLocalidades.Refresh();

            //CARGAR TODAS LAS LOCALIDADES EN LA GRILLA

            blLabBioquimica.bl_LOCALIDAD blLocalidad = new blLabBioquimica.bl_LOCALIDAD();
            blLabBioquimica.bl_LOCALIDADEntidadColeccion col = blLocalidad.Buscar(null, null);

            foreach (blLabBioquimica.bl_LOCALIDADEntidad ent in col)
            {
                dgvLocalidades.Rows.Add(ent.ID_LOCALIDAD, ent.NOMBRE, ent.CODPOSTAL);
            }

            this.lblCantFilas.Text = col.Count.ToString();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                this.dgvLocalidades.Rows.Clear();
                this.dgvLocalidades.Refresh();

                String nombre = txtConsulta.Text;
                blLabBioquimica.bl_LOCALIDAD blLocalidad = new blLabBioquimica.bl_LOCALIDAD();
                blLabBioquimica.bl_LOCALIDADEntidadColeccion col = blLocalidad.Buscar(null, nombre);

                foreach (blLabBioquimica.bl_LOCALIDADEntidad ent in col)
                {
                    dgvLocalidades.Rows.Add(ent.ID_LOCALIDAD, ent.NOMBRE, ent.CODPOSTAL);
                }

                this.lblCantFilas.Text = col.Count.ToString();
            }
            else
            {
                cargarLocalidades();
            }
        }

        private void dgvLocalidades_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvLocalidades.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvLocalidades.SelectedRows)
                {
                    dr.Selected = false;
                }


                if (position_xy_mouse_row >= 0)
                {
                    dgvLocalidades.Rows[position_xy_mouse_row].Selected = true;

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

                miMenu.Show(dgvLocalidades, new Point(e.X, e.Y));

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
                    Forms.ABMC.AltaLocalidades altaLocalidades = new Forms.ABMC.AltaLocalidades(this);
                    altaLocalidades.ShowDialog();
                    altaLocalidades.Dispose();
                    break;

                case "Modificar":
                    String idLocalidadMod = dgvLocalidades.Rows[posSelec].Cells[0].Value.ToString();
                    int idModificar = int.Parse(idLocalidadMod);
                    Forms.ABMC.AltaLocalidades modLocalidades = new Forms.ABMC.AltaLocalidades(this);
                    modLocalidades.traerParaEditar(idModificar);
                    modLocalidades.ShowDialog();        
                    modLocalidades.Dispose();

                    break;

                case "Eliminar":
                    String idLocalidadBaja = dgvLocalidades.Rows[posSelec].Cells[0].Value.ToString();
                    String nomBaja = dgvLocalidades.Rows[posSelec].Cells[1].Value.ToString();
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la localidad?", "Eliminar Localidad", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Baja(idLocalidadBaja);
                        MessageBox.Show("La localidad " + nomBaja + " ha sido eliminado");
                        cargarLocalidades();
                    }
                    break;

                case "Salir":
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void Baja(String idLocalidad)
        {
            blLabBioquimica.bl_LOCALIDAD blLocalidad = new blLabBioquimica.bl_LOCALIDAD();
            blLabBioquimica.bl_LOCALIDADEntidad ent = new blLabBioquimica.bl_LOCALIDADEntidad();

            ent.ID_LOCALIDAD = int.Parse(idLocalidad);
            ent.USR_BAJA = "ADMIN";
            ent.FEC_BAJA = DateTime.Now;

            blLocalidad.Baja(ent);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtConsulta.Text = "";
        }


    }
}
