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
    public partial class NuevoAnalisis : Form
    {

        private NuevoProtocolo np_frm;
        
        //Constructor sin parametros
        public NuevoAnalisis()
        {
            InitializeComponent();
        }

        //Constructor con parametro del form Nuevo Protocolo
        public NuevoAnalisis(NuevoProtocolo np, String numProtocolo)
        {
            InitializeComponent();
            np_frm = np;
            this.txtProtocolo.Text = numProtocolo;
            cargarComboAnalisis();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (this.cboAnalisis.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el analisis");
                this.cboAnalisis.Focus();
                return;
            }

            this.cboAnalisis.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = true;



            //Cargar los items a la grilla del analisis elegido
            int idAnalisis = int.Parse(this.cboAnalisis.SelectedValue.ToString());

            //CARGAR TODOS LOS ITEMS DEL ANALISIS EN LA GRILLA
            this.dgvItemsAnalisis.Rows.Clear();
            this.dgvItemsAnalisis.Refresh();

            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidadColeccion col = blItem.Buscar(null, idAnalisis, null);

            foreach (blLabBioquimica.bl_ITEMEntidad ent in col)
            {
                dgvItemsAnalisis.Rows.Add(ent.ID_ITEM, ent.NOMBRE);
            }

            //Cargar en base datos protocolo detalle


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cboAnalisis.Enabled = true;
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = false;

            this.dgvItemsAnalisis.Rows.Clear();
            this.dgvItemsAnalisis.Refresh();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargarComp_Click(object sender, EventArgs e)
        {
            //Cargar un items en el analisis seleccionado del data grid view



        }

        private void btnCargarTodos_Click(object sender, EventArgs e)
        {
            //Cargar todos los items en el analisis seleccionado del data grid view



        }
    }
}
