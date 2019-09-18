using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAR_DetalleResponse
    {
        public string fecha_ope
        {
            get { return m_fecha_ope; }
            set { m_fecha_ope = value; }
        }
        private string m_fecha_ope;

        public string numero_ope
        {
            get { return m_numero_ope; }
            set { m_numero_ope = value; }
        }
        private string m_numero_ope;

        public string lug_negocia
        {
            get { return m_lug_negocia; }
            set { m_lug_negocia = value; }
        }
        private string m_lug_negocia;

        public string sit_asignac
        {
            get { return m_sit_asignac; }
            set { m_sit_asignac = value; }
        }
        private string m_sit_asignac;

        public string des_asignac
        {
            get { return m_des_asignac; }
            set { m_des_asignac = value; }
        }
        private string m_des_asignac;

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


    public class VLAR_ListadoDetalle
    {
        public List<VLAR_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAR_DetalleResponse> m_detalle;
    }


    public class VLAR_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;

        public VLAR_ListadoDetalle listadodetalle
        {
            get { return m_listadodetalle; }
            set { m_listadodetalle = value; }
        }
        private VLAR_ListadoDetalle m_listadodetalle;
    }


    public class VLAR_XMLNSCResponse
    {
        public VLAR_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAR_IntegrationResponse m_integrationResponse;
    }


    public class VLAR_RootResponse
    {
        public VLAR_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAR_XMLNSCResponse m_XMLNSC;
    }


}
