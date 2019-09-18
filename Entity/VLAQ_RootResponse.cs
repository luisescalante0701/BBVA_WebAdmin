using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAQ_DetalleResponse
    {

        public string lugnegoc
        {
            get { return m_lugnegoc; }
            set { m_lugnegoc = value; }
        }
        private string m_lugnegoc;

        public string mercado
        {
            get { return m_mercado; }
            set { m_mercado = value; }
        }
        private string m_mercado;

        public string comven
        {
            get { return m_comven; }
            set { m_comven = value; }
        }
        private string m_comven;

        public string menonico
        {
            get { return m_menonico; }
            set { m_menonico = value; }
        }
        private string m_menonico;

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;

        public string duracion
        {
            get { return m_duracion; }
            set { m_duracion = value; }
        }
        private string m_duracion;

        public int cant_titulos
        {
            get { return m_cant_titulos; }
            set { m_cant_titulos = value; }
        }
        private int m_cant_titulos;

        public string ref_tipo
        {
            get { return m_ref_tipo; }
            set { m_ref_tipo = value; }
        }
        private string m_ref_tipo;

        public string refer_ord
        {
            get { return m_refer_ord; }
            set { m_refer_ord = value; }
        }
        private string m_refer_ord;

        public string fech_fpt
        {
            get { return m_fech_fpt; }
            set { m_fech_fpt = value; }
        }
        private string m_fech_fpt;

        public int corto
        {
            get { return m_corto; }
            set { m_corto = value; }
        }
        private int m_corto;

    }


    public class VLAQ_ListadoDetalle
    {
        public List<VLAQ_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAQ_DetalleResponse> m_detalle;

    }


    public class VLAQ_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAQ_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAQ_ListadoDetalle m_listadoDetalle;

        public int ult_orden
        {
            get { return m_ult_orden; }
            set { m_ult_orden = value; }
        }
        private int m_ult_orden;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

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


    public class VLAQ_XMLNSCResponse
    {
        public VLAQ_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAQ_IntegrationResponse m_integrationResponse;

    }


    public class VLAQ_RootResponse
    {
        public VLAQ_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAQ_XMLNSCResponse m_XMLNSC;

    }
}
