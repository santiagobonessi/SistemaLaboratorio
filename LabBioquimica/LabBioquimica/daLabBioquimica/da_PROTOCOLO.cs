using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_PROTOCOLO : daLabBioquimica.Framework.daBase
    {
        public da_PROTOCOLO() :base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_PROTOCOLO)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT Prot.idProtocolo, Prot.nroProtocolo, Prot.fecha, Prot.idPaciente, Pac.apellido + ' ' + Pac.nombre AS nomapePac, "
                               + "Prot.idProfesional, Prof.apellido + ' ' + Prof.nombre AS nomapeProf, "
                               + "Prot.usr_ing, Prot.fec_ing, Prot.usr_mod, Prot.fec_mod, Prot.usr_baja, Prot.fec_baja "
                               + "FROM Protocolo Prot INNER JOIN Pacientes Pac ON Prot.idPaciente = Pac.idPaciente "
                               + "INNER JOIN  Profesionales Prof ON Prot.idProfesional = Prof.idProfesional "
                               + "WHERE Prot.idProtocolo = @ID_PROTOCOLO ";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_PROTOCOLO", p_ID_PROTOCOLO);

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

        public DataTable Buscar(Nullable<Int32> p_ID_PROTOCOLO, Nullable<Int32> p_NRO_PROTOCOLO, Nullable<DateTime> p_FECHA, Nullable<Int32> p_ID_PACIENTE, Nullable<Int32> p_ID_PROFESIONAL)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT Prot.idProtocolo, Prot.nroProtocolo, Prot.fecha, Prot.idPaciente, Pac.apellido + ' ' + Pac.nombre AS nomapePac, "
                               + "Prot.idProfesional, Prof.apellido + ' ' + Prof.nombre AS nomapeProf, "
                               + "Prot.usr_ing, Prot.fec_ing, Prot.usr_mod, Prot.fec_mod, Prot.usr_baja, Prot.fec_baja "
                               + "FROM Protocolo Prot INNER JOIN Pacientes Pac ON Prot.idPaciente = Pac.idPaciente "
                               + "INNER JOIN  Profesionales Prof ON Prot.idProfesional = Prof.idProfesional "
                               + "WHERE (Prot.idProtocolo = @ID_PROTOCOLO OR @ID_PROTOCOLO IS NULL) "
                               + "AND (Prot.nroProtocolo = @NRO_PROTOCOLO OR @NRO_PROTOCOLO IS NULL) "
                               + "AND (Prot.fecha = @FECHA OR @FECHA IS NULL) "
                               + "AND (Prot.idPaciente = @ID_PACIENTE OR @ID_PACIENTE IS NULL) "
                               + "AND (Prot.idProfesional = @ID_PROFESIONAL OR @ID_PROFESIONAL IS NULL) "
                               + "AND Prot.usr_baja IS NULL "
                               + "AND Prot.fec_baja IS NULL "
                               + "ORDER BY Prot.fecha";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", p_ID_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", DBNull.Value);

                if (p_NRO_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@NRO_PROTOCOLO", p_NRO_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@NRO_PROTOCOLO", DBNull.Value);

                if (p_FECHA != null)
                    com.Parameters.AddWithValue("@FECHA", p_FECHA);
                else
                    com.Parameters.AddWithValue("@FECHA", DBNull.Value);

                if (p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);

                if (p_ID_PROFESIONAL != null)
                    com.Parameters.AddWithValue("@ID_PROFESIONAL", p_ID_PROFESIONAL);
                else
                    com.Parameters.AddWithValue("@ID_PROFESIONAL", DBNull.Value);

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

        public Int32 Insertar(Nullable<Int32> p_NRO_PROTOCOLO, Nullable<DateTime> p_FECHA, Nullable<Int32> p_ID_PACIENTE, Nullable<Int32> p_ID_PROFESIONAL, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO Protocolo (nroProtocolo, fecha, idPaciente, idProfesional, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja)"
                            + "VALUES (@NRO_PROTOCOLO, @FECHA, @ID_PACIENTE, @ID_PROFESIONAL, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";
                SqlCommand com = new SqlCommand(sql, conn);

                if (p_NRO_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@NRO_PROTOCOLO", p_NRO_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@NRO_PROTOCOLO", DBNull.Value);

                if (p_FECHA != null)
                    com.Parameters.AddWithValue("@FECHA", p_FECHA);
                else
                    com.Parameters.AddWithValue("@FECHA", DBNull.Value);

                if (p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);

                if (p_ID_PROFESIONAL != null)
                    com.Parameters.AddWithValue("@ID_PROFESIONAL", p_ID_PROFESIONAL);
                else
                    com.Parameters.AddWithValue("@ID_PROFESIONAL", DBNull.Value);

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


                int idProtocolo = Convert.ToInt32(com.ExecuteScalar());


                conn.Close();

                return idProtocolo;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_PROTOCOLO, Nullable<Int32> p_NRO_PROTOCOLO, Nullable<DateTime> p_FECHA, Nullable<Int32> p_ID_PACIENTE, Nullable<Int32> p_ID_PROFESIONAL, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Protocolo SET nroProtocolo = @NRO_PROTOCOLO, fecha = @FECHA, "
                            + "idPaciente = @ID_PACIENTE, idProfesional = @ID_PROFESIONAL, "
                            + "usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idProtocolo = @ID_PROTOCOLO";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", p_ID_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", DBNull.Value);

                if (p_NRO_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@NRO_PROTOCOLO", p_NRO_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@NRO_PROTOCOLO", DBNull.Value);

                if (p_FECHA != null)
                    com.Parameters.AddWithValue("@FECHA", p_FECHA);
                else
                    com.Parameters.AddWithValue("@FECHA", DBNull.Value);

                if (p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);

                if (p_ID_PROFESIONAL != null)
                    com.Parameters.AddWithValue("@ID_PROFESIONAL", p_ID_PROFESIONAL);
                else
                    com.Parameters.AddWithValue("@ID_PROFESIONAL", DBNull.Value);

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

        public void Baja(Nullable<Int32> p_ID_PROTOCOLO, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Protocolo SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idProtocolo = @ID_PROTOCOLO";
                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PROTOCOLO != null)
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", p_ID_PROTOCOLO);
                else
                    com.Parameters.AddWithValue("@ID_PROTOCOLO", DBNull.Value);

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
