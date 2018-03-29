using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_SEXO : daLabBioquimica.Framework.daBase
    {
        public da_SEXO() : base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_SEXO)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT * FROM Sexo WHERE idSexo = @ID_SEXO";
                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_SEXO", p_ID_SEXO);

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

        public DataTable Buscar(Nullable<Int32> p_ID_SEXO)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT S.idSexo, S.nombre FROM Sexo S "
                               + "WHERE S.idSexo = @ID_SEXO OR @ID_SEXO IS NULL";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_SEXO != null)
                    com.Parameters.AddWithValue("@ID_SEXO", p_ID_SEXO);
                else
                    com.Parameters.AddWithValue("@ID_SEXO", DBNull.Value);


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
