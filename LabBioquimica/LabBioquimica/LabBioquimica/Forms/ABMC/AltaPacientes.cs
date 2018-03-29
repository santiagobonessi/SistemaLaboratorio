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
    public partial class AltaPacientes : Form
    {
        
        private Pacientes p_frm;

        public static Int32 idModificar;

        public AltaPacientes(Pacientes pac)
        {
            InitializeComponent();
            p_frm = pac;

            cargarComboMutual();
            cargarComboSexo();
            cargarComboTipoDoc();
            cargarComboLocalidad();
            this.dtpNacimiento.Value = DateTime.Now;
            this.btnGrabar.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            blLabBioquimica.bl_PACIENTEEntidad ent = new blLabBioquimica.bl_PACIENTEEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del paciente");
                this.txtApellido.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del paciente");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.APELLIDO = this.txtApellido.Text;
            ent.NOMBRE = this.txtNombre.Text;
            if(this.txtDocumento.Text != "") { ent.DOCUMENTO = int.Parse(this.txtDocumento.Text); }

            ent.ID_TIPO_DOC = int.Parse(this.cboTipoDoc.SelectedValue.ToString());
            ent.ID_SEXO = int.Parse(this.cboSexo.SelectedValue.ToString());
            
            //Si la fecha se modifica, se guarda la fecha de nacimiento.
            DateTime fecha = DateTime.Parse(this.dtpNacimiento.Text);
            DateTime fechaActual = System.DateTime.Now;

            if (fecha.ToShortDateString() != fechaActual.ToShortDateString())
            {
                ent.FECHA_NACIMIENTO = DateTime.Parse(this.dtpNacimiento.Text);
            }
            
            if(this.txtTelefono.Text != "") { ent.TELEFONO = this.txtTelefono.Text; }
            
            ent.ID_MUTUAL = int.Parse(this.cboMutual.SelectedValue.ToString());
            ent.ID_LOCALIDAD = int.Parse(this.cboLocalidad.SelectedValue.ToString());

            if(this.txtCalle.Text != "") { ent.CALLE = this.txtCalle.Text; }
            if(this.txtNroCalle.Text != "") { ent.NRO_CALLE = int.Parse(this.txtNroCalle.Text); }

            ent.USR_ING = "ADMIN";
            ent.FEC_ING = DateTime.Now;

            int idPaciente = (int) blPaciente.Insertar(ent).ID_PACIENTE;
            if (idPaciente > 0)
            {
                MessageBox.Show("Se registró con éxito el paciente " + ent.APELLIDO + ", " + ent.NOMBRE +"");
                limpiarAltaPaciente();
                Close();
                p_frm.cargarPacientes();
            }

        }

        public void traerParaEditar(Int32 p_ID_PACIENTE)
        {
            
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            blLabBioquimica.bl_PACIENTEEntidad ent = blPaciente.BuscarPorPK(p_ID_PACIENTE);
            idModificar = p_ID_PACIENTE;
            this.lblTitulo.Text = "Modificar Paciente";
            this.txtApellido.Text = ent.APELLIDO;
            this.txtNombre.Text = ent.NOMBRE;
            this.txtDocumento.Text = ent.DOCUMENTO.ToString();
            this.cboTipoDoc.Text = ent.N_TIPO_DOC;
            this.cboSexo.Text = ent.N_SEXO;
            this.dtpNacimiento.Text = ent.FECHA_NACIMIENTO.ToString();
            this.txtTelefono.Text = ent.TELEFONO;
            this.cboMutual.Text = ent.N_MUTUAL;
            this.cboLocalidad.Text = ent.N_LOCALIDAD;
            this.txtCalle.Text = ent.CALLE;
            this.txtNroCalle.Text = ent.NRO_CALLE.ToString();
            this.btnInsertar.Visible = false;
            this.btnGrabar.Visible = true;
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_PACIENTE blPaciente = new blLabBioquimica.bl_PACIENTE();
            blLabBioquimica.bl_PACIENTEEntidad ent = new blLabBioquimica.bl_PACIENTEEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del paciente");
                this.txtApellido.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del paciente");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.ID_PACIENTE = idModificar;
            ent.APELLIDO = this.txtApellido.Text;
            ent.NOMBRE = this.txtNombre.Text;
            if (this.txtDocumento.Text != "") { ent.DOCUMENTO = int.Parse(this.txtDocumento.Text); }

            ent.ID_TIPO_DOC = int.Parse(this.cboTipoDoc.SelectedValue.ToString());
            ent.ID_SEXO = int.Parse(this.cboSexo.SelectedValue.ToString());

            //Si la fecha se modifica, se guarda la fecha de nacimiento.
            DateTime fecha = DateTime.Parse(this.dtpNacimiento.Text);
            DateTime fechaActual = System.DateTime.Now;

            if (fecha.ToShortDateString() != fechaActual.ToShortDateString())
            {
                ent.FECHA_NACIMIENTO = DateTime.Parse(this.dtpNacimiento.Text);
            }

            if (this.txtTelefono.Text != "") { ent.TELEFONO = this.txtTelefono.Text; }

            ent.ID_MUTUAL = int.Parse(this.cboMutual.SelectedValue.ToString());
            ent.ID_LOCALIDAD = int.Parse(this.cboLocalidad.SelectedValue.ToString());

            if (this.txtCalle.Text != "") { ent.CALLE = this.txtCalle.Text; }
            if (this.txtNroCalle.Text != "") { ent.NRO_CALLE = int.Parse(this.txtNroCalle.Text); }

            ent.USR_MOD = "ADMIN";
            ent.FEC_MOD = DateTime.Now;

            blPaciente.Modificar(ent);

            MessageBox.Show("Se modificó con éxito el paciente " + ent.APELLIDO + ", " + ent.NOMBRE + "");
            limpiarAltaPaciente();
            Close();
            p_frm.cargarPacientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void limpiarAltaPaciente()
        {
            this.txtApellido.Text = "";
            this.txtNombre.Text = "";
            this.txtDocumento.Text = "";
            this.cboTipoDoc.SelectedIndex = 0;
            this.cboSexo.SelectedIndex = 0;
            this.dtpNacimiento.Value = DateTime.Now;
            this.txtTelefono.Text = "";
            this.cboMutual.SelectedIndex = 0;
            this.cboLocalidad.SelectedIndex = 0;
            this.txtCalle.Text = "";
            this.txtNroCalle.Text = "";
        }

        public void cargarComboMutual()
        {

            blLabBioquimica.bl_MUTUAL blMutual = new blLabBioquimica.bl_MUTUAL();

            this.cboMutual.DataSource = null;
            this.cboMutual.DataSource = blMutual.dataTableMutual();
            this.cboMutual.ValueMember = "idMutual";
            this.cboMutual.DisplayMember = "nombre";
            this.cboMutual.SelectedIndex = 0;

        }

        public void cargarComboSexo()
        {

            blLabBioquimica.bl_SEXO blSexo = new blLabBioquimica.bl_SEXO();

            this.cboSexo.DataSource = null;
            this.cboSexo.DataSource = blSexo.dataTableSexo();
            this.cboSexo.ValueMember = "idSexo";
            this.cboSexo.DisplayMember = "nombre";
            this.cboSexo.SelectedIndex = 0;

        }

        public void cargarComboTipoDoc()
        {
            blLabBioquimica.bl_TIPO_DOC blTipoDoc = new blLabBioquimica.bl_TIPO_DOC();

            this.cboTipoDoc.DataSource = null;
            this.cboTipoDoc.DataSource = blTipoDoc.dataTableTipoDoc();
            this.cboTipoDoc.ValueMember = "idTipoDoc";
            this.cboTipoDoc.DisplayMember = "nombre";
            this.cboTipoDoc.SelectedIndex = 0;
        }

        public void cargarComboLocalidad()
        {

            blLabBioquimica.bl_LOCALIDAD blLocalidad = new blLabBioquimica.bl_LOCALIDAD();

            this.cboLocalidad.DataSource = null;
            this.cboLocalidad.DataSource = blLocalidad.dataTableLocalidad();
            this.cboLocalidad.ValueMember = "idLocalidad";
            this.cboLocalidad.DisplayMember = "nombre";
            this.cboLocalidad.SelectedIndex = 0;

        }

        private void cboMutual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboTipoDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
