using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{

    public class bl_MUTUALEntidad
    {
        private Nullable<Int32> p_ID_MUTUAL;
        public Nullable<Int32> ID_MUTUAL
        {
            get { return p_ID_MUTUAL; }
            set { p_ID_MUTUAL = value; }
        }

        private String p_NOMBRE;
        public String NOMBRE
        {
            get { return p_NOMBRE; }
            set { p_NOMBRE = value; }
        }

        private String p_TELEFONO;
        public String TELEFONO
        {
            get { return p_TELEFONO; }
            set { p_TELEFONO = value; }
        }

        private String p_DIRECCION;
        public String DIRECCION
        {
            get { return p_DIRECCION; }
            set { p_DIRECCION = value; }
        }

        private String p_EMAIL;
        public String EMAIL
        {
            get { return p_EMAIL; }
            set { p_EMAIL = value; }
        }

        private String p_USR_ING;
        public String USR_ING
        {
            get { return p_USR_ING; }
            set { p_USR_ING = value; }
        }
        private Nullable<DateTime> p_FEC_ING;
        public Nullable<DateTime> FEC_ING
        {
            get { return p_FEC_ING; }
            set { p_FEC_ING = value; }
        }
        private String p_USR_MOD;
        public String USR_MOD
        {
            get { return p_USR_MOD; }
            set { p_USR_MOD = value; }
        }
        private Nullable<DateTime> p_FEC_MOD;
        public Nullable<DateTime> FEC_MOD
        {
            get { return p_FEC_MOD; }
            set { p_FEC_MOD = value; }
        }
        private String p_USR_BAJA;
        public String USR_BAJA
        {
            get { return p_USR_BAJA; }
            set { p_USR_BAJA = value; }
        }
        private Nullable<DateTime> p_FEC_BAJA;
        public Nullable<DateTime> FEC_BAJA
        {
            get { return p_FEC_BAJA; }
            set { p_FEC_BAJA = value; }
        }

        public bl_MUTUALEntidad() { }

        public bl_MUTUALEntidad(Nullable<Int32> ID_MUTUAL)
        {
            try
            {
                bl_MUTUAL bl = new bl_MUTUAL();
                bl_MUTUALEntidad ent = bl.BuscarPorPK(ID_MUTUAL);

                if(ent != null)
                {
                    this.ID_MUTUAL = ent.ID_MUTUAL;
                    this.NOMBRE = ent.NOMBRE;
                    this.TELEFONO = ent.TELEFONO;
                    this.DIRECCION = ent.DIRECCION;
                    this.EMAIL = ent.EMAIL;
                    this.USR_ING = ent.USR_ING;
                    this.FEC_ING = ent.FEC_ING;
                    this.USR_MOD = ent.USR_MOD;
                    this.FEC_MOD = ent.FEC_MOD;
                    this.USR_BAJA = ent.USR_BAJA;
                    this.FEC_BAJA = ent.FEC_BAJA;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class bl_MUTUALEntidadColeccion : List<bl_MUTUALEntidad>
    {
    }

    public class bl_MUTUAL
    {

        private daLabBioquimica.da_MUTUAL p_da;

        public bl_MUTUAL()
        {
            p_da = new daLabBioquimica.da_MUTUAL();
        }

        public bl_MUTUALEntidad BuscarPorPK(Nullable<Int32> ID_MUTUAL)
        {

            try
            {
                DataTable dt = p_da.BuscarPorPK(ID_MUTUAL);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_MUTUALEntidad ent = new bl_MUTUALEntidad();

                    if (dt.Rows[0]["idMutual"] != DBNull.Value)
                        ent.ID_MUTUAL = Convert.ToInt32(dt.Rows[0]["idMutual"]);
                    if (dt.Rows[0]["nombre"] != DBNull.Value)
                        ent.NOMBRE = Convert.ToString(dt.Rows[0]["nombre"]);
                    if (dt.Rows[0]["telefono"] != DBNull.Value)
                        ent.TELEFONO = Convert.ToString(dt.Rows[0]["telefono"]);
                    if (dt.Rows[0]["direccion"] != DBNull.Value)
                        ent.DIRECCION = Convert.ToString(dt.Rows[0]["direccion"]);
                    if (dt.Rows[0]["email"] != DBNull.Value)
                        ent.EMAIL = Convert.ToString(dt.Rows[0]["email"]);
                    if (dt.Rows[0]["usr_ing"] != DBNull.Value)
                        ent.USR_ING = Convert.ToString(dt.Rows[0]["usr_ing"]);
                    if (dt.Rows[0]["fec_ing"] != DBNull.Value)
                        ent.FEC_ING = Convert.ToDateTime(dt.Rows[0]["fec_ing"]);
                    if (dt.Rows[0]["usr_mod"] != DBNull.Value)
                        ent.USR_MOD = Convert.ToString(dt.Rows[0]["usr_mod"]);
                    if (dt.Rows[0]["fec_mod"] != DBNull.Value)
                        ent.FEC_MOD = Convert.ToDateTime(dt.Rows[0]["fec_mod"]);
                    if (dt.Rows[0]["usr_baja"] != DBNull.Value)
                        ent.USR_BAJA = Convert.ToString(dt.Rows[0]["usr_baja"]);
                    if (dt.Rows[0]["fec_baja"] != DBNull.Value)
                        ent.FEC_BAJA = Convert.ToDateTime(dt.Rows[0]["fec_baja"]);

                    return ent;
                }
                else
                {
                    return null;
                }

            }

            catch (blLabBioquimica.Framework.blException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public bl_MUTUALEntidadColeccion Buscar(Nullable<Int32> p_ID_MUTUAL, String p_NOMBRE)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_MUTUAL, p_NOMBRE);
                bl_MUTUALEntidadColeccion lista = new bl_MUTUALEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_MUTUALEntidad ent = new bl_MUTUALEntidad();

                        if (dr["idMutual"] != DBNull.Value)
                            ent.ID_MUTUAL = Convert.ToInt32(dr["idMutual"]);
                        if (dr["nombre"] != DBNull.Value)
                            ent.NOMBRE = Convert.ToString(dr["nombre"]);
                        if (dr["telefono"] != DBNull.Value)
                            ent.TELEFONO = Convert.ToString(dr["telefono"]);
                        if (dr["direccion"] != DBNull.Value)
                            ent.DIRECCION = Convert.ToString(dr["direccion"]);
                        if (dr["email"] != DBNull.Value)
                            ent.EMAIL = Convert.ToString(dr["email"]);
                        if (dr["usr_ing"] != DBNull.Value)
                            ent.USR_ING = Convert.ToString(dr["usr_ing"]);
                        if (dr["fec_ing"] != DBNull.Value)
                            ent.FEC_ING = Convert.ToDateTime(dr["fec_ing"]);
                        if (dr["usr_mod"] != DBNull.Value)
                            ent.USR_MOD = Convert.ToString(dr["usr_mod"]);
                        if (dr["fec_mod"] != DBNull.Value)
                            ent.FEC_MOD = Convert.ToDateTime(dr["fec_mod"]);
                        if (dr["usr_baja"] != DBNull.Value)
                            ent.USR_BAJA = Convert.ToString(dr["usr_baja"]);
                        if (dr["fec_baja"] != DBNull.Value)
                            ent.FEC_BAJA = Convert.ToDateTime(dr["fec_baja"]);

                        lista.Add(ent);
                    }
                }

                return lista;
            }

            catch (blLabBioquimica.Framework.blException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public bl_MUTUALEntidad Insertar(bl_MUTUALEntidad ent)
        {
            try
            {

                ent.ID_MUTUAL = p_da.Insertar(ent.NOMBRE,ent.TELEFONO, ent.DIRECCION, ent.EMAIL, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

                return ent;
            }
            catch (blLabBioquimica.Framework.blException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public void Modificar(bl_MUTUALEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_MUTUAL, ent.NOMBRE, ent.TELEFONO, ent.DIRECCION, ent.EMAIL, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_MUTUALEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_MUTUAL, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTableMutual()
        {
            try
            {
                DataTable dt = p_da.Buscar(null, null);

                if (dt != null)
                {
                    return dt;
                }

                return null;
            }

            catch (blLabBioquimica.Framework.blException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

    }
}
