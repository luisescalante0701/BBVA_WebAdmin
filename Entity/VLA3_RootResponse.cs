using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{


    public class VLA3_DetalleResponse
    {

        public string tipo_doc
        {
            get { return m_tipo_doc; }
            set { m_tipo_doc = value; }
        }
        private string m_tipo_doc;

        public string nume_doc
        {
            get { return m_nume_doc; }
            set { m_nume_doc = value; }
        }
        private string m_nume_doc;

        public string cliente
        {
            get { return m_cliente; }
            set { m_cliente = value; }
        }
        private string m_cliente;

        public string rutbvl
        {
            get { return m_rutbvl; }
            set { m_rutbvl = value; }
        }
        private string m_rutbvl;

    }


    public class VLA3_ListadoDetalle
    {
        public List<VLA3_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLA3_DetalleResponse> m_detalle;

    }


    public class VLA3_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLA3_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLA3_ListadoDetalle m_listadoDetalle;


        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public string sgte_cliente
        {
            get { return m_sgte_cliente; }
            set { m_sgte_cliente = value; }
        }
        private string m_sgte_cliente;

        public string sgte_rut
        {
            get { return m_sgte_rut; }
            set { m_sgte_rut = value; }
        }
        private string m_sgte_rut;

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


    public class VLA3_XMLNSCResponse
    {
        public VLA3_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLA3_IntegrationResponse m_integrationResponse;

    }


    public class VLA3_RootResponse
    {
        public VLA3_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLA3_XMLNSCResponse m_XMLNSC;

    }
}
