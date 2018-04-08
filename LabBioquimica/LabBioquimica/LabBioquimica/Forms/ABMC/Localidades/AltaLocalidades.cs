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
    public partial class AltaLocalidades : Form
    {
        //Creo una instancia del Form Localidades para actualizar la grilla
        private Localidades l_frm;

        public static Int32 idModificar;

        public AltaLocalidades()
        {
            InitializeComponent();
            this.btnGrabar.Visible = false;
        }

        //Constructor con parámetro del form Localidades
        public AltaLocalidades(Localidades loc)
        {
            InitializeComponent();
            l_frm = loc;
            this.btnGrabar.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_LOCALIDAD blLocalidad = new blLabBioquimica.bl_LOCALIDAD();
            blLabBioquimica.bl_LOCALIDADEnitdad ent = new blLabBioquimica.bl_LOCALIDADEnitdad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la localidad");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(this.txtCodPostal.Text)) { ent.CODPOSTAL = this.txtCodPostal.Text; }
            ent.USR_ING = "ADMIN";
            ent.FEC_ING = DateTime.Now;

            int idLocalidad = (int)blLocalidad.Insertar(ent).ID_LOCALIDAD;
            if (idLocalidad > 0)
            {
                MessageBox.Show("Se registró con éxito la localidad " + ent.NOMBRE + "");
                limpiarAltaLocalidad();
                Close();

                if (l_frm != null) { l_frm.cargarLocalidades(); }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_LOCALIDAD blLocalidad = new blLabBioquimica.bl_LOCALIDAD();
            blLabBioquimica.bl_LOCALIDADEnitdad ent = new blLabBioquimica.bl_LOCALIDADEnitdad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la localidad");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.ID_LOCALIDAD = idModificar;
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(this.txtCodPostal.Text)) { ent.CODPOSTAL = this.txtCodPostal.Text; }
            ent.USR_MOD = "ADMIN";
            ent.FEC_MOD = DateTime.Now;

            blLocalidad.Modificar(ent);

            //MessageBox.Show("Se modificó con éxito la localidad " + ent.NOMBRE + "");
            limpiarAltaLocalidad();
            Close();
            l_frm.cargarLocalidades();

        }

        public void traerParaEditar(Int32 p_ID_LOCALIDAD)
        {
            blLabBioquimica.bl_LOCALIDAD blLocalidad = new blLabBioquimica.bl_LOCALIDAD();
            blLabBioquimica.bl_LOCALIDADEnitdad ent = blLocalidad.BuscarPorPK(p_ID_LOCALIDAD);

            idModificar = p_ID_LOCALIDAD;
            this.lblTitulo.Text = "Modificar Localidad";
            this.txtNombre.Text = ent.NOMBRE;
            this.txtCodPostal.Text = ent.CODPOSTAL;
            this.btnInsertar.Visible = false;
            this.btnGrabar.Visible = true;

        }

        public void limpiarAltaLocalidad()
        {
            this.txtNombre.Text = "";
            this.txtCodPostal.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
