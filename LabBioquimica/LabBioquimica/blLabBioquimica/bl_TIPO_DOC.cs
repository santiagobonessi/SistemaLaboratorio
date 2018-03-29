using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace blLabBioquimica
{
    public class bl_TIPO_DOCEntidad
    {

        private Nullable<Int32> p_ID_TIPO_DOC;
        public Nullable<Int32> ID_TIPO_DOC
        {
            get { return p_ID_TIPO_DOC; }
            set { p_ID_TIPO_DOC = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        public bl_TIPO_DOCEntidad() { }

        public bl_TIPO_DOCEntidad(Int32 ID_TIPO_DOC)
        {
            try
            {
                bl_TIPO_DOC bl = new bl_TIPO_DOC();
                bl_TIPO_DOCEntidad ent = bl.BuscarPorPK(ID_TIPO_DOC);

                if (ent != null)
                {
                    this.ID_TIPO_DOC = ent.ID_TIPO_DOC;
                    this.NOMBRE = ent.NOMBRE;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    public class bl_TIPO_DOCEntidadColeccion: List<bl_TIPO_DOCEntidad>
    {
    }

    public class bl_TIPO_DOC
    {
        private daLabBioquimica.da_TIPO_DOC p_da;

        public bl_TIPO_DOC()
        {
            p_da = new daLabBioquimica.da_TIPO_DOC();
        }

        public bl_TIPO_DOCEntidad BuscarPorPK(Nullable<Int32> ID_TIPO_DOC)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_TIPO_DOC);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_TIPO_DOCEntidad ent = new bl_TIPO_DOCEntidad();

                    if (dt.Rows[0]["idTipoDoc"] != DBNull.Value)
                        ent.ID_TIPO_DOC = Convert.ToInt32(dt.Rows[0]["idTipoDoc"]);
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

        public bl_TIPO_DOCEntidadColeccion Buscar(Nullable<Int32> p_ID_TIPO_DOC)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_TIPO_DOC);
                bl_TIPO_DOCEntidadColeccion lista = new bl_TIPO_DOCEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_TIPO_DOCEntidad ent = new bl_TIPO_DOCEntidad();

                        if (dr["idTipoDoc"] != DBNull.Value)
                            ent.ID_TIPO_DOC = Convert.ToInt32(dr["idTipoDoc"]);
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

        public DataTable dataTableTipoDoc()
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
