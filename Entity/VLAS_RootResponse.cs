using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAS_DetalleResponse
    {

        public string cod_valor
        {
            get { return m_cod_valor; }
            set { m_cod_valor = value; }
        }
        private string m_cod_valor;

        public string nemonic
        {
            get { return m_nemonic; }
            set { m_nemonic = value; }
        }
        private string m_nemonic;

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;

        public string moneda
        {
            get { return m_moneda; }
            set { m_moneda = value; }
        }
        private string m_moneda;

        public int titdia_c
        {
            get { return m_titdia_c; }
            set { m_titdia_c = value; }
        }
        private int m_titdia_c;

        public int titneg_c
        {
            get { return m_titneg_c; }
            set { m_titneg_c = value; }
        }
        private int m_titneg_c;

        public int titdia_v
        {
            get { return m_titdia_v; }
            set { m_titdia_v = value; }
        }
        private int m_titdia_v;

        public int titneg_v
        {
            get { return m_titneg_v; }
            set { m_titneg_v = value; }
        }
        private int m_titneg_v;

        public string tipo_ope
        {
            get { return m_tipo_ope; }
            set { m_tipo_ope = value; }
        }
        private string m_tipo_ope;

    }


    public class VLAS_ListadoDetalle
    {
        public List<VLAS_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAS_DetalleResponse> m_detalle;
    }


    public class VLAS_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAS_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAS_ListadoDetalle m_listadoDetalle;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public string codvalor_sgte
        {
            get { return m_codvalor_sgte; }
            set { m_codvalor_sgte = value; }
        }
        private string m_codvalor_sgte;

        public string precio_sgte
        {
            get { return m_precio_sgte; }
            set { m_precio_sgte = value; }
        }
        private string m_precio_sgte;

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


    public class VLAS_XMLNSCResponse
    {
        public VLAS_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAS_IntegrationResponse m_integrationResponse;
    }


    public class VLAS_RootResponse
    {
        public VLAS_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAS_XMLNSCResponse m_XMLNSC;

    }
}
