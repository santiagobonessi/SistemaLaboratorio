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
    public partial class Analisis : Form
    {

        public static Int32 posSelec;

        public Analisis()
        {
            InitializeComponent();
        }

        private void Analisis_Load(object sender, EventArgs e)
        {
            cargarAnalisis();
            this.dgvAnalisis.Width = this.Width -20;
            this.dgvAnalisis.Height = this.Height - 20;
        }

        private void Analisis_Resize(object sender, EventArgs e)
        {
            this.dgvAnalisis.Width = this.Width - 20;
            this.dgvAnalisis.Height = this.Height - 20;
        }

        public void cargarAnalisis()
        {
            this.dgvAnalisis.Rows.Clear();
            this.dgvAnalisis.Refresh();

            //CARGAR TODAS LAS MUTUALES EN LA GRILLA

            blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
            blLabBioquimica.bl_ANALISISEntidadColeccion col = blAnalisis.Buscar(null, null);

            foreach (blLabBioquimica.bl_ANALISISEntidad ent in col)
            {
                dgvAnalisis.Rows.Add(ent.ID_ANALISIS, ent.CODIGO, ent.NOMBRE, ent.METODO, ent.UNIDAD_BIOQ);
            }

            this.lblCantFilas.Text = col.Count.ToString();

        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConsulta.Text))
            {
                this.dgvAnalisis.Rows.Clear();
                this.dgvAnalisis.Refresh();

                String nombre = txtConsulta.Text;
                blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
                blLabBioquimica.bl_ANALISISEntidadColeccion col = blAnalisis.Buscar(null, nombre);

                foreach (blLabBioquimica.bl_ANALISISEntidad ent in col)
                {
                    dgvAnalisis.Rows.Add(ent.ID_ANALISIS, ent.CODIGO, ent.NOMBRE, ent.METODO, ent.UNIDAD_BIOQ);
                }

                this.lblCantFilas.Text = col.Count.ToString();
            }
            else
            {
                cargarAnalisis();
            }
        }

        private void dgvAnalisis_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvAnalisis.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvAnalisis.SelectedRows)
                {
                    dr.Selected = false;
                }


                if (position_xy_mouse_row >= 0)
                {
                    dgvAnalisis.Rows[position_xy_mouse_row].Selected = true;

                    miMenu.Items.Add("Ver Items").Name = "Ver Items";
                    ToolStripSeparator tss = new ToolStripSeparator();
                    miMenu.Items.Add(tss);
                    miMenu.Items.Add("Nuevo").Name = "Nuevo";
                    miMenu.Items.Add("Modificar").Name = "Modificar";
                    miMenu.Items.Add("Eliminar").Name = "Eliminar";
                    ToolStripSeparator tss2 = new ToolStripSeparator();
                    miMenu.Items.Add(tss2);
                    miMenu.Items.Add("Salir").Name = "Salir";
                }
                else
                {
                    miMenu.Items.Add("Nuevo").Name = "Nuevo";
                    ToolStripSeparator tss = new ToolStripSeparator();
                    miMenu.Items.Add(tss);
                    miMenu.Items.Add("Salir").Name = "Salir";
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
                case "Ver Items":
                    String idAnalisisSelec = dgvAnalisis.Rows[posSelec].Cells[0].Value.ToString();
                    String nombre = dgvAnalisis.Rows[posSelec].Cells[2].Value.ToString();
                    Forms.ABMC.Items items = new Forms.ABMC.Items(this);
                    int idAnalisis = int.Parse(idAnalisisSelec);
                    items.cargarItemsXAnalisis(idAnalisis, nombre);
                    items.ShowDialog();
                    items.Dispose();
                    break;

                case "Nuevo":
                    Forms.ABMC.AltaAnalisis altaAnalisis = new Forms.ABMC.AltaAnalisis(this);
                    altaAnalisis.ShowDialog();
                    altaAnalisis.Dispose();
                    break;

                case "Modificar":
                    String idAnalisisMod = dgvAnalisis.Rows[posSelec].Cells[0].Value.ToString();
                    
                    Forms.ABMC.AltaAnalisis modAnalisis = new Forms.ABMC.AltaAnalisis(this);
                    int idModificar = int.Parse(idAnalisisMod);
                    modAnalisis.traerParaEditar(idModificar);
                    modAnalisis.ShowDialog();
                    modAnalisis.Dispose();

                    break;

                case "Eliminar":
                    String idAnalisisBaja = dgvAnalisis.Rows[posSelec].Cells[0].Value.ToString();
                    String nomBaja = dgvAnalisis.Rows[posSelec].Cells[2].Value.ToString();

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el analisis?", "Eliminar Analisis", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Baja(idAnalisisBaja);
                        MessageBox.Show("El analisis " + nomBaja + " ha sido eliminado");
                        cargarAnalisis();
                    }
                    break;

                case "Salir":
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void Baja(String idAnalisis)
        {
            blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
            blLabBioquimica.bl_ANALISISEntidad ent = new blLabBioquimica.bl_ANALISISEntidad();

            ent.ID_ANALISIS = int.Parse(idAnalisis);
            ent.USR_BAJA = "ADMIN";
            ent.FEC_BAJA = DateTime.Now;

            blAnalisis.Baja(ent);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtConsulta.Text = "";
        }


    }
}
