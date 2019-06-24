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


        public DataTable BuscarPorPK(Nullable<Int32> p_ID_ANALISIS)
        {
            try {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT A.idAnalisis, A.codigo, A.nombre, A.metodo, A.unidadBioquimica, "
                            + "A.usr_ing, A.fec_ing, A.usr_mod, A.fec_mod, A.usr_baja, A.fec_baja "
                            + "FROM Analisis A WHERE idAnalisis = @ID_ANALISIS";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);

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

        public DataTable BuscarPorCodigo(String p_CODIGO)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT A.idAnalisis, A.codigo, A.nombre, A.metodo, A.unidadBioquimica, "
                            + "A.usr_ing, A.fec_ing, A.usr_mod, A.fec_mod, A.usr_baja, A.fec_baja "
                            + "FROM Analisis A WHERE codigo = @CODIGO";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@CODIGO", p_CODIGO);

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

        public DataTable Buscar(Nullable<Int32> p_ID_ANALISIS, String p_CODIGO,  String p_NOMBRE)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT A.idAnalisis, A.codigo, A.nombre, A.metodo, A.unidadBioquimica, "
                               + "A.usr_ing, A.fec_ing, A.usr_mod, A.fec_mod, A.usr_baja, A.fec_baja "
                               + "FROM Analisis A "
                               + "WHERE (A.idAnalisis = @ID_ANALISIS OR @ID_ANALISIS IS NULL) "
                               + "AND (A.codigo = @CODIGO OR @CODIGO IS NULL) "
                               + "AND (A.nombre LIKE @NOMBRE + '%' OR @NOMBRE IS NULL) "
                               + "AND A.usr_baja IS NULL "
                               + "AND A.fec_baja IS NULL "
                               + "ORDER BY A.nombre";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_CODIGO != null)
                    com.Parameters.AddWithValue("@CODIGO", p_CODIGO);
                else
                    com.Parameters.AddWithValue("@CODIGO", DBNull.Value);
                

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

        public Int32 Insertar(String p_CODIGO, String p_NOMBRE, String p_METODO, Nullable<Decimal> p_UNIDAD_BIOQ, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO Analisis (codigo, nombre, metodo, unidadBioquimica, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja) "
                            + "VALUES (@CODIGO, @NOMBRE, @METODO, @UNIDAD_BIOQ, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_CODIGO != null)
                    com.Parameters.AddWithValue("@CODIGO", p_CODIGO);
                else
                    com.Parameters.AddWithValue("@CODIGO", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_METODO != null)
                    com.Parameters.AddWithValue("@METODO", p_METODO);
                else
                    com.Parameters.AddWithValue("@METODO", DBNull.Value);

                if (p_UNIDAD_BIOQ != null)
                    com.Parameters.AddWithValue("@UNIDAD_BIOQ", p_UNIDAD_BIOQ);
                else
                    com.Parameters.AddWithValue("@UNIDAD_BIOQ", DBNull.Value);

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


                int idAnalisis = Convert.ToInt32(com.ExecuteScalar());

                conn.Close();

                return idAnalisis;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_ANALISIS, String p_CODIGO, String p_NOMBRE, String p_METODO, Nullable<Decimal> p_UNIDAD_BIOQ, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Analisis SET codigo = @CODIGO, nombre = @NOMBRE, "
                            + "metodo = @METODO, unidadBioquimica = @UNIDAD_BIOQ, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idAnalisis = @ID_ANALISIS";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);

                if (p_CODIGO != null)
                    com.Parameters.AddWithValue("@CODIGO", p_CODIGO);
                else
                    com.Parameters.AddWithValue("@CODIGO", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_METODO != null)
                    com.Parameters.AddWithValue("@METODO", p_METODO);
                else
                    com.Parameters.AddWithValue("@METODO", DBNull.Value);

                if (p_UNIDAD_BIOQ != null)
                    com.Parameters.AddWithValue("@UNIDAD_BIOQ", p_UNIDAD_BIOQ);
                else
                    com.Parameters.AddWithValue("@UNIDAD_BIOQ", DBNull.Value);

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

        public void Baja(Nullable<Int32> p_ID_ANALISIS, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Analisis SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idAnalisis = @ID_ANALISIS";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);

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
