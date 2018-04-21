using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_PROTOCOLO_DETALLEEntidad
    {
        private Nullable<Int32> p_ID_PROTOCOLO_DETALLE;
        public Nullable<Int32> ID_PROTOCOLO_DETALLE
        {
            get { return p_ID_PROTOCOLO_DETALLE; }
            set { p_ID_PROTOCOLO_DETALLE = value; }
        }

        private Nullable<Int32> p_ID_PROTOCOLO;
        public Nullable<Int32> ID_PROTOCOLO
        {
            get { return p_ID_PROTOCOLO; }
            set { p_ID_PROTOCOLO = value; }
        }

        private Nullable<Int32> p_ID_ANALISIS;
        public Nullable<Int32> ID_ANALISIS
        {
            get { return p_ID_ANALISIS; }
            set { p_ID_ANALISIS = value; }
        }

        private String p_CODIGO_ANALISIS;
        public String CODIGO_ANALISIS
        {
            get { return p_CODIGO_ANALISIS; }
            set { p_CODIGO_ANALISIS = value; }
        }

        private String p_NOMBRE_ANALISIS;
        public String NOMBRE_ANALISIS
        {
            get { return p_NOMBRE_ANALISIS; }
            set { p_NOMBRE_ANALISIS = value; }
        }

        private String p_METODO_ANALISIS;
        public String METODO_ANALISIS
        {
            get { return p_METODO_ANALISIS; }
            set { p_METODO_ANALISIS = value; }
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

        public bl_PROTOCOLO_DETALLEEntidad() { }

        public bl_PROTOCOLO_DETALLEEntidad(Int32 ID_PROTOCOLO_DET)
        {
            try
            {

                bl_PROTOCOLO_DETALLE bl = new bl_PROTOCOLO_DETALLE();
                bl_PROTOCOLO_DETALLEEntidad ent = bl.BuscarPorPK(ID_PROTOCOLO_DET);


                if (ent != null)
                {
                    this.ID_PROTOCOLO_DETALLE = ent.ID_PROTOCOLO_DETALLE;
                    this.ID_PROTOCOLO = ent.ID_PROTOCOLO;
                    this.ID_ANALISIS = ent.ID_ANALISIS;
                    this.NOMBRE_ANALISIS = ent.NOMBRE_ANALISIS;
                    this.METODO_ANALISIS = ent.METODO_ANALISIS;
                    this.CODIGO_ANALISIS = ent.CODIGO_ANALISIS;
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

    public class bl_PROTOCOLO_DETALLEEntidadColeccion : List<bl_PROTOCOLO_DETALLEEntidad>
    {
    }

    public class bl_PROTOCOLO_DETALLE
    {

        private daLabBioquimica.da_PROTOCOLO_DETALLE p_da;

        public bl_PROTOCOLO_DETALLE()
        {
            p_da = new daLabBioquimica.da_PROTOCOLO_DETALLE();
        }

        public bl_PROTOCOLO_DETALLEEntidad BuscarPorPK(Nullable<Int32> p_ID_PROTOCOLO_DET)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(p_ID_PROTOCOLO_DET);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_PROTOCOLO_DETALLEEntidad ent = new bl_PROTOCOLO_DETALLEEntidad();

                    if (dt.Rows[0]["idProtocoloDetalle"] != DBNull.Value)
                        ent.ID_PROTOCOLO_DETALLE = Convert.ToInt32(dt.Rows[0]["idProtocoloDetalle"]);
                    if (dt.Rows[0]["idProtocolo"] != DBNull.Value)
                        ent.ID_PROTOCOLO = Convert.ToInt32(dt.Rows[0]["idProtocolo"]);
                    if (dt.Rows[0]["idAnalisis"] != DBNull.Value)
                        ent.ID_ANALISIS = Convert.ToInt32(dt.Rows[0]["idAnalisis"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE_ANALISIS = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["metodo"] != DBNull.Value)
                        ent.METODO_ANALISIS = Convert.ToString(dt.Rows[0]["metodo"]);
                    if (dt.Rows[0]["codigo"] != DBNull.Value)
                        ent.CODIGO_ANALISIS = Convert.ToString(dt.Rows[0]["codigo"]);
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

        public bl_PROTOCOLO_DETALLEEntidadColeccion Buscar(Nullable<Int32> p_ID_PROTOCOLO_DET, Nullable<Int32> p_ID_PROTOCOLO, Nullable<Int32> p_ID_ANALISIS)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_PROTOCOLO_DET, p_ID_PROTOCOLO, p_ID_ANALISIS);
                bl_PROTOCOLO_DETALLEEntidadColeccion lista = new bl_PROTOCOLO_DETALLEEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_PROTOCOLO_DETALLEEntidad ent = new bl_PROTOCOLO_DETALLEEntidad();

                        if (dr["idProtocoloDetalle"] != DBNull.Value)
                            ent.ID_PROTOCOLO_DETALLE = Convert.ToInt32(dr["idProtocoloDetalle"]);
                        if (dr["idProtocolo"] != DBNull.Value)
                            ent.ID_PROTOCOLO = Convert.ToInt32(dr["idProtocolo"]);
                        if (dr["idAnalisis"] != DBNull.Value)
                            ent.ID_ANALISIS = Convert.ToInt32(dr["idAnalisis"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE_ANALISIS = Convert.ToString(dr["nombre"]);
                        if (dr["metodo"] != DBNull.Value)
                            ent.METODO_ANALISIS = Convert.ToString(dr["metodo"]);
                        if (dr["codigo"] != DBNull.Value)
                            ent.CODIGO_ANALISIS = Convert.ToString(dr["codigo"]);
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


        public bl_PROTOCOLO_DETALLEEntidad Insertar(bl_PROTOCOLO_DETALLEEntidad ent)
        {
            try
            {

                ent.ID_PROTOCOLO = p_da.Insertar(ent.ID_PROTOCOLO, ent.ID_ANALISIS, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_PROTOCOLO_DETALLEEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_PROTOCOLO_DETALLE, ent.ID_PROTOCOLO, ent.ID_ANALISIS, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_PROTOCOLO_DETALLEEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_PROTOCOLO_DETALLE, ent.USR_BAJA, ent.FEC_BAJA);
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
                DataTable dt = p_da.Buscar(null, null, null);

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
