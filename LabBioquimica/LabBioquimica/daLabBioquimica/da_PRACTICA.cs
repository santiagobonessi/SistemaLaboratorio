using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_PRACTICA : daLabBioquimica.Framework.daBase
    {
        public da_PRACTICA() :base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_PRACTICA)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT P.idPractica, PD.idProtocoloDetalle, P.idItem, I.nombre AS Item, "
                               + "P.resultado, U.nombre AS Unidad, I.valorReferencia, "
                               + "P.usr_ing, P.fec_ing, P.usr_mod, P.fec_mod, P.usr_baja, P.fec_baja "
                               + "FROM Practica P INNER JOIN ProtocoloDetalle PD ON P.idProtocoloDetalle = PD.idProtocoloDetalle "
                               + "INNER JOIN  Item I ON P.idItem = I.idItem "
                               + "LEFT JOIN Unidad U ON I.idUnidad = U.idUnidad "
                               + "WHERE P.idPractica = @ID_PRACTICA ";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_PRACTICA", p_ID_PRACTICA);

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

        public DataTable Buscar(Nullable<Int32> p_ID_PRACTICA, Nullable<Int32> p_ID_PROTOCOLO_DET, Nullable<Int32> p_ID_ITEM)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT P.idPractica, PD.idProtocoloDetalle, P.idItem, I.nombre AS Item, "
                               + "P.resultado, U.nombre AS UNIDAD, I.valorReferencia, "
                               + "P.usr_ing, P.fec_ing, P.usr_mod, P.fec_mod, P.usr_baja, P.fec_baja "
                               + "FROM Practica P INNER JOIN ProtocoloDetalle PD ON P.idProtocoloDetalle = PD.idProtocoloDetalle "
                               + "INNER JOIN  Item I ON P.idItem = I.idItem "
                               + "LEFT JOIN Unidad U ON I.idUnidad = U.idUnidad "
                               + "WHERE (P.idPractica = @ID_PRACTICA OR @ID_PRACTICA IS NULL) "
                               + "AND (P.idProtocoloDetalle = @ID_PROTOCOLO_DET OR @ID_PROTOCOLO_DET IS NULL) "
                               + "AND (P.idItem = @ID_ITEM OR @ID_ITEM IS NULL) "
                               + "AND P.usr_baja IS NULL "
                               + "AND P.fec_baja IS NULL ";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PRACTICA != null)
                    com.Parameters.AddWithValue("@ID_PRACTICA", p_ID_PRACTICA);
                else
                    com.Parameters.AddWithValue("@ID_PRACTICA", DBNull.Value);

                if (p_ID_PROTOCOLO_DET != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", p_ID_PROTOCOLO_DET);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", DBNull.Value);

                if (p_ID_ITEM != null)
                    com.Parameters.AddWithValue("@ID_ITEM", p_ID_ITEM);
                else
                    com.Parameters.AddWithValue("@ID_ITEM", DBNull.Value);

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

        public Int32 Insertar(Nullable<Int32> p_ID_PROTOCOLO_DET, Nullable<Int32> p_ID_ITEM, String p_RESULTADO,  String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO Practica (idProtocoloDetalle, idItem, resultado, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja)"
                            + "VALUES (@ID_PROTOCOLO_DET, @ID_ITEM, @RESULTADO, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PROTOCOLO_DET != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", p_ID_PROTOCOLO_DET);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", DBNull.Value);

                if (p_ID_ITEM != null)
                    com.Parameters.AddWithValue("@ID_ITEM", p_ID_ITEM);
                else
                    com.Parameters.AddWithValue("@ID_ITEM", DBNull.Value);

                if (p_RESULTADO != null)
                    com.Parameters.AddWithValue("@RESULTADO", p_RESULTADO);
                else
                    com.Parameters.AddWithValue("@RESULTADO", DBNull.Value);

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


                int idPractica = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idPractica;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_PRACTICA, Nullable<Int32> p_ID_PROTOCOLO_DET, Nullable<Int32> p_ID_ITEM, String p_RESULTADO, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Practica "
                            + "SET idProtocoloDetalle = @ID_PROTOCOLO_DET, " 
                            + "idItem = @ID_ITEM, resultado = @RESULTADO, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idPractica = @ID_PRACTICA";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PRACTICA != null)
                    com.Parameters.AddWithValue("@ID_PRACTICA", p_ID_PRACTICA);
                else
                    com.Parameters.AddWithValue("@ID_PRACTICA", DBNull.Value);

                if (p_ID_PROTOCOLO_DET != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", p_ID_PROTOCOLO_DET);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", DBNull.Value);

                if (p_ID_ITEM != null)
                    com.Parameters.AddWithValue("@ID_ITEM", p_ID_ITEM);
                else
                    com.Parameters.AddWithValue("@ID_ITEM", DBNull.Value);

                if (p_RESULTADO != null)
                    com.Parameters.AddWithValue("@RESULTADO", p_RESULTADO);
                else
                    com.Parameters.AddWithValue("@RESULTADO", DBNull.Value);

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

        public void ModificarResultado(Nullable<Int32> p_ID_PRACTICA, String p_RESULTADO, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Practica "
                            + "SET resultado = @RESULTADO, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idPractica = @ID_PRACTICA";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PRACTICA != null)
                    com.Parameters.AddWithValue("@ID_PRACTICA", p_ID_PRACTICA);
                else
                    com.Parameters.AddWithValue("@ID_PRACTICA", DBNull.Value);

                if (p_RESULTADO != null)
                    com.Parameters.AddWithValue("@RESULTADO", p_RESULTADO);
                else
                    com.Parameters.AddWithValue("@RESULTADO", DBNull.Value);

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

        }//Termina método Modificar Resultado

        public void Baja(Nullable<Int32> p_ID_PRACTICA, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Practica SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idPractica = @ID_PRACTICA";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PRACTICA != null)
                    com.Parameters.AddWithValue("@ID_PRACTICA", p_ID_PRACTICA);
                else
                    com.Parameters.AddWithValue("@ID_PRACTICA", DBNull.Value);

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
