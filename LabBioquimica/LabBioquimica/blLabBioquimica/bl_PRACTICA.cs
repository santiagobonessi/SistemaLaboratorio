using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_PRACTICAEntidad
    {
        private Nullable<Int32> p_ID_PRACTICA;
        public Nullable<Int32> ID_PRACTICA
        {
            get { return p_ID_PRACTICA; }
            set { p_ID_PRACTICA = value; }
        }

        private Nullable<Int32> p_ID_PROTOCOLO_DETALLE;
        public Nullable<Int32> ID_PROTOCOLO_DETALLE
        {
            get { return p_ID_PROTOCOLO_DETALLE; }
            set { p_ID_PROTOCOLO_DETALLE = value; }
        }

        private Nullable<Int32> p_ID_ITEM;
        public Nullable<Int32> ID_ITEM
        {
            get { return p_ID_ITEM; }
            set { p_ID_ITEM = value; }
        }

        private String p_RESULTADO;
        public String RESULTADO
        {
            get { return p_RESULTADO; }
            set { p_RESULTADO = value; }
        }

    }

    public class bl_PRACTICA
    {
    }
}
