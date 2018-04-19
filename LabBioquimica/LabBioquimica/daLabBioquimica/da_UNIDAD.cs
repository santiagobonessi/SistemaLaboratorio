using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_UNIDAD : daLabBioquimica.Framework.daBase
    {
        public da_UNIDAD() : base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_UNIDAD)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT U.idUNidad, U.nombre, "
                            + "U.usr_ing, U.fec_ing, U.usr_mod, U.fec_mod, U.usr_baja, U.fec_baja "
                            + "FROM Unidad U WHERE idUnidad = @ID_UNIDAD";
                

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_UNIDAD", p_ID_UNIDAD);

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


        public DataTable Buscar(String p_NOMBRE)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT U.idUnidad, U.nombre, "
                               + "U.usr_ing, U.fec_ing, U.usr_mod, U.fec_mod, U.usr_baja, U.fec_baja "
                               + "FROM Unidad U "
                               + "WHERE (U.nombre LIKE @NOMBRE + '%' OR @NOMBRE IS NULL) "
                               + "AND U.usr_baja IS NULL "
                               + "AND U.fec_baja IS NULL "
                               + "ORDER BY U.idUnidad";

                SqlCommand com = new SqlCommand(sql, conn);

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

        public Int32 Insertar(String p_NOMBRE, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO Unidad (nombre, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja) "
                            + "VALUES (@NOMBRE, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";
                SqlCommand com = new SqlCommand(sql, conn);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

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


                int idUnidad = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idUnidad;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_UNIDAD, String p_NOMBRE, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Unidad SET nombre = @NOMBRE, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idUnidad = @ID_UNIDAD";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_UNIDAD != null)
                    com.Parameters.AddWithValue("@ID_UNIDAD", p_ID_UNIDAD);
                else
                    com.Parameters.AddWithValue("@ID_UNIDAD", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

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

        public void Baja(Nullable<Int32> p_ID_UNIDAD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Unidad SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idUnidad = @ID_UNIDAD";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_UNIDAD != null)
                    com.Parameters.AddWithValue("@ID_UNIDAD", p_ID_UNIDAD);
                else
                    com.Parameters.AddWithValue("@ID_UNIDAD", DBNull.Value);

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
