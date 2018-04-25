using System;
using System.Collections.Generic;
using System.Data;
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

        private String p_N_PACIENTE;
        public String N_PACIENTE
        {
            get { return p_N_PACIENTE; }
            set { p_N_PACIENTE = value; }
        }

        private Nullable<Int32> p_ID_PROFESIONAL;
        public Nullable<Int32> ID_PROFESIONAL
        {
            get { return p_ID_PROFESIONAL; }
            set { p_ID_PROFESIONAL = value; }
        }

        private String p_N_PROFESIONAL;
        public String N_PROFESIONAL
        {
            get { return p_N_PROFESIONAL; }
            set { p_N_PROFESIONAL = value; }
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

        public bl_PROTOCOLOEntidad() { }

        public bl_PROTOCOLOEntidad(Int32 ID_PROTOCOLO)
        {
            try
            {

                bl_PROTOCOLO bl = new bl_PROTOCOLO();
                bl_PROTOCOLOEntidad ent = bl.BuscarPorPK(ID_PROTOCOLO);


                if (ent != null)
                {

                    this.ID_PROTOCOLO = ent.ID_PROTOCOLO;
                    this.NRO_PROTOCOLO = ent.NRO_PROTOCOLO;
                    this.FECHA = ent.FECHA;
                    this.ID_PACIENTE = ent.ID_PACIENTE;
                    this.ID_PROFESIONAL = ent.ID_PROFESIONAL;
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

    public class bl_PROTOCOLOEntidadColeccion : List<bl_PROTOCOLOEntidad>
    {
    }

    public class bl_PROTOCOLO
    {

        private daLabBioquimica.da_PROTOCOLO p_da;

        public bl_PROTOCOLO()
        {
            p_da = new daLabBioquimica.da_PROTOCOLO();
        }

        public bl_PROTOCOLOEntidad BuscarPorPK(Nullable<Int32> p_ID_PROTOCOLO)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(p_ID_PROTOCOLO);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_PROTOCOLOEntidad ent = new bl_PROTOCOLOEntidad();

                    if (dt.Rows[0]["idProtocolo"] != DBNull.Value)
                        ent.ID_PROTOCOLO = Convert.ToInt32(dt.Rows[0]["idProtocolo"]);
                    if (dt.Rows[0]["nroProtocolo"] != DBNull.Value)
                        ent.NRO_PROTOCOLO = Convert.ToInt32(dt.Rows[0]["nroProtocolo"]);
                    if (dt.Rows[0]["fecha"] != DBNull.Value)
                        ent.FECHA = Convert.ToDateTime(dt.Rows[0]["fecha"]);
                    if (dt.Rows[0]["idPaciente"] != DBNull.Value)
                        ent.ID_PACIENTE = Convert.ToInt32(dt.Rows[0]["idPaciente"]);
                    if (dt.Rows[0]["nomapePac"] != DBNull.Value)
                        ent.N_PACIENTE = Convert.ToString(dt.Rows[0]["nomapePac"]);
                    if (dt.Rows[0]["idProfesional"] != DBNull.Value)
                        ent.ID_PROFESIONAL = Convert.ToInt32(dt.Rows[0]["idProfesional"]);
                    if (dt.Rows[0]["nomapeProf"] != DBNull.Value)
                        ent.N_PROFESIONAL = Convert.ToString(dt.Rows[0]["nomapeProf"]);
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


        public bl_PROTOCOLOEntidadColeccion Buscar(Nullable<Int32> p_ID_PROTOCOLO, Nullable<Int32> p_NRO_PROTOCOLO, Nullable<DateTime> p_FECHA, Nullable<Int32> p_ID_PACIENTE, Nullable<Int32> p_ID_PROFESIONAL)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_PROTOCOLO, p_NRO_PROTOCOLO, p_FECHA, p_ID_PACIENTE, p_ID_PROFESIONAL);
                bl_PROTOCOLOEntidadColeccion lista = new bl_PROTOCOLOEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_PROTOCOLOEntidad ent = new bl_PROTOCOLOEntidad();

                        if (dr["idProtocolo"] != DBNull.Value)
                            ent.ID_PROTOCOLO = Convert.ToInt32(dr["idProtocolo"]);
                        if (dr["nroProtocolo"] != DBNull.Value)
                            ent.NRO_PROTOCOLO = Convert.ToInt32(dr["nroProtocolo"]);
                        if (dr["fecha"] != DBNull.Value)
                            ent.FECHA = Convert.ToDateTime(dr["fecha"]);
                        if (dr["idPaciente"] != DBNull.Value)
                            ent.ID_PACIENTE = Convert.ToInt32(dr["idPaciente"]);
                        if (dr["nomapePac"] != DBNull.Value)
                            ent.N_PACIENTE = Convert.ToString(dr["nomapePac"]);
                        if (dr["idProfesional"] != DBNull.Value)
                            ent.ID_PROFESIONAL = Convert.ToInt32(dr["idProfesional"]);
                        if (dr["nomapeProf"] != DBNull.Value)
                            ent.N_PROFESIONAL = Convert.ToString(dr["nomapeProf"]);
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


        public bl_PROTOCOLOEntidad Insertar(bl_PROTOCOLOEntidad ent)
        {
            try
            {

                ent.ID_PROTOCOLO = p_da.Insertar(ent.NRO_PROTOCOLO, ent.FECHA, ent.ID_PACIENTE, ent.ID_PROFESIONAL, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_PROTOCOLOEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_PROTOCOLO, ent.NRO_PROTOCOLO, ent.FECHA, ent.ID_PACIENTE, ent.ID_PROFESIONAL, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_PROTOCOLOEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_PROTOCOLO, ent.USR_BAJA, ent.FEC_BAJA);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }

        }

        public DataTable dataTablePaciente()
        {
            try
            {
                DataTable dt = p_da.Buscar(null, null, null, null, null);

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
