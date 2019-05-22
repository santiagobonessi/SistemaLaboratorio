using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_ITEMEntidad
    {
        private Nullable<Int32> p_ID_ITEM;
        public Nullable<Int32> ID_ITEM
        {
            get { return p_ID_ITEM; }
            set { p_ID_ITEM = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private String p_VALOR_REF;
        public String VALOR_REF
        {
            get { return p_VALOR_REF; }
            set { p_VALOR_REF = value; }
        }

        private Nullable<Int32> p_ID_ANALISIS;
        public Nullable<Int32> ID_ANALISIS
        {
            get { return p_ID_ANALISIS; }
            set { p_ID_ANALISIS = value; }
        }

        private String p_N_ANALISIS;
        public String N_ANALISIS
        {
            get { return p_N_ANALISIS; }
            set { p_N_ANALISIS = value; }
        }

        private Nullable<Int32> p_ID_UNIDAD;
        public Nullable<Int32> ID_UNIDAD
        {
            get { return p_ID_UNIDAD; }
            set { p_ID_UNIDAD = value; }
        }

        private String p_N_UNIDAD;
        public String N_UNIDAD
        {
            get { return p_N_UNIDAD; }
            set { p_N_UNIDAD = value; }
        }

        private Nullable<Int32> p_NRO_ORDEN;
        public Nullable<Int32> NRO_ORDEN
        {
            get { return p_NRO_ORDEN; }
            set { p_NRO_ORDEN = value; }
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



        public bl_ITEMEntidad() { }

        public bl_ITEMEntidad(Int32 ID_ITEM)
        {
            try
            {

                bl_ITEM bl = new bl_ITEM();
                bl_ITEMEntidad ent = bl.BuscarPorPK(ID_ITEM);

                if (ent != null)
                {
                    this.ID_ITEM = ent.ID_ITEM;
                    this.NOMBRE = ent.NOMBRE;
                    this.VALOR_REF = ent.VALOR_REF;
                    this.ID_ANALISIS = ent.ID_ANALISIS;
                    this.N_ANALISIS = ent.N_ANALISIS;
                    this.ID_UNIDAD = ent.ID_UNIDAD;
                    this.N_UNIDAD = ent.N_UNIDAD;
                    this.NRO_ORDEN = ent.NRO_ORDEN;
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

    public class bl_ITEMEntidadColeccion : List<bl_ITEMEntidad>
    {
    }

    public class bl_ITEM
    {
        private daLabBioquimica.da_ITEM p_da;

        public bl_ITEM()
        {
            p_da = new daLabBioquimica.da_ITEM();
        }

        public bl_ITEMEntidad BuscarPorPK(Nullable<Int32> p_ID_ITEM)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(p_ID_ITEM);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_ITEMEntidad ent = new bl_ITEMEntidad();

                    if (dt.Rows[0]["idItem"] != DBNull.Value)
                        ent.ID_ITEM = Convert.ToInt32(dt.Rows[0]["idItem"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["valorReferencia"] != DBNull.Value)
                        ent.VALOR_REF = Convert.ToString(dt.Rows[0]["valorReferencia"]);
                    if (dt.Rows[0]["idAnalisis"] != DBNull.Value)
                        ent.ID_ANALISIS = Convert.ToInt32(dt.Rows[0]["idAnalisis"]);
                    if (dt.Rows[0]["Analisis"] != DBNull.Value)
                        ent.N_ANALISIS = Convert.ToString(dt.Rows[0]["Analisis"]);
                    if (dt.Rows[0]["idUnidad"] != DBNull.Value)
                        ent.ID_UNIDAD = Convert.ToInt32(dt.Rows[0]["idUnidad"]);
                    if (dt.Rows[0]["Unidad"] != DBNull.Value)
                        ent.N_UNIDAD = Convert.ToString(dt.Rows[0]["Unidad"]);
                    if (dt.Rows[0]["nroOrden"] != DBNull.Value)
                        ent.NRO_ORDEN = Convert.ToInt32(dt.Rows[0]["nroOrden"]);
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

        public bl_ITEMEntidadColeccion Buscar(Nullable<Int32> p_ID_ITEM, Nullable<Int32> p_ID_ANALISIS, String p_NOMBRE)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_ITEM, p_ID_ANALISIS, p_NOMBRE);
                bl_ITEMEntidadColeccion lista = new bl_ITEMEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_ITEMEntidad ent = new bl_ITEMEntidad();

                        if (dr["idItem"] != DBNull.Value)
                            ent.ID_ITEM = Convert.ToInt32(dr["idItem"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
                        if (dr["valorReferencia"] != DBNull.Value)
                            ent.VALOR_REF = Convert.ToString(dr["valorReferencia"]);
                        if (dr["idAnalisis"] != DBNull.Value)
                            ent.ID_ANALISIS = Convert.ToInt32(dr["idAnalisis"]);
                        if (dr["Analisis"] != DBNull.Value)
                            ent.N_ANALISIS = Convert.ToString(dr["Analisis"]);
                        if (dr["idUnidad"] != DBNull.Value)
                            ent.ID_UNIDAD = Convert.ToInt32(dr["idUnidad"]);
                        if (dr["Unidad"] != DBNull.Value)
                            ent.N_UNIDAD = Convert.ToString(dr["Unidad"]);
                        if (dr["nroOrden"] != DBNull.Value)
                            ent.NRO_ORDEN = Convert.ToInt32(dr["nroOrden"]);
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

        public bl_ITEMEntidad Insertar(bl_ITEMEntidad ent)
        {
            try
            {

                ent.ID_ITEM = p_da.Insertar(ent.NOMBRE, ent.VALOR_REF, ent.ID_ANALISIS, ent.ID_UNIDAD, ent.NRO_ORDEN, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_ITEMEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_ITEM, ent.NOMBRE, ent.VALOR_REF, ent.ID_ANALISIS, ent.ID_UNIDAD, ent.NRO_ORDEN, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_ITEMEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_ITEM, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTableItem()
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
