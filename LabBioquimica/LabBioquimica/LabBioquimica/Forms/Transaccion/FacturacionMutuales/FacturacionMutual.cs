using System;
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

        //Variable de la posicion seleccionada en la grilla dgvProtocolosXPaciente
        public static Int32 posSelecPP;

        //Variable de la posicion seleccionada en la grilla dgvPacientesXAnalisisFacturados
        public static Int32 posSelecPAF;

        public FacturacionMutual()
        {
            InitializeComponent();
            cargarComboMutual();
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

        
        private void btnAceptarMutual_Click(object sender, EventArgs e)
        {
            //Busca todos los pacientes que esten adheridos a la mutual seleccionada
            try
            {
                if (txtPrecioUnidBioq.Text == "") { return; }
                int filaSelec = this.cboMutual.SelectedIndex;
                String valueMember = this.cboMutual.ValueMember.ToString();

                if (!string.IsNullOrEmpty(valueMember) && filaSelec >= 0 && this.cboMutual.SelectedValue != null)
                {
                    //Falta validar que se lleno el text box de precio Unid Bioq
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
                    

                    // cargo la lista de items para el autocomplete dle combobox
                    this.cboPacientesAdheridos.AutoCompleteCustomSource = AutocompletePaciente();
                    this.cboPacientesAdheridos.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboPacientesAdheridos.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    
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
            string nomapePaciente = this.cboPacientesAdheridos.Text;
            string cadenaCodigos = "";
            decimal cantUnidBioq = 0;
            decimal precioUnidBioq = decimal.Parse(this.txtPrecioUnidBioq.Text);
            bool codigo1 = this.chCargarCod1.Checked;

            //Recorro los analisis seleccionados
            foreach (DataGridViewRow row in dgvAnalisisXProtocolo.Rows)
            {
                if (row.Cells[7].Value != null)
                { 
                    string codigo = "";
                    decimal unidadBioq = 0;

                    //Codigo 1 
                    if (codigo1)
                    {
                        codigo = "1";
                        cadenaCodigos += codigo + " - ";

                        cantUnidBioq = decimal.Parse(txtUnidBioqCod1.Text);


                        codigo1 = false; // Para cargarlo solo una vez por orden.
                    }

                    //Filtro por los checks seleccionados
                    if (row.Cells[7].Value.Equals(true))//Columna de checks
                    {
                     //Guardo en la grilla dgvPacientesXAnalisisFacturados los analisis
                     codigo = row.Cells[5].Value.ToString();
                     cadenaCodigos += codigo + " - ";

                         if (row.Cells[6].Value.ToString() != "")
                         {
                            unidadBioq = int.Parse(row.Cells[6].Value.ToString());
                            cantUnidBioq += unidadBioq;
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

            dgvPacientesXAnalisisFacturados.Rows.Add(nomapePaciente, cadenaCodigos, cantUnidBioq.ToString(), subtotal.ToString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //TO DO : Limpiar todos los campos
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

                    hoja_trabajo.Cells[1, 1] = "FACTURACIÓN " + this.cboMesFact.Text + " " + DateTime.Now.Year.ToString();

                    //Cargar cabecera
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        hoja_trabajo.Cells[2, j + 1] = dgv.Columns[j].HeaderText.ToUpper();
                    }

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 3, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
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
                posSelecPAF = position_xy_mouse_row;

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
                        //blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
                        //blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad entPDBaja = new blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad();
                        //String idProtocoloBaja = dgvProtocoloDetalle.Rows[posSelecPD].Cells[0].Value.ToString();
                        //String idPDBaja = dgvProtocoloDetalle.Rows[posSelecPD].Cells[1].Value.ToString();

                        //entPDBaja.ID_PROTOCOLO_DETALLE = int.Parse(idPDBaja);
                        //entPDBaja.USR_BAJA = "ADMIN";
                        //entPDBaja.FEC_BAJA = DateTime.Now;

                        //blProtocoloDet.Baja(entPDBaja);

                        ////Actualizar grilla Protocolo Detalle y Practica
                        //cargarGrillaPDyP(int.Parse(idProtocoloBaja));

                    }

                    break;

                default:
                    break;

            }


       }



    }
}
