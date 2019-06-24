using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_SEXOEntidad
    {
        private Nullable<Int32> p_ID_SEXO;
        public Nullable<Int32> ID_SEXO
        {
            get { return p_ID_SEXO; }
            set { p_ID_SEXO = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        public bl_SEXOEntidad() { }

        public bl_SEXOEntidad(Int32 ID_SEXO)
        {
            try
            {
                bl_SEXO bl = new bl_SEXO();
                bl_SEXOEntidad ent = bl.BuscarPorPK(ID_SEXO);

                if (ent != null)
                {
                    this.ID_SEXO = ent.ID_SEXO;
                    this.NOMBRE = ent.NOMBRE;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
         
    }

    public class bl_SEXOEntidadColeccion : List<bl_SEXOEntidad>
    {
    }


    public class bl_SEXO
    {

        private daLabBioquimica.da_SEXO p_da;

        public bl_SEXO()
        {
            p_da = new daLabBioquimica.da_SEXO();
        }

        public bl_SEXOEntidad BuscarPorPK(Nullable<Int32> ID_SEXO)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_SEXO);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_SEXOEntidad ent = new bl_SEXOEntidad();

                    if (dt.Rows[0]["idSexo"] != DBNull.Value)
                        ent.ID_SEXO = Convert.ToInt32(dt.Rows[0]["idSexo"]);
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

        public bl_SEXOEntidadColeccion Buscar(Nullable<Int32> p_ID_SEXO)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_SEXO);
                bl_SEXOEntidadColeccion lista = new bl_SEXOEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_SEXOEntidad ent = new bl_SEXOEntidad();

                        if (dr["idSexo"] != DBNull.Value)
                            ent.ID_SEXO = Convert.ToInt32(dr["idSexo"]);
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

        public DataTable dataTableSexo()
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
