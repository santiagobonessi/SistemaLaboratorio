using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_LOCALIDADEntidad
    {
        private Nullable<Int32> p_ID_LOCALIDAD;
        public Nullable<Int32> ID_LOCALIDAD
        {
            get { return p_ID_LOCALIDAD; }
            set { p_ID_LOCALIDAD = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private String p_CODPOSTAL;
        public String CODPOSTAL
        {
            get { return p_CODPOSTAL; }
            set { p_CODPOSTAL = value; }
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

        public bl_LOCALIDADEntidad() { }

        public bl_LOCALIDADEntidad(Int32 ID_LOCALIDAD)
        {
            try
            {
                bl_LOCALIDAD bl = new bl_LOCALIDAD();
                bl_LOCALIDADEntidad ent = bl.BuscarPorPK(ID_LOCALIDAD);

                if (ent != null)
                {
                    this.ID_LOCALIDAD = ent.ID_LOCALIDAD;
                    this.NOMBRE = ent.NOMBRE;
                    this.CODPOSTAL = ent.CODPOSTAL;
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

    public class bl_LOCALIDADEntidadColeccion: List<bl_LOCALIDADEntidad>
    {
    }

    public class bl_LOCALIDAD
    {

        private daLabBioquimica.da_LOCALIDAD p_da;

        public bl_LOCALIDAD()
        {
            p_da = new daLabBioquimica.da_LOCALIDAD();
        }

        public bl_LOCALIDADEntidad BuscarPorPK(Nullable<Int32> ID_LOCALIDAD)
        {

            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_LOCALIDAD);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_LOCALIDADEntidad ent = new bl_LOCALIDADEntidad();

                    if (dt.Rows[0]["idLocalidad"] != DBNull.Value)
                        ent.ID_LOCALIDAD = Convert.ToInt32(dt.Rows[0]["idLocalidad"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["codPostal"] != DBNull.Value)
                        ent.CODPOSTAL = Convert.ToString(dt.Rows[0]["codPostal"]);
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

        public bl_LOCALIDADEntidadColeccion Buscar(Nullable<Int32> p_ID_LOCALIDAD, String p_NOMBRE)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_LOCALIDAD, p_NOMBRE);
                bl_LOCALIDADEntidadColeccion lista = new bl_LOCALIDADEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_LOCALIDADEntidad ent = new bl_LOCALIDADEntidad();

                        if (dr["idLocalidad"] != DBNull.Value)
                            ent.ID_LOCALIDAD = Convert.ToInt32(dr["idLocalidad"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
                        if (dr["codPostal"] != DBNull.Value)
                            ent.CODPOSTAL = Convert.ToString(dr["codPostal"]);
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

        public bl_LOCALIDADEntidad Insertar(bl_LOCALIDADEntidad ent)
        {
            try
            {

                ent.ID_LOCALIDAD = p_da.Insertar(ent.NOMBRE, ent.CODPOSTAL, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_LOCALIDADEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_LOCALIDAD, ent.NOMBRE, ent.CODPOSTAL, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_LOCALIDADEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_LOCALIDAD, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTableLocalidad()
        {
            try
            {
                DataTable dt = p_da.Buscar(null, null);
                
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
