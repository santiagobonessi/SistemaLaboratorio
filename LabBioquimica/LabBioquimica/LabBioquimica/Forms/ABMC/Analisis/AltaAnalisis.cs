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
    public partial class AltaAnalisis : Form
    {
        //Creo una instancia del Form Analisis para actualizar la grilla
        private Analisis a_frm;

        public static Int32 idModificar;

        public AltaAnalisis()
        {
            InitializeComponent();
            this.btnGrabar.Visible = false;
        }

        //Constructor con parámetro del form Analisis
        public AltaAnalisis(Analisis anali)
        {
            InitializeComponent();
            a_frm = anali;
            this.btnGrabar.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
            blLabBioquimica.bl_ANALISISEntidad ent = new blLabBioquimica.bl_ANALISISEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar el código del análisis");
                this.txtCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del análisis");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.CODIGO = this.txtCodigo.Text;
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(this.txtMetodo.Text)) { ent.METODO = this.txtMetodo.Text; }
            if (!string.IsNullOrWhiteSpace(this.txtUnidadBioq.Text)) { ent.UNIDAD_BIOQ = decimal.Parse(this.txtUnidadBioq.Text); }
            ent.USR_ING = "ADMIN";
            ent.FEC_ING = DateTime.Now;

            int idAnalisis = (int)blAnalisis.Insertar(ent).ID_ANALISIS;
            if (idAnalisis > 0)
            {
                MessageBox.Show("Se registró con éxito el analisis " + ent.NOMBRE + "");
                limpiarAltaAnalisis();
                Close();

                if (a_frm != null) { a_frm.cargarAnalisis(); }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
            blLabBioquimica.bl_ANALISISEntidad ent = new blLabBioquimica.bl_ANALISISEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar el código del análisis");
                this.txtCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del análisis");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.ID_ANALISIS = idModificar;
            ent.CODIGO = this.txtCodigo.Text;
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(this.txtMetodo.Text)) { ent.METODO = this.txtMetodo.Text; }
            if (!string.IsNullOrWhiteSpace(this.txtUnidadBioq.Text)) { ent.UNIDAD_BIOQ = decimal.Parse(this.txtUnidadBioq.Text); }
            ent.USR_MOD = "ADMIN";
            ent.FEC_MOD = DateTime.Now;

            blAnalisis.Modificar(ent);

            //MessageBox.Show("Se modificó con éxito el análisis " + ent.NOMBRE + "");
            limpiarAltaAnalisis();
            Close();
            a_frm.cargarAnalisis();
        }

        public void traerParaEditar(Int32 p_ID_ANALISIS)
        {
            blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
            blLabBioquimica.bl_ANALISISEntidad ent = blAnalisis.BuscarPorPK(p_ID_ANALISIS);

            idModificar = p_ID_ANALISIS;
            this.lblTitulo.Text = "Modificar Análisis";
            this.txtCodigo.Text = ent.CODIGO;
            this.txtNombre.Text = ent.NOMBRE;
            this.txtMetodo.Text = ent.METODO;
            this.txtUnidadBioq.Text = ent.UNIDAD_BIOQ.ToString();
            this.btnInsertar.Visible = false;
            this.btnGrabar.Visible = true;

        }

        public void limpiarAltaAnalisis()
        {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtMetodo.Text = "";
            this.txtUnidadBioq.Text = "";
        }

        /// <summary>
        /// Evento que me permite ingresar solo numeros con coma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUnidadBioq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtUnidadBioq.Text.Length; i++)
            {
                if (txtUnidadBioq.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 44)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
