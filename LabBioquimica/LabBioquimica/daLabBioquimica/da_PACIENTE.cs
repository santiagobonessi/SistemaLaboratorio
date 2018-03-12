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
                               + "P.fechaNacimiento, P.telefono, P.idMutual, M.nombre AS Mutual, P.idLocalidad, L.nombre AS Localidad, P.calle, P.nroCalle "
                               + "FROM Pacientes P, TipoDocumento TD, Sexo S, Mutuales M, Localidad L " 
                               + "WHERE P.idPaciente = @ID_PACIENTE "
                               + "AND P.idTipoDoc = TD.idTipoDoc " 
                               + "AND P.idSexo = S.idSexo " 
                               + "AND P.idMutual = M.idMutual " 
                               + "AND P.idLocalidad = L.idLocalidad ";

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


        public DataTable Buscar(Nullable<Int32> p_ID_PACIENTE, string p_APELLIDO, string p_NOMBRE, string p_DOCUMENTO)
        {
            try
            {

                SqlConnection conn = new SqlConnection(CadenaDeConexion());
                conn.Open();

                String sql = @"SELECT P.idPaciente, P.apellido, P.nombre, P.documento, P.idTipoDoc, TD.nombre AS TipoDoc, P.idSexo, S.nombre AS Sexo, "
                               + "P.fechaNacimiento, P.telefono, P.idMutual, M.nombre AS Mutual, P.idLocalidad, L.nombre AS Localidad, P.calle, P.nroCalle "
                               + "FROM Pacientes P, TipoDocumento TD, Sexo S, Mutuales M, Localidad L "
                               + "WHERE (P.idPaciente = @ID_PACIENTE OR @ID_PACIENTE IS NULL) "
                               + "AND (P.apellido LIKE @APELLIDO + '%' OR @APELLIDO IS NULL) "
                               + "AND (P.nombre LIKE @NOMBRE + '%' OR @NOMBRE IS NULL) "
                               + "AND (P.documento = @DOCUMENTO OR @DOCUMENTO IS NULL) "
                               + "AND P.idTipoDoc = TD.idTipoDoc "
                               + "AND P.idSexo = S.idSexo "
                               + "AND P.idMutual = M.idMutual "
                               + "AND P.idLocalidad = L.idLocalidad ";
                
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







    }

}
