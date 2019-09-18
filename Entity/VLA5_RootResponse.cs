using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLA5_DetalleResponse
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

        public int sdocon
        {
            get { return m_sdocon; }
            set { m_sdocon = value; }
        }
        private int m_sdocon;

        public int sdodis
        {
            get { return m_sdodis; }
            set { m_sdodis = value; }
        }
        private int m_sdodis;

        public int compnl
        {
            get { return m_compnl; }
            set { m_compnl = value; }
        }
        private int m_compnl;

        public double prepro
        {
            get { return m_prepro; }
            set { m_prepro = value; }
        }
        private double m_prepro;

        public double preact
        {
            get { return m_preact; }
            set { m_preact = value; }
        }
        private double m_preact;

        public double valact
        {
            get { return m_valact; }
            set { m_valact = value; }
        }
        private double m_valact;

        public double utilid
        {
            get { return m_utilid; }
            set { m_utilid = value; }
        }
        private double m_utilid;

        public string utilid_s
        {
            get { return m_utilid_s; }
            set { m_utilid_s = value; }
        }
        private string m_utilid_s;

        public int custodio
        {
            get { return m_custodio; }
            set { m_custodio = value; }
        }
        private int m_custodio;

        public string indvalor
        {
            get { return m_indvalor; }
            set { m_indvalor = value; }
        }
        private string m_indvalor;

    }

    public class VLA5_ListadoDetalle
    {
        public List<VLA5_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLA5_DetalleResponse> m_detalle;

    }

    public class VLA5_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLA5_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLA5_ListadoDetalle m_listadoDetalle;

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

    public class VLA5_XMLNSCResponse
    {
        public VLA5_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLA5_IntegrationResponse m_integrationResponse;
    }

    public class VLA5_RootResponse
    {
        public VLA5_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLA5_XMLNSCResponse m_XMLNSC;
    }

}
