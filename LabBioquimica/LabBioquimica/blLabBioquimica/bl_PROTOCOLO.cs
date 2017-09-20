using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_PROTOCOLOEntidad
    {
        private Nullable<Int32> p_ID_PROTOCOLO;
        public Nullable<Int32> ID_PROTOCOLO
        {
            get { return p_ID_PROTOCOLO;  }
            set { p_ID_PROTOCOLO = value; }
        }

        private Nullable<Int32> p_NRO_PROTOCOLO;
        public Nullable<Int32> NRO_PROTOCOLO
        {
            get { return p_NRO_PROTOCOLO; }
            set { p_NRO_PROTOCOLO = value; }
        }

        private Nullable<DateTime> p_FECHA;
        public Nullable<DateTime> FECHA
        {
            get { return p_FECHA; }
            set { p_FECHA = value; }
        }

        private Nullable<Int32> p_ID_PACIENTE;
        public Nullable<Int32> ID_PACIENTE
        {
            get { return p_ID_PACIENTE; }
            set { p_ID_PACIENTE = value; }
        }

        private Nullable<Int32> p_ID_PROFESIONAL;
        public Nullable<Int32> ID_PROFESIONAL
        {
            get { return p_ID_PROFESIONAL; }
            set { p_ID_PROFESIONAL = value; }
        }


    }

    public class bl_PROTOCOLO
    {

    }
}
