using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAN_DetalleResponse
    {

        public int broker_s
        {
            get { return m_broker_s; }
            set { m_broker_s = value; }
        }
        private int m_broker_s;

        public string nomb_broker
        {
            get { return m_nomb_broker; }
            set { m_nomb_broker = value; }
        }
        private string m_nomb_broker;

    }


    public class VLAN_ListadoDetalle
    {
        public List<VLAN_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAN_DetalleResponse> m_detalle;

    }


    public class VLAN_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAN_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAN_ListadoDetalle m_listadoDetalle;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public int broker_sgte
        {
            get { return m_broker_sgte; }
            set { m_broker_sgte = value; }
        }
        private int m_broker_sgte;

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


    public class VLAN_XMLNSCResponse
    {
        public VLAN_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAN_IntegrationResponse m_integrationResponse;

    }


    public class VLAN_RootResponse
    {
        public VLAN_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAN_XMLNSCResponse m_XMLNSC;

    }

}
