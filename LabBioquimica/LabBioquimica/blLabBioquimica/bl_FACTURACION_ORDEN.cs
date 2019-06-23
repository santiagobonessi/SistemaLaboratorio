using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blLabBioquimica
{
    public class bl_FACTURACION_ORDENEntidad
    {

        private Nullable<Int32> p_ID_FACTURACION_ORDEN;
        public Nullable<Int32> ID_FACTURACION_ORDEN
        {
            get { return p_ID_FACTURACION_ORDEN; }
            set { p_ID_FACTURACION_ORDEN = value; }
        }

        private Nullable<Int32> p_ID_FACTURACION_MUTUAL;
        public Nullable<Int32> ID_FACTURACION_MUTUAL
        {
            get { return p_ID_FACTURACION_MUTUAL; }
            set { p_ID_FACTURACION_MUTUAL = value; }
        }

        private Nullable<Int32> p_ID_PACIENTE;
        public Nullable<Int32> ID_PACIENTE
        {
            get { return p_ID_PACIENTE; }
            set { p_ID_PACIENTE = value; }
        }

        private String p_N_PACIENTE;
        public String N_PACIENTE
        {
            get { return p_N_PACIENTE; }
            set { p_N_PACIENTE = value; }
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

        public bl_FACTURACION_ORDENEntidad() { }

        public bl_FACTURACION_ORDENEntidad(Int32 ID_FACTURACION_ORDEN)
        {
            try
            {

                bl_FACTURACION_ORDEN bl = new bl_FACTURACION_ORDEN();
                bl_FACTURACION_ORDENEntidad ent = bl.BuscarPorPK(ID_FACTURACION_ORDEN);


                if (ent != null)
                {
                    this.ID_FACTURACION_ORDEN = ent.ID_FACTURACION_ORDEN;
                    this.ID_FACTURACION_MUTUAL = ent.ID_FACTURACION_MUTUAL;
                    this.ID_PACIENTE = ent.ID_PACIENTE;
                    this.N_PACIENTE = ent.N_PACIENTE;
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

    public class bl_FACTURACION_ORDENEntidadColeccion : List<bl_FACTURACION_ORDENEntidad>
    {
    }

    public class bl_FACTURACION_ORDEN
    {

        private daLabBioquimica.da_FACTURACION_ORDEN p_da;

        public bl_FACTURACION_ORDEN()
        {
            p_da = new daLabBioquimica.da_FACTURACION_ORDEN();
        }

        public bl_FACTURACION_ORDENEntidad BuscarPorPK(Nullable<Int32> p_ID_FACTURACION_ORDEN)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(p_ID_FACTURACION_ORDEN);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_FACTURACION_ORDENEntidad ent = new bl_FACTURACION_ORDENEntidad();

                    if (dt.Rows[0]["idFacturacionOrden"] != DBNull.Value)
                        ent.ID_FACTURACION_ORDEN = Convert.ToInt32(dt.Rows[0]["idFacturacionOrden"]);
                    if (dt.Rows[0]["idFacturacionMutual"] != DBNull.Value)
                        ent.ID_FACTURACION_MUTUAL = Convert.ToInt32(dt.Rows[0]["idFacturacionMutual"]);
                    if (dt.Rows[0]["idPaciente"] != DBNull.Value)
                        ent.ID_PACIENTE = Convert.ToInt32(dt.Rows[0]["idPaciente"]);
                    if (dt.Rows[0]["nomapePac"] != DBNull.Value)
                        ent.N_PACIENTE = Convert.ToString(dt.Rows[0]["nomapePac"]);
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


        public bl_FACTURACION_ORDENEntidadColeccion Buscar(Nullable<Int32> p_ID_FACTURACION_ORDEN, Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_PACIENTE)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_FACTURACION_ORDEN, p_ID_FACTURACION_MUTUAL, p_ID_PACIENTE);
                bl_FACTURACION_ORDENEntidadColeccion lista = new bl_FACTURACION_ORDENEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_FACTURACION_ORDENEntidad ent = new bl_FACTURACION_ORDENEntidad();

                        if (dr["idFacturacionOrden"] != DBNull.Value)
                            ent.ID_FACTURACION_ORDEN = Convert.ToInt32(dr["idFacturacionOrden"]);
                        if (dr["idFacturacionMutual"] != DBNull.Value)
                            ent.ID_FACTURACION_MUTUAL = Convert.ToInt32(dr["idFacturacionMutual"]);
                        if (dr["idPaciente"] != DBNull.Value)
                            ent.ID_PACIENTE = Convert.ToInt32(dr["idPaciente"]);
                        if (dr["nomapePac"] != DBNull.Value)
                            ent.N_PACIENTE = Convert.ToString(dr["nomapePac"]);
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


        public bl_FACTURACION_ORDENEntidad Insertar(bl_FACTURACION_ORDENEntidad ent)
        {
            try
            {

                ent.ID_FACTURACION_ORDEN = p_da.Insertar(ent.ID_FACTURACION_MUTUAL, ent.ID_PACIENTE, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_FACTURACION_ORDENEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_FACTURACION_ORDEN, ent.ID_FACTURACION_MUTUAL, ent.ID_PACIENTE, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_FACTURACION_ORDENEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_FACTURACION_ORDEN, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTableFacturacionMutual(Nullable<Int32> p_ID_FACTURACION_ORDEN, Nullable<Int32> p_ID_FACTURACION_MUTUAL, Nullable<Int32> p_ID_PACIENTE)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_FACTURACION_ORDEN, p_ID_FACTURACION_MUTUAL, p_ID_PACIENTE);

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
