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
    public partial class AltaProfesional : Form
    {
        //Creo una instancia del Form Pacientes para actualizar la grilla
        private Profesionales p_frm;
        //Creo una instancia del Form NuevoProtocolo para actualizar el combo box
        private LabBioquimica.Forms.Transaccion.NuevoProtocolo np_frm;

        public static Int32 idModificar;

        //Constructor sin parámetros
        public AltaProfesional()
        {
            InitializeComponent();

            cargarComboLocalidad();
            this.btnGrabar.Visible = false;
        }
        //Constructor con parámetro del form Profesionales
        public AltaProfesional(Profesionales pro)
        {
            InitializeComponent();
            p_frm = pro;

            cargarComboLocalidad();
            this.btnGrabar.Visible = false;
        }

        //Constructor con parámetro del form NuevoProtocolo
        public AltaProfesional(LabBioquimica.Forms.Transaccion.NuevoProtocolo nuevoP)
        {
            InitializeComponent();
            np_frm = nuevoP;

            cargarComboLocalidad();
            this.btnGrabar.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();
            blLabBioquimica.bl_PROFESIONALEntidad ent = new blLabBioquimica.bl_PROFESIONALEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del profesional");
                this.txtApellido.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del profesional");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.APELLIDO = this.txtApellido.Text;
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(txtMatricula.Text)) { ent.MATRICULA = this.txtMatricula.Text; }
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text)) { ent.TELEFONO = this.txtTelefono.Text; }
            if (this.cboLocalidad.SelectedValue.ToString() != "0")
            {
                ent.ID_LOCALIDAD = int.Parse(this.cboLocalidad.SelectedValue.ToString());
            }
            if (!string.IsNullOrWhiteSpace(txtCalle.Text)) { ent.CALLE = this.txtCalle.Text; }
            if (!string.IsNullOrWhiteSpace(txtNroCalle.Text)) { ent.NRO_CALLE = int.Parse(this.txtNroCalle.Text); }

            ent.USR_ING = "ADMIN";
            ent.FEC_ING = DateTime.Now;

            int idProfesional = (int)blProfesional.Insertar(ent).ID_PROFESIONAL;
            if (idProfesional > 0)
            {
                MessageBox.Show("Se registró con éxito el profesional " + ent.APELLIDO + ", " + ent.NOMBRE + "");
                limpiarAltaProfesional();
                Close();

                if (p_frm != null) { p_frm.cargarProfesionales(); }
                if (np_frm != null)
                {
                    np_frm.cargarComboProfesionales();
                    np_frm.cargarNomApeAltaProfesionales(ent.APELLIDO + " " + ent.NOMBRE);
                }
                 
            }

        }

        public void traerParaEditar(Int32 p_ID_PROFESIONAL)
        {

            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();
            blLabBioquimica.bl_PROFESIONALEntidad ent = blProfesional.BuscarPorPK(p_ID_PROFESIONAL);
            idModificar = p_ID_PROFESIONAL;
            this.lblTitulo.Text = "Modificar Profesional";
            this.txtApellido.Text = ent.APELLIDO;
            this.txtNombre.Text = ent.NOMBRE;
            this.txtMatricula.Text = ent.MATRICULA;
            this.txtTelefono.Text = ent.TELEFONO;
            if (ent.ID_LOCALIDAD != null) { this.cboLocalidad.Text = ent.N_LOCALIDAD; }
            else { this.cboLocalidad.SelectedIndex = 0; }
            this.txtCalle.Text = ent.CALLE;
            this.txtNroCalle.Text = ent.NRO_CALLE.ToString();
            this.btnInsertar.Visible = false;
            this.btnGrabar.Visible = true;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            blLabBioquimica.bl_PROFESIONAL blProfesional = new blLabBioquimica.bl_PROFESIONAL();
            blLabBioquimica.bl_PROFESIONALEntidad ent = new blLabBioquimica.bl_PROFESIONALEntidad();

            //Validaciones
            if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del profesional");
                this.txtApellido.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del profesional");
                this.txtNombre.Focus();
                return;
            }

            //Datos
            ent.ID_PROFESIONAL = idModificar;
            ent.APELLIDO = this.txtApellido.Text;
            ent.NOMBRE = this.txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(txtMatricula.Text)) { ent.MATRICULA = this.txtMatricula.Text; }
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text)) { ent.TELEFONO = this.txtTelefono.Text; }
            if (this.cboLocalidad.SelectedValue.ToString() != "0")
            {
                ent.ID_LOCALIDAD = int.Parse(this.cboLocalidad.SelectedValue.ToString());
            }
            if (!string.IsNullOrWhiteSpace(txtCalle.Text)) { ent.CALLE = this.txtCalle.Text; }
            if (!string.IsNullOrWhiteSpace(txtNroCalle.Text)) { ent.NRO_CALLE = int.Parse(this.txtNroCalle.Text); }

            ent.USR_MOD = "ADMIN";
            ent.FEC_MOD = DateTime.Now;

            blProfesional.Modificar(ent);
            //MessageBox.Show("Se modificó con éxito el profesional " + ent.APELLIDO + ", " + ent.NOMBRE + "");
            limpiarAltaProfesional();
            Close();
            p_frm.cargarProfesionales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void limpiarAltaProfesional()
        {
            this.txtApellido.Text = "";
            this.txtNombre.Text = "";
            this.txtMatricula.Text = "";
            this.txtTelefono.Text = "";
            this.cboLocalidad.SelectedIndex = -1;
            this.txtCalle.Text = "";
            this.txtNroCalle.Text = "";
        }

        public void cargarComboLocalidad()
        {
            blLabBioquimica.bl_LOCALIDAD blLocalidad = new blLabBioquimica.bl_LOCALIDAD();

            DataTable dt = blLocalidad.dataTableLocalidad();
            DataRow nuevaFila = dt.NewRow();

            nuevaFila["idLocalidad"] = 0;
            nuevaFila["nombre"] = "--SELECCIONE--";
            dt.Rows.InsertAt(nuevaFila, 0);

            this.cboLocalidad.DataSource = null;
            this.cboLocalidad.DataSource = dt;
            this.cboLocalidad.ValueMember = "idLocalidad";
            this.cboLocalidad.DisplayMember = "nombre";
            this.cboLocalidad.SelectedIndex = 0;

        }



    }
}
