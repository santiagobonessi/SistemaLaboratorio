using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_PACIENTEEntidad
    {
        private Nullable<Int32> p_ID_PACIENTE;
        public Nullable<Int32> ID_PACIENTE
        {
            get { return p_ID_PACIENTE; }
            set { p_ID_PACIENTE = value; }
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

        private Nullable<Int32> p_DOCUMENTO;
        public Nullable<Int32> DOCUMENTO
        {
            get { return p_DOCUMENTO; }
            set { p_DOCUMENTO = value; }
        }

        private Nullable<Int32> p_ID_TIPO_DOC;
        public Nullable<Int32> ID_TIPO_DOC
        {
            get { return p_ID_TIPO_DOC; }
            set { p_ID_TIPO_DOC = value; }
        }

        private Nullable<Int32> p_ID_SEXO;
        public Nullable<Int32> ID_SEXO
        {
            get { return p_ID_SEXO; }
            set { p_ID_SEXO = value; }
        }

        private String p_TELEFONO;
        public String TELEFONO
        {
            get { return p_TELEFONO; }
            set { p_TELEFONO = value; }
        }

        private Nullable<Int32> p_ID_MUTUAL;
        public Nullable<Int32> ID_MUTUAL
        {
            get { return p_ID_MUTUAL; }
            set { p_ID_MUTUAL = value; }
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

    public class bl_PACIENTE
    {
    }
}
