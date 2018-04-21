using System;
using System.Collections.Generic;
using System.Data;
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

        private String p_NOMBRE_ITEM;
        public String NOMBRE_ITEM
        {
            get { return p_NOMBRE_ITEM; }
            set { p_NOMBRE_ITEM = value; }
        }

        private String p_VALOR_REF_ITEM;
        public String VALOR_REF_ITEM
        {
            get { return p_VALOR_REF_ITEM; }
            set { p_VALOR_REF_ITEM = value; }
        }

        private String p_RESULTADO;
        public String RESULTADO
        {
            get { return p_RESULTADO; }
            set { p_RESULTADO = value; }
        }

        private String p_NOMBRE_UNIDAD;
        public String NOMBRE_UNIDAD
        {
            get { return p_NOMBRE_UNIDAD; }
            set { p_NOMBRE_UNIDAD = value; }
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

        public bl_PRACTICAEntidad() { }

        public bl_PRACTICAEntidad(Int32 ID_PRACTICA)
        {
            try
            {

                bl_PRACTICA bl = new bl_PRACTICA();
                bl_PRACTICAEntidad ent = bl.BuscarPorPK(ID_PRACTICA);

                if (ent != null)
                {
                    this.ID_PRACTICA = ent.ID_PRACTICA;
                    this.ID_PROTOCOLO_DETALLE = ent.ID_PROTOCOLO_DETALLE;
                    this.ID_ITEM = ent.ID_ITEM;
                    this.NOMBRE_ITEM = ent.NOMBRE_ITEM;
                    this.VALOR_REF_ITEM = ent.VALOR_REF_ITEM;
                    this.NOMBRE_UNIDAD = ent.NOMBRE_UNIDAD;
                    this.RESULTADO = ent.RESULTADO;
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

    public class bl_PRACTICAEntidadColeccion : List<bl_PRACTICAEntidad>
    {
    }

    public class bl_PRACTICA
    {

        private daLabBioquimica.da_PRACTICA p_da;

        public bl_PRACTICA()
        {
            p_da = new daLabBioquimica.da_PRACTICA();
        }

        public bl_PRACTICAEntidad BuscarPorPK(Nullable<Int32> p_ID_PRACTICA)
        {
            try
            {
                DataTable dt = p_da.BuscarPorPK(p_ID_PRACTICA);

                if (dt != null && dt.Rows.Count > 0)
                {
                    bl_PRACTICAEntidad ent = new bl_PRACTICAEntidad();

                    if (dt.Rows[0]["idPractica"] != DBNull.Value)
                        ent.ID_PRACTICA = Convert.ToInt32(dt.Rows[0]["idPractica"]);
                    if (dt.Rows[0]["idProtocoloDetalle"] != DBNull.Value)
                        ent.ID_PROTOCOLO_DETALLE = Convert.ToInt32(dt.Rows[0]["idProtocoloDetalle"]);
                    if (dt.Rows[0]["idItem"] != DBNull.Value)
                        ent.ID_ITEM = Convert.ToInt32(dt.Rows[0]["idItem"]);
                    if (dt.Rows[0]["Item"] != DBNull.Value)
                        ent.NOMBRE_ITEM = Convert.ToString(dt.Rows[0]["Item"]);
                    if (dt.Rows[0]["valorReferencia"] != DBNull.Value)
                        ent.VALOR_REF_ITEM = Convert.ToString(dt.Rows[0]["valorReferencia"]);
                    if (dt.Rows[0]["resultado"] != DBNull.Value)
                        ent.RESULTADO = Convert.ToString(dt.Rows[0]["resultado"]);
                    if (dt.Rows[0]["Unidad"] != DBNull.Value)
                        ent.NOMBRE_UNIDAD = Convert.ToString(dt.Rows[0]["Unidad"]);
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

        public bl_PRACTICAEntidadColeccion Buscar(Nullable<Int32> p_ID_PRACTICA, Nullable<Int32> p_ID_PROTOCOLO_DET, Nullable<Int32> p_ID_ITEM)
        {
            try
            {
                DataTable dt = p_da.Buscar(p_ID_PRACTICA, p_ID_PROTOCOLO_DET, p_ID_ITEM);
                bl_PRACTICAEntidadColeccion lista = new bl_PRACTICAEntidadColeccion();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        bl_PRACTICAEntidad ent = new bl_PRACTICAEntidad();

                        if (dr["idPractica"] != DBNull.Value)
                            ent.ID_PRACTICA = Convert.ToInt32(dr["idPractica"]);
                        if (dr["idProtocoloDetalle"] != DBNull.Value)
                            ent.ID_PROTOCOLO_DETALLE = Convert.ToInt32(dr["idProtocoloDetalle"]);
                        if (dr["idItem"] != DBNull.Value)
                            ent.ID_ITEM = Convert.ToInt32(dr["idItem"]);
                        if (dr["Item"] != DBNull.Value)
                            ent.NOMBRE_ITEM = Convert.ToString(dr["Item"]);
                        if (dr["valorReferencia"] != DBNull.Value)
                            ent.VALOR_REF_ITEM = Convert.ToString(dr["valorReferencia"]);
                        if (dr["resultado"] != DBNull.Value)
                            ent.RESULTADO = Convert.ToString(dr["resultado"]);
                        if (dr["Unidad"] != DBNull.Value)
                            ent.NOMBRE_UNIDAD = Convert.ToString(dr["Unidad"]);
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


        public bl_PRACTICAEntidad Insertar(bl_PRACTICAEntidad ent)
        {
            try
            {

                ent.ID_PRACTICA = p_da.Insertar(ent.ID_PROTOCOLO_DETALLE, ent.ID_ITEM, ent.RESULTADO, ent.USR_ING, ent.FEC_ING, ent.USR_MOD, ent.FEC_MOD, ent.USR_BAJA, ent.FEC_BAJA);

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

        public void Modificar(bl_PRACTICAEntidad ent)
        {
            try
            {
                p_da.Modificar(ent.ID_PRACTICA, ent.ID_PROTOCOLO_DETALLE, ent.ID_ITEM, ent.RESULTADO, ent.USR_MOD, ent.FEC_MOD);
            }
            catch (Exception ex)
            {
                throw new blLabBioquimica.Framework.blException(ex.Message);
            }
        }

        public void Baja(bl_PRACTICAEntidad ent)
        {
            try
            {
                p_da.Baja(ent.ID_PRACTICA, ent.USR_BAJA, ent.FEC_BAJA);
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
                DataTable dt = p_da.Buscar(null, null, null);

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
