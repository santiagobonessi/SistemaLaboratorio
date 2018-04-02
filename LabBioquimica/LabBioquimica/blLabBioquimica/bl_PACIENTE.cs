using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_PACIENTEEntidad
    {
        private Nullable<Int32> p_ID_PACIENTE;
        public Nullable<Int32> ID_PACIENTE
        {
            get { return p_ID_PACIENTE; }
            set { p_ID_PACIENTE = value; }
        }

        private String p_APELLIDO;
        public String APELLIDO
        {
            get { return p_APELLIDO; }
            set { p_APELLIDO = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private Nullable<Int32> p_DOCUMENTO;
        public Nullable<Int32> DOCUMENTO
        {
            get { return p_DOCUMENTO; }
            set { p_DOCUMENTO = value; }
        }

        private Nullable<Int32> p_ID_TIPO_DOC;
        public Nullable<Int32> ID_TIPO_DOC
        {
            get { return p_ID_TIPO_DOC; }
            set { p_ID_TIPO_DOC = value; }
        }

        private String p_N_TIPO_DOC;
        public String N_TIPO_DOC
        {
            get { return p_N_TIPO_DOC; }
            set { p_N_TIPO_DOC = value; }
        }

        private Nullable<Int32> p_ID_SEXO;
        public Nullable<Int32> ID_SEXO
        {
            get { return p_ID_SEXO; }
            set { p_ID_SEXO = value; }
        }

        private String p_N_SEXO;
        public String N_SEXO
        {
            get { return p_N_SEXO; }
            set { p_N_SEXO = value; }
        }

        private Nullable<DateTime> p_FECHA_NACIMIENTO;
        public Nullable<DateTime> FECHA_NACIMIENTO
        {
            get { return p_FECHA_NACIMIENTO; }
            set { p_FECHA_NACIMIENTO = value; }
        }

        private String p_TELEFONO;
        public String TELEFONO
        {
            get { return p_TELEFONO; }
            set { p_TELEFONO = value; }
        }

        private Nullable<Int32> p_ID_MUTUAL;
        public Nullable<Int32> ID_MUTUAL
        {
            get { return p_ID_MUTUAL; }
            set { p_ID_MUTUAL = value; }
        }

        private String p_N_MUTUAL;
        public String N_MUTUAL
        {
            get { return p_N_MUTUAL; }
            set { p_N_MUTUAL = value; }
        }

        private Nullable<Int32> p_ID_LOCALIDAD;
        public Nullable<Int32> ID_LOCALIDAD
        {
            get { return p_ID_LOCALIDAD; }
            set { p_ID_LOCALIDAD = value; }
        }

        private String p_N_LOCALIDAD;
        public String N_LOCALIDAD
        {
            get { return p_N_LOCALIDAD; }
            set { p_N_LOCALIDAD = value; }
        }

        private String p_CALLE;
        public String CALLE
        {
            get { return p_CALLE; }
            set { p_CALLE = value; }
        }

        private Nullable<Int32> p_NRO_CALLE;
        public Nullable<Int32> NRO_CALLE
        {
            get { return p_NRO_CALLE; }
            set { p_NRO_CALLE = value; }
        }
        private String p_USR_ING;
        public String USR_ING
        {
            get { return p_USR_ING; }
            set { p_USR_ING = value; }
        }
        private Nullable<DateTime> p_FEC_ING;
        public Nullable<DateTime> FEC_ING
        {
            get { return p_FEC_ING; }
            set { p_FEC_ING = value; }
        }
        private String p_USR_MOD;
        public String USR_MOD
        {
            get { return p_USR_MOD; }
            set { p_USR_MOD = value; }
        }
        private Nullable<DateTime> p_FEC_MOD;
        public Nullable<DateTime> FEC_MOD
        {
            get { return p_FEC_MOD; }
            set { p_FEC_MOD = value; }
        }
        private String p_USR_BAJA;
        public String USR_BAJA
        {
            get { return p_USR_BAJA; }
            set { p_USR_BAJA = value; }
        }
        private Nullable<DateTime> p_FEC_BAJA;
        public Nullable<DateTime> FEC_BAJA
        {
            get { return p_FEC_BAJA; }
            set { p_FEC_BAJA = value; }
        }

        public bl_PACIENTEEntidad() { }

        public bl_PACIENTEEntidad(Int32 ID_PACIENTE)
        {
            try
            {

                bl_PACIENTE bl = new bl_PACIENTE();
                bl_PACIENTEEntidad ent = bl.BuscarPorPK(ID_PACIENTE);


                if (ent != null)
                {

                    this.ID_PACIENTE = ent.ID_PACIENTE;
                    this.APELLIDO = ent.APELLIDO;
                    this.NOMBRE = ent.NOMBRE;
                    this.DOCUMENTO = ent.DOCUMENTO;
                    this.ID_TIPO_DOC = ent.ID_TIPO_DOC;
                    this.ID_SEXO = ent.ID_SEXO;
                    this.FECHA_NACIMIENTO = ent.FECHA_NACIMIENTO;
                    this.TELEFONO = ent.TELEFONO;
                    this.ID_MUTUAL = ent.ID_MUTUAL;
                    this.ID_LOCALIDAD = ent.ID_LOCALIDAD;
                    this.CALLE = ent.CALLE;
                    this.NRO_CALLE = ent.NRO_CALLE;
                    this.USR_ING = ent.USR_ING;
                    this.FEC_ING = ent.FEC_ING;
                    this.USR_MOD = ent.USR_MOD;
                    this.FEC_MOD = ent.FEC_MOD;
                    this.USR_BAJA = ent.USR_BAJA;
                    this.FEC_BAJA = ent.FEC_BAJA;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    public class bl_PACIENTEEntidadColeccion : List<bl_PACIENTEEntidad>
    {
    }

    public class bl_PACIENTE
    {

        private daLabBioquimica.da_PACIENTE p_da;

        public bl_PACIENTE()
        {
            p_da = new daLabBioquimica.da_PACIENTE();
        }

        public bl_PACIENTEEntidad BuscarPorPK(Nullable<Int32> p_ID_PACIENTE)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(p_ID_PACIENTE);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_PACIENTEEntidad ent = new bl_PACIENTEEntidad();


                    if (dt.Rows[0]["idPaciente"] != DBNull.Value)
                        ent.ID_PACIENTE = Convert.ToInt32(dt.Rows[0]["idPaciente"]);
                    if (dt.Rows[0]["apellido"] != DBNull.Value)
                        ent.APELLIDO = Convert.ToString(dt.Rows[0]["apellido"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["documento"] != DBNull.Value)
                        ent.DOCUMENTO = Convert.ToInt32(dt.Rows[0]["documento"]);
                    if (dt.Rows[0]["idTipoDoc"] != DBNull.Value)
                        ent.ID_TIPO_DOC = Convert.ToInt32(dt.Rows[0]["idTipoDoc"]);
                    if (dt.Rows[0]["TipoDoc"] != DBNull.Value)
                        ent.N_TIPO_DOC = Convert.ToString(dt.Rows[0]["TipoDoc"]);
                    if (dt.Rows[0]["idSexo"] != DBNull.Value)
                        ent.ID_SEXO = Convert.ToInt32(dt.Rows[0]["idSexo"]);
                    if (dt.Rows[0]["Sexo"] != DBNull.Value)
                        ent.N_SEXO = Convert.ToString(dt.Rows[0]["Sexo"]);
                    if (dt.Rows[0]["fechaNacimiento"] != DBNull.Value)
                        ent.FECHA_NACIMIENTO = Convert.ToDateTime(dt.Rows[0]["fechaNacimiento"]);
                    if (dt.Rows[0]["telefono"] != DBNull.Value)
                        ent.TELEFONO = Convert.ToString(dt.Rows[0]["telefono"]);
                    if (dt.Rows[0]["idMutual"] != DBNull.Value)
                        ent.ID_MUTUAL = Convert.ToInt32(dt.Rows[0]["idMutual"]);
                    if (dt.Rows[0]["Mutual"] != DBNull.Value)
                        ent.N_MUTUAL = Convert.ToString(dt.Rows[0]["Mutual"]);
                    if (dt.Rows[0]["idLocalidad"] != DBNull.Value)
                        ent.ID_LOCALIDAD = Convert.ToInt32(dt.Rows[0]["idLocalidad"]);
                    if (dt.Rows[0]["Localidad"] != DBNull.Value)
                        ent.N_LOCALIDAD = Convert.ToString(dt.Rows[0]["Localidad"]);
                    if (dt.Rows[0]["calle"] != DBNull.Value)
                        ent.CALLE = Convert.ToString(dt.Rows[0]["calle"]);
                    if (dt.Rows[0]["nroCalle"] != DBNull.Value)
                        ent.NRO_CALLE = Convert.ToInt32(dt.Rows[0]["nroCalle"]);
                    if (dt.Rows[0]["usr_ing"] != DBNull.Value)
                        ent.USR_ING = Convert.ToString(dt.Rows[0]["usr_ing"]);
                    if (dt.Rows[0]["fec_ing"] != DBNull.Value)
                        ent.FEC_ING = Convert.ToDateTime(dt.Rows[0]["fec_ing"]);
                    if (dt.Rows[0]["usr_mod"] != DBNull.Value)
                        ent.USR_MOD = Convert.ToString(dt.Rows[0]["usr_mod"]);
                    if (dt.Rows[0]["fec_mod"] != DBNull.Value)
                        ent.FEC_MOD = Convert.ToDateTime(dt.Rows[0]["fec_mod"]);
                    if (dt.Rows[0]["usr_baja"] != DBNull.Value)
                        ent.USR_BAJA = Convert.ToString(dt.Rows[0]["usr_baja"]);
                    if (dt.Rows[0]["fec_baja"] != DBNull.Value)
                        ent.FEC_BAJA = Convert.ToDateTime(dt.Rows[0]["fec_baja"]);

                    return ent;
                }
                else
                {
                    return null;
                }

            }

            catch (blLabBioquimica.Framework.blException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }


        public bl_PACIENTEEntidadColeccion Buscar(Nullable<Int32> p_ID_PACIENTE, string p_APELLIDO, string p_NOMBRE, string p_DOCUMENTO)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_PACIENTE, p_APELLIDO, p_NOMBRE, p_DOCUMENTO);
                bl_PACIENTEEntidadColeccion lista = new bl_PACIENTEEntidadColeccion();

                if (dt != null) { 
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_PACIENTEEntidad ent = new bl_PACIENTEEntidad();
                        if (dr["idPaciente"] != DBNull.Value)
                            ent.ID_PACIENTE = Convert.ToInt32(dr["idPaciente"]);
                        if (dr["apellido"] != DBNull.Value)
                            ent.APELLIDO = Convert.ToString(dr["apellido"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
                        if (dr["documento"] != DBNull.Value)
                            ent.DOCUMENTO = Convert.ToInt32(dr["documento"]);
                        if (dr["idTipoDoc"] != DBNull.Value)
                            ent.ID_TIPO_DOC = Convert.ToInt32(dr["idTipoDoc"]);
                        if (dr["TipoDoc"] != DBNull.Value)
                            ent.N_TIPO_DOC = Convert.ToString(dr["TipoDoc"]);
                        if (dr["idSexo"] != DBNull.Value)
                            ent.ID_SEXO = Convert.ToInt32(dr["idSexo"]);
                        if (dr["Sexo"] != DBNull.Value)
                            ent.N_SEXO = Convert.ToString(dr["Sexo"]);
                        if (dr["fechaNacimiento"] != DBNull.Value)
                            ent.FECHA_NACIMIENTO = Convert.ToDateTime(dr["fechaNacimiento"]);
                        if (dr["telefono"] != DBNull.Value)
                            ent.TELEFONO = Convert.ToString(dr["telefono"]);
                        if (dr["idMutual"] != DBNull.Value)
                            ent.ID_MUTUAL = Convert.ToInt32(dr["idMutual"]);
                        if (dr["Mutual"] != DBNull.Value)
                            ent.N_MUTUAL = Convert.ToString(dr["Mutual"]);
                        if (dr["idLocalidad"] != DBNull.Value)
                            ent.ID_LOCALIDAD = Convert.ToInt32(dr["idLocalidad"]);
                        if (dr["Localidad"] != DBNull.Value)
                            ent.N_LOCALIDAD = Convert.ToString(dr["Localidad"]);
                        if (dr["calle"] != DBNull.Value)
                            ent.CALLE = Convert.ToString(dr["calle"]);
                        if (dr["nroCalle"] != DBNull.Value)
                            ent.NRO_CALLE = Convert.ToInt32(dr["nroCalle"]);
                        if (dr["usr_ing"] != DBNull.Value)
                            ent.USR_ING = Convert.ToString(dr["usr_ing"]);
                        if (dr["fec_ing"] != DBNull.Value)
                            ent.FEC_ING = Convert.ToDateTime(dr["fec_ing"]);
                        if (dr["usr_mod"] != DBNull.Value)
                            ent.USR_MOD = Convert.ToString(dr["usr_mod"]);
                        if (dr["fec_mod"] != DBNull.Value)
                            ent.FEC_MOD = Convert.ToDateTime(dr["fec_mod"]);
                        if (dr["usr_baja"] != DBNull.Value)
                            ent.USR_BAJA = Convert.ToString(dr["usr_baja"]);
                        if (dr["fec_baja"] != DBNull.Value)
                            ent.FEC_BAJA = Convert.ToDateTime(dr["fec_baja"]);



                        lista.Add(ent);
                    }
                }

                return lista;

            }
            catch (blLabBioquimica.Framework.blException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }


        public bl_PACIENTEEntidad Insertar(bl_PACIENTEEntidad ent)
        {
            try
            {

                ent.ID_PACIENTE = p_da.Insertar(ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.ID_TIPO_DOC, ent.ID_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.ID_MUTUAL, ent.ID_LOCALIDAD, ent.CALLE, ent.NRO_CALLE, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

                return ent;
            }
            catch (blLabBioquimica.Framework.blException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public void Modificar(bl_PACIENTEEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_PACIENTE, ent.APELLIDO, ent.NOMBRE, ent.DOCUMENTO, ent.ID_TIPO_DOC, ent.ID_SEXO, ent.FECHA_NACIMIENTO, ent.TELEFONO, ent.ID_MUTUAL, ent.ID_LOCALIDAD, ent.CALLE, ent.NRO_CALLE, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_PACIENTEEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_PACIENTE, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTablePaciente()
        {
            try
            {
                DataTable dt = p_da.Buscar(null, null, null, null);

                if (dt != null)
                {
                    return dt;
                }

                return null;
            }

            catch (blLabBioquimica.Framework.blException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }



    }
}
