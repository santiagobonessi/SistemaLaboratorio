using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace LabBioquimica.Forms.Transaccion
{
    public partial class NuevoProtocolo : Form
    {
        //Configuracion ruta de acceso a reporte
        private string rutaReporteExamenes = ConfigurationManager.AppSettings["ruta.reporte.examenes"];

        //Id protocolo para manejo dentro de la clase
        private int idProtocoloActual;

        //Variable de la posicion seleccionada en la grilla dgvProtocoloDetalle
        public static Int32 posSelecPD;
        //Variable de la posicion seleccionada en la grilla dgvPracticas
        public static Int32 posSelecPra;

        //Constructor sin parámetros
        public NuevoProtocolo()
        {
            InitializeComponent();
            lblMensaje.Visible = false;
            cargarComboPacientes();
            cargarComboProfesionales();
            this.btnModificar.Enabled = false;
        }

        //Constructor con parámetro de nro protocolo para traer un protocolo a pantalla
        //Es llamado desde el informe Protocolos por paciente
        public NuevoProtocolo(Int32 p_NRO_PROTOCOLO)
        {
            InitializeComponent();
            lblMensaje.Visible = false;
            cargarComboPacientes();
            cargarComboProfesionales();

            //Traer datos del protocolo 
            blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
            blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, p_NRO_PROTOCOLO, null, null, null);
            limpiarBGProtocolo();
            cargarPantalla(col);
        }

        //Evento que se desencadena cuando hago click en la grilla dgvProtocoloDetalle
        private void dgvProtocoloDetalle_MouseClick(object sender, MouseEventArgs e)
        {
            //Click con el boton derecho
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvProtocoloDetalle.HitTest(e.X, e.Y).RowIndex;
                posSelecPD = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvProtocoloDetalle.SelectedRows)
                {
                    dr.Selected = false;
                }

                //Si selecciona un protocolo detalle
                if (position_xy_mouse_row >= 0)
                {
                    dgvProtocoloDetalle.Rows[position_xy_mouse_row].Selected = true;

                    miMenu.Items.Add("Nueva Práctica").Name = "NuevaPractica";
                    miMenu.Items.Add("Eliminar Práctica").Name = "EliminarPractica";
                    miMenu.Items.Add("Agregar o Modificar Items de la Práctica").Name = "AgregarModificarItemsPractica";

                    dgvPracticas.Enabled = true;
                    dgvPracticas.Rows.Clear();
                    dgvPracticas.Refresh();

                    //Cargar Practicas del Protocolo Detalle seleccionado
                    String idPDGrilla = dgvProtocoloDetalle.Rows[posSelecPD].Cells[1].Value.ToString();
                    int idPD = int.Parse(idPDGrilla);

                    blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                    blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);


                    foreach (blLabBioquimica.bl_PRACTICAEntidad entPrac in colPrac)
                    {
                        dgvPracticas.Rows.Add(entPrac.ID_PROTOCOLO_DETALLE, entPrac.ID_PRACTICA, entPrac.ID_ITEM, entPrac.NOMBRE_ITEM, entPrac.RESULTADO, entPrac.VALOR_REF_ITEM, entPrac.NOMBRE_UNIDAD);
                    }

                }
                //Si no selecciona un protocolo detalle
                else
                {
                    dgvPracticas.Rows.Clear();
                    dgvPracticas.Refresh();
                    miMenu.Items.Add("Nueva Práctica").Name = "NuevaPractica";
                }

                miMenu.Show(dgvProtocoloDetalle, new Point(e.X, e.Y));

                //Evento menu click
                miMenu.ItemClicked += new ToolStripItemClickedEventHandler(MiMenu_ItemClicked);

            }
            //Click con el boton izquierdo
            else if (e.Button == MouseButtons.Left)
            {
                //Cargar Practicas del Protocolo Detalle seleccionado
                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvProtocoloDetalle.HitTest(e.X, e.Y).RowIndex;
                posSelecPD = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvProtocoloDetalle.SelectedRows)
                {
                    dr.Selected = false;
                }

                dgvPracticas.Rows.Clear();
                dgvPracticas.Refresh();

                //Si selecciona un protocolo detalle
                if (position_xy_mouse_row >= 0)
                {
                    dgvPracticas.Enabled = true;

                    dgvProtocoloDetalle.Rows[position_xy_mouse_row].Selected = true;

                    //Cargar Practicas del Protocolo Detalle seleccionado
                    String idPDGrilla = dgvProtocoloDetalle.Rows[posSelecPD].Cells[1].Value.ToString();
                    int idPD = int.Parse(idPDGrilla);

                    blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                    blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);

                    foreach (blLabBioquimica.bl_PRACTICAEntidad entPrac in colPrac)
                    {
                        dgvPracticas.Rows.Add(entPrac.ID_PROTOCOLO_DETALLE, entPrac.ID_PRACTICA, entPrac.ID_ITEM, entPrac.NOMBRE_ITEM, entPrac.RESULTADO, entPrac.VALOR_REF_ITEM, entPrac.NOMBRE_UNIDAD);
                    }

                }
            }
        }

        //Evento que se desencadena cuando pulso una tecla en la grilla dgvProtocoloDetalle
        private void dgvProtocoloDetalle_KeyUp(object sender, KeyEventArgs e)
        {
            //Si el analisis seleccionado anteriormente es igual al que se le cargan los componentes
            //se debe agregar la practica, sino no se agrega

            DataGridViewRow filSelec = dgvProtocoloDetalle.CurrentRow;

            foreach (DataGridViewRow dr in dgvProtocoloDetalle.SelectedRows)
            {
                dr.Selected = false;
            }

            dgvPracticas.Rows.Clear();
            dgvPracticas.Refresh();

            //Si selecciona un protocolo detalle
            if (filSelec.Index >= 0)
            {
                dgvPracticas.Enabled = true;

                dgvProtocoloDetalle.Rows[filSelec.Index].Selected = true;

                //Cargar Practicas del Protocolo Detalle seleccionado
                String idPDGrilla = dgvProtocoloDetalle.Rows[filSelec.Index].Cells[1].Value.ToString();
                int idPD = int.Parse(idPDGrilla);

                blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);

                foreach (blLabBioquimica.bl_PRACTICAEntidad entPrac in colPrac)
                {
                    dgvPracticas.Rows.Add(entPrac.ID_PROTOCOLO_DETALLE, entPrac.ID_PRACTICA, entPrac.ID_ITEM, entPrac.NOMBRE_ITEM, entPrac.RESULTADO, entPrac.VALOR_REF_ITEM, entPrac.NOMBRE_UNIDAD);
                }

            }
        }

        //Evento que se desencadena al hacer click en una opcion del menu desplegable de la grilla dgvProtocoloDetalle
        private void MiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Evento seleccionado, para luego realizar la operación necesaria
            String eventoSelec = e.ClickedItem.Name.ToString();

            switch (eventoSelec)
            {
                case "NuevaPractica":
                    
                    String numProtocolo = this.txtNroProtocolo.Text;
                    String paciente = this.cboPaciente.Text;
                    Forms.Transaccion.NuevoAnalisis nuevoAnalisis = new Forms.Transaccion.NuevoAnalisis(this, numProtocolo, paciente);
                    nuevoAnalisis.ShowDialog();
                    nuevoAnalisis.Dispose();
                    break;

                case "EliminarPractica":
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la Practica?", "Eliminar Practica", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Borrar practica
                        blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
                        blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad entPDBaja = new blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad();
                        String idProtocoloBaja = dgvProtocoloDetalle.Rows[posSelecPD].Cells[0].Value.ToString();
                        String idPDBaja = dgvProtocoloDetalle.Rows[posSelecPD].Cells[1].Value.ToString();

                        entPDBaja.ID_PROTOCOLO_DETALLE = int.Parse(idPDBaja);
                        entPDBaja.USR_BAJA = "ADMIN";
                        entPDBaja.FEC_BAJA = DateTime.Now;

                        blProtocoloDet.Baja(entPDBaja);

                        //Actualizar grilla Protocolo Detalle y Practica
                        cargarGrillaPDyP(int.Parse(idProtocoloBaja));

                    }

                    break;

                case "AgregarModificarItemsPractica":

                    
                        blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad entPD = new blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad();

                        String idPDMod = dgvProtocoloDetalle.Rows[posSelecPD].Cells[1].Value.ToString();
                        String idAnalisisMod = dgvProtocoloDetalle.Rows[posSelecPD].Cells[2].Value.ToString();
                        String nomAnalisisMod = dgvProtocoloDetalle.Rows[posSelecPD].Cells[3].Value.ToString();

                        entPD.ID_PROTOCOLO_DETALLE = int.Parse(idPDMod);
                        entPD.ID_ANALISIS = int.Parse(idAnalisisMod);
                        entPD.NOMBRE_ANALISIS = nomAnalisisMod;

                        String numProtocoloMod = this.txtNroProtocolo.Text;
                        String pacienteMod = this.cboPaciente.Text;
                        Forms.Transaccion.NuevoAnalisis modAnalisis = new Forms.Transaccion.NuevoAnalisis(this, numProtocoloMod, pacienteMod, entPD);
                        modAnalisis.ShowDialog();
                        modAnalisis.Dispose();
                    
                    break;

                default:
                    break;
            }

        }

        //Evento que se desencadena cuando hago click en la grilla dgvPracticas
        private void dgvPracticas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvPracticas.HitTest(e.X, e.Y).RowIndex;
                posSelecPra = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvPracticas.SelectedRows)
                {
                    dr.Selected = false;

                }


                if (position_xy_mouse_row >= 0)
                {
                    dgvPracticas.Rows[position_xy_mouse_row].Selected = true;
                    miMenu.Items.Add("Eliminar Item").Name = "EliminarItem";
                }

                miMenu.Show(dgvPracticas, new Point(e.X, e.Y));

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
                    String idPracticaBaja = dgvPracticas.Rows[posSelecPra].Cells[1].Value.ToString();

                    //Borrar Item de la grilla Practica
                    blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                    blLabBioquimica.bl_PRACTICAEntidad entPra = new blLabBioquimica.bl_PRACTICAEntidad();
                    entPra.ID_PRACTICA = int.Parse(idPracticaBaja);
                    entPra.USR_BAJA = "ADMIN";
                    entPra.FEC_BAJA = DateTime.Now;

                    blPractica.Baja(entPra);

                    //Actualizar grilla practica
                    //Carga las Practicas de la primer fila que es la seleccionada inicialmente
                    DataGridViewRow filSelec = dgvProtocoloDetalle.CurrentRow;
                    if (filSelec != null)
                    {
                        dgvPracticas.Rows.Clear();
                        dgvPracticas.Refresh();

                        String idPDGrilla = dgvProtocoloDetalle.Rows[filSelec.Index].Cells[1].Value.ToString();

                        int idPD = int.Parse(idPDGrilla);

                        //Traer datos de la/s practica/s del Protocolo Detalle Seleccionado
                        blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);

                        foreach (blLabBioquimica.bl_PRACTICAEntidad ent in colPrac)
                        {
                            dgvPracticas.Rows.Add(ent.ID_PROTOCOLO_DETALLE, ent.ID_PRACTICA, ent.ID_ITEM, ent.NOMBRE_ITEM, ent.RESULTADO, ent.VALOR_REF_ITEM, ent.NOMBRE_UNIDAD);
                        }

                    }



                    break;

                default:
                    break;
            }
        }

        public void cargarComboPacientes()
        {
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();

            this.cboPaciente.DataSource = null;
            this.cboPaciente.DataSource = blPaciente.dataTablePaciente(null, null, null, null, null);
            this.cboPaciente.ValueMember = "idPaciente";
            this.cboPaciente.DisplayMember = "nomape";
            this.cboPaciente.SelectedIndex = -1;

            // cargo la lista de items para el autocomplete dle combobox
            this.cboPaciente.AutoCompleteCustomSource = AutocompletePaciente();
            this.cboPaciente.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Método para cargar la coleccion de datos para el autocomplete de pacientes
        public AutoCompleteStringCollection AutocompletePaciente()
        {
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            DataTable dt = blPaciente.dataTablePaciente(null, null, null, null, null);

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nomape"]));
            }

            return coleccion;
        }

        public void cargarComboProfesionales()
        {
            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();

            this.cboProfesional.DataSource = null;
            this.cboProfesional.DataSource = blProfesional.dataTableProfesional();
            this.cboProfesional.ValueMember = "idProfesional";
            this.cboProfesional.DisplayMember = "nomape";
            this.cboProfesional.SelectedIndex = -1;

            // cargo la lista de items para el autocomplete del combobox
            this.cboProfesional.AutoCompleteCustomSource = AutocompleteProfesional();
            this.cboProfesional.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboProfesional.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Método para cargar la coleccion de datos para el autocomplete de profesionales
        public AutoCompleteStringCollection AutocompleteProfesional()
        {
            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();
            DataTable dt = blProfesional.dataTableProfesional();
            
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nomape"]));
            }

            return coleccion;
        }

        public void cargarNomApeAltaPaciente(String nomape)
        {
            this.cboPaciente.Text = nomape;
        }

        public void cargarNomApeAltaProfesionales(String nomape)
        {
            this.cboProfesional.Text = nomape;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            Forms.ABMC.AltaPacientes altaPacientes = new Forms.ABMC.AltaPacientes(this);
            altaPacientes.ShowDialog();
            altaPacientes.Dispose();
        }

        private void btnProfesional_Click(object sender, EventArgs e)
        {
            Forms.ABMC.AltaProfesional altaProfesionales = new Forms.ABMC.AltaProfesional(this);
            altaProfesionales.ShowDialog();
            altaProfesionales.Dispose();
        }

        //Insertar los datos del protocolo si es nuevo
        //Modificar datos del protocolo si ya existe
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtNroProtocolo.Text))
            {
                MessageBox.Show("Debe ingresar el número de protocolo");
                this.txtNroProtocolo.Focus();
                return;
            }
            if (this.cboPaciente.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el paciente");
                this.cboPaciente.Focus();
                return;
            }
            if (this.cboProfesional.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el profesional");
                this.cboProfesional.Focus();
                return;
            }
            blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();

            this.gbNuevoProtocolo.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.dgvProtocoloDetalle.Enabled = true;
            this.dgvPracticas.Enabled = true;


            blLabBioquimica.bl_PROTOCOLOEntidad ent = new blLabBioquimica.bl_PROTOCOLOEntidad();

            //Datos
            ent.NRO_PROTOCOLO = int.Parse(this.txtNroProtocolo.Text);
            ent.FECHA = DateTime.Parse(this.dtpFecha.Text);
            ent.ID_PACIENTE = int.Parse(this.cboPaciente.SelectedValue.ToString());
            ent.ID_PROFESIONAL = int.Parse(this.cboProfesional.SelectedValue.ToString());

            if (idProtocoloActual == 0)
            {
                //Insertar nuevo protocolo en base de datos
                int idProtocolo = (int)blProtocolo.Insertar(ent).ID_PROTOCOLO;
                //Guardo el id protocolo utilizado en la pantalla actualmente
                idProtocoloActual = idProtocolo;
            }
            else
            {
                ent.ID_PROTOCOLO = idProtocoloActual;
                ent.USR_MOD = "ADMIN";
                ent.FEC_MOD = DateTime.Now;
                //Modificar protocolo ya existente en base de datos
                blProtocolo.Modificar(ent);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.gbNuevoProtocolo.Enabled = true;
            this.txtNroProtocolo.Enabled = false;
            this.btnAceptar.Enabled = true;
            this.btnModificar.Enabled = false;
        }

        private void txtProtocolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Carga la pantalla NuevoProtocolo completa en base a un protocolo encontrado
        public void cargarPantalla(blLabBioquimica.bl_PROTOCOLOEntidadColeccion col)
        {
            int idProtocolo = 0;

            foreach (blLabBioquimica.bl_PROTOCOLOEntidad ent in col)
            {
                //Guardo el id protocolo utilizado en la pantalla actualmente
                idProtocoloActual = (int)ent.ID_PROTOCOLO;

                idProtocolo = (int)ent.ID_PROTOCOLO;
                this.txtNroProtocolo.Text = ent.NRO_PROTOCOLO.ToString();
                this.dtpFecha.Text = ent.FECHA.ToString();
                this.cboPaciente.Text = ent.N_PACIENTE;
                this.cboProfesional.Text = ent.N_PROFESIONAL;
            }

            this.gbNuevoProtocolo.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.dgvProtocoloDetalle.Enabled = true;

            if (idProtocolo != 0)
            {
                cargarGrillaPDyP(idProtocolo);
            }
        }

        //Metodo que carga los datos en grillas dgvProtocoloDetalle y dgvPracticas con parametro idProtocolo
        public void cargarGrillaPDyP(Int32 p_ID_PROTOCOLO)
        {
            //Limpiar grilla dgvProtocoloDetalle
            dgvProtocoloDetalle.Rows.Clear();
            dgvProtocoloDetalle.Refresh();

            //Traer datos del protocolo detalle
            blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
            blLabBioquimica.bl_PROTOCOLO_DETALLEEntidadColeccion colDet = blProtocoloDet.Buscar(null, p_ID_PROTOCOLO, null);

            int idProtocoloDet = 0;
            foreach (blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad ent in colDet)
            {
                idProtocoloDet = (int)ent.ID_PROTOCOLO_DETALLE;
                dgvProtocoloDetalle.Rows.Add(ent.ID_PROTOCOLO, ent.ID_PROTOCOLO_DETALLE, ent.ID_ANALISIS, ent.NOMBRE_ANALISIS, ent.METODO_ANALISIS, ent.CODIGO_ANALISIS);
            }

            if (idProtocoloDet != 0)
            {
                cargarGrillaPracticas(idProtocoloDet);
            }
            else
            {
                dgvPracticas.Rows.Clear();
                dgvPracticas.Refresh();
            }
        }

        //Metodo que carga los datos de la grilla dgvPracticas
        public void cargarGrillaPracticas(Int32 p_ID_PROTOCOLO_DET)
        {

            //Limpiar grilla dgvPracticas
            dgvPracticas.Rows.Clear();
            dgvPracticas.Refresh();

            dgvPracticas.Enabled = true;

            //Carga las Practicas de la fila seleccionada en la grilla dgvProtocoloDetalle
            DataGridViewRow filSelec = dgvProtocoloDetalle.CurrentRow;
            
            //Si hay una fila seleccionada trae las practicas, sino trae las practicas de la primer fila
            if (filSelec != null)
            {
                

                String idPDGrilla = dgvProtocoloDetalle.Rows[filSelec.Index].Cells[1].Value.ToString();
                int idPD = int.Parse(idPDGrilla);

                //Traer datos de la/s practica/s del Protocolo Detalle Seleccionado
                blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);

                foreach (blLabBioquimica.bl_PRACTICAEntidad ent in colPrac)
                {
                    dgvPracticas.Rows.Add(ent.ID_PROTOCOLO_DETALLE, ent.ID_PRACTICA, ent.ID_ITEM, ent.NOMBRE_ITEM, ent.RESULTADO, ent.VALOR_REF_ITEM, ent.NOMBRE_UNIDAD);
                }

            }
            else
            {
                

                String idPDGrilla = dgvProtocoloDetalle.Rows[0].Cells[1].Value.ToString();
                int idPD = int.Parse(idPDGrilla);

                //Traer datos de la/s practica/s del Protocolo Detalle Seleccionado
                blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);

                if (colPrac.Count > 0)
                {
                    foreach (blLabBioquimica.bl_PRACTICAEntidad ent in colPrac)
                    {
                        dgvPracticas.Rows.Add(ent.ID_PROTOCOLO_DETALLE, ent.ID_PRACTICA, ent.ID_ITEM, ent.NOMBRE_ITEM, ent.RESULTADO, ent.VALOR_REF_ITEM, ent.NOMBRE_UNIDAD);
                    }
                }
                
            }

        }


        //Busqueda de protocolo por nro de protocolo
        private void btnConsultaProtocolo_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtConsultaProtocolo.Text))
            {
                MessageBox.Show("Debe ingresar el número de protocolo a buscar");
                this.txtConsultaProtocolo.Focus();
                return;
            }

            //Traer datos del protocolo por nu numero
            blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
            blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, int.Parse(this.txtConsultaProtocolo.Text), null, null, null);

            //Validar que Nº de Protocolo exista
            if (col.Count > 0)
            {
                //Limpiar Protocolo
                limpiarBGProtocolo();
                cargarPantalla(col);
            }
            else
            {
                MessageBox.Show("Protocolo inexistente");
                this.txtConsultaProtocolo.Focus();
                return;
            }

        }

        public void limpiarBGProtocolo()
        {
            this.gbNuevoProtocolo.Enabled = true;
            this.txtNroProtocolo.Text = "";
            this.dtpFecha.Value = DateTime.Now;
            this.cboPaciente.SelectedIndex = -1;
            this.cboProfesional.SelectedIndex = -1;
            this.btnAceptar.Enabled = true;
            this.btnModificar.Enabled = false;

        }

        public Int32 getProtocoloActual()
        {
            return idProtocoloActual;
        }

        //Metodo utilizado desde el form NuevoAnalisis para cargar una fila de Protocolo Detalle
        public void cargarProtocoloDetalle(Int32 p_ID_PROTOCOLO_DET)    
        {
            //Busco los datos del protocolo detalle
            blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
            blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad entPD = blProtocoloDet.BuscarPorPK(p_ID_PROTOCOLO_DET);

            dgvProtocoloDetalle.Rows.Add(entPD.ID_PROTOCOLO, entPD.ID_PROTOCOLO_DETALLE, entPD.ID_ANALISIS, entPD.NOMBRE_ANALISIS, entPD.METODO_ANALISIS, entPD.CODIGO_ANALISIS);

        }

        //Metodo utilizado desde el form NuevoAnalisis para actualizar grilla dgvPracticas
        public void cargarComponentePractica(Int32 p_ID_PRACTICA)
        {
            dgvPracticas.Enabled = true;

            //Si el analisis seleccionado anteriormente es igual al que se le cargan los componentes
            //se debe agregar la practica, sino no se agrega

            blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
            blLabBioquimica.bl_PRACTICAEntidad entPrac = blPractica.BuscarPorPK(p_ID_PRACTICA);

            DataGridViewRow filSelec = dgvProtocoloDetalle.CurrentRow;

            if (filSelec != null)
            {
                String idPDGrilla = dgvProtocoloDetalle.Rows[filSelec.Index].Cells[1].Value.ToString();
                int idPD = int.Parse(idPDGrilla);
                if (idPD == entPrac.ID_PROTOCOLO_DETALLE)
                {
                    dgvPracticas.Rows.Add(entPrac.ID_PROTOCOLO_DETALLE, entPrac.ID_PRACTICA, entPrac.ID_ITEM, entPrac.NOMBRE_ITEM, entPrac.RESULTADO, entPrac.VALOR_REF_ITEM, entPrac.NOMBRE_UNIDAD);
                }
            }
        }

        //Este evento se desencadena al modificar una celda de la columa Resultado en la grilla dgvPracticas
        private void dgvPracticas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filSelec = dgvPracticas.CurrentRow;
            if (filSelec != null)
            {
                //Agregar el resultado a la Practica modificada
                String idPractica = dgvPracticas.Rows[filSelec.Index].Cells[1].Value.ToString();
                String resultado = dgvPracticas.Rows[filSelec.Index].Cells[4].Value.ToString();

                blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                blLabBioquimica.bl_PRACTICAEntidad entPrac = new blLabBioquimica.bl_PRACTICAEntidad();

                entPrac.ID_PRACTICA = int.Parse(idPractica);
                entPrac.RESULTADO = resultado;
                entPrac.USR_MOD = "ADMIN";
                entPrac.FEC_MOD = DateTime.Now;


                blPractica.ModificarResultado(entPrac);
            }
        }

        //Evento que se desencadena cuando se modifica el texto del txtProtocolo
        private void txtProtocolo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNroProtocolo.Text))
            {
                blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
                //Validar que Nº de Protocolo no esté repetido
                blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, int.Parse(this.txtNroProtocolo.Text), null, null, null);
                if (col.Count > 0)
                {
                    this.lblMensaje.Visible = true;
                    this.txtNroProtocolo.Focus();
                    btnAceptar.Enabled = false;
                }
                else
                {
                    this.lblMensaje.Visible = false;
                    btnAceptar.Enabled = true;
                }
            }
            
        }

        private void NuevoProtocolo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            String idProtocolo = this.idProtocoloActual.ToString();


            //Creamos una instancia del formulario del reporte
            Reportes.RPT_EXAMENES formRPT = new Reportes.RPT_EXAMENES();
            ReportDocument oRep = new ReportDocument();


            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            pf.Name = "@ID_PROTOCOLO"; // variable del store procedure
            pdv.Value = idProtocolo; // variable donde se  guarda el nro de protocolo
            pf.CurrentValues.Add(pdv);
            pfs.Add(pf);
            formRPT.crvExamenes.ParameterFieldInfo = pfs;
            
            oRep.Load(@rutaReporteExamenes.ToString());
            formRPT.crvExamenes.ReportSource = oRep;
            formRPT.Show();
            oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"Nombre_Examenes.pdf");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // TO DO : Limpiar todos los campos, que arranque de cero.
        }
    }
}
