using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_FACTURACION_MUTUAL : daLabBioquimica.Framework.daBase
    {

        public da_FACTURACION_MUTUAL() :base() { }

        /// <summary>
        /// Metodo que busca por clave primaria un objeto especifico.
        /// </summary>
        /// <param name="p_ID_FACTURACION_MUTUAL"></param>
        /// <returns name="DataTable"></returns>
        public DataTable BuscarPorPK(Nullable<Int32> p_ID_FACTURACION_MUTUAL)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT FM.idFacturacionMutual, FM.idMutual, M.nombre AS nomMutual, FM.idFacturacionMes, "
                               + "FMes.nombre AS nomMes, FM.anio, FM.precioUnidadBioquimica, "
                               + "FM.usr_ing, FM.fec_ing, FM.usr_mod, FM.fec_mod, FM.usr_baja, FM.fec_baja "
                               + "FROM FacturacionMutual FM INNER JOIN Mutuales M ON FM.idMutual = M.idMutual "
                               + "INNER JOIN  FacturacionMes FMes ON FM.idFacturacionMes = FMes.idFacturacionMes "
                               + "WHERE FM.idFacturacionMutual = @ID_FACTURACION_MUTUAL ";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", p_ID_FACTURACION_MUTUAL);

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

        /// <summary>
        /// Metodo que retorna un DataTable con los datos encontrados.
        /// </summary>
        /// <param name="p_ID_FACTURACION_MUTUAL"></param>
        /// <param name="p_ID_MUTUAL"></param>
        /// <param name="p_ID_FACTURACION_MES"></param>
        /// <returns name="DateTable"></returns>
        public DataTable Buscar(Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_MUTUAL, Nullable<Int32> p_ID_FACTURACION_MES, Nullable<Int32> p_ANIO)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT FM.idFacturacionMutual, FM.idMutual, M.nombre AS nomMutual, FM.idFacturacionMes, " 
                               + "FMes.nombre AS nomMes, FM.anio, FM.precioUnidadBioquimica, "
                               + "FM.usr_ing, FM.fec_ing, FM.usr_mod, FM.fec_mod, FM.usr_baja, FM.fec_baja "
                               + "FROM FacturacionMutual FM INNER JOIN Mutuales M ON FM.idMutual = M.idMutual "
                               + "INNER JOIN  FacturacionMes FMes ON FM.idFacturacionMes = FMes.idFacturacionMes "
                               + "WHERE (FM.idFacturacionMutual = @ID_FACTURACION_MUTUAL OR @ID_FACTURACION_MUTUAL IS NULL) "
                               + "AND (FM.idMutual = @ID_MUTUAL OR @ID_MUTUAL IS NULL) "
                               + "AND (FM.idFacturacionMes = @ID_FACTURACION_MES OR @ID_FACTURACION_MES IS NULL) "
                               + "AND (FM.anio = @ANIO OR @ANIO IS NULL) "
                               + "AND FM.usr_baja IS NULL "
                               + "AND FM.fec_baja IS NULL ";
                               

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", p_ID_FACTURACION_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", DBNull.Value);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

                if (p_ID_FACTURACION_MES != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", p_ID_FACTURACION_MES);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", DBNull.Value);

                if (p_ANIO != null)
                    com.Parameters.AddWithValue("@ANIO", p_ANIO);
                else
                    com.Parameters.AddWithValue("@ANIO", DBNull.Value);


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

        /// <summary>
        /// Metodo que retorna un DataTable con los datos encontrados.
        /// </summary>
        /// <param name="p_ID_FACTURACION_MUTUAL"></param>
        /// <param name="p_ID_MUTUAL"></param>
        /// <param name="p_ID_FACTURACION_MES"></param>
        /// <returns name="DateTable"></returns>
        public DataTable BuscarConTotal(Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_MUTUAL, Nullable<Int32> p_ID_FACTURACION_MES, Nullable<Int32> p_ANIO)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT FM.idFacturacionMutual, FM.idMutual, M.nombre AS nomMutual, FM.idFacturacionMes, "
                               + "FMes.nombre AS nomMes, FM.anio, FM.precioUnidadBioquimica, "
                               + "FM.usr_ing, FM.fec_ing, FM.usr_mod, FM.fec_mod, FM.usr_baja, FM.fec_baja, "
                               + "(SELECT SUM(A.unidadBioquimica) FROM FacturacionOrden FO "
                               + "INNER JOIN FacturacionAnalisis FA ON (FO.idFacturacionOrden = FA.idFacturacionOrden AND FO.usr_baja IS NULL AND FO.fec_baja IS NULL) "
                               + "INNER JOIN Analisis A ON (FA.idAnalisis = A.idAnalisis) "
                               + "WHERE FO.idFacturacionMutual = FM.idFacturacionMutual) AS TotalUnidadBioq "
                               + "FROM FacturacionMutual FM INNER JOIN Mutuales M ON FM.idMutual = M.idMutual "
                               + "INNER JOIN  FacturacionMes FMes ON FM.idFacturacionMes = FMes.idFacturacionMes "
                               + "WHERE (FM.idFacturacionMutual = @ID_FACTURACION_MUTUAL OR @ID_FACTURACION_MUTUAL IS NULL) "
                               + "AND (FM.idMutual = @ID_MUTUAL OR @ID_MUTUAL IS NULL) "
                               + "AND (FM.idFacturacionMes = @ID_FACTURACION_MES OR @ID_FACTURACION_MES IS NULL) "
                               + "AND (FM.anio = @ANIO OR @ANIO IS NULL) "
                               + "AND FM.usr_baja IS NULL "
                               + "AND FM.fec_baja IS NULL "
                               + "ORDER BY FM.anio, FM.idFacturacionMes";


                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", p_ID_FACTURACION_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", DBNull.Value);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

                if (p_ID_FACTURACION_MES != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", p_ID_FACTURACION_MES);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", DBNull.Value);

                if (p_ANIO != null)
                    com.Parameters.AddWithValue("@ANIO", p_ANIO);
                else
                    com.Parameters.AddWithValue("@ANIO", DBNull.Value);


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

        /// <summary>
        /// Método que inserta un objeto de la clase y retorna el id.
        /// </summary>
        /// <param name="p_ID_MUTUAL"></param>
        /// <param name="p_ID_FACTURACION_MES"></param>
        /// <param name="p_PRECIO_UNID_BIOQ"></param>
        /// <param name="p_USR_ING"></param>
        /// <param name="p_FEC_ING"></param>
        /// <param name="p_USR_MOD"></param>
        /// <param name="p_FEC_MOD"></param>
        /// <param name="p_USR_BAJA"></param>
        /// <param name="p_FEC_BAJA"></param>
        /// <returns name ="idFacturacionMutual"></returns>
        public Int32 Insertar(Nullable<Int32> p_ID_MUTUAL, Nullable<Int32> p_ID_FACTURACION_MES, Nullable<Int32> p_ANIO, Nullable<Decimal> p_PRECIO_UNID_BIOQ, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO FacturacionMutual (idMutual, idFacturacionMes, anio, precioUnidadBioquimica, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja)"
                            + "VALUES (@ID_MUTUAL, @ID_FACTURACION_MES, @ANIO, @PRECIO_UNID_BIOQ, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

                if (p_ID_FACTURACION_MES != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", p_ID_FACTURACION_MES);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", DBNull.Value);

                if (p_ANIO != null)
                    com.Parameters.AddWithValue("@ANIO", p_ANIO);
                else
                    com.Parameters.AddWithValue("@ANIO", DBNull.Value);

                if (p_PRECIO_UNID_BIOQ != null)
                    com.Parameters.AddWithValue("@PRECIO_UNID_BIOQ", p_PRECIO_UNID_BIOQ);
                else
                    com.Parameters.AddWithValue("@PRECIO_UNID_BIOQ", DBNull.Value);

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


                int idFacturacionMutual = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idFacturacionMutual;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        /// <summary>
        /// Método que me permite modificar datos del objeto.
        /// </summary>
        /// <param name="p_ID_FACTURACION_MUTUAL"></param>
        /// <param name="p_ID_MUTUAL"></param>
        /// <param name="p_ID_FACTURACION_MES"></param>
        /// <param name="p_PRECIO_UNID_BIOQ"></param>
        /// <param name="p_USR_MOD"></param>
        /// <param name="p_FEC_MOD"></param>
        public void Modificar(Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_MUTUAL, Nullable<Int32> p_ID_FACTURACION_MES, Nullable<Int32> p_ANIO, Nullable<Decimal> p_PRECIO_UNID_BIOQ, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE FacturacionMutual SET idMutual = @ID_MUTUAL, idFacturacionMes = @ID_FACTURACION_MES, "
                            + "anio = @ANIO, precioUnidadBioquimica = @PRECIO_UNID_BIOQ, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idFacturacionMutual = @ID_FACTURACION_MUTUAL";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", p_ID_FACTURACION_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", DBNull.Value);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

                if (p_ID_FACTURACION_MES != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", p_ID_FACTURACION_MES);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MES", DBNull.Value);

                if (p_ANIO != null)
                    com.Parameters.AddWithValue("@ANIO", p_ANIO);
                else
                    com.Parameters.AddWithValue("@ANIO", DBNull.Value);

                if (p_PRECIO_UNID_BIOQ != null)
                    com.Parameters.AddWithValue("@PRECIO_UNID_BIOQ", p_PRECIO_UNID_BIOQ);
                else
                    com.Parameters.AddWithValue("@PRECIO_UNID_BIOQ", DBNull.Value);

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

        /// <summary>
        /// Metodo que realiza la baja logica de un objeto.
        /// </summary>
        /// <param name="p_ID_FACTURACION_MUTUAL"></param>
        /// <param name="p_USR_BAJA"></param>
        /// <param name="p_FEC_BAJA"></param>
        public void Baja(Nullable<Int32> p_ID_FACTURACION_MUTUAL, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE FacturacionMutual SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idFacturacionMutual = @ID_FACTURACION_MUTUAL";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", p_ID_FACTURACION_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", DBNull.Value);

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
