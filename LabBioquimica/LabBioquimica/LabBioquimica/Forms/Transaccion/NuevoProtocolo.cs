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


namespace LabBioquimica.Forms.Transaccion
{
    public partial class NuevoProtocolo : Form
    {

        private int idProtocoloActual;

        public static Int32 posSelecPD;

        public static Int32 posSelecPra;

        public NuevoProtocolo()
        {
            InitializeComponent();
            lblMensaje.Visible = false;
            cargarComboPacientes();
            cargarComboProfesionales();
            this.btnModificar.Enabled = false;
            
        }

        private void btnNueoAnalisis_Click(object sender, EventArgs e)
        {
            Forms.Transaccion.NuevoAnalisis nuevoAnalisis = new Forms.Transaccion.NuevoAnalisis();
            nuevoAnalisis.ShowDialog();
            nuevoAnalisis.Dispose();

        }


        private void dgvProtocoloDetalle_MouseClick(object sender, MouseEventArgs e)
        {
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


                if (position_xy_mouse_row >= 0)
                {
                    dgvProtocoloDetalle.Rows[position_xy_mouse_row].Selected = true;

                    miMenu.Items.Add("Nueva Práctica").Name = "NuevaPractica";
                    miMenu.Items.Add("Eliminar Práctica").Name = "EliminarPractica";
                    miMenu.Items.Add("Agregar o Modificar Items de la Práctica").Name = "AgregarModificarItemsPractica";

                    dgvPractica.Enabled = true;
                    dgvPractica.Rows.Clear();
                    dgvPractica.Refresh();

                    String idPDGrilla = dgvProtocoloDetalle.Rows[posSelecPD].Cells[1].Value.ToString();
                    int idPD = int.Parse(idPDGrilla);

                    blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                    blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);


                    foreach (blLabBioquimica.bl_PRACTICAEntidad entPrac in colPrac)
                    {
                        dgvPractica.Rows.Add(entPrac.ID_PROTOCOLO_DETALLE, entPrac.ID_PRACTICA, entPrac.ID_ITEM, entPrac.NOMBRE_ITEM, entPrac.RESULTADO, entPrac.VALOR_REF_ITEM, entPrac.NOMBRE_UNIDAD);
                    }

                }
                else
                {
                    dgvPractica.Rows.Clear();
                    dgvPractica.Refresh();
                    miMenu.Items.Add("Nueva Práctica").Name = "NuevaPractica";
                }

                miMenu.Show(dgvProtocoloDetalle, new Point(e.X, e.Y));

                //Evento menu click
                miMenu.ItemClicked += new ToolStripItemClickedEventHandler(MiMenu_ItemClicked);

            }
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

                dgvPractica.Rows.Clear();
                dgvPractica.Refresh();

                if (position_xy_mouse_row >= 0)
                {
                    dgvPractica.Enabled = true;

                    dgvProtocoloDetalle.Rows[position_xy_mouse_row].Selected = true;

                    String idPDGrilla = dgvProtocoloDetalle.Rows[posSelecPD].Cells[1].Value.ToString();
                    int idPD = int.Parse(idPDGrilla);

                    blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                    blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);



                    foreach (blLabBioquimica.bl_PRACTICAEntidad entPrac in colPrac)
                    {
                        dgvPractica.Rows.Add(entPrac.ID_PROTOCOLO_DETALLE, entPrac.ID_PRACTICA, entPrac.ID_ITEM, entPrac.NOMBRE_ITEM, entPrac.RESULTADO, entPrac.VALOR_REF_ITEM, entPrac.NOMBRE_UNIDAD);
                    }

                }

            }
        }


        private void MiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Evento seleccionado, para luego realizar la operación necesaria
            String eventoSelec = e.ClickedItem.Name.ToString();

            switch (eventoSelec)
            {
                case "NuevaPractica":
                    

                    String numProtocolo = this.txtProtocolo.Text;
                    Forms.Transaccion.NuevoAnalisis nuevoAnalisis = new Forms.Transaccion.NuevoAnalisis(this, numProtocolo);
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
                        String idPDBaja = dgvProtocoloDetalle.Rows[posSelecPD].Cells[1].Value.ToString();

                        entPDBaja.ID_PROTOCOLO_DETALLE = int.Parse(idPDBaja);
                        entPDBaja.USR_BAJA = "ADMIN";
                        entPDBaja.FEC_BAJA = DateTime.Now;
                        blProtocoloDet.Baja(entPDBaja);

                        //Limpiar grillas 
                        dgvProtocoloDetalle.Rows.Clear();
                        dgvProtocoloDetalle.Refresh();

                        dgvPractica.Rows.Clear();
                        dgvPractica.Refresh();

                        //Actualizar grilla Protocolo Detalle y Practica
                        //Traer datos del protocolo 
                        blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
                        blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, int.Parse(this.txtProtocolo.Text), null, null, null);
                        cargarPantalla(col);
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

                        String numProtocoloMod = this.txtProtocolo.Text;

                        Forms.Transaccion.NuevoAnalisis modAnalisis = new Forms.Transaccion.NuevoAnalisis(this, numProtocoloMod, entPD);
                        modAnalisis.ShowDialog();
                        modAnalisis.Dispose();
                    
                    break;

                default:
                    break;
            }

        }

        private void dgvItems_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip miMenu = new System.Windows.Forms.ContextMenuStrip();

                //Posicion de la fila que haces click
                int position_xy_mouse_row = dgvPractica.HitTest(e.X, e.Y).RowIndex;
                posSelecPra = position_xy_mouse_row;

                foreach (DataGridViewRow dr in dgvPractica.SelectedRows)
                {
                    dr.Selected = false;

                }
                

                if (position_xy_mouse_row >= 0)
                {
                    dgvPractica.Rows[position_xy_mouse_row].Selected = true;
                    miMenu.Items.Add("Eliminar Item").Name = "EliminarItem";
                }

                miMenu.Show(dgvPractica, new Point(e.X, e.Y));

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
                    String idPracticaBaja = dgvPractica.Rows[posSelecPra].Cells[1].Value.ToString();

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
                        dgvPractica.Rows.Clear();
                        dgvPractica.Refresh();

                        String idPDGrilla = dgvProtocoloDetalle.Rows[filSelec.Index].Cells[1].Value.ToString();

                        int idPD = int.Parse(idPDGrilla);

                        //Traer datos de la/s practica/s del Protocolo Detalle Seleccionado
                        blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);

                        foreach (blLabBioquimica.bl_PRACTICAEntidad ent in colPrac)
                        {
                            dgvPractica.Rows.Add(ent.ID_PROTOCOLO_DETALLE, ent.ID_PRACTICA, ent.ID_ITEM, ent.NOMBRE_ITEM, ent.RESULTADO, ent.VALOR_REF_ITEM, ent.NOMBRE_UNIDAD);
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
            this.cboPaciente.DataSource = blPaciente.dataTablePaciente();
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
            DataTable dt = blPaciente.dataTablePaciente();

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

            // cargo la lista de items para el autocomplete dle combobox
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

        //Insertar los datos del protocolo
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtProtocolo.Text))
            {
                MessageBox.Show("Debe ingresar el número de protocolo");
                this.txtProtocolo.Focus();
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
            //Validar que Nº de Protocolo no esté repetido
            blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, int.Parse(this.txtProtocolo.Text), null, null, null);
            if (col.Count > 0)
            {
                this.lblMensaje.Visible = true;
                this.txtProtocolo.Focus();
                return;
            }
            else
            {
                this.lblMensaje.Visible = false;
            }

            this.gbNuevoProtocolo.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.dgvProtocoloDetalle.Enabled = true;
            this.dgvPractica.Enabled = true;

            //Insertar nuevo protocolo en base de datos
            blLabBioquimica.bl_PROTOCOLOEntidad ent = new blLabBioquimica.bl_PROTOCOLOEntidad();

            //Datos
            ent.NRO_PROTOCOLO = int.Parse(this.txtProtocolo.Text);
            ent.FECHA = DateTime.Parse(this.dtpFecha.Text);
            ent.ID_PACIENTE = int.Parse(this.cboPaciente.SelectedValue.ToString());
            ent.ID_PROFESIONAL = int.Parse(this.cboProfesional.SelectedValue.ToString());

            int idProtocolo = (int)blProtocolo.Insertar(ent).ID_PROTOCOLO;
            
            //Guardo el id protocolo utilizado en la pantalla actualmente
            idProtocoloActual = idProtocolo;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.gbNuevoProtocolo.Enabled = true;
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

        public void cargarPantalla(blLabBioquimica.bl_PROTOCOLOEntidadColeccion col)
        {
            int idProtocolo = 0;

            foreach (blLabBioquimica.bl_PROTOCOLOEntidad ent in col)
            {
                //Guardo el id protocolo utilizado en la pantalla actualmente
                idProtocoloActual = (int)ent.ID_PROTOCOLO;

                idProtocolo = (int)ent.ID_PROTOCOLO;
                this.txtProtocolo.Text = ent.NRO_PROTOCOLO.ToString();
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
                //Traer datos del protocolo detalle
                blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
                blLabBioquimica.bl_PROTOCOLO_DETALLEEntidadColeccion colDet = blProtocoloDet.Buscar(null, idProtocolo, null);

                int idProtocoloDet = 0;
                foreach (blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad ent in colDet)
                {
                    idProtocoloDet = (int)ent.ID_PROTOCOLO_DETALLE;
                    dgvProtocoloDetalle.Rows.Add(ent.ID_PROTOCOLO, ent.ID_PROTOCOLO_DETALLE, ent.ID_ANALISIS, ent.NOMBRE_ANALISIS, ent.METODO_ANALISIS, ent.CODIGO_ANALISIS);
                }

                if (idProtocoloDet != 0)
                {

                    //Carga las Practicas de la primer fila que es la seleccionada inicialmente
                    DataGridViewRow filSelec = dgvProtocoloDetalle.CurrentRow;
                    if (filSelec != null)
                    {

                        dgvPractica.Enabled = true;

                        String idPDGrilla = dgvProtocoloDetalle.Rows[filSelec.Index].Cells[1].Value.ToString();

                        int idPD = int.Parse(idPDGrilla);

                        //Traer datos de la/s practica/s del Protocolo Detalle Seleccionado
                        blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                        blLabBioquimica.bl_PRACTICAEntidadColeccion colPrac = blPractica.Buscar(null, idPD, null);

                        foreach (blLabBioquimica.bl_PRACTICAEntidad ent in colPrac)
                        {
                            dgvPractica.Rows.Add(ent.ID_PROTOCOLO_DETALLE, ent.ID_PRACTICA, ent.ID_ITEM, ent.NOMBRE_ITEM, ent.RESULTADO, ent.VALOR_REF_ITEM, ent.NOMBRE_UNIDAD);
                        }

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

            //Limpiar Protocolo
            limpiarBGProtocolo();

            //Limpiar grillas 
            dgvProtocoloDetalle.Rows.Clear();
            dgvProtocoloDetalle.Refresh();

            dgvPractica.Rows.Clear();
            dgvPractica.Refresh();

            //Traer datos del protocolo 
            blLabBioquimica.bl_PROTOCOLO blProtocolo = new blLabBioquimica.bl_PROTOCOLO();
            blLabBioquimica.bl_PROTOCOLOEntidadColeccion col = blProtocolo.Buscar(null, int.Parse(this.txtConsultaProtocolo.Text), null, null, null);

            //Validar que Nº de Protocolo exista
            if (col.Count > 0)
            {
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
            this.txtProtocolo.Text = "";
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

        public void cargarProtocoloDetalle(Int32 p_ID_PROTOCOLO_DET)    
        {
            //Busco los datos del protocolo detalle
            blLabBioquimica.bl_PROTOCOLO_DETALLE blProtocoloDet = new blLabBioquimica.bl_PROTOCOLO_DETALLE();
            blLabBioquimica.bl_PROTOCOLO_DETALLEEntidad entPD = blProtocoloDet.BuscarPorPK(p_ID_PROTOCOLO_DET);

            dgvProtocoloDetalle.Rows.Add(entPD.ID_PROTOCOLO, entPD.ID_PROTOCOLO_DETALLE, entPD.ID_ANALISIS, entPD.NOMBRE_ANALISIS, entPD.METODO_ANALISIS, entPD.CODIGO_ANALISIS);

        }

        public void cargarComponentePractica(Int32 p_ID_PRACTICA)
        {
            //Si el analisis seleccionado anteriormente es igual al que se le cargan los componentes
            //se debe agregar la practica, sino no se agrega

            //dgvPractica.Rows.Clear();
            //dgvPractica.Refresh();

            blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
            blLabBioquimica.bl_PRACTICAEntidad entPrac = blPractica.BuscarPorPK(p_ID_PRACTICA);

            DataGridViewRow filSelec = dgvProtocoloDetalle.CurrentRow;

            if (filSelec != null)
            {
                String idPDGrilla = dgvProtocoloDetalle.Rows[filSelec.Index].Cells[1].Value.ToString();
                int idPD = int.Parse(idPDGrilla);
                if (idPD == entPrac.ID_PROTOCOLO_DETALLE)
                {
                    dgvPractica.Rows.Add(entPrac.ID_PROTOCOLO_DETALLE, entPrac.ID_PRACTICA, entPrac.ID_ITEM, entPrac.NOMBRE_ITEM, entPrac.RESULTADO, entPrac.VALOR_REF_ITEM, entPrac.NOMBRE_UNIDAD);
                }
            }
        }

        private void dgvPractica_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow filSelec = dgvPractica.CurrentRow;
            if (filSelec != null)
            {
                //Agregar el resultado a la Practica modificada
                String idPractica = dgvPractica.Rows[filSelec.Index].Cells[1].Value.ToString();
                String resultado = dgvPractica.Rows[filSelec.Index].Cells[4].Value.ToString();

                blLabBioquimica.bl_PRACTICA blPractica = new blLabBioquimica.bl_PRACTICA();
                blLabBioquimica.bl_PRACTICAEntidad entPrac = new blLabBioquimica.bl_PRACTICAEntidad();

                entPrac.ID_PRACTICA = int.Parse(idPractica);
                entPrac.RESULTADO = resultado;
                entPrac.USR_MOD = "ADMIN";
                entPrac.FEC_MOD = DateTime.Now;


                blPractica.ModificarResultado(entPrac);
            }


        }


    }
}
