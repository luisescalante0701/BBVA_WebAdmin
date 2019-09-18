using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLA0_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        ////public VLA0_ListadoDetalle listadoDetalle
        ////{
        ////    get { return m_listadoDetalle; }
        ////    set { m_listadoDetalle = value; }
        ////}
        ////private VLA0_ListadoDetalle m_listadoDetalle;


        public string cod_ret
        {
            get { return m_cod_ret; }
            set { m_cod_ret = value; }
        }
        private string m_cod_ret;

        public string msg_res
        {
            get { return m_msg_res; }
            set { m_msg_res = value; }
        }
        private string m_msg_res;

    }

    public class VLA0_XMLNSCResponse
    {
        public VLA0_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLA0_IntegrationResponse m_integrationResponse;
    }

    public class VLA0_RootResponse
    {
        public VLA0_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLA0_XMLNSCResponse m_XMLNSC;
    }




}
