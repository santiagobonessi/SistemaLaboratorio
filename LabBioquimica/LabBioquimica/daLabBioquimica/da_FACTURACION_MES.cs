using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_FACTURACION_MES : daLabBioquimica.Framework.daBase
    {
        public da_FACTURACION_MES() : base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_FACTURACION_MES)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT * FROM Facturacionmes WHERE idFacturacionMes = @ID_FACTURACION_MES";
                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_FACTURACION_MES", p_ID_FACTURACION_MES);

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

        public DataTable Buscar(Nullable<Int32> p_ID_FACTURACION_MES)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT FMes.idFacturacionMes, FMes.nombre FROM FacturacionMes FMes "
                               + "WHERE FMes.idFacturacionMes = @ID_FACTURACION_MES OR @ID_FACTURACION_MES IS NULL";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_MES != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", p_ID_FACTURACION_MES);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", DBNull.Value);


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
