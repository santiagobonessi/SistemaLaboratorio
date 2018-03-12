using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBioquimica.Forms.Transaccion
{
    public partial class NuevoProtocolo : Form
    {

        public NuevoProtocolo()
        {
            InitializeComponent();
            lblMensaje.Visible = false;
        }

        private void btnNueoAnalisis_Click(object sender, EventArgs e)
        {
            Forms.Transaccion.NuevoAnalisis nuevoAnalisis = new Forms.Transaccion.NuevoAnalisis();
            nuevoAnalisis.Show();
           
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
                dgvAnalisis.Rows[position_xy_mouse_row].Selected = true;

                if (position_xy_mouse_row >= 0)
                {
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
                dgvItems.Rows[position_xy_mouse_row].Selected = true;

                if (position_xy_mouse_row >= 0)
                {
                    
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
    }
}
