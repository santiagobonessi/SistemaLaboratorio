using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_LOCALIDADEnitdad
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

        public bl_LOCALIDADEnitdad() { }

        public bl_LOCALIDADEnitdad(Int32 ID_LOCALIDAD)
        {
            try
            {
                bl_LOCALIDAD bl = new bl_LOCALIDAD();
                bl_LOCALIDADEnitdad ent = bl.BuscarPorPK(ID_LOCALIDAD);

                if (ent != null)
                {
                    this.ID_LOCALIDAD = ent.ID_LOCALIDAD;
                    this.NOMBRE = ent.NOMBRE;
                    this.CODPOSTAL = ent.CODPOSTAL;
                    
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

    public class bl_LOCALIDADEntidadColeccion: List<bl_LOCALIDADEnitdad>
    {
    }

    public class bl_LOCALIDAD
    {

        private daLabBioquimica.da_LOCALIDAD p_da;

        public bl_LOCALIDAD()
        {
            p_da = new daLabBioquimica.da_LOCALIDAD();
        }

        public bl_LOCALIDADEnitdad BuscarPorPK(Nullable<Int32> ID_LOCALIDAD)
        {

            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_LOCALIDAD);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_LOCALIDADEnitdad ent = new bl_LOCALIDADEnitdad();

                    if (dt.Rows[0]["idLocalidad"] != DBNull.Value)
                        ent.ID_LOCALIDAD = Convert.ToInt32(dt.Rows[0]["idLocalidad"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["codPostal"] != DBNull.Value)
                        ent.CODPOSTAL = Convert.ToString(dt.Rows[0]["codPostal"]);

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

        public bl_LOCALIDADEntidadColeccion Buscar(Nullable<Int32> p_ID_LOCALIDAD)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_LOCALIDAD);
                bl_LOCALIDADEntidadColeccion lista = new bl_LOCALIDADEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_LOCALIDADEnitdad ent = new bl_LOCALIDADEnitdad();

                        if (dr["idLocalidad"] != DBNull.Value)
                            ent.ID_LOCALIDAD = Convert.ToInt32(dr["idLocalidad"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
                        if (dr["codPostal"] != DBNull.Value)
                            ent.CODPOSTAL = Convert.ToString(dr["codPostal"]);

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

        public DataTable dataTableLocalidad()
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
