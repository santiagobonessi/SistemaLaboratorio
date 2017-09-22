using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daLabBioquimica.Framework
{
    public class daException : Exception
    {
        public daException(String mensaje)
            : base(mensaje)
        {
        }
    }
}
