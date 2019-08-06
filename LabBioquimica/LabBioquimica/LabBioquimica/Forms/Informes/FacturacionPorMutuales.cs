using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBioquimica.Forms.Informes
{
    public partial class FacturacionPorMutuales : Form
    {

        public static Int32 posSelec;

        public FacturacionPorMutuales()
        {
            InitializeComponent();
            cargarComboMutuales();
        }

        public void cargarComboMutuales()
        {
            try
            {
                blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();

                DataTable dt = blMutual.dataTableMutual();
                DataRow nuevaFila = dt.NewRow();

                nuevaFila["idMutual"] = 0;
                nuevaFila["nombre"] = "--SELECCIONE--";
                dt.Rows.InsertAt(nuevaFila, 0);

                this.cboMutual.DataSource = null;
                this.cboMutual.DataSource = dt;
                this.cboMutual.ValueMember = "idMutual";
                this.cboMutual.DisplayMember = "nombre";
                this.cboMutual.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboMutual_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvFacturacionesPorMutual.Rows.Clear();

                int filaSelec = this.cboMutual.SelectedIndex;
                String valueMember = this.cboMutual.ValueMember.ToString();

                if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboMutual.SelectedValue != null)
                {
                    int idMutual = int.Parse(this.cboMutual.SelectedValue.ToString());

                    blLabBioquimica.bl_FACTURACION_MUTUAL blFacturacionMutual = new blLabBioquimica.bl_FACTURACION_MUTUAL();
                    blLabBioquimica.bl_FACTURACION_MUTUALEntidadColeccion col = blFacturacionMutual.BuscarConTotal(null, idMutual, null, null);

                    foreach (var ent in col)
                    {
                        decimal totalFacturado = 0;
                        if (ent.PRECIO_UNID_BIOQ > 0 && ent.TOTAL_UNID_BIOQ > 0)
                        {
                             totalFacturado = Math.Round((decimal)ent.PRECIO_UNID_BIOQ * (decimal)ent.TOTAL_UNID_BIOQ, 2);
                        }
                        
                        dgvFacturacionesPorMutual.Rows.Add(ent.ID_FACTURACION_MUTUAL, ent.ANIO, ent.N_FACTURACION_MES, totalFacturado);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvFacturacionesPorMutual_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                    //Posicion de la fila que haces click
                    int position_xy_mouse_row = dgvFacturacionesPorMutual.HitTest(e.X, e.Y).RowIndex;
                    posSelec = position_xy_mouse_row;

                    foreach (DataGridViewRow dr in dgvFacturacionesPorMutual.SelectedRows)
                    {
                        dr.Selected = false;
                    }


                    if (position_xy_mouse_row >= 0)
                    {
                        dgvFacturacionesPorMutual.Rows[position_xy_mouse_row].Selected = true;

                        miMenu.Items.Add("Detalle Facturacion").Name = "Detalle Facturacion";
                        ToolStripSeparator tss = new ToolStripSeparator();
                        miMenu.Items.Add(tss);
                        miMenu.Items.Add("Salir").Name = "Salir";

                    }

                    miMenu.Show(dgvFacturacionesPorMutual, new Point(e.X, e.Y));

                    //Evento menu click
                    miMenu.ItemClicked += new ToolStripItemClickedEventHandler(MiMenu_ItemClicked);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void MiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //Evento seleccionado, para luego realizar la operación necesaria
                String eventoSelec = e.ClickedItem.Name.ToString();

                switch (eventoSelec)
                {
                    case "Detalle Facturacion":
                        String idFacturacionMutual = dgvFacturacionesPorMutual.Rows[posSelec].Cells[0].Value.ToString();
                        Forms.Transaccion.FacturacionMutuales.FacturacionMutual facturacionMutual = new Transaccion.FacturacionMutuales.FacturacionMutual(int.Parse(idFacturacionMutual));
                        facturacionMutual.ShowDialog();
                        facturacionMutual.Dispose();

                        break;

                    case "Salir":
                        Close();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
