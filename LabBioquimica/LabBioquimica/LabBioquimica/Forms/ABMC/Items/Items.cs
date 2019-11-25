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
    public partial class Items : Form
    {

        public static Int32 posSelec;

        //Creo una instancia del Form Analisis para filtrar por analisis
        private Analisis a_frm;

        public Items()
        {
            InitializeComponent();
            cargarItems();
            cargarComboAnalisis();
        }

        public Items(Analisis anali)
        {
            InitializeComponent();
            a_frm = anali;
            
        }

        private void Items_Load(object sender, EventArgs e)
        {
            this.dgvItems.Width = this.Width - 35;
            this.dgvItems.Height = this.Height - 85;
        }

        private void Items_Resize(object sender, EventArgs e)
        {
            this.dgvItems.Width = this.Width - 35;
            this.dgvItems.Height = this.Height - 85;
        }

        public void cargarItems()
        {
            this.dgvItems.Rows.Clear();
            this.dgvItems.Refresh();

            //CARGAR TODOS LOS ITEMS EN LA GRILLA

            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidadColeccion col = blItem.Buscar(null, null, null);

            foreach (blLabBioquimica.bl_ITEMEntidad ent in col)
            {
                dgvItems.Rows.Add(ent.ID_ITEM, ent.NOMBRE, ent.VALOR_REF, ent.N_ANALISIS, ent.N_UNIDAD, ent.NRO_ORDEN);
            }

            this.lblCantFilas.Text = col.Count.ToString();
        }

        public void cargarItemsXAnalisis(Int32 idAnalisis, String nomAnalisis)
        {
            //Bloquear busqueda y limpiezo de combo
            this.lblBusqueda.Text = "";
            this.btnBuscar.Visible = false;
            this.btnLimpiar.Visible = false;
            this.cboAnalisis.Enabled = false;

            //Cargar nombre del analisis en el combo box
            this.cboAnalisis.ValueMember = idAnalisis.ToString();
            this.cboAnalisis.Text = nomAnalisis;

            this.dgvItems.Rows.Clear();
            this.dgvItems.Refresh();

            //CARGAR TODOS LOS ITEMS DEL ANALISIS EN LA GRILLA

            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidadColeccion col = blItem.Buscar(null, idAnalisis, null);

            foreach (blLabBioquimica.bl_ITEMEntidad ent in col)
            {
                dgvItems.Rows.Add(ent.ID_ITEM, ent.NOMBRE, ent.VALOR_REF, ent.N_ANALISIS, ent.N_UNIDAD, ent.NRO_ORDEN);
            }

            this.lblCantFilas.Text = col.Count.ToString();
        }

        private void dgvItems_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvItems.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvItems.SelectedRows)
                {
                    dr.Selected = false;
                }

                if (position_xy_mouse_row >= 0)
                {
                    dgvItems.Rows[position_xy_mouse_row].Selected = true;

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

                miMenu.Show(dgvItems, new Point(e.X, e.Y));

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
                    
                    if(a_frm != null)
                    {
                        Forms.ABMC.AltaItems altaItemsAnalisis = new Forms.ABMC.AltaItems(this, this.cboAnalisis.ValueMember, this.cboAnalisis.Text);
                        altaItemsAnalisis.ShowDialog();
                        altaItemsAnalisis.Dispose();
                    }
                    else
                    {
                        Forms.ABMC.AltaItems altaItems = new Forms.ABMC.AltaItems(this);
                        altaItems.ShowDialog();
                        altaItems.Dispose();
                    }
                    
                    break;

                case "Modificar":
                    String idItemMod = dgvItems.Rows[posSelec].Cells[0].Value.ToString();
                    int idModificar = int.Parse(idItemMod);
                    
                    if (a_frm != null)
                    {
                        Forms.ABMC.AltaItems modItemsAnalisis = new Forms.ABMC.AltaItems(this, this.cboAnalisis.ValueMember, this.cboAnalisis.Text);
                        modItemsAnalisis.traerParaEditarDesdeAnalisis(idModificar);
                        modItemsAnalisis.ShowDialog();
                        modItemsAnalisis.Dispose();
                    }
                    else
                    {
                        Forms.ABMC.AltaItems modItems = new Forms.ABMC.AltaItems(this);
                        modItems.traerParaEditar(idModificar);
                        modItems.ShowDialog();
                        modItems.Dispose();
                    }
                    break;

                case "Eliminar":
                    String idItemBaja = dgvItems.Rows[posSelec].Cells[0].Value.ToString();
                    String nomBaja = dgvItems.Rows[posSelec].Cells[1].Value.ToString();

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el item?", "Eliminar Item", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Baja(idItemBaja);
                        MessageBox.Show("El item " + nomBaja + " ha sido eliminado");
                        if(a_frm != null)
                        {
                            // TO DO: Ver como llamar al nomre del analisis sin actualizar grilla
                            cargarItemsXAnalisis(int.Parse(this.cboAnalisis.ValueMember), this.cboAnalisis.Text);
                        }
                        else
                        {
                            int index = this.dgvItems.Rows[posSelec].Index;
                            this.dgvItems.Rows.RemoveAt(index);
                        }
                        
                    }
                    break;

                case "Salir":
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void Baja(String idItem)
        {
            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidad ent = new blLabBioquimica.bl_ITEMEntidad();

            ent.ID_ITEM = int.Parse(idItem);
            ent.USR_BAJA = "ADMIN";
            ent.FEC_BAJA = DateTime.Now;

            blItem.Baja(ent);
        }

        public void cargarComboAnalisis()
        {
            blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();

            this.cboAnalisis.DataSource = null;
            this.cboAnalisis.DataSource = blAnalisis.dataTableAnalisis();
            this.cboAnalisis.ValueMember = "idAnalisis";
            this.cboAnalisis.DisplayMember = "nombre";
            this.cboAnalisis.SelectedIndex = -1;

            // cargo la lista de items para el autocomplete dle combobox
            this.cboAnalisis.AutoCompleteCustomSource = AutocompleteAnalisis();
            this.cboAnalisis.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboAnalisis.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Método para cargar la coleccion de datos para el autocomplete de analisis
        public AutoCompleteStringCollection AutocompleteAnalisis()
        {
            blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
            DataTable dt = blAnalisis.dataTableAnalisis();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nombre"]));
            }

            return coleccion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cboAnalisis.SelectedValue != null)
            {
                this.dgvItems.Rows.Clear();
                this.dgvItems.Refresh();

                int idAnalisis = int.Parse(this.cboAnalisis.SelectedValue.ToString()); ;
                blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
                blLabBioquimica.bl_ITEMEntidadColeccion col = blItem.Buscar(null, idAnalisis, null);

                foreach (blLabBioquimica.bl_ITEMEntidad ent in col)
                {
                    dgvItems.Rows.Add(ent.ID_ITEM, ent.NOMBRE, ent.VALOR_REF, ent.N_ANALISIS, ent.N_UNIDAD, ent.NRO_ORDEN);
                }

                this.lblCantFilas.Text = col.Count.ToString();
            }
            else
            {
                cargarItems();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cboAnalisis.SelectedIndex = -1;
            cargarItems();
        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}
