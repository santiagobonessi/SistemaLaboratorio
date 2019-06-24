using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_FACTURACION_ORDEN : daLabBioquimica.Framework.daBase
    {

        public da_FACTURACION_ORDEN() :base() { }

        /// <summary>
        /// Metodo que busca por clave primaria un objeto especifico.
        /// </summary>
        /// <param name="p_ID_FACTURACION_ORDEN"></param>
        /// <returns name="DataTable"></returns>
        public DataTable BuscarPorPK(Nullable<Int32> p_ID_FACTURACION_ORDEN)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT FO.idFacturacionOrden, FO.idFacturacionMutual, FO.idPaciente, P.apellido + ' ' + P.nombre AS nomapePac, "
                               + "FO.usr_ing, FO.fec_ing, FO.usr_mod, FO.fec_mod, FO.usr_baja, FO.fec_baja "
                               + "FROM FacturacionOrden FO INNER JOIN FacturacionMutual FM ON FO.idFacturacionMutual =  FM.idFacturacionMutual"
                               + "INNER JOIN  Pacientes P ON FO.idPaciente = P.idPaciente "
                               + "WHERE FO.idFacturacionOrden = @ID_FACTURACION_ORDEN ";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_FACTURACION_ORDEN", p_ID_FACTURACION_ORDEN);

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
        /// <param name="p_ID_FACTURACION_ORDEN"></param>
        /// <param name="p_ID_FACTURACION_MUTUAL"></param>
        /// <param name="p_ID_PACIENTE"></param>
        /// <returns></returns>
        public DataTable Buscar(Nullable<Int32> p_ID_FACTURACION_ORDEN, Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_PACIENTE)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT FO.idFacturacionOrden, FO.idFacturacionMutual, FO.idPaciente, P.apellido + ' ' + P.nombre AS nomapePac, "
                               + "FO.usr_ing, FO.fec_ing, FO.usr_mod, FO.fec_mod, FO.usr_baja, FO.fec_baja "
                               + "FROM FacturacionOrden FO INNER JOIN FacturacionMutual FM ON FO.idFacturacionMutual = FM.idFacturacionMutual"
                               + "INNER JOIN Pacientes P ON FO.idPaciente = P.idPaciente "
                               + "WHERE (FO.idFacturacionOrden = @ID_FACTURACION_ORDEN OR @ID_FACTURACION_ORDEN IS NULL) "
                               + "AND (FO.idFacturacionMutual = @ID_FACTURACION_MUTUAL OR @ID_FACTURACION_MUTUAL IS NULL) "
                               + "AND (FO.idPaciente = @ID_PACIENTE OR @ID_PACIENTE IS NULL) "
                               + "AND FO.usr_baja IS NULL "
                               + "AND FO.fec_baja IS NULL ";


                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_ORDEN != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_ORDEN", p_ID_FACTURACION_ORDEN);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_ORDEN", DBNull.Value);

                if (p_ID_FACTURACION_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", p_ID_FACTURACION_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", DBNull.Value);

                if (p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);


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
        }//Termina metodo buscar,

        /// <summary>
        /// Método que inserta un objeto de la clase y retorna el id.
        /// </summary>
        /// <param name="p_ID_FACTURACION_MUTUAL"></param>
        /// <param name="p_ID_PACIENTE"></param>
        /// <param name="p_USR_ING"></param>
        /// <param name="p_FEC_ING"></param>
        /// <param name="p_USR_MOD"></param>
        /// <param name="p_FEC_MOD"></param>
        /// <param name="p_USR_BAJA"></param>
        /// <param name="p_FEC_BAJA"></param>
        /// <returns></returns>
        public Int32 Insertar(Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_PACIENTE, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO FacturacionOrden (idFacturacionMutual, idPaciente, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja)"
                            + "VALUES (@ID_FACTURACION_MUTUAL, @ID_PACIENTE,@USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", p_ID_FACTURACION_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", DBNull.Value);

                if (p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);

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


                int idFacturacionOrden = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idFacturacionOrden;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        /// <summary>
        /// Método que me permite modificar datos del objeto.
        /// </summary>
        /// <param name="p_ID_FACTURACION_ORDEN"></param>
        /// <param name="p_ID_FACTURACION_MUTUAL"></param>
        /// <param name="p_ID_PACIENTE"></param>
        /// <param name="p_USR_MOD"></param>
        /// <param name="p_FEC_MOD"></param>
        public void Modificar(Nullable<Int32> p_ID_FACTURACION_ORDEN, Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_PACIENTE, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE FacturacionOrden SET idFacturacionMutual = @ID_FACTURACION_MUTUAL, "
                            + "idPaciente = @ID_PACIENTE, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idFacturacionOrden = @ID_FACTURACION_ORDEN";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_ORDEN != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_ORDEN", p_ID_FACTURACION_ORDEN);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_ORDEN", DBNull.Value);

                if (p_ID_FACTURACION_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", p_ID_FACTURACION_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_MUTUAL", DBNull.Value);

                if (p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);

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
        /// <param name="p_ID_FACTURACION_ORDEN"></param>
        /// <param name="p_USR_BAJA"></param>
        /// <param name="p_FEC_BAJA"></param>
        public void Baja(Nullable<Int32> p_ID_FACTURACION_ORDEN, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE FacturacionOrden SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idFacturacionOrden = @ID_FACTURACION_ORDEN";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_FACTURACION_ORDEN != null)
                    com.Parameters.AddWithValue("@ID_FACTURACION_ORDEN", p_ID_FACTURACION_ORDEN);
                else
                    com.Parameters.AddWithValue("@ID_FACTURACION_ORDEN", DBNull.Value);

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
