using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_ANALISISEntidad
    {
        private Nullable<Int32> p_ID_ANALISIS;
        public Nullable<Int32> ID_ANALISIS
        {
            get { return p_ID_ANALISIS; }
            set { p_ID_ANALISIS = value; }
        }

        private String p_CODIGO;
        public String CODIGO
        {
            get { return p_CODIGO; }
            set { p_CODIGO = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private String p_METODO;
        public String METODO
        {
            get { return p_METODO; }
            set { p_METODO = value; }
        }

        private Nullable<Double> p_UNID_BIOQ;
        public Nullable<Double> UNID_BIOQ
        {
            get { return p_UNID_BIOQ; }
            set { p_UNID_BIOQ = value; }
        }
    }

    public class bl_ANALISIS
    {
    }
}
