using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcceoBaseDatos
{
    public class AccesoDatos
    {

        #region Atributos
        //Declaramos las variables comando y conexion
        private SqlCommand comando = new SqlCommand();
        private SqlConnection conexion = new SqlConnection();
        private string connection_string = ConfigurationManager.ConnectionStrings["Laboratorio"].ConnectionString;
        private SqlTransaction transaccion;

        #endregion

        #region Conexión BD
        //Conectarme a la base de datos
        public void Conectar()
        {
            conexion.ConnectionString = connection_string;
            comando.Connection = conexion;
            conexion.Open();
        }

        //Desconectarme de la base de datos
        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }
        #endregion

    }
}
