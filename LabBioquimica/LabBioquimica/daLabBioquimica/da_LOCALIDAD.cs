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

                String sql = @"SELECT L.idLocalidad, L.nombre, L.codPostal, "
                            + "L.usr_ing, L.fec_ing, L.usr_mod, L.fec_mod, L.usr_baja, L.fec_baja "
                            + "FROM Localidad L WHERE idLocalidad = @ID_LOCALIDAD";

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

        public DataTable Buscar(Nullable<Int32> p_ID_LOCALIDAD, String p_NOMBRE)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT L.idLocalidad, L.nombre, L.codPostal, "
                               + "L.usr_ing, L.fec_ing, L.usr_mod, L.fec_mod, L.usr_baja, L.fec_baja "
                               + "FROM Localidad L "
                               + "WHERE (L.idLocalidad = @ID_LOCALIDAD OR @ID_LOCALIDAD IS NULL) "
                               + "AND (L.nombre LIKE @NOMBRE + '%' OR @NOMBRE IS NULL) "
                               + "AND L.usr_baja IS NULL "
                               + "AND L.fec_baja IS NULL "
                               + "ORDER BY L.nombre";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_LOCALIDAD != null)
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", p_ID_LOCALIDAD);
                else
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", DBNull.Value);

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

        public Int32 Insertar(String p_NOMBRE, String P_COD_POSTAL, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO Localidad (nombre, codPostal, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja) "
                            + "VALUES (@NOMBRE, @COD_POSTAL, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";
                SqlCommand com = new SqlCommand(sql, conn);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (P_COD_POSTAL != null)
                    com.Parameters.AddWithValue("@COD_POSTAL", P_COD_POSTAL);
                else
                    com.Parameters.AddWithValue("@COD_POSTAL", DBNull.Value);

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


                int idLocalidad = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idLocalidad;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_LOCALIDAD, String p_NOMBRE, String p_COD_POSTAL, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Localidad SET nombre = @NOMBRE, codPostal = @COD_POSTAL,"
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idLocalidad = @ID_LOCALIDAD";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_LOCALIDAD != null)
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", p_ID_LOCALIDAD);
                else
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_COD_POSTAL != null)
                    com.Parameters.AddWithValue("@COD_POSTAL", p_COD_POSTAL);
                else
                    com.Parameters.AddWithValue("@COD_POSTAL", DBNull.Value);

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

        public void Baja(Nullable<Int32> p_ID_LOCALIDAD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Localidad SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idLocalidad = @ID_LOCALIDAD";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_LOCALIDAD != null)
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", p_ID_LOCALIDAD);
                else
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", DBNull.Value);

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
