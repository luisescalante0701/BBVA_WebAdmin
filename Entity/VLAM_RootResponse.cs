using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAM_DetalleResponse
    {

        public string nemonico
        {
            get { return m_nemonico; }
            set { m_nemonico = value; }
        }
        private string m_nemonico;

        public string tipo_renta
        {
            get { return m_tipo_renta; }
            set { m_tipo_renta = value; }
        }
        private string m_tipo_renta;

        public string codvalor
        {
            get { return m_codvalor; }
            set { m_codvalor = value; }
        }
        private string m_codvalor;

        public string valrepor
        {
            get { return m_valrepor; }
            set { m_valrepor = value; }
        }
        private string m_valrepor;

    }


    public class VLAM_ListadoDetalle
    {
        public List<VLAM_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAM_DetalleResponse> m_detalle;

    }


    public class VLAM_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAM_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAM_ListadoDetalle m_listadoDetalle;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public string nemotec_sgte
        {
            get { return m_nemotec_sgte; }
            set { m_nemotec_sgte = value; }
        }
        private string m_nemotec_sgte;

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


    public class VLAM_XMLNSCResponse
    {
        public VLAM_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAM_IntegrationResponse m_integrationResponse;

    }


    public class VLAM_RootResponse
    {
        public VLAM_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAM_XMLNSCResponse m_XMLNSC;

    }
}
