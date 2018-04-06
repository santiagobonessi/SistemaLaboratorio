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
    public partial class AltaMutuales : Form
    {
        //Creo una instancia del Form Pacientes para actualizar la grilla
        private Mutuales m_frm;

        public static Int32 idModificar;

        public AltaMutuales()
        {
            InitializeComponent();
            this.btnGrabar.Visible = false;
        }
        //Constructor con parámetro del form Mutuales
        public AltaMutuales(Mutuales mut)
        {
            InitializeComponent();
            m_frm = mut;
            this.btnGrabar.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();
            blLabBioquimica.bl_MUTUALEntidad ent = new blLabBioquimica.bl_MUTUALEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la mutual");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text)) { ent.TELEFONO = this.txtTelefono.Text; }
            if (!string.IsNullOrWhiteSpace(txtDireccion.Text)) { ent.DIRECCION = this.txtDireccion.Text; }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text)) { ent.EMAIL = this.txtEmail.Text; }
            ent.USR_ING = "ADMIN";
            ent.FEC_ING = DateTime.Now;

            int idMutual = (int)blMutual.Insertar(ent).ID_MUTUAL;
            if (idMutual > 0)
            {
                MessageBox.Show("Se registró con éxito la mutual " + ent.NOMBRE + "");
                limpiarAltaMutual();
                Close();

                if (m_frm != null) { m_frm.cargarMutuales(); }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();
            blLabBioquimica.bl_MUTUALEntidad ent = new blLabBioquimica.bl_MUTUALEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la mutual");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.ID_MUTUAL = idModificar;
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text)) { ent.TELEFONO = this.txtTelefono.Text; }
            if (!string.IsNullOrWhiteSpace(txtDireccion.Text)) { ent.DIRECCION = this.txtDireccion.Text; }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text)) { ent.EMAIL = this.txtEmail.Text; }
            ent.USR_MOD = "ADMIN";
            ent.FEC_MOD = DateTime.Now;

            blMutual.Modificar(ent);
            //MessageBox.Show("Se modificó con éxito la mutual " + ent.NOMBRE + "");
            limpiarAltaMutual();
            Close();
            m_frm.cargarMutuales();
        }

        public void traerParaEditar(Int32 p_ID_MUTUAL)
        {
            blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();
            blLabBioquimica.bl_MUTUALEntidad ent = blMutual.BuscarPorPK(p_ID_MUTUAL);

            idModificar = p_ID_MUTUAL;
            this.lblTitulo.Text = "Modificar Mutual";
            this.txtNombre.Text = ent.NOMBRE;
            this.txtTelefono.Text = ent.TELEFONO;
            this.txtDireccion.Text = ent.DIRECCION;
            this.txtEmail.Text = ent.EMAIL;
            this.btnInsertar.Visible = false;
            this.btnGrabar.Visible = true;
        }

        public void limpiarAltaMutual()
        {
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";
            this.txtEmail.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
