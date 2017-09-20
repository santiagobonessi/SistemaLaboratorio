using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_PROFESIONALEntidad
    {
        private Nullable<Int32> p_ID_PROFESIONAL;
        public Nullable<Int32> ID_PROFESIONAL
        {
            get { return p_ID_PROFESIONAL; }
            set { p_ID_PROFESIONAL = value; }
        }

        private String p_APELLIDO;
        public String APELLIDO
        {
            get { return p_APELLIDO; }
            set { p_APELLIDO = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private String p_MATRICULA;
        public String MATRICULA
        {
            get { return p_MATRICULA; }
            set { p_MATRICULA = value; }
        }

        private String p_TELEFONO;
        public String TELEFONO
        {
            get { return p_TELEFONO; }
            set { p_TELEFONO = value; }
        }

        private Nullable<Int32> p_ID_LOCALIDAD;
        public Nullable<Int32> ID_LOCALIDAD
        {
            get { return p_ID_LOCALIDAD; }
            set { p_ID_LOCALIDAD = value; }
        }

        private String p_CALLE;
        public String CALLE
        {
            get { return p_CALLE; }
            set { p_CALLE = value; }
        }

        private Nullable<Int32> p_NRO_CALLE;
        public Nullable<Int32> NRO_CALLE
        {
            get { return p_NRO_CALLE; }
            set { p_NRO_CALLE = value; }
        }


    }


    public class bl_PROFESIONAL
    {
    }
}
