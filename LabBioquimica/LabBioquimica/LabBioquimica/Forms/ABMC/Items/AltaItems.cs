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
    public partial class AltaItems : Form
    {
        //Creo una instancia del Form Items para actualizar la grilla
        private Items i_frm;

        public static Int32 idModificar;

        //Constructor sin parámetros
        public AltaItems()
        {
            InitializeComponent();

            cargarComboAnalisis();
            cargarComboUnidad();
            this.btnGrabar.Visible = false;
        }

        //Constructor con parámetro del form Profesionales
        public AltaItems(Items it)
        {
            InitializeComponent();
            i_frm = it;

            cargarComboAnalisis();
            cargarComboUnidad();
            this.btnGrabar.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidad ent = new blLabBioquimica.bl_ITEMEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del item");
                this.txtNombre.Focus();
                return;
            }
            if (this.cboAnalisis.SelectedValue == null)
            {
                MessageBox.Show("Debe ingresar el analisis al cual pertenece el item");
                this.cboAnalisis.Focus();
                return;
            }

            //Datos
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(txtValorRef.Text)) { ent.VALOR_REF = this.txtValorRef.Text; }
            ent.ID_ANALISIS = int.Parse(this.cboAnalisis.SelectedValue.ToString());
            if (this.cboUnidad.SelectedValue.ToString() != "0")
            {
                ent.ID_UNIDAD = int.Parse(this.cboUnidad.SelectedValue.ToString());
            }


            ent.USR_ING = "ADMIN";
            ent.FEC_ING = DateTime.Now;

            int idItem = (int)blItem.Insertar(ent).ID_ITEM;
            if (idItem > 0)
            {
                MessageBox.Show("Se registró con éxito el item " + ent.NOMBRE + "");
                limpiarAltaItems();
                Close();

                if (i_frm != null) { i_frm.cargarItems(); }
            }

        }

        public void traerParaEditar(Int32 p_ID_ITEM)
        {

            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidad ent = blItem.BuscarPorPK(p_ID_ITEM);

            idModificar = p_ID_ITEM;
            this.lblTitulo.Text = "Modificar Item";
            this.txtNombre.Text = ent.NOMBRE;
            this.txtValorRef.Text = ent.VALOR_REF;
            this.cboAnalisis.Text = ent.N_ANALISIS;
            if (ent.ID_UNIDAD != null) { this.cboUnidad.Text = ent.N_UNIDAD; }
            else { this.cboUnidad.SelectedIndex = 0; }
            
            this.btnInsertar.Visible = false;
            this.btnGrabar.Visible = true;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidad ent = new blLabBioquimica.bl_ITEMEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del item");
                this.txtNombre.Focus();
                return;
            }
            if (this.cboAnalisis.SelectedValue == null)
            {
                MessageBox.Show("Debe ingresar el analisis al cual pertenece el item");
                this.cboAnalisis.Focus();
                return;
            }


            //Datos
            ent.ID_ITEM = idModificar;
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(txtValorRef.Text)) { ent.VALOR_REF = this.txtValorRef.Text; }
            ent.ID_ANALISIS = int.Parse(this.cboAnalisis.SelectedValue.ToString());
            if (this.cboUnidad.SelectedValue.ToString() != "0")
            {
                ent.ID_UNIDAD = int.Parse(this.cboUnidad.SelectedValue.ToString());
            }

            ent.USR_MOD = "ADMIN";
            ent.FEC_MOD = DateTime.Now;

            blItem.Modificar(ent);
            //MessageBox.Show("Se modificó con éxito el item " + ent.NOMBRE + "");
            limpiarAltaItems();
            Close();
            i_frm.cargarItems();
        }


        public void limpiarAltaItems()
        {
            this.txtNombre.Text = "";
            this.txtValorRef.Text = "";
            this.cboAnalisis.SelectedIndex = -1;
            this.cboUnidad.SelectedIndex = -1;
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

        public void cargarComboUnidad()
        {
            blLabBioquimica.bl_UNIDAD blUnidad = new blLabBioquimica.bl_UNIDAD();

            DataTable dt = blUnidad.dataTableUnidad();
            DataRow nuevaFila = dt.NewRow();

            nuevaFila["idUnidad"] = 0;
            nuevaFila["nombre"] = "--SELECCIONE--";
            dt.Rows.InsertAt(nuevaFila, 0);

            this.cboUnidad.DataSource = null;
            this.cboUnidad.DataSource = dt;
            this.cboUnidad.ValueMember = "idUnidad";
            this.cboUnidad.DisplayMember = "nombre";
            this.cboUnidad.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
