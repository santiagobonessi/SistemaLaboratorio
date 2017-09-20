using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_PROTOCOLO_DETALLEEntidad
    {
        private Nullable<Int32> p_ID_PROTOCOLO_DETALLE;
        public Nullable<Int32> ID_PROTOCOLO_DETALLE
        {
            get { return p_ID_PROTOCOLO_DETALLE; }
            set { p_ID_PROTOCOLO_DETALLE = value; }
        }

        private Nullable<Int32> p_ID_PROTOCOLO;
        public Nullable<Int32> ID_PROTOCOLO
        {
            get { return p_ID_PROTOCOLO; }
            set { p_ID_PROTOCOLO = value; }
        }

        private Nullable<Int32> p_ID_ANALISIS;
        public Nullable<Int32> ID_ANALISIS
        {
            get { return p_ID_ANALISIS; }
            set { p_ID_ANALISIS = value; }
        }

    }

    public class bl_PROTOCOLO_DETALLE
    {
    }
}
