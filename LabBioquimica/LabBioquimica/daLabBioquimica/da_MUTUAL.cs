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

                String sql = @"SELECT M.idMutual, M.nombre, M.telefono, M.direccion, M.email, "
                             + "M.usr_ing, M.fec_ing, M.usr_mod, M.fec_mod, M.usr_baja, M.fec_baja "
                             + "FROM Mutuales M "
                             + "WHERE idMutual = @ID_MUTUAL";

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

                String sql = @"SELECT M.idMutual, M.nombre, M.telefono, M.direccion, M.email, "
                               + "M.usr_ing, M.fec_ing, M.usr_mod, M.fec_mod, M.usr_baja, M.fec_baja "
                               + "FROM Mutuales M "
                               + "WHERE (M.idMutual = @ID_MUTUAL OR @ID_MUTUAL IS NULL) "
                               + "AND (M.nombre LIKE @NOMBRE + '%' OR @NOMBRE IS NULL) "
                               + "AND M.usr_baja IS NULL "
                               + "AND M.fec_baja IS NULL "
                               + "ORDER BY M.nombre";

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

        public Int32 Insertar(String p_NOMBRE, String p_TELEFONO, String p_DIRECCION, String p_EMAIL, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO Mutuales (nombre, telefono, direccion, email, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja) "
                            + "VALUES (@NOMBRE, @TELEFONO, @DIRECCION, @EMAIL, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";
                SqlCommand com = new SqlCommand(sql, conn);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_TELEFONO != null)
                    com.Parameters.AddWithValue("@TELEFONO", p_TELEFONO);
                else
                    com.Parameters.AddWithValue("@TELEFONO", DBNull.Value);

                if (p_DIRECCION != null)
                    com.Parameters.AddWithValue("@DIRECCION", p_DIRECCION);
                else
                    com.Parameters.AddWithValue("@DIRECCION", DBNull.Value);

                if (p_EMAIL != null)
                    com.Parameters.AddWithValue("@EMAIL", p_EMAIL);
                else
                    com.Parameters.AddWithValue("@EMAIL", DBNull.Value);

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


                int idMutual = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idMutual;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_MUTUAL, String p_NOMBRE, String p_TELEFONO, String p_DIRECCION, String p_EMAIL, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Mutuales SET nombre = @NOMBRE, telefono = @TELEFONO,"
                            + "direccion = @DIRECCION, email = @EMAIL, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idMutual = @ID_MUTUAL";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_TELEFONO != null)
                    com.Parameters.AddWithValue("@TELEFONO", p_TELEFONO);
                else
                    com.Parameters.AddWithValue("@TELEFONO", DBNull.Value);

                if (p_DIRECCION != null)
                    com.Parameters.AddWithValue("@DIRECCION", p_DIRECCION);
                else
                    com.Parameters.AddWithValue("@DIRECCION", DBNull.Value);

                if (p_EMAIL != null)
                    com.Parameters.AddWithValue("@EMAIL", p_EMAIL);
                else
                    com.Parameters.AddWithValue("@EMAIL", DBNull.Value);

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

        public void Baja(Nullable<Int32> p_ID_MUTUAL, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Mutuales SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idMutual = @ID_MUTUAL";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

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
