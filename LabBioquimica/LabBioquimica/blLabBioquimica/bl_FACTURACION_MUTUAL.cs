using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_FACTURACION_MUTUALEntidad
    {
        private Nullable<Int32> p_ID_FACTURACION_MUTUAL;
        public Nullable<Int32> ID_FACTURACION_MUTUAL
        {
            get { return p_ID_FACTURACION_MUTUAL; }
            set { p_ID_FACTURACION_MUTUAL = value; }
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

        private Nullable<Int32> p_ID_FACTURACION_MES;
        public Nullable<Int32> ID_FACTURACION_MES
        {
            get { return p_ID_FACTURACION_MES; }
            set { p_ID_FACTURACION_MES = value; }
        }

        private String p_N_FACTURACION_MES;
        public String N_FACTURACION_MES
        {
            get { return p_N_FACTURACION_MES; }
            set { p_N_FACTURACION_MES = value; }
        }

        private Nullable<Decimal> p_PRECIO_UNID_BIOQ;
        public Nullable<Decimal> PRECIO_UNID_BIOQ
        {
            get { return p_PRECIO_UNID_BIOQ; }
            set { p_PRECIO_UNID_BIOQ = value; }
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

        public bl_FACTURACION_MUTUALEntidad() { }

        public bl_FACTURACION_MUTUALEntidad(Int32 ID_FACTURACION_MUTUAL)
        {
            try
            {

                bl_FACTURACION_MUTUAL bl = new bl_FACTURACION_MUTUAL();
                bl_FACTURACION_MUTUALEntidad ent = bl.BuscarPorPK(ID_FACTURACION_MUTUAL);


                if (ent != null)
                {

                    this.ID_FACTURACION_MUTUAL = ent.ID_FACTURACION_MUTUAL;
                    this.ID_MUTUAL = ent.ID_MUTUAL;
                    this.N_MUTUAL = ent.N_MUTUAL;
                    this.ID_FACTURACION_MES = ent.ID_FACTURACION_MES;
                    this.N_FACTURACION_MES = ent.N_FACTURACION_MES;
                    this.PRECIO_UNID_BIOQ = ent.PRECIO_UNID_BIOQ;
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

    public class bl_FACTURACION_MUTUALEntidadColeccion : List<bl_FACTURACION_MUTUALEntidad>
    {
    }

    public class bl_FACTURACION_MUTUAL
    {

        private daLabBioquimica.da_FACTURACION_MUTUAL p_da;

        public bl_FACTURACION_MUTUAL()
        {
            p_da = new daLabBioquimica.da_FACTURACION_MUTUAL();
        }

        public bl_FACTURACION_MUTUALEntidad BuscarPorPK(Nullable<Int32> p_ID_FACTURACION_MUTUAL)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(p_ID_FACTURACION_MUTUAL);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_FACTURACION_MUTUALEntidad ent = new bl_FACTURACION_MUTUALEntidad();


                    if (dt.Rows[0]["idFacturacionMutual"] != DBNull.Value)
                        ent.ID_FACTURACION_MUTUAL = Convert.ToInt32(dt.Rows[0]["idFacturacionMutual"]);
                    if (dt.Rows[0]["idMutual"] != DBNull.Value)
                        ent.ID_MUTUAL = Convert.ToInt32(dt.Rows[0]["idMutual"]);
                    if (dt.Rows[0]["nomMutual"] != DBNull.Value)
                        ent.N_MUTUAL = Convert.ToString(dt.Rows[0]["nomMutual"]);
                    if (dt.Rows[0]["idFacturacionMes"] != DBNull.Value)
                        ent.ID_FACTURACION_MES = Convert.ToInt32(dt.Rows[0]["idFacturacionMes"]);
                    if (dt.Rows[0]["nomMes"] != DBNull.Value)
                        ent.N_FACTURACION_MES = Convert.ToString(dt.Rows[0]["nomMes"]);
                    if (dt.Rows[0]["precioUnidadBioquimica"] != DBNull.Value)
                        ent.PRECIO_UNID_BIOQ = Convert.ToDecimal(dt.Rows[0]["precioUnidadBioquimica"]);
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


        public bl_FACTURACION_MUTUALEntidadColeccion Buscar(Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_MUTUAL, Nullable<Int32> p_ID_FACTURACION_MES)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_FACTURACION_MUTUAL, p_ID_MUTUAL, p_ID_FACTURACION_MES);
                bl_FACTURACION_MUTUALEntidadColeccion lista = new bl_FACTURACION_MUTUALEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_FACTURACION_MUTUALEntidad ent = new bl_FACTURACION_MUTUALEntidad();
                        if (dr["idFacturacionMutual"] != DBNull.Value)
                            ent.ID_FACTURACION_MUTUAL = Convert.ToInt32(dr["idFacturacionMutual"]);
                        if (dr["idMutual"] != DBNull.Value)
                            ent.ID_MUTUAL = Convert.ToInt32(dr["idMutual"]);
                        if (dr["nomMutual"] != DBNull.Value)
                            ent.N_MUTUAL = Convert.ToString(dr["nomMutual"]);
                        if (dr["idFacturacionMes"] != DBNull.Value)
                            ent.ID_FACTURACION_MES = Convert.ToInt32(dr["idFacturacionMes"]);
                        if (dr["nomMes"] != DBNull.Value)
                            ent.N_FACTURACION_MES = Convert.ToString(dr["nomMes"]);
                        if (dr["precioUnidadBioquimica"] != DBNull.Value)
                            ent.PRECIO_UNID_BIOQ = Convert.ToInt32(dr["precioUnidadBioquimica"]);
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


        public bl_FACTURACION_MUTUALEntidad Insertar(bl_FACTURACION_MUTUALEntidad ent)
        {
            try
            {

                ent.ID_FACTURACION_MUTUAL = p_da.Insertar(ent.ID_MUTUAL, ent.ID_FACTURACION_MES, ent.PRECIO_UNID_BIOQ, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_FACTURACION_MUTUALEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_FACTURACION_MUTUAL, ent.ID_MUTUAL, ent.ID_FACTURACION_MES, ent.PRECIO_UNID_BIOQ, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_FACTURACION_MUTUALEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_FACTURACION_MUTUAL, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTableFacturacionMutual(Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_MUTUAL, Nullable<Int32> p_ID_FACTURACION_MES)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_FACTURACION_MUTUAL, p_ID_MUTUAL, p_ID_FACTURACION_MES);

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
