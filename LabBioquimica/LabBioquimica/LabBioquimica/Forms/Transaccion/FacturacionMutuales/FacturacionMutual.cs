﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBioquimica.Forms.Transaccion.FacturacionMutuales
{
    public partial class FacturacionMutual : Form
    {
        //Variable del id  de FacturacionMutual usado actualmente.
        public static int idFacturacionMutualActual = 0;  

        //Variable de la posicion seleccionada en la grilla dgvProtocolosXPaciente
        public static int posSelecPP;

        //Variable de la posicion seleccionada en la grilla dgvPacientesXAnalisisFacturados
        public static int posSelecFO;


        public FacturacionMutual()
        {
            InitializeComponent();
            cargarComboMutual();
            cargarComboMes();
            this.txtAnioFacturacion.Text = DateTime.Now.Year.ToString();

        }

        //Constructor con parámetro de id facturacion mutual para traer una facturacion a pantalla
        //Es llamado desde el informe Facturacion por mutuales
        public FacturacionMutual(Nullable<Int32> p_ID_FACTURACION_MUTUAL)
        {
            InitializeComponent();
            cargarComboMutual();
            cargarComboMes();
            this.txtAnioFacturacion.Text = DateTime.Now.Year.ToString();

            cargarPantallaFacturacionMutual(p_ID_FACTURACION_MUTUAL);

        }

        //Cargar datos de una facturacion mutual ya creada
        public void cargarPantallaFacturacionMutual(Nullable<Int32> p_ID_FACTURACION_MUTUAL)
        {
            try
            {
                //Traer datos de la facturacion
                blLabBioquimica.bl_FACTURACION_MUTUAL blFacturacionMutual = new blLabBioquimica.bl_FACTURACION_MUTUAL();
                blLabBioquimica.bl_FACTURACION_MUTUALEntidad entFacturacionMutual = blFacturacionMutual.BuscarPorPK(p_ID_FACTURACION_MUTUAL);

                if (entFacturacionMutual != null)
                {
                    //Carga de datos Informacion General 
                    this.gbInfoMutual.Enabled = false;
                    this.cboMutual.Text = entFacturacionMutual.N_MUTUAL;
                    this.cboMesFact.Text = entFacturacionMutual.N_FACTURACION_MES;
                    this.txtAnioFacturacion.Text = entFacturacionMutual.ANIO.ToString();
                    this.txtPrecioUnidBioq.Text = entFacturacionMutual.PRECIO_UNID_BIOQ.ToString();

                    int filaSelec = this.cboMutual.SelectedIndex;
                    String valueMember = this.cboMutual.ValueMember.ToString();

                    if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboMutual.SelectedValue != null)
                    {

                        this.gbInfoMutual.Enabled = false;
                        this.gbPacientesAdheridos.Enabled = true;

                        //Llenar el combo box con los pacientes adheridos a la mutual seleccionada
                        int idMutual = int.Parse(this.cboMutual.SelectedValue.ToString());
                        blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();

                        this.cboPacientesAdheridos.SelectedIndex = -1;
                        this.cboPacientesAdheridos.DataSource = null;
                        this.cboPacientesAdheridos.DataSource = blPaciente.dataTablePaciente(null, null, null, null, idMutual);
                        this.cboPacientesAdheridos.ValueMember = "idPaciente";
                        this.cboPacientesAdheridos.DisplayMember = "nomape";


                        //Cargo la lista de items para el autocomplete del combobox
                        this.cboPacientesAdheridos.AutoCompleteCustomSource = AutocompletePaciente();
                        this.cboPacientesAdheridos.AutoCompleteMode = AutoCompleteMode.Suggest;
                        this.cboPacientesAdheridos.AutoCompleteSource = AutoCompleteSource.CustomSource;

                        idFacturacionMutualActual = (int)p_ID_FACTURACION_MUTUAL;

                        blLabBioquimica.bl_FACTURACION_ORDEN blFacturacionOrden = new blLabBioquimica.bl_FACTURACION_ORDEN();
                        blLabBioquimica.bl_FACTURACION_ORDENEntidadColeccion colFO  = blFacturacionOrden.Buscar(null, idFacturacionMutualActual, null);

                        //Recorro las ordenes para la faturacion mutual
                        foreach (var entFO in colFO)
                        {
                            blLabBioquimica.bl_FACTURACION_ANALISIS blFacturacionAnalisis = new blLabBioquimica.bl_FACTURACION_ANALISIS();
                            blLabBioquimica.bl_FACTURACION_ANALISISEntidadColeccion colFA = blFacturacionAnalisis.Buscar(null, entFO.ID_FACTURACION_ORDEN, null);

                            string cadenaCodigos = "";
                            decimal cantUnidBioq = 0;

                            //Recorro las facturaciones analisis para cada orden
                            foreach (var entFA in colFA)
                            {
                                cadenaCodigos += entFA.CODIGO_ANALISIS + " - ";
                                cantUnidBioq += (decimal) entFA.UNIDAD_BIOQ_ANALSIS;
                            }

                            decimal subtotal = Math.Round(cantUnidBioq * (decimal) entFacturacionMutual.PRECIO_UNID_BIOQ, 2);
                            decimal total = 0;
                            if (this.txtTotalFacturacion.Text == "")
                            {
                                total = subtotal;
                            }
                            else
                            {
                                decimal totalAnterior = decimal.Parse(this.txtTotalFacturacion.Text);
                                total = Math.Round(totalAnterior + subtotal, 2);
                            }
                            this.txtTotalFacturacion.Text = total.ToString();

                            dgvPacientesXAnalisisFacturados.Rows.Add(entFO.ID_FACTURACION_ORDEN, entFO.N_PACIENTE, cadenaCodigos, cantUnidBioq.ToString(), subtotal.ToString());

                        }


                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cargarComboMutual()
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

        public void cargarComboMes()
        {
          
            blLabBioquimica.bl_FACTURACION_MES blFacturacionMes = new blLabBioquimica.bl_FACTURACION_MES();

            DataTable dt = blFacturacionMes.dataTableFacturacionMes();
            DataRow nuevaFila = dt.NewRow();

            nuevaFila["idFacturacionMes"] = 0;
            nuevaFila["nombre"] = "--SELECCIONE--";
            dt.Rows.InsertAt(nuevaFila, 0);

            this.cboMesFact.DataSource = null;
            this.cboMesFact.DataSource = dt;
            this.cboMesFact.ValueMember = "idFacturacionMes";
            this.cboMesFact.DisplayMember = "nombre";
            this.cboMesFact.SelectedIndex = 0;

        }

        
        private void btnAceptarMutual_Click(object sender, EventArgs e)
        {
            //Busca todos los pacientes que esten adheridos a la mutual seleccionada
            try
            {
                //Verifico que complete los campos.
                if (this.txtPrecioUnidBioq.Text == "") { return; }
                if(this.cboMesFact.SelectedIndex == 0) { return; }

                int filaSelec = this.cboMutual.SelectedIndex;
                String valueMember = this.cboMutual.ValueMember.ToString();

                if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboMutual.SelectedValue != null)
                {
                   
                    this.gbInfoMutual.Enabled = false;
                    this.gbPacientesAdheridos.Enabled = true;

                    //Llenar el combo box con los pacientes adheridos a la mutual seleccionada
                    int idMutual = int.Parse(this.cboMutual.SelectedValue.ToString());
                    blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();

                    this.cboPacientesAdheridos.SelectedIndex = -1;
                    this.cboPacientesAdheridos.DataSource = null;
                    this.cboPacientesAdheridos.DataSource = blPaciente.dataTablePaciente(null, null, null, null, idMutual);
                    this.cboPacientesAdheridos.ValueMember = "idPaciente";
                    this.cboPacientesAdheridos.DisplayMember = "nomape";
                    

                    //Cargo la lista de items para el autocomplete del combobox
                    this.cboPacientesAdheridos.AutoCompleteCustomSource = AutocompletePaciente();
                    this.cboPacientesAdheridos.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboPacientesAdheridos.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    if (idFacturacionMutualActual == 0)
                    {
                        //Insertar FacturacionMutual en base de datos
                        blLabBioquimica.bl_FACTURACION_MUTUAL blFactMutual = new blLabBioquimica.bl_FACTURACION_MUTUAL();
                        blLabBioquimica.bl_FACTURACION_MUTUALEntidad ent = new blLabBioquimica.bl_FACTURACION_MUTUALEntidad();

                        ent.ID_MUTUAL = idMutual;
                        ent.ID_FACTURACION_MES = int.Parse(this.cboMesFact.SelectedValue.ToString());
                        ent.ANIO = int.Parse(this.txtAnioFacturacion.Text);
                        ent.PRECIO_UNID_BIOQ = decimal.Parse(this.txtPrecioUnidBioq.Text);
                        ent.USR_ING = "ADMIN";
                        ent.FEC_ING = DateTime.Now;

                        int idFacturacionMutual = (int)blFactMutual.Insertar(ent).ID_FACTURACION_MUTUAL;
                        idFacturacionMutualActual = idFacturacionMutual;
                    }                    

                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para cargar la coleccion de datos para el autocomplete de pacientes
        public AutoCompleteStringCollection AutocompletePaciente()
        {
            try
            {
                int idMutual = int.Parse(this.cboMutual.SelectedValue.ToString());

                blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
                DataTable dt = blPaciente.dataTablePaciente(null, null, null, null, idMutual);

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                //recorrer y cargar los items para el autocompletado
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["nomape"]));
                }

                return coleccion;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void cboPacientesAdheridos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Limpio la grilla de analisis por protocolo
                this.dgvAnalisisXProtocolo.Rows.Clear();

                int filaSelec = this.cboPacientesAdheridos.SelectedIndex;
                String valueMember = this.cboPacientesAdheridos.ValueMember.ToString();
               
                    if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboPacientesAdheridos.SelectedValue != null)
                    {

                        int idPaciente = int.Parse(this.cboPacientesAdheridos.SelectedValue.ToString());

                        this.dgvProtocolosXPaciente.Rows.Clear();
                        this.dgvProtocolosXPaciente.Refresh();

                        blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
                        blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, null, null, idPaciente, null);

                        foreach (blLabBioquimica.bl_PROTOCOLOEntidad ent in col)
                        {
                            dgvProtocolosXPaciente.Rows.Add(ent.ID_PROTOCOLO, ent.NRO_PROTOCOLO, ent.FECHA.Value.ToShortDateString(), ent.N_PROFESIONAL);
                        }

                        //Saco el select de la primer fila por defecto en la grilla
                        foreach (DataGridViewRow dr in dgvProtocolosXPaciente.SelectedRows)
                        {
                            dr.Selected = false;
                        }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvProtocolosXPaciente_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Cargar Practicas del Protocolo Detalle seleccionado
                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvProtocolosXPaciente.HitTest(e.X, e.Y).RowIndex;
                posSelecPP = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvProtocolosXPaciente.SelectedRows)
                {
                    dr.Selected = false;
                }

                dgvAnalisisXProtocolo.Rows.Clear();
                dgvAnalisisXProtocolo.Refresh();

                //Si selecciona un protocolo detalle
                if (position_xy_mouse_row >= 0)
                {
                    dgvAnalisisXProtocolo.Enabled = true;

                    dgvProtocolosXPaciente.Rows[position_xy_mouse_row].Selected = true;

                    //Cargar Practicas del Protocolo Detalle seleccionado
                    String idProtGrilla = dgvProtocolosXPaciente.Rows[posSelecPP].Cells[0].Value.ToString();
                    int idProt = int.Parse(idProtGrilla);

                    //Traer datos del protocolo detalle
                    blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
                    blLabBioquimica.bl_PROTOCOLO_DETALLEEntidadColeccion colDet = blProtocoloDet.Buscar(null, idProt, null);

                    
                    foreach (blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad ent in colDet)
                    {
                        dgvAnalisisXProtocolo.Rows.Add(ent.ID_PROTOCOLO, ent.ID_PROTOCOLO_DETALLE, ent.ID_ANALISIS, ent.NOMBRE_ANALISIS, ent.METODO_ANALISIS, ent.CODIGO_ANALISIS, ent.UNIDAD_BIOQ_ANALISIS);
                    }

                }
            }
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            string cadenaCodigos = "";
            decimal cantUnidBioq = 0;
            decimal precioUnidBioq = decimal.Parse(this.txtPrecioUnidBioq.Text);

            bool checkActoBioquimico = this.chActoBioquimico.Checked;
            string codigoActoBioquimico = "660001";

            int idPaciente = int.Parse(this.cboPacientesAdheridos.SelectedValue.ToString());
            string nomapePaciente = this.cboPacientesAdheridos.Text;

            int idFacturacionOrden = 0;

            if (idFacturacionMutualActual != 0 && idPaciente != 0)
            {
                //Insertar en base de datos FacturacionOrden
                blLabBioquimica.bl_FACTURACION_ORDEN blFacturacionOrden = new blLabBioquimica.bl_FACTURACION_ORDEN();
                blLabBioquimica.bl_FACTURACION_ORDENEntidad entFO = new blLabBioquimica.bl_FACTURACION_ORDENEntidad();
                entFO.ID_FACTURACION_MUTUAL = idFacturacionMutualActual;
                entFO.ID_PACIENTE = idPaciente;
                entFO.USR_ING = "ADMIN";
                entFO.FEC_ING = DateTime.Now;

                idFacturacionOrden = (int) blFacturacionOrden.Insertar(entFO).ID_FACTURACION_ORDEN;
            }

            //Insertar en base de datos FacturacionAnalisis  
            blLabBioquimica.bl_FACTURACION_ANALISIS blFacturacionAnalisis = new blLabBioquimica.bl_FACTURACION_ANALISIS();
            blLabBioquimica.bl_FACTURACION_ANALISISEntidad entFA = new blLabBioquimica.bl_FACTURACION_ANALISISEntidad();

            //Agrego al incio el analisis ACTO BIOQUIMICO
            if (checkActoBioquimico)
            {
                //Consultar por analisis ACTO BIOQUIMICO.
                blLabBioquimica.bl_ANALISIS blAnalisis = new blLabBioquimica.bl_ANALISIS();
                blLabBioquimica.bl_ANALISISEntidad entAnalisis = blAnalisis.BuscarPorCodigo(codigoActoBioquimico);

                if (entAnalisis != null)
                {
                    cadenaCodigos += entAnalisis.CODIGO + " - ";
                    cantUnidBioq = (decimal)entAnalisis.UNIDAD_BIOQ;

                    //Insertar en base de datos FacturacionAnalisis
                    if (idFacturacionOrden != 0)
                    {
                        entFA.ID_ANALISIS = entAnalisis.ID_ANALISIS;
                        entFA.ID_FACTURACION_ORDEN = idFacturacionOrden;
                        entFA.USR_ING = "ADMIN";
                        entFA.FEC_ING = DateTime.Now;

                        int idFacturacionAnalisis = (int)blFacturacionAnalisis.Insertar(entFA).ID_FACTURACION_ANALISIS;
                    }
                }
            }

            //Recorro los analisis seleccionados
            foreach (DataGridViewRow row in dgvAnalisisXProtocolo.Rows)
            {
                if (row.Cells[7].Value != null)
                { 
                    string codigo = "";
                    decimal unidadBioq = 0;

                    //Filtro por los checks seleccionados
                    if (row.Cells[7].Value.Equals(true))//Columna de checks
                    {
                     //Guardo en la grilla dgvPacientesXAnalisisFacturados los analisis
                     codigo = row.Cells[5].Value.ToString();
                     cadenaCodigos += codigo + " - ";

                         if (row.Cells[6].Value.ToString() != "")
                         {
                            unidadBioq = decimal.Parse(row.Cells[6].Value.ToString());
                            cantUnidBioq += unidadBioq;

                            if (idFacturacionOrden != 0)
                            {
                                //Insertar en base de datos FacturacionAnalisis
                                entFA.ID_ANALISIS = int.Parse(row.Cells[2].Value.ToString());
                                entFA.ID_FACTURACION_ORDEN = idFacturacionOrden;
                                entFA.USR_ING = "ADMIN";
                                entFA.FEC_ING = DateTime.Now;

                                int idFacturacionAnalisis = (int)blFacturacionAnalisis.Insertar(entFA).ID_FACTURACION_ANALISIS;
                            }
                        }
                    }

                    

                }
                
            }
            
            decimal subtotal = Math.Round(cantUnidBioq * precioUnidBioq, 2);
            decimal total = 0;
            if (this.txtTotalFacturacion.Text == "")
            {
                total = subtotal;
            }
            else
            {
                decimal totalAnterior = decimal.Parse(this.txtTotalFacturacion.Text);
                total = Math.Round(totalAnterior + subtotal, 2);
            }
            this.txtTotalFacturacion.Text = total.ToString();

            dgvPacientesXAnalisisFacturados.Rows.Add(idFacturacionOrden, nomapePaciente, cadenaCodigos, cantUnidBioq.ToString(), subtotal.ToString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar todos los campos
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            this.gbInfoMutual.Enabled = true;
            this.cboMutual.SelectedIndex = 0;
            this.cboMesFact.SelectedIndex = 0;
            this.txtAnioFacturacion.Text = DateTime.Now.Year.ToString();
            this.txtPrecioUnidBioq.Text = "";

            this.cboPacientesAdheridos.Text = "";
            this.dgvProtocolosXPaciente.Rows.Clear();
            this.dgvAnalisisXProtocolo.Rows.Clear();
            this.dgvPacientesXAnalisisFacturados.Rows.Clear();
            this.txtTotalFacturacion.Text = "";

        }

        /// <summary>
        /// Metodo que exporta a excel los datos de facturacion de mutuales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvPacientesXAnalisisFacturados);
        }

        /// <summary>
        /// Método que exporta a un fichero Excel el contenido de un DataGridView.
        /// </summary>
        /// <param name="dgv">DataGridView que contiene los datos a exportar</param>
        private void ExportarDataGridViewExcel(DataGridView dgv)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo = aplicacion.Workbooks.Add();
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    hoja_trabajo.Name = this.cboMesFact.Text +" "+ this.txtAnioFacturacion.Text;

                    hoja_trabajo.Cells[1, 1] = "FACTURACIÓN " + this.cboMutual.Text + " " + this.cboMesFact.Text + " " + this.txtAnioFacturacion.Text;

                    //Cargar cabecera
                    for (int j = 1; j < dgv.ColumnCount; j++)
                    {
                        hoja_trabajo.Cells[2, j] = dgv.Columns[j].HeaderText.ToUpper();
                    }

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 1; j < dgv.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 3, j] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    hoja_trabajo.Cells[dgv.Rows.Count + 3, 3] = "TOTAL";
                    hoja_trabajo.Cells[dgv.Rows.Count + 3, 4] = this.txtTotalFacturacion.Text;

                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        //Evento que se desencadena cuando hago click en la grilla
        private void dgvPacientesXAnalisisFacturados_MouseClick(object sender, MouseEventArgs e)
        {
            //Click con el boton derecho
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvPacientesXAnalisisFacturados.HitTest(e.X, e.Y).RowIndex;
                posSelecFO = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvPacientesXAnalisisFacturados.SelectedRows)
                {
                    dr.Selected = false;
                }

                //Si selecciona un protocolo detalle
                if (position_xy_mouse_row >= 0)
                {
                    dgvPacientesXAnalisisFacturados.Rows[position_xy_mouse_row].Selected = true;
                    miMenu.Items.Add("Eliminar Orden").Name = "EliminarOrden";
                }

                miMenu.Show(dgvPacientesXAnalisisFacturados, new Point(e.X, e.Y));
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
                case "EliminarOrden":
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la Orden?", "Eliminar Orden", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Borrar orden
                        blLabBioquimica.bl_FACTURACION_ORDEN blFacturacionOrden = new blLabBioquimica.bl_FACTURACION_ORDEN();
                        blLabBioquimica.bl_FACTURACION_ORDENEntidad entFO = new blLabBioquimica.bl_FACTURACION_ORDENEntidad();
                        String idFactOrdenBaja = dgvPacientesXAnalisisFacturados.Rows[posSelecFO].Cells[0].Value.ToString();
                        String subtotalBaja = dgvPacientesXAnalisisFacturados.Rows[posSelecFO].Cells[4].Value.ToString();

                        entFO.ID_FACTURACION_ORDEN = int.Parse(idFactOrdenBaja);
                        entFO.USR_BAJA = "ADMIN";
                        entFO.FEC_BAJA = DateTime.Now;

                        blFacturacionOrden.Baja(entFO);

                        //Borrar de la grilla el elemento dado de baja.
                        foreach (DataGridViewRow c in dgvPacientesXAnalisisFacturados.Rows)
                        {
                            if (c.Cells[0].Value.ToString() == idFactOrdenBaja)
                            {
                                dgvPacientesXAnalisisFacturados.Rows.Remove(c);
                            }
                        }

                        //Actualizar el monto total de facturacion
                        decimal totalAnterior = decimal.Parse(this.txtTotalFacturacion.Text);
                        decimal subtotal = decimal.Parse(subtotalBaja);
                        decimal total = Math.Round(totalAnterior - subtotal, 2);
                        this.txtTotalFacturacion.Text = total.ToString();

                    }

                    break;

                default:
                    break;

            }


       }

        /// <summary>
        /// Evento que me permite ingresar solo numeros con coma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrecioUnidBioq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecioUnidBioq.Text.Length; i++)
            {
                if (txtPrecioUnidBioq.Text[i] == ',')
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


    }
}
