using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Error_IntegrationResponse
    {

        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


    }

    public class Error_RootResponse
    {
        public Error_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private Error_IntegrationResponse m_integrationResponse;
    }
}
