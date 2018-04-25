using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_PROTOCOLO_DETALLE : daLabBioquimica.Framework.daBase
    {

        public da_PROTOCOLO_DETALLE() :base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_PROTOCOLO_DET)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT PD.idProtocoloDetalle, PD.idProtocolo, PD.idAnalisis, "
                               + "A.nombre, A.metodo, A.codigo, "
                               + "PD.usr_ing, PD.fec_ing, PD.usr_mod, PD.fec_mod, PD.usr_baja, PD.fec_baja "
                               + "FROM ProtocoloDetalle PD INNER JOIN Protocolo P ON PD.idProtocolo = P.idProtocolo "
                               + "INNER JOIN  Analisis A ON PD.idAnalisis = A.idAnalisis "
                               + "WHERE PD.idProtocoloDetalle = @ID_PROTOCOLO_DET "
                               + "AND PD.usr_baja IS NULL "
                               + "AND PD.fec_baja IS NULL ";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", p_ID_PROTOCOLO_DET);

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

        public DataTable Buscar(Nullable<Int32> p_ID_PROTOCOLO_DET, Nullable<Int32> p_ID_PROTOCOLO, Nullable<Int32> p_ID_ANALISIS)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT PD.idProtocoloDetalle, PD.idProtocolo, PD.idAnalisis, "
                               + "A.nombre, A.metodo, A.codigo, "
                               + "PD.usr_ing, PD.fec_ing, PD.usr_mod, PD.fec_mod, PD.usr_baja, PD.fec_baja "
                               + "FROM ProtocoloDetalle PD INNER JOIN Protocolo P ON PD.idProtocolo = P.idProtocolo "
                               + "INNER JOIN  Analisis A ON PD.idAnalisis = A.idAnalisis "
                               + "WHERE (PD.idProtocoloDetalle = @ID_PROTOCOLO_DET OR @ID_PROTOCOLO_DET IS NULL) "
                               + "AND (PD.idProtocolo = @ID_PROTOCOLO OR @ID_PROTOCOLO IS NULL) "
                               + "AND (PD.idAnalisis = @ID_ANALISIS OR @ID_ANALISIS IS NULL) "
                               + "AND PD.usr_baja IS NULL "
                               + "AND PD.fec_baja IS NULL "
                               + "ORDER BY A.nombre";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PROTOCOLO_DET != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", p_ID_PROTOCOLO_DET);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", DBNull.Value);

                if (p_ID_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", p_ID_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", DBNull.Value);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);
                
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

        public Int32 Insertar(Nullable<Int32> p_ID_PROTOCOLO, Nullable<Int32> p_ID_ANALISIS, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO ProtocoloDetalle (idProtocolo, idAnalisis, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja)"
                            + "VALUES (@ID_PROTOCOLO, @ID_ANALISIS, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";
                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", p_ID_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", DBNull.Value);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);

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


                int idProtocoloDetalle = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idProtocoloDetalle;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_PROTOCOLO_DET, Nullable<Int32> p_ID_PROTOCOLO, Nullable<Int32> p_ID_ANALISIS, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE ProtocoloDetalle "
                            + "SET idProtocolo = @ID_PROTOCOLO, idAnalisis = @ID_ANALISIS, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idProtocoloDetalle = @ID_PROTOCOLO_DET";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PROTOCOLO_DET != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", p_ID_PROTOCOLO_DET);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", DBNull.Value);

                if (p_ID_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", p_ID_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", DBNull.Value);

                if (p_ID_ANALISIS != null)
                    com.Parameters.AddWithValue("@ID_ANALISIS", p_ID_ANALISIS);
                else
                    com.Parameters.AddWithValue("@ID_ANALISIS", DBNull.Value);

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

        public void Baja(Nullable<Int32> p_ID_PROTOCOLO_DET, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE ProtocoloDetalle SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idProtocoloDetalle = @ID_PROTOCOLO_DET";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PROTOCOLO_DET != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", p_ID_PROTOCOLO_DET);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO_DET", DBNull.Value);

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
