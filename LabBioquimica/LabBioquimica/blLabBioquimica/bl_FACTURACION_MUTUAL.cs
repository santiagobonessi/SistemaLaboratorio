using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_FACTURACION_MUTUAL
    {
        private Nullable<Int32> p_ID_FACTURACION_MUTUAL;
        public Nullable<Int32> ID_FACTURACION_MUTUAL
        {
            get { return p_ID_FACTURACION_MUTUAL; }
            set { p_ID_FACTURACION_MUTUAL = value; }
        }

        private Nullable<Int32> p_ID_MUTUAL;
        public Nullable<Int32> ID_MUTUAL
        {
            get { return p_ID_MUTUAL; }
            set { p_ID_MUTUAL = value; }
        }

        private Nullable<Int32> p_ID_FACTURACION_MES;
        public Nullable<Int32> ID_FACTURACION_MES
        {
            get { return p_ID_FACTURACION_MES; }
            set { p_ID_FACTURACION_MES = value; }
        }

        private Nullable<Decimal> p_PRECIO_UNID_BIOQ;
        public Nullable<Decimal> PRECIO_UNID_BIOQ
        {
            get { return p_PRECIO_UNID_BIOQ; }
            set { p_PRECIO_UNID_BIOQ = value; }
        }



    }
}
