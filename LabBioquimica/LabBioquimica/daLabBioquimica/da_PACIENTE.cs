using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica
{
    public class da_PACIENTE : daLabBioquimica.Framework.daBase
    {
        public da_PACIENTE()  :base() { }

        public DataTable BuscarPorPK(Nullable<Int32> p_ID_PACIENTE)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT P.idPaciente, P.apellido, P.nombre, P.documento, P.idTipoDoc, TD.nombre AS TipoDoc, P.idSexo, S.nombre AS Sexo, "
                               + "P.fechaNacimiento, P.telefono, P.idMutual, M.nombre AS Mutual, P.idLocalidad, L.nombre AS Localidad, P.direccion, "
                               + "P.usr_ing, P.fec_ing, P.usr_mod, P.fec_mod, P.usr_baja, P.fec_baja "
                               + "FROM Pacientes P LEFT JOIN TipoDocumento TD ON P.idTipoDoc = TD.idTipoDoc LEFT JOIN  Sexo S ON P.idSexo = S.idSexo "
                               + "LEFT JOIN  Mutuales M ON P.idMutual = M.idMutual LEFT JOIN Localidad L ON P.idLocalidad = L.idLocalidad "
                               + "WHERE P.idPaciente = @ID_PACIENTE ";

                SqlCommand com = new SqlCommand(sql, conn);

                com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);

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


        public DataTable Buscar(Nullable<Int32> p_ID_PACIENTE, String p_APELLIDO, String p_NOMBRE, String p_DOCUMENTO, Nullable<Int32> p_ID_MUTUAL)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT P.idPaciente, P.apellido, P.nombre, P.apellido + ' ' + P.nombre AS nomape, P.documento, P.idTipoDoc, TD.nombre AS TipoDoc, P.idSexo, S.nombre AS Sexo, "
                               + "P.fechaNacimiento, P.telefono, P.idMutual, M.nombre AS Mutual, P.idLocalidad, L.nombre AS Localidad, P.direccion, "
                               + "P.usr_ing, P.fec_ing, P.usr_mod, P.fec_mod, P.usr_baja, P.fec_baja "
                               + "FROM Pacientes P LEFT JOIN TipoDocumento TD ON P.idTipoDoc = TD.idTipoDoc LEFT JOIN  Sexo S ON P.idSexo = S.idSexo "
                               + "LEFT JOIN  Mutuales M ON P.idMutual = M.idMutual LEFT JOIN Localidad L ON P.idLocalidad = L.idLocalidad "
                               + "WHERE (P.idPaciente = @ID_PACIENTE OR @ID_PACIENTE IS NULL) "
                               + "AND (P.apellido LIKE @APELLIDO + '%' OR @APELLIDO IS NULL) "
                               + "AND (P.nombre LIKE @NOMBRE + '%' OR @NOMBRE IS NULL) "
                               + "AND (P.documento = @DOCUMENTO OR @DOCUMENTO IS NULL) "
                               + "AND (P.idMutual = @ID_MUTUAL OR @ID_MUTUAL IS NULL) "
                               + "AND P.usr_baja IS NULL "
                               + "AND P.fec_baja IS NULL "
                               + "ORDER BY P.apellido, P.nombre";

                SqlCommand com = new SqlCommand(sql, conn);

                if(p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);

                if (p_APELLIDO != null)
                    com.Parameters.AddWithValue("@APELLIDO", p_APELLIDO);
                else
                    com.Parameters.AddWithValue("@APELLIDO", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_DOCUMENTO != null)
                    com.Parameters.AddWithValue("@DOCUMENTO", p_DOCUMENTO);
                else
                    com.Parameters.AddWithValue("@DOCUMENTO", DBNull.Value);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);


                SqlDataAdapter da = new SqlDataAdapter(com);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0) { 
                    return ds.Tables[0];
                }

                

                return null;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }

        
        public Int32 Insertar(String p_APELLIDO, String p_NOMBRE, Nullable<Int32> p_DOCUMENTO, Nullable<Int32> p_ID_TIPO_DOC, Nullable<Int32> p_ID_SEXO, Nullable<DateTime> p_FECHA_NACIMIENTO, String p_TELEFONO, Nullable<Int32> p_ID_MUTUAL, Nullable<Int32> p_ID_LOCALIDAD, String p_DIRECCION, String p_USR_ING, Nullable<DateTime> p_FEC_ING, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"INSERT INTO Pacientes (apellido, nombre, documento, idTipoDoc, idSexo, fechaNacimiento, telefono, idMutual, idLocalidad, direccion, usr_ing, fec_ing, usr_mod, fec_mod, usr_baja, fec_baja)"
                            + "VALUES (@APELLIDO, @NOMBRE, @DOCUMENTO, @ID_TIPODOC, @ID_SEXO, @FECHANACIMIENTO, @TELEFONO, @ID_MUTUAL, @ID_LOCALIDAD, @DIRECCION, @USR_ING, @FEC_ING, @USR_MOD, @FEC_MOD, @USR_BAJA, @FEC_BAJA)"
                            + "; SELECT @@Identity as ID";
                SqlCommand com = new SqlCommand(sql, conn);

                if (p_APELLIDO != null)
                    com.Parameters.AddWithValue("@APELLIDO", p_APELLIDO);
                else
                    com.Parameters.AddWithValue("@APELLIDO", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_DOCUMENTO != null)
                    com.Parameters.AddWithValue("@DOCUMENTO", p_DOCUMENTO);
                else
                    com.Parameters.AddWithValue("@DOCUMENTO", DBNull.Value);

                if (p_ID_TIPO_DOC != null)
                    com.Parameters.AddWithValue("@ID_TIPODOC", p_ID_TIPO_DOC);
                else
                    com.Parameters.AddWithValue("@ID_TIPODOC", DBNull.Value);

                if (p_ID_SEXO != null)
                    com.Parameters.AddWithValue("@ID_SEXO", p_ID_SEXO);
                else
                    com.Parameters.AddWithValue("@ID_SEXO", DBNull.Value);

                if (p_FECHA_NACIMIENTO != null)
                    com.Parameters.AddWithValue("@FECHANACIMIENTO", p_FECHA_NACIMIENTO);
                else
                    com.Parameters.AddWithValue("@FECHANACIMIENTO", DBNull.Value);

                if (p_TELEFONO != null)
                    com.Parameters.AddWithValue("@TELEFONO", p_TELEFONO);
                else
                    com.Parameters.AddWithValue("@TELEFONO", DBNull.Value);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

                if (p_ID_LOCALIDAD != null)
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", p_ID_LOCALIDAD);
                else
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", DBNull.Value);

                if (p_DIRECCION != null)
                    com.Parameters.AddWithValue("@DIRECCION", p_DIRECCION);
                else
                    com.Parameters.AddWithValue("@DIRECCION", DBNull.Value);

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


                int idPaciente = Convert.ToInt32(com.ExecuteScalar());

                
                conn.Close();

                return idPaciente;
            }
            catch (Exception ex)
            {
                throw new daLabBioquimica.Framework.daException(ex.Message);
            }
        }//Termina el método Insertar

        public void Modificar(Nullable<Int32> p_ID_PACIENTE, String p_APELLIDO, String p_NOMBRE, Nullable<Int32> p_DOCUMENTO, Nullable<Int32> p_ID_TIPO_DOC, Nullable<Int32> p_ID_SEXO, Nullable<DateTime> p_FECHA_NACIMIENTO, String p_TELEFONO, Nullable<Int32> p_ID_MUTUAL, Nullable<Int32> p_ID_LOCALIDAD, String p_DIRECCION, String p_USR_MOD, Nullable<DateTime> p_FEC_MOD)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Pacientes SET apellido = @APELLIDO, nombre = @NOMBRE, documento = @DOCUMENTO, " 
                            + "idTipoDoc = @ID_TIPODOC,idSexo = @ID_SEXO,fechaNacimiento = @FECHANACIMIENTO, "
                            + "telefono = @TELEFONO, idMutual = @ID_MUTUAL, idLocalidad = @ID_LOCALIDAD, "
                            + "direccion = @DIRECCION, usr_mod = @USR_MOD, fec_mod = @FEC_MOD "
                            + "WHERE idPaciente = @ID_PACIENTE";

                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);

                if (p_APELLIDO != null)
                    com.Parameters.AddWithValue("@APELLIDO", p_APELLIDO);
                else
                    com.Parameters.AddWithValue("@APELLIDO", DBNull.Value);

                if (p_NOMBRE != null)
                    com.Parameters.AddWithValue("@NOMBRE", p_NOMBRE);
                else
                    com.Parameters.AddWithValue("@NOMBRE", DBNull.Value);

                if (p_DOCUMENTO != null)
                    com.Parameters.AddWithValue("@DOCUMENTO", p_DOCUMENTO);
                else
                    com.Parameters.AddWithValue("@DOCUMENTO", DBNull.Value);

                if (p_ID_TIPO_DOC != null)
                    com.Parameters.AddWithValue("@ID_TIPODOC", p_ID_TIPO_DOC);
                else
                    com.Parameters.AddWithValue("@ID_TIPODOC", DBNull.Value);

                if (p_ID_SEXO != null)
                    com.Parameters.AddWithValue("@ID_SEXO", p_ID_SEXO);
                else
                    com.Parameters.AddWithValue("@ID_SEXO", DBNull.Value);

                if (p_FECHA_NACIMIENTO != null)
                    com.Parameters.AddWithValue("@FECHANACIMIENTO", p_FECHA_NACIMIENTO);
                else
                    com.Parameters.AddWithValue("@FECHANACIMIENTO", DBNull.Value);

                if (p_TELEFONO != null)
                    com.Parameters.AddWithValue("@TELEFONO", p_TELEFONO);
                else
                    com.Parameters.AddWithValue("@TELEFONO", DBNull.Value);

                if (p_ID_MUTUAL != null)
                    com.Parameters.AddWithValue("@ID_MUTUAL", p_ID_MUTUAL);
                else
                    com.Parameters.AddWithValue("@ID_MUTUAL", DBNull.Value);

                if (p_ID_LOCALIDAD != null)
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", p_ID_LOCALIDAD);
                else
                    com.Parameters.AddWithValue("@ID_LOCALIDAD", DBNull.Value);

                if (p_DIRECCION != null)
                    com.Parameters.AddWithValue("@DIRECCION", p_DIRECCION);
                else
                    com.Parameters.AddWithValue("@DIRECCION", DBNull.Value);

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

        public void Baja(Nullable<Int32> p_ID_PACIENTE, String p_USR_BAJA, Nullable<DateTime> p_FEC_BAJA)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"UPDATE Pacientes SET usr_baja = @USR_BAJA, fec_baja = @FEC_BAJA "
                            + "WHERE idPaciente = @ID_PACIENTE";
                SqlCommand com = new SqlCommand(sql, conn);

                if (p_ID_PACIENTE != null)
                    com.Parameters.AddWithValue("@ID_PACIENTE", p_ID_PACIENTE);
                else
                    com.Parameters.AddWithValue("@ID_PACIENTE", DBNull.Value);

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
