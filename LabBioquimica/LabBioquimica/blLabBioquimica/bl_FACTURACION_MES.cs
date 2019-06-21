using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_FACTURACION_MESEntidad
    {
        private Nullable<Int32> p_ID_FACTURACION_MES;
        public Nullable<Int32> ID_FACTURACION_MES
        {
            get { return p_ID_FACTURACION_MES; }
            set { p_ID_FACTURACION_MES = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        public bl_FACTURACION_MESEntidad() { }

        public bl_FACTURACION_MESEntidad(Int32 ID_FACTURACION_MES)
        {
            try
            {
                bl_FACTURACION_MES bl = new bl_FACTURACION_MES();
                bl_FACTURACION_MESEntidad ent = bl.BuscarPorPK(ID_FACTURACION_MES);

                if (ent != null)
                {
                    this.ID_FACTURACION_MES = ent.ID_FACTURACION_MES;
                    this.NOMBRE = ent.NOMBRE;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    public class bl_FACTURACION_MESEntidadColeccion : List<bl_FACTURACION_MESEntidad>
    {
    }

    public class bl_FACTURACION_MES
    {
        private daLabBioquimica.da_FACTURACION_MES p_da;

        public bl_FACTURACION_MES()
        {
            p_da = new daLabBioquimica.da_FACTURACION_MES();
        }

        public bl_FACTURACION_MESEntidad BuscarPorPK(Nullable<Int32> ID_FACTURACION_MES)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_FACTURACION_MES);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_FACTURACION_MESEntidad ent = new bl_FACTURACION_MESEntidad();

                    if (dt.Rows[0]["idFacturacionMes"] != DBNull.Value)
                        ent.ID_FACTURACION_MES = Convert.ToInt32(dt.Rows[0]["idFacturacionMes"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);

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

        public bl_FACTURACION_MESEntidadColeccion Buscar(Nullable<Int32> p_ID_SEXO)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_SEXO);
                bl_FACTURACION_MESEntidadColeccion lista = new bl_FACTURACION_MESEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_FACTURACION_MESEntidad ent = new bl_FACTURACION_MESEntidad();

                        if (dr["idFacturacionMutual"] != DBNull.Value)
                            ent.ID_FACTURACION_MES = Convert.ToInt32(dr["idFacturacionMutual"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);


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

        public DataTable dataTableFacturacionMes()
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
