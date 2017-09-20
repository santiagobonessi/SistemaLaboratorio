using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_ITEMEntidad
    {
        private Nullable<Int32> p_ID_ITEM;
        public Nullable<Int32> ID_ITEM
        {
            get { return p_ID_ITEM; }
            set { p_ID_ITEM = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private Nullable<Int32> p_ID_UNIDAD;
        public Nullable<Int32> ID_UNIDAD
        {
            get { return p_ID_UNIDAD; }
            set { p_ID_UNIDAD = value; }
        }

        private String p_VALOR_REF;
        public String VALOR_REF
        {
            get { return p_VALOR_REF; }
            set { p_VALOR_REF = value; }
        }


    }

    public class bl_ITEM
    {
    }
}
