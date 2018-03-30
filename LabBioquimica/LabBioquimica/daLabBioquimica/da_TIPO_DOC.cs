using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_TIPO_DOC : daLabBioquimica.Framework.daBase
    {
        public da_TIPO_DOC() : base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_TIPO_DOC)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT * FROM TipoDocumento WHERE idTipoDoc = @ID_TIPO_DOC";
                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_TIPO_DOC", p_ID_TIPO_DOC);

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

        public DataTable Buscar(Nullable<Int32> p_ID_TIPO_DOC)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT TD.idTipoDoc, TD.nombre FROM TipoDocumento TD "
                               + "WHERE (TD.idTipoDoc = @ID_TIPO_DOC OR @ID_TIPO_DOC IS NULL) ";


                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_TIPO_DOC != null)
                    com.Parameters.AddWithValue("@ID_TIPO_DOC", p_ID_TIPO_DOC);
                else
                    com.Parameters.AddWithValue("@ID_TIPO_DOC", DBNull.Value);


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
