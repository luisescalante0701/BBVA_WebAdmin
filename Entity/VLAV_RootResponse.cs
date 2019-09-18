using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{


    public class VLAV_DetalleResponse
    {

        public string numero_ope
        {
            get { return m_numero_ope; }
            set { m_numero_ope = value; }
        }
        private string m_numero_ope;

        public string com_ven
        {
            get { return m_com_ven; }
            set { m_com_ven = value; }
        }
        private string m_com_ven;

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;

        public string can_titulos
        {
            get { return m_can_titulos; }
            set { m_can_titulos = value; }
        }
        private string m_can_titulos;

        public string mto_operacion
        {
            get { return m_mto_operacion; }
            set { m_mto_operacion = value; }
        }
        private string m_mto_operacion;

        public string aux_num01
        {
            get { return m_aux_num01; }
            set { m_aux_num01 = value; }
        }
        private string m_aux_num01;

        public string aux_num02
        {
            get { return m_aux_num02; }
            set { m_aux_num02 = value; }
        }
        private string m_aux_num02;

    }


    public class VLAV_ListadoDetalle
    {
        public List<VLAV_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAV_DetalleResponse> m_detalle;

    }


    public class VLAV_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;

        public VLAV_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAV_ListadoDetalle m_listadoDetalle;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public string sgte_nroopera
        {
            get { return m_sgte_nroopera; }
            set { m_sgte_nroopera = value; }
        }
        private string m_sgte_nroopera;

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


    public class VLAV_XMLNSCResponse
    {
        public VLAV_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAV_IntegrationResponse m_integrationResponse;

    }


    public class VLAV_RootResponse
    {
        public VLAV_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAV_XMLNSCResponse m_XMLNSC;

    }
}
