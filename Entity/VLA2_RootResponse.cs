using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLA2_DetalleResponse
    {

        public string ctavalor
        {
            get { return m_ctavalor; }
            set { m_ctavalor = value; }
        }
        private string m_ctavalor;

        public string rut
        {
            get { return m_rut; }
            set { m_rut = value; }
        }
        private string m_rut;

        public string ecocar
        {
            get { return m_ecocar; }
            set { m_ecocar = value; }
        }
        private string m_ecocar;

        public string moncar
        {
            get { return m_moncar; }
            set { m_moncar = value; }
        }
        private string m_moncar;

        public string ecoabo
        {
            get { return m_ecoabo; }
            set { m_ecoabo = value; }
        }
        private string m_ecoabo;

        public string monabo
        {
            get { return m_monabo; }
            set { m_monabo = value; }
        }
        private string m_monabo;

        public string tipcom
        {
            get { return m_tipcom; }
            set { m_tipcom = value; }
        }
        private string m_tipcom;

        public string comrda
        {
            get { return m_comrda; }
            set { m_comrda = value; }
        }
        private string m_comrda;

        public string lugneg
        {
            get { return m_lugneg; }
            set { m_lugneg = value; }
        }
        private string m_lugneg;


    }

    public class VLA2_ListadoDetalle
    {
        public List<VLA2_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLA2_DetalleResponse> m_detalle;

    }

    public class VLA2_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLA2_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLA2_ListadoDetalle m_listadoDetalle;

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

        public string direccion
        {
            get { return m_direccion; }
            set { m_direccion = value; }
        }
        private string m_direccion;

        public string telefonos
        {
            get { return m_telefonos; }
            set { m_telefonos = value; }
        }
        private string m_telefonos;

        public string telefonos1
        {
            get { return m_telefono1; }
            set { m_telefono1 = value; }
        }
        private string m_telefono1;

        public string telefonos2
        {
            get { return m_telefono2; }
            set { m_telefono2 = value; }
        }
        private string m_telefono2;

        public string telefonos3
        {
            get { return m_telefono3; }
            set { m_telefono3 = value; }
        }
        private string m_telefono3;

        public string email
        {
            get { return m_email; }
            set { m_email = value; }
        }
        private string m_email;


        public string numcli
        {
            get { return m_numcli; }
            set { m_numcli = value; }
        }
        private string m_numcli;

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

    public class VLA2_XMLNSCResponse
    {
        public VLA2_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLA2_IntegrationResponse m_integrationResponse;
    }

    public class VLA2_RootResponse
    {
        public VLA2_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLA2_XMLNSCResponse m_XMLNSC;
    }
}
