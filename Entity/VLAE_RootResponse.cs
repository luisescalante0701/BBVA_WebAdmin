using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAE_DetalleResponse
    {

        public string ctaval
        {
            get { return m_ctaval; }
            set { m_ctaval = value; }
        }
        private string m_ctaval;

        public string nemonico
        {
            get { return m_nemonico; }
            set { m_nemonico = value; }
        }
        private string m_nemonico;

        public string moneda
        {
            get { return m_moneda; }
            set { m_moneda = value; }
        }
        private string m_moneda;

        public string sdocon
        {
            get { return m_sdocon; }
            set { m_sdocon = value; }
        }
        private string m_sdocon;

        public string sdodis
        {
            get { return m_sdodis; }
            set { m_sdodis = value; }
        }
        private string m_sdodis;

        public string compnl
        {
            get { return m_compnl; }
            set { m_compnl = value; }
        }
        private string m_compnl;

        public string prepro
        {
            get { return m_prepro; }
            set { m_prepro = value; }
        }
        private string m_prepro;

        public string preact
        {
            get { return m_preact; }
            set { m_preact = value; }
        }
        private string m_preact;

        public string valact
        {
            get { return m_valact; }
            set { m_valact = value; }
        }
        private string m_valact;

        public string utilid
        {
            get { return m_utilid; }
            set { m_utilid = value; }
        }
        private string m_utilid;

        public string utilid_s
        {
            get { return m_utilid_s; }
            set { m_utilid_s = value; }
        }
        private string m_utilid_s;

        public string custodio
        {
            get { return m_custodio; }
            set { m_custodio = value; }
        }
        private string m_custodio;

        public string indvalor
        {
            get { return m_indvalor; }
            set { m_indvalor = value; }
        }
        private string m_indvalor;

    }

    public class VLAE_ListadoDetalle
    {
        public List<VLAE_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAE_DetalleResponse> m_detalle;

    }

    public class VLAE_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAE_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAE_ListadoDetalle m_listadoDetalle;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public string ctaval_sgte
        {
            get { return m_ctaval_sgte; }
            set { m_ctaval_sgte = value; }
        }
        private string m_ctaval_sgte;

        public string nemoni_sgte
        {
            get { return m_nemoni_sgte; }
            set { m_nemoni_sgte = value; }
        }
        private string m_nemoni_sgte;

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

    public class VLAE_XMLNSCResponse
    {
        public VLAE_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAE_IntegrationResponse m_integrationResponse;
    }

    public class VLAE_RootResponse
    {
        public VLAE_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAE_XMLNSCResponse m_XMLNSC;
    }

}
