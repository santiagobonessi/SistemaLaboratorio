using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_LOCALIDAD : daLabBioquimica.Framework.daBase
    {
        public da_LOCALIDAD() : base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_LOCALIDAD)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT * FROM Localidad WHERE idLocalidad = @ID_LOCALIDAD";
                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_LOCALIDAD", p_ID_LOCALIDAD);

                SqlDataAdapter da = new SqlDataAdapter(com);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                    return ds.Tables[0];

                return null;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }

        public DataTable Buscar(Nullable<Int32> p_ID_LOCALIDAD)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT L.idLocalidad, L.nombre, L.codPostal "
                               + "FROM Localidad L "
                               + "WHERE (L.idLocalidad = @ID_LOCALIDAD OR @ID_LOCALIDAD IS NULL) ";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_LOCALIDAD != null)
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", p_ID_LOCALIDAD);
                else
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", DBNull.Value);


                SqlDataAdapter da = new SqlDataAdapter(com);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }


    }
}
