using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_ANALISIS : daLabBioquimica.Framework.daBase
    {
        public da_ANALISIS() : base() { }


        public DataTable BuscarPorPK(Nullable<Int32> ID_ANALISIS)
        {
            try {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT * FROM Analisis WHERE idAnalisis = @ID_ANALISIS";
                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_ANALISIS", ID_ANALISIS);

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


    }
}
