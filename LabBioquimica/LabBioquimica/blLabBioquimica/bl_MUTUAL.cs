using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_MUTUALEntidad
    {
        private Nullable<Int32> p_ID_MUTUAL;
        public Nullable<Int32> ID_MUTUAL
        {
            get { return p_ID_MUTUAL; }
            set { p_ID_MUTUAL = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private String p_TELEFONO;
        public String TELEFONO
        {
            get { return p_TELEFONO; }
            set { p_TELEFONO = value; }
        }

        private String p_DIRECCION;
        public String DIRECCION
        {
            get { return p_DIRECCION; }
            set { p_DIRECCION = value; }
        }

        private String p_EMAIL;
        public String EMAIL
        {
            get { return p_EMAIL; }
            set { p_EMAIL = value; }
        }

        public bl_MUTUALEntidad() { }

        public bl_MUTUALEntidad(Int32 ID_MUTUAL)
        {
            try
            {
                bl_MUTUAL bl = new bl_MUTUAL();
                bl_MUTUALEntidad ent = bl.BuscarPorPK(ID_MUTUAL);

                if(ent != null)
                {
                    this.ID_MUTUAL = ent.ID_MUTUAL;
                    this.NOMBRE = ent.NOMBRE;
                    this.TELEFONO = ent.TELEFONO;
                    this.DIRECCION = ent.DIRECCION;
                    this.EMAIL = ent.EMAIL;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class bl_MUTUALEntidadColeccion : List<bl_MUTUALEntidad>
    {
    }

    public class bl_MUTUAL
    {

        private daLabBioquimica.da_MUTUAL p_da;

        public bl_MUTUAL()
        {
            p_da = new daLabBioquimica.da_MUTUAL();
        }

        public bl_MUTUALEntidad BuscarPorPK(Nullable<Int32> ID_MUTUAL)
        {

            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_MUTUAL);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_MUTUALEntidad ent = new bl_MUTUALEntidad();

                    if (dt.Rows[0]["idMutual"] != DBNull.Value)
                        ent.ID_MUTUAL = Convert.ToInt32(dt.Rows[0]["idMutual"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["telefono"] != DBNull.Value)
                        ent.TELEFONO = Convert.ToString(dt.Rows[0]["telefono"]);
                    if (dt.Rows[0]["direccion"] != DBNull.Value)
                        ent.DIRECCION = Convert.ToString(dt.Rows[0]["direccion"]);
                    if (dt.Rows[0]["email"] != DBNull.Value)
                        ent.EMAIL = Convert.ToString(dt.Rows[0]["email"]);

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

        public bl_MUTUALEntidadColeccion Buscar(Nullable<Int32> p_ID_MUTUAL, String p_NOMBRE)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_MUTUAL, p_NOMBRE);
                bl_MUTUALEntidadColeccion lista = new bl_MUTUALEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_MUTUALEntidad ent = new bl_MUTUALEntidad();

                        if (dr["idMutual"] != DBNull.Value)
                            ent.ID_MUTUAL = Convert.ToInt32(dr["idMutual"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
                        if (dr["telefono"] != DBNull.Value)
                            ent.TELEFONO = Convert.ToString(dr["telefono"]);
                        if (dr["direccion"] != DBNull.Value)
                            ent.DIRECCION = Convert.ToString(dr["direccion"]);
                        if (dr["email"] != DBNull.Value)
                            ent.EMAIL = Convert.ToString(dr["email"]);

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

        public DataTable dataTableMutual()
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
