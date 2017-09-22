using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica.Framework
{
    public class blException : Exception
    {
        public blException(String mensaje)
            : base(mensaje)
        {
        }
    }
}
