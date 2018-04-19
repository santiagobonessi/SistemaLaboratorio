using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_UNIDADEntidad
    {
        private Nullable<Int32> p_ID_UNIDAD;
        public Nullable<Int32> ID_UNIDAD
        {
            get { return p_ID_UNIDAD; }
            set { p_ID_UNIDAD = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
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

        public bl_UNIDADEntidad() { }

        public bl_UNIDADEntidad(Int32 ID_UNIDAD)
        {
            try
            {
                bl_UNIDAD bl = new bl_UNIDAD();
                bl_UNIDADEntidad ent = bl.BuscarPorPK(ID_UNIDAD);

                if (ent != null)
                {
                    this.ID_UNIDAD = ent.ID_UNIDAD;
                    this.NOMBRE = ent.NOMBRE;
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

    public class bl_UNIDADEntidadColeccion : List<bl_UNIDADEntidad>
    {
    }

    public class bl_UNIDAD
    {
        private daLabBioquimica.da_UNIDAD p_da;

        public bl_UNIDAD()
        {
            p_da = new daLabBioquimica.da_UNIDAD();
        }

        public bl_UNIDADEntidad BuscarPorPK(Nullable<Int32> ID_UNIDAD)
        {

            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_UNIDAD);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_UNIDADEntidad ent = new bl_UNIDADEntidad();

                    if (dt.Rows[0]["idUnidad"] != DBNull.Value)
                        ent.ID_UNIDAD = Convert.ToInt32(dt.Rows[0]["idUnidad"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
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

        public bl_UNIDADEntidadColeccion Buscar(String p_NOMBRE)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_NOMBRE);
                bl_UNIDADEntidadColeccion lista = new bl_UNIDADEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_UNIDADEntidad ent = new bl_UNIDADEntidad();

                        if (dr["idUnidad"] != DBNull.Value)
                            ent.ID_UNIDAD = Convert.ToInt32(dr["idUnidad"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
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

        public bl_UNIDADEntidad Insertar(bl_UNIDADEntidad ent)
        {
            try
            {

                ent.ID_UNIDAD = p_da.Insertar(ent.NOMBRE, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_UNIDADEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_UNIDAD, ent.NOMBRE, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_UNIDADEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_UNIDAD, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTableUnidad()
        {
            try
            {
                DataTable dt = p_da.Buscar(null);

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
