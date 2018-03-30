using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_PROFESIONALEntidad
    {
        private Nullable<Int32> p_ID_PROFESIONAL;
        public Nullable<Int32> ID_PROFESIONAL
        {
            get { return p_ID_PROFESIONAL; }
            set { p_ID_PROFESIONAL = value; }
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

        private String p_MATRICULA;
        public String MATRICULA
        {
            get { return p_MATRICULA; }
            set { p_MATRICULA = value; }
        }

        private String p_TELEFONO;
        public String TELEFONO
        {
            get { return p_TELEFONO; }
            set { p_TELEFONO = value; }
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

        public bl_PROFESIONALEntidad() { }

        public bl_PROFESIONALEntidad(Int32 ID_PROFESIONAL)
        {
            try
            {

                bl_PROFESIONAL bl = new bl_PROFESIONAL();
                bl_PROFESIONALEntidad ent = bl.BuscarPorPK(ID_PROFESIONAL);


                if (ent != null)
                {

                    this.ID_PROFESIONAL = ent.ID_PROFESIONAL;
                    this.APELLIDO = ent.APELLIDO;
                    this.NOMBRE = ent.NOMBRE;
                    this.MATRICULA = ent.MATRICULA;
                    this.TELEFONO = ent.TELEFONO;
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

    public class bl_PROFESIONALEntidadColeccion : List<bl_PROFESIONALEntidad>
    {
    }


    public class bl_PROFESIONAL
    {
        private daLabBioquimica.da_PROFESIONAL p_da;

        public bl_PROFESIONAL()
        {
            p_da = new daLabBioquimica.da_PROFESIONAL();
        }

        public bl_PROFESIONALEntidad BuscarPorPK(Nullable<Int32> p_ID_PROFESIONAL)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(p_ID_PROFESIONAL);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_PROFESIONALEntidad ent = new bl_PROFESIONALEntidad();


                    if (dt.Rows[0]["idProfesional"] != DBNull.Value)
                        ent.ID_PROFESIONAL = Convert.ToInt32(dt.Rows[0]["idProfesional"]);
                    if (dt.Rows[0]["apellido"] != DBNull.Value)
                        ent.APELLIDO = Convert.ToString(dt.Rows[0]["apellido"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["matricula"] != DBNull.Value)
                        ent.MATRICULA = Convert.ToString(dt.Rows[0]["matricula"]);
                    if (dt.Rows[0]["telefono"] != DBNull.Value)
                        ent.TELEFONO = Convert.ToString(dt.Rows[0]["telefono"]);
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

        public bl_PROFESIONALEntidadColeccion Buscar(Nullable<Int32> p_ID_PROFESIONAL, String p_APELLIDO, String p_NOMBRE, String p_MATRICULA)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_PROFESIONAL, p_APELLIDO, p_NOMBRE, p_MATRICULA);
                bl_PROFESIONALEntidadColeccion lista = new bl_PROFESIONALEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_PROFESIONALEntidad ent = new bl_PROFESIONALEntidad();
                        if (dr["idProfesional"] != DBNull.Value)
                            ent.ID_PROFESIONAL = Convert.ToInt32(dr["idProfesional"]);
                        if (dr["apellido"] != DBNull.Value)
                            ent.APELLIDO = Convert.ToString(dr["apellido"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
                        if (dr["matricula"] != DBNull.Value)
                            ent.MATRICULA = Convert.ToString(dr["matricula"]);
                        if (dr["telefono"] != DBNull.Value)
                            ent.TELEFONO = Convert.ToString(dr["telefono"]);
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

        public bl_PROFESIONALEntidad Insertar(bl_PROFESIONALEntidad ent)
        {
            try
            {

                ent.ID_PROFESIONAL = p_da.Insertar(ent.APELLIDO, ent.NOMBRE, ent.MATRICULA, ent.TELEFONO, ent.ID_LOCALIDAD, ent.CALLE, ent.NRO_CALLE, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_PROFESIONALEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_PROFESIONAL, ent.APELLIDO, ent.NOMBRE, ent.MATRICULA, ent.TELEFONO, ent.ID_LOCALIDAD, ent.CALLE, ent.NRO_CALLE, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_PROFESIONALEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_PROFESIONAL, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

    }
}
