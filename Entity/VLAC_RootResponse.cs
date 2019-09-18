using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAC_DetalleResponse
    {

        //Sin detalle 

    }


    public class VLAC_ListadoDetalle
    {

        //Sin detalle

    }


    public class VLAC_IntegrationResponse
    {

        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public string nemoni_valor
        {
            get { return m_nemoni_valor; }
            set { m_nemoni_valor = value; }
        }
        private string m_nemoni_valor;

        public double tit_negociado
        {
            get { return m_tit_negociado; }
            set { m_tit_negociado = value; }
        }
        private double m_tit_negociado;

        public double pre_negociado
        {
            get { return m_pre_negociado; }
            set { m_pre_negociado = value; }
        }
        private double m_pre_negociado;

        public int dias_utiles
        {
            get { return m_dias_utiles; }
            set { m_dias_utiles = value; }
        }
        private int m_dias_utiles;

        public int com_orden
        {
            get { return m_com_orden; }
            set { m_com_orden = value; }
        }
        private int m_com_orden;

        public int com_orden_cns
        {
            get { return m_com_orden_cns; }
            set { m_com_orden_cns = value; }
        }
        private int m_com_orden_cns;

        public int vta_orden
        {
            get { return m_vta_orden; }
            set { m_vta_orden = value; }
        }
        private int m_vta_orden;

        public int vta_orden_cns
        {
            get { return m_vta_orden_cns; }
            set { m_vta_orden_cns = value; }
        }
        private int m_vta_orden_cns;

        public double imp_retenido
        {
            get { return m_imp_retenido; }
            set { m_imp_retenido = value; }
        }
        private double m_imp_retenido;

        public string cust_titulos_c
        {
            get { return m_cust_titulos_c; }
            set { m_cust_titulos_c = value; }
        }
        private string m_cust_titulos_c;

        public double imp_operacion_c
        {
            get { return m_imp_operacion_c; }
            set { m_imp_operacion_c = value; }
        }
        private double m_imp_operacion_c;

        public double imp_liquidacion_c
        {
            get { return m_imp_liquidacion_c; }
            set { m_imp_liquidacion_c = value; }
        }
        private double m_imp_liquidacion_c;

        public string auxiliar1_c
        {
            get { return m_auxiliar1_c; }
            set { m_auxiliar1_c = value; }
        }
        private string m_auxiliar1_c;

        public int auxiliar2_c
        {
            get { return m_auxiliar2_c; }
            set { m_auxiliar2_c = value; }
        }
        private int m_auxiliar2_c;

        public string cust_titulos_v
        {
            get { return m_cust_titulos_v; }
            set { m_cust_titulos_v = value; }
        }
        private string m_cust_titulos_v;

        public double imp_operacion_v
        {
            get { return m_imp_operacion_v; }
            set { m_imp_operacion_v = value; }
        }
        private double m_imp_operacion_v;

        public double imp_liquidacion_v
        {
            get { return m_imp_liquidacion_v; }
            set { m_imp_liquidacion_v = value; }
        }
        private double m_imp_liquidacion_v;

        public string auxiliar1_v
        {
            get { return m_auxiliar1_v; }
            set { m_auxiliar1_v = value; }
        }
        private string m_auxiliar1_v;

        public int auxiliar2_v
        {
            get { return m_auxiliar2_v; }
            set { m_auxiliar2_v = value; }
        }
        private int m_auxiliar2_v;

        public string ind_actualiz
        {
            get { return m_ind_actualiz; }
            set { m_ind_actualiz = value; }
        }
        private string m_ind_actualiz;

        public string tipo_orden
        {
            get { return m_tipo_orden; }
            set { m_tipo_orden = value; }
        }
        private string m_tipo_orden;

        public string representa_sab
        {
            get { return m_representa_sab; }
            set { m_representa_sab = value; }
        }
        private string m_representa_sab;

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


    public class VLAC_XMLNSCResponse
    {
        public VLAC_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAC_IntegrationResponse m_integrationResponse;

    }


    public class VLAC_RootResponse
    {
        public VLAC_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAC_XMLNSCResponse m_XMLNSC;

    }

}
