using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAT_DetalleResponse
    {

        public string nro_orden
        {
            get { return m_nro_orden; }
            set { m_nro_orden = value; }
        }
        private string m_nro_orden;

        public string cta_valor
        {
            get { return m_cta_valor; }
            set { m_cta_valor = value; }
        }
        private string m_cta_valor;

        public string comitente
        {
            get { return m_comitente; }
            set { m_comitente = value; }
        }
        private string m_comitente;

        public string titdia
        {
            get { return m_titdia; }
            set { m_titdia = value; }
        }
        private string m_titdia;

        public string titpor
        {
            get { return m_titpor; }
            set { m_titpor = value; }
        }
        private string m_titpor;

        public string titneg
        {
            get { return m_titneg; }
            set { m_titneg = value; }
        }
        private string m_titneg;

        public string preneg
        {
            get { return m_preneg; }
            set { m_preneg = value; }
        }
        private string m_preneg;

        public string mtoope
        {
            get { return m_mtoope; }
            set { m_mtoope = value; }
        }
        private string m_mtoope;

        public string mtoliq
        {
            get { return m_mtoliq; }
            set { m_mtoliq = value; }
        }
        private string m_mtoliq;

    }


    public class VLAT_ListadoDetalle
    {
        public List<VLAT_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAT_DetalleResponse> m_detalle;

    }


    public class VLAT_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAT_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAT_ListadoDetalle m_listadoDetalle;

        public string nemonic
        {
            get { return m_nemonic; }
            set { m_nemonic = value; }
        }
        private string m_nemonic;

        public string com_vta
        {
            get { return m_com_vta; }
            set { m_com_vta = value; }
        }
        private string m_com_vta;

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;

        public string moneda
        {
            get { return m_moneda; }
            set { m_moneda = value; }
        }
        private string m_moneda;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public string orden_sgte
        {
            get { return m_orden_sgte; }
            set { m_orden_sgte = value; }
        }
        private string m_orden_sgte;

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


    public class VLAT_XMLNSCResponse
    {
        public VLAT_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAT_IntegrationResponse m_integrationResponse;
    }


    public class VLAT_RootResponse
    {
        public VLAT_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAT_XMLNSCResponse m_XMLNSC;

    }
}
