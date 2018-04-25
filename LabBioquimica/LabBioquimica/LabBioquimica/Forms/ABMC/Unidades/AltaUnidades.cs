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
    public partial class AltaUnidades : Form
    {

        //Creo una instancia del Form Unidades para actualizar la grilla
        private Unidades u_frm;

        //Creo una instancia del Form Item para llamar el alta desde la pantalla Items
        private AltaItems i_frm;

        public static Int32 idModificar;

        public AltaUnidades()
        {
            InitializeComponent();
        }

        //Constructor con parámetro del form Unidades
        public AltaUnidades(Unidades unid)
        {
            InitializeComponent();
            u_frm = unid;
            this.btnGrabar.Visible = false;
        }

        //Constructor con parámetro del form Items
        public AltaUnidades(AltaItems nuevoI)
        {
            InitializeComponent();
            i_frm = nuevoI;
            this.btnGrabar.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_UNIDAD blUnidad = new blLabBioquimica.bl_UNIDAD();
            blLabBioquimica.bl_UNIDADEntidad ent = new blLabBioquimica.bl_UNIDADEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la unidad");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.NOMBRE = this.txtNombre.Text;
            ent.USR_ING = "ADMIN";
            ent.FEC_ING = DateTime.Now;

            int idUnidad = (int)blUnidad.Insertar(ent).ID_UNIDAD;
            if (idUnidad > 0)
            {
                MessageBox.Show("Se registró con éxito la unidad " + ent.NOMBRE + "");
                limpiarAltaUnidad();
                Close();

                if (u_frm != null) { u_frm.cargarUnidades(); }
                if (i_frm != null)
                {
                    i_frm.cargarComboUnidad();
                    i_frm.cargarNomAltaUnidad(ent.NOMBRE);
                }
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_UNIDAD blUnidad = new blLabBioquimica.bl_UNIDAD();
            blLabBioquimica.bl_UNIDADEntidad ent = new blLabBioquimica.bl_UNIDADEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la unidad");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.ID_UNIDAD = idModificar;
            ent.NOMBRE = this.txtNombre.Text;
            ent.USR_MOD = "ADMIN";
            ent.FEC_MOD = DateTime.Now;

            blUnidad.Modificar(ent);

            //MessageBox.Show("Se modificó con éxito la unidad " + ent.NOMBRE + "");
            limpiarAltaUnidad();
            Close();
            if (u_frm != null) { u_frm.cargarUnidades(); }
            if (i_frm != null)
            {
                i_frm.cargarComboUnidad();
                i_frm.cargarNomAltaUnidad(ent.NOMBRE);
            }

        }

        public void traerParaEditar(Int32 p_ID_UNIDAD)
        {
            blLabBioquimica.bl_UNIDAD blUnidad = new blLabBioquimica.bl_UNIDAD();
            blLabBioquimica.bl_UNIDADEntidad ent = blUnidad.BuscarPorPK(p_ID_UNIDAD);

            idModificar = p_ID_UNIDAD;
            this.lblTitulo.Text = "Modificar Unidad";
            this.txtNombre.Text = ent.NOMBRE;
            this.btnInsertar.Visible = false;
            this.btnGrabar.Visible = true;

        }

        public void limpiarAltaUnidad()
        {
            this.txtNombre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
