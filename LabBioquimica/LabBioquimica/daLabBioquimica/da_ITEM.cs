using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_ITEM : daLabBioquimica.Framework.daBase
    {
        public da_ITEM() : base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_ITEM)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();
                
                String sql = @"SELECT I.idItem, I.nombre, I.valorReferencia, " 
                            + "I.idAnalisis, A.nombre AS Analisis, I.idUnidad, U.nombre AS Unidad, "
                            + "I.usr_ing, I.fec_ing, I.usr_mod, I.fec_mod, I.usr_baja, I.fec_baja "
                            + "FROM Item I LEFT JOIN Analisis A ON I.idAnalisis = A.idAnalisis "
                            + "LEFT JOIN Unidad U ON I.idUnidad = U.idUnidad "
                            + "WHERE idItem = @ID_ITEM";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_ITEM", p_ID_ITEM);

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

        public DataTable Buscar(Nullable<Int32> p_ID_ITEM, Nullable<Int32> p_ID_ANALISIS, String p_NOMBRE)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT I.idItem, I.nombre, I.valorReferencia, "
                               + "I.idAnalisis, A.nombre AS Analisis, I.idUnidad, U.nombre AS Unidad, "
                               + "I.usr_ing, I.fec_ing, I.usr_mod, I.fec_mod, I.usr_baja, I.fec_baja "
                               + "FROM Item I LEFT JOIN Analisis A ON I.idAnalisis = A.idAnalisis "
                               + "LEFT JOIN Unidad U ON I.idUnidad = U.idUnidad "
                               + "WHERE (I.idItem = @ID_ITEM OR @ID_ITEM IS NULL) "
                               + "AND (I.idAnalisis = @ID_ANALISIS OR @ID_ANALISIS IS NULL) "
                               + "AND (I.nombre LIKE @NOMBRE + '%' OR @NOMBRE IS NULL) "
                               + "AND I.usr_baja IS NULL "
                               + "AND I.fec_baja IS NULL ";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_ITEM != null)
                    com.Parameters.AddWithValue("@ID_ITEM", p_ID_ITEM);
                else
                    com.Parameters.AddWithValue("@ID_ITEM", DBNull.Value);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);

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

        public Int32 Insertar(String p_NOMBRE, String p_VALOR_REF, Nullable<Int32> p_ID_ANALISIS,  Nullable<Int32> p_ID_UNIDAD, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO Item (nombre, valorReferencia, idAnalisis, idUnidad, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja) "
                            + "VALUES (@NOMBRE, @VALOR_REF, @ID_ANALISIS, @ID_UNIDAD, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_VALOR_REF != null)
                    com.Parameters.AddWithValue("@VALOR_REF", p_VALOR_REF);
                else
                    com.Parameters.AddWithValue("@VALOR_REF", DBNull.Value);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);

                if (p_ID_UNIDAD != null)
                    com.Parameters.AddWithValue("@ID_UNIDAD", p_ID_UNIDAD);
                else
                    com.Parameters.AddWithValue("@ID_UNIDAD", DBNull.Value);

                if (p_USR_ING != null)
                    com.Parameters.AddWithValue("@USR_ING", p_USR_ING);
                else
                    com.Parameters.AddWithValue("@USR_ING", DBNull.Value);

                if (p_FEC_ING != null)
                    com.Parameters.AddWithValue("@FEC_ING", p_FEC_ING);
                else
                    com.Parameters.AddWithValue("@FEC_ING", DBNull.Value);

                if (p_USR_MOD != null)
                    com.Parameters.AddWithValue("@USR_MOD", p_USR_MOD);
                else
                    com.Parameters.AddWithValue("@USR_MOD", DBNull.Value);

                if (p_FEC_MOD != null)
                    com.Parameters.AddWithValue("@FEC_MOD", p_FEC_MOD);
                else
                    com.Parameters.AddWithValue("@FEC_MOD", DBNull.Value);

                if (p_USR_BAJA != null)
                    com.Parameters.AddWithValue("@USR_BAJA", p_USR_BAJA);
                else
                    com.Parameters.AddWithValue("@USR_BAJA", DBNull.Value);

                if (p_FEC_BAJA != null)
                    com.Parameters.AddWithValue("@FEC_BAJA", p_FEC_BAJA);
                else
                    com.Parameters.AddWithValue("@FEC_BAJA", DBNull.Value);


                int idItem = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idItem;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_ITEM, String p_NOMBRE, String p_VALOR_REF,Nullable<Int32> p_ID_ANALISIS, Nullable<Int32> p_ID_UNIDAD, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Item SET nombre = @NOMBRE, valorReferencia = @VALOR_REF, "
                            + "idAnalisis = @ID_ANALISIS, idUnidad = @ID_UNIDAD, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idItem = @ID_ITEM";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_ITEM != null)
                    com.Parameters.AddWithValue("@ID_ITEM", p_ID_ITEM);
                else
                    com.Parameters.AddWithValue("@ID_ITEM", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_VALOR_REF != null)
                    com.Parameters.AddWithValue("@VALOR_REF", p_VALOR_REF);
                else
                    com.Parameters.AddWithValue("@VALOR_REF", DBNull.Value);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);

                if (p_ID_UNIDAD != null)
                    com.Parameters.AddWithValue("@ID_UNIDAD", p_ID_UNIDAD);
                else
                    com.Parameters.AddWithValue("@ID_UNIDAD", DBNull.Value);

                if (p_USR_MOD != null)
                    com.Parameters.AddWithValue("@USR_MOD", p_USR_MOD);
                else
                    com.Parameters.AddWithValue("@USR_MOD", DBNull.Value);

                if (p_FEC_MOD != null)
                    com.Parameters.AddWithValue("@FEC_MOD", p_FEC_MOD);
                else
                    com.Parameters.AddWithValue("@FEC_MOD", DBNull.Value);


                com.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }

        }//Termina método Modificar

        public void Baja(Nullable<Int32> p_ID_ITEM, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Item SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idItem = @ID_ITEM";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_ITEM != null)
                    com.Parameters.AddWithValue("@ID_ITEM", p_ID_ITEM);
                else
                    com.Parameters.AddWithValue("@ID_ITEM", DBNull.Value);

                if (p_USR_BAJA != null)
                    com.Parameters.AddWithValue("@USR_BAJA", p_USR_BAJA);
                else
                    com.Parameters.AddWithValue("@USR_BAJA", DBNull.Value);

                if (p_FEC_BAJA != null)
                    com.Parameters.AddWithValue("@FEC_BAJA", p_FEC_BAJA);
                else
                    com.Parameters.AddWithValue("@FEC_BAJA", DBNull.Value);


                com.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }

        } //Termina método Baja


    }
}
