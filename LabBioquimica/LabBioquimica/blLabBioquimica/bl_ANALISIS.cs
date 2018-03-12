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

        private Nullable<Double> p_UNID_BIOQ;
        public Nullable<Double> UNID_BIOQ
        {
            get { return p_UNID_BIOQ; }
            set { p_UNID_BIOQ = value; }
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
                    this.UNID_BIOQ = ent.UNID_BIOQ;
                }
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
                        ent.UNID_BIOQ = Convert.ToDouble(dt.Rows[0]["unidadBioquimica"]);

                    return ent;
                }
                else
                {
                    return null;
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
