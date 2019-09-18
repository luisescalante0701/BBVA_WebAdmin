using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAF_DetalleResponse
    {
        public string ctaval_g
        {
            get { return m_ctaval_g; }
            set { m_ctaval_g = value; }
        }
        private string m_ctaval_g;

        public string nemoni_g
        {
            get { return m_nemoni_g; }
            set { m_nemoni_g = value; }
        }
        private string m_nemoni_g;

        public string sdoxli_g
        {
            get { return m_sdoxli_g; }
            set { m_sdoxli_g = value; }
        }
        private string m_sdoxli_g;

        public string titulo_g
        {
            get { return m_titulo_g; }
            set { m_titulo_g = value; }
        }
        private string m_titulo_g;

        public string prerep_g
        {
            get { return m_prerep_g; }
            set { m_prerep_g = value; }
        }
        private string m_prerep_g;

        public string porcas_g
        {
            get { return m_porcas_g; }
            set { m_porcas_g = value; }
        }
        private string m_porcas_g;

        public string impgar_g
        {
            get { return m_impgar_g; }
            set { m_impgar_g = value; }
        }
        private string m_impgar_g;

        public string indsdo_g
        {
            get { return m_indsdo_g; }
            set { m_indsdo_g = value; }
        }
        private string m_indsdo_g;

    }

    public class VLAF_ListadoDetalle
    {
        public List<VLAF_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAF_DetalleResponse> m_detalle;

    }

    public class VLAF_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAF_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAF_ListadoDetalle m_listadoDetalle;

        public string efectivo
        {
            get { return m_efectivo; }
            set { m_efectivo = value; }
        }
        private string m_efectivo;

        public string gar_cubierta
        {
            get { return m_gar_cubierta; }
            set { m_gar_cubierta = value; }
        }
        private string m_gar_cubierta;

        public string garantia
        {
            get { return m_garantia; }
            set { m_garantia = value; }
        }
        private string m_garantia;

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

    public class VLAF_XMLNSCResponse
    {
        public VLAF_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAF_IntegrationResponse m_integrationResponse;
    }

    public class VLAF_RootResponse
    {
        public VLAF_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAF_XMLNSCResponse m_XMLNSC;
    }

}
