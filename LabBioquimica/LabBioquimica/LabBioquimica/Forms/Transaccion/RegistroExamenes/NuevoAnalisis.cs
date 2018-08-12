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

        public static Int32 posSelec;

        public static Int32 idProtocoloDetActual;

        private NuevoProtocolo np_frm;
        
        //Constructor sin parametros
        public NuevoAnalisis()
        {
            InitializeComponent();
        }

        //Constructor con parametro del form Nuevo Protocolo
        public NuevoAnalisis(NuevoProtocolo np, String numProtocolo, String paciente)
        {
            InitializeComponent();
            np_frm = np;
            this.txtProtocolo.Text = numProtocolo;
            this.txtPaciente.Text = paciente;
            cargarComboAnalisis();
        }

        //Constructor con parametros del form Nuevo Protocolo
        //Se llama a este constructor cuando ya existe el Protocolo Detalle
        public NuevoAnalisis(NuevoProtocolo np, String numProtocolo, String paciente, blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad ent)
        {
            InitializeComponent();
            np_frm = np;
            cargarComboAnalisis();
            this.txtProtocolo.Text = numProtocolo;
            this.txtPaciente.Text = paciente;
            this.cboAnalisis.Text = ent.NOMBRE_ANALISIS;
            this.cboAnalisis.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = true;
            this.dgvItemsAnalisis.Enabled = true;

            idProtocoloDetActual = (int)ent.ID_PROTOCOLO_DETALLE;

            cargarPracticasPDExistente();
        }

        public void cargarPracticasPDExistente()
        {
            //Cargar los items a la grilla del analisis elegido
            int idAnalisis = int.Parse(this.cboAnalisis.SelectedValue.ToString());

            //CARGAR TODOS LOS ITEMS DEL ANALISIS EN LA GRILLA
            this.dgvItemsAnalisis.Rows.Clear();
            this.dgvItemsAnalisis.Refresh();

            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidadColeccion col = blItem.Buscar(null, idAnalisis, null);

            foreach (blLabBioquimica.bl_ITEMEntidad ent in col)
            {
                dgvItemsAnalisis.Rows.Add(ent.ID_ITEM, ent.NOMBRE, ent.VALOR_REF);
            }



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
            this.dgvItemsAnalisis.Enabled = true;

            //Cargar los items a la grilla del analisis elegido
            int idAnalisis = int.Parse(this.cboAnalisis.SelectedValue.ToString());

            //CARGAR TODOS LOS ITEMS DEL ANALISIS EN LA GRILLA
            this.dgvItemsAnalisis.Rows.Clear();
            this.dgvItemsAnalisis.Refresh();

            blLabBioquimica.bl_ITEM blItem = new blLabBioquimica.bl_ITEM();
            blLabBioquimica.bl_ITEMEntidadColeccion col = blItem.Buscar(null, idAnalisis, null);

            foreach (blLabBioquimica.bl_ITEMEntidad ent in col)
            {
                dgvItemsAnalisis.Rows.Add(ent.ID_ITEM, ent.NOMBRE, ent.VALOR_REF);
            }

            //Cargar en base datos protocolo detalle
            blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
            blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad entPD = new blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad();

            //Datos
            entPD.ID_PROTOCOLO = np_frm.getProtocoloActual();
            entPD.ID_ANALISIS = int.Parse(this.cboAnalisis.SelectedValue.ToString());
            entPD.USR_ING = "ADMIN";
            entPD.FEC_ING = DateTime.Now;

            idProtocoloDetActual = (int)blProtocoloDet.Insertar(entPD).ID_PROTOCOLO_DETALLE;

            //Cargar el protocolo detalle en la grilla de la pantalla Nuevo Protocolo
            np_frm.cargarProtocoloDetalle(idProtocoloDetActual);

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

        private void dgvItemsAnalisis_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvItemsAnalisis.HitTest(e.X, e.Y).RowIndex;
                posSelec = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvItemsAnalisis.SelectedRows)
                {
                    dr.Selected = false;
                }


                if (position_xy_mouse_row >= 0)
                {
                    dgvItemsAnalisis.Rows[position_xy_mouse_row].Selected = true;
                    miMenu.Items.Add("Cargar Componente").Name = "Cargar Componente";
                    miMenu.Items.Add("Cargar Todos").Name = "Cargar Todos";
                }
                else
                {
                    miMenu.Items.Add("Cargar Todos").Name = "Cargar Todos";
                }

                miMenu.Show(dgvItemsAnalisis, new Point(e.X, e.Y));

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
                case "Cargar Componente":

                    //Cargar  Componente Practica
                    String idItemGrilla = dgvItemsAnalisis.Rows[posSelec].Cells[0].Value.ToString();
                    int idItem = int.Parse(idItemGrilla);
                    if (existeItemEnPractica(idItem ) == true)
                    {
                        //No lo cargo si ya existe
                        MessageBox.Show("Ya se encuentra cargado ese Item", "Aviso");
                    }
                    else
                    {
                        cargarComponentePractica(idItem);
                    }
                    
                    break;

                case "Cargar Todos":
                    //Cargar Todos los Componentes de Practica
                    cargarTodosComponentesPractica();
                    break;

                default:
                    break;
            }
        }

        public bool existeItemEnPractica(Int32 p_ID_ITEM)
        {

            blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
            blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idProtocoloDetActual, null);

            foreach (blLabBioquimica.bl_PRACTICAEntidad ent in colPrac)
            {
                //Ya se encuentra cargada la Practica con ese Item
                if (ent.ID_ITEM == p_ID_ITEM)
                {
                    return true;
                }
            }

            return false;
        }

        public void cargarComponentePractica(Int32 p_ID_ITEM)
        {

            //Cargar Practica en base de datos
            blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
            blLabBioquimica.bl_PRACTICAEntidad entPrac = new blLabBioquimica.bl_PRACTICAEntidad();

            //Datos
            entPrac.ID_PROTOCOLO_DETALLE = idProtocoloDetActual;
            entPrac.ID_ITEM = p_ID_ITEM;

            int idPractica = (int)blPractica.Insertar(entPrac).ID_PRACTICA;

            np_frm.cargarComponentePractica(idPractica);

        }

        public void cargarTodosComponentesPractica()
        {

            //Cargar Practicas en base de datos
            blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
            blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idProtocoloDetActual, null);

            Boolean existe = false;
            //Insertar las Practicas(items) que no estén en el Protocolo Detalle seleccionado
            for (int i = 0; i < dgvItemsAnalisis.Rows.Count; i++)
            {
                int idItem = 0;
                existe = false;
                idItem = int.Parse(dgvItemsAnalisis.Rows[i].Cells[0].Value.ToString());

                foreach (blLabBioquimica.bl_PRACTICAEntidad ent in colPrac)  
                {
                    
                    if (ent.ID_ITEM == idItem)
                    {
                        existe = true;
                    }
                }

                if (existe == false) 
                {
                    //Cargar Practicas en base de datos
                    blLabBioquimica.bl_PRACTICAEntidad entPrac = new blLabBioquimica.bl_PRACTICAEntidad();
                    
                    //Datos
                    entPrac.ID_PROTOCOLO_DETALLE = idProtocoloDetActual;
                    entPrac.ID_ITEM = idItem;

                    int idPractica = (int)blPractica.Insertar(entPrac).ID_PRACTICA;

                    np_frm.cargarComponentePractica(idPractica);
                }

                
            }
            

        }



    }
}
