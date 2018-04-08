using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_ANALISISEntidad
    {
        private Nullable<Int32> p_ID_ANALISIS;
        public Nullable<Int32> ID_ANALISIS
        {
            get { return p_ID_ANALISIS; }
            set { p_ID_ANALISIS = value; }
        }

        private String p_CODIGO;
        public String CODIGO
        {
            get { return p_CODIGO; }
            set { p_CODIGO = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private String p_METODO;
        public String METODO
        {
            get { return p_METODO; }
            set { p_METODO = value; }
        }

        private Nullable<Double> p_UNIDAD_BIOQ;
        public Nullable<Double> UNIDAD_BIOQ
        {
            get { return p_UNIDAD_BIOQ; }
            set { p_UNIDAD_BIOQ = value; }
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

        public bl_ANALISISEntidad() { }

        public bl_ANALISISEntidad(Int32 ID_ANALISIS)
        {
            try
            {
                
                bl_ANALISIS bl = new bl_ANALISIS();
                bl_ANALISISEntidad ent = bl.BuscarPorPK(ID_ANALISIS);

                if (ent != null)
                {
                    this.ID_ANALISIS = ent.ID_ANALISIS;
                    this.CODIGO = ent.CODIGO;
                    this.NOMBRE = ent.NOMBRE;
                    this.METODO = ent.METODO;
                    this.UNIDAD_BIOQ = ent.UNIDAD_BIOQ;
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

    public class bl_ANALISISEntidadColeccion : List<bl_ANALISISEntidad>
    {
    }

    public class bl_ANALISIS
    {
        private daLabBioquimica.da_ANALISIS p_da;

        public bl_ANALISIS()
        {
            p_da = new daLabBioquimica.da_ANALISIS();
        }

        public bl_ANALISISEntidad BuscarPorPK(Nullable<Int32> ID_ANALISIS)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_ANALISIS);
                
                if(dt != null && dt.Rows.Count > 0)
                {
                    bl_ANALISISEntidad ent = new bl_ANALISISEntidad();

                    if (dt.Rows[0]["idAnalisis"] != DBNull.Value)
                        ent.ID_ANALISIS = Convert.ToInt32(dt.Rows[0]["idAnalisis"]);
                    if (dt.Rows[0]["codigo"] != DBNull.Value)
                        ent.CODIGO = Convert.ToString(dt.Rows[0]["codigo"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["metodo"] != DBNull.Value)
                        ent.METODO = Convert.ToString(dt.Rows[0]["metodo"]);
                    if (dt.Rows[0]["unidadBioquimica"] != DBNull.Value)
                        ent.UNIDAD_BIOQ = Convert.ToDouble(dt.Rows[0]["unidadBioquimica"]);
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

        public bl_ANALISISEntidadColeccion Buscar(Nullable<Int32> p_ID_ANALISIS, String p_NOMBRE)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_ANALISIS, p_NOMBRE);
                bl_ANALISISEntidadColeccion lista = new bl_ANALISISEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_ANALISISEntidad ent = new bl_ANALISISEntidad();

                        if (dr["idAnalisis"] != DBNull.Value)
                            ent.ID_ANALISIS = Convert.ToInt32(dr["idAnalisis"]);
                        if (dr["codigo"] != DBNull.Value)
                            ent.CODIGO = Convert.ToString(dr["codigo"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
                        if (dr["metodo"] != DBNull.Value)
                            ent.METODO = Convert.ToString(dr["metodo"]);
                        if (dr["unidadBioquimica"] != DBNull.Value)
                            ent.UNIDAD_BIOQ = Convert.ToDouble(dr["unidadBioquimica"]);
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

        public bl_ANALISISEntidad Insertar(bl_ANALISISEntidad ent)
        {
            try
            {

                ent.ID_ANALISIS = p_da.Insertar(ent.CODIGO, ent.NOMBRE, ent.METODO, ent.UNIDAD_BIOQ, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_ANALISISEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_ANALISIS, ent.CODIGO, ent.NOMBRE, ent.METODO, ent.UNIDAD_BIOQ, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_ANALISISEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_ANALISIS, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTableAnalisis()
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
