using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace daLabBioquimica.Framework
{
    public abstract class daBase
    {

        protected String CadenaDeConexion()
        {
            return ConfigurationManager.ConnectionStrings["CADENA_DE_CONEXION"].ConnectionString;

        }
    }
}
