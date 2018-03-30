using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_MUTUAL : daLabBioquimica.Framework.daBase
    {
        public da_MUTUAL() : base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_MUTUAL)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT * FROM Mutuales WHERE idMutual = @ID_MUTUAL";
                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);

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

        public DataTable Buscar(Nullable<Int32> p_ID_MUTUAL, String p_NOMBRE)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT M.idMutual, M.nombre, M.telefono, M.direccion, M.email "
                               + "FROM Mutuales M "
                               + "WHERE (M.idMutual = @ID_MUTUAL OR @ID_MUTUAL IS NULL) "
                               + "AND (M.nombre LIKE @NOMBRE + '%' OR @NOMBRE IS NULL)";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);


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
