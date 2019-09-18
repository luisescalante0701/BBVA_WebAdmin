using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAP_DetalleResponse
    {

        public string con_plz
        {
            get { return m_con_plz; }
            set { m_con_plz = value; }
        }
        private string m_con_plz;

        public int codcom
        {
            get { return m_codcom; }
            set { m_codcom = value; }
        }
        private int m_codcom;

        public string descri
        {
            get { return m_descri; }
            set { m_descri = value; }
        }
        private string m_descri;

        public string tipcom
        {
            get { return m_tipcom; }
            set { m_tipcom = value; }
        }
        private string m_tipcom;

        public string porcen
        {
            get { return m_porcen; }
            set { m_porcen = value; }
        }
        private string m_porcen;

        public double import
        {
            get { return m_import; }
            set { m_import = value; }
        }
        private double m_import;

    }


    public class VLAP_ListadoDetalle
    {
        public List<VLAP_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAP_DetalleResponse> m_detalle;

    }


    public class VLAP_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAP_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAP_ListadoDetalle m_listadoDetalle;

        public string precio_con
        {
            get { return m_precio_con; }
            set { m_precio_con = value; }
        }
        private string m_precio_con;

        public string mtoope_con
        {
            get { return m_mtoope_con; }
            set { m_mtoope_con = value; }
        }
        private string m_mtoope_con;

        public string int_corr_con
        {
            get { return m_int_corr_con; }
            set { m_int_corr_con = value; }
        }
        private string m_int_corr_con;

        public string totcom_con
        {
            get { return m_totcom_con; }
            set { m_totcom_con = value; }
        }
        private string m_totcom_con;

        public string mtopar_con
        {
            get { return m_mtopar_con; }
            set { m_mtopar_con = value; }
        }
        private string m_mtopar_con;

        public string mtot_liq_con
        {
            get { return m_mtot_liq_con; }
            set { m_mtot_liq_con = value; }
        }
        private string m_mtot_liq_con;

        public string precio_plz
        {
            get { return m_precio_plz; }
            set { m_precio_plz = value; }
        }
        private string m_precio_plz;

        public string mtoope_plz
        {
            get { return m_mtoope_plz; }
            set { m_mtoope_plz = value; }
        }
        private string m_mtoope_plz;

        public string int_corr_plz
        {
            get { return m_int_corr_plz; }
            set { m_int_corr_plz = value; }
        }
        private string m_int_corr_plz;

        public string totcom_plz
        {
            get { return m_totcom_plz; }
            set { m_totcom_plz = value; }
        }
        private string m_totcom_plz;

        public string mtopar_plz
        {
            get { return m_mtopar_plz; }
            set { m_mtopar_plz = value; }
        }
        private string m_mtopar_plz;

        public string mtot_liq_plz
        {
            get { return m_mtot_liq_plz; }
            set { m_mtot_liq_plz = value; }
        }
        private string m_mtot_liq_plz;

        public string fecha_vcto
        {
            get { return m_fecha_vcto; }
            set { m_fecha_vcto = value; }
        }
        private string m_fecha_vcto;

        public string tipo_cambio
        {
            get { return m_tipo_cambio; }
            set { m_tipo_cambio = value; }
        }
        private string m_tipo_cambio;

        public string tem
        {
            get { return m_tem; }
            set { m_tem = value; }
        }
        private string m_tem;

        public string tasa_utilidad
        {
            get { return m_tasa_utilidad; }
            set { m_tasa_utilidad = value; }
        }
        private string m_tasa_utilidad;

        public string monto_util
        {
            get { return m_monto_util; }
            set { m_monto_util = value; }
        }
        private string m_monto_util;

        public string cod_retorno
        {
            get { return m_cod_retorno; }
            set { m_cod_retorno = value; }
        }
        private string m_cod_retorno;

        public string cod_error_dev
        {
            get { return m_cod_error_dev; }
            set { m_cod_error_dev = value; }
        }
        private string m_cod_error_dev;

        public string var1_error
        {
            get { return m_var1_error; }
            set { m_var1_error = value; }
        }
        private string m_var1_error;

        public string var2_error
        {
            get { return m_var2_error; }
            set { m_var2_error = value; }
        }
        private string m_var2_error;

    }


    public class VLAP_XMLNSCResponse
    {
        public VLAP_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAP_IntegrationResponse m_integrationResponse;

    }


    public class VLAP_RootResponse
    {
        public VLAP_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAP_XMLNSCResponse m_XMLNSC;

    }

}
