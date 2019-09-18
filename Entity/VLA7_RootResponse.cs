using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLA7_DetalleResponse
    {

        //Sin detalle 

    }


    public class VLA7_ListadoDetalle
    {

        //Sin detalle

    }


    public class VLA7_IntegrationResponse
    {

        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public string cta_eco_cargo
        {
            get { return m_cta_eco_cargo; }
            set { m_cta_eco_cargo = value; }
        }
        private string m_cta_eco_cargo;

        public string mon_eco_cargo
        {
            get { return m_mon_eco_cargo; }
            set { m_mon_eco_cargo = value; }
        }
        private string m_mon_eco_cargo;

        public string nro_ctavalor
        {
            get { return m_nro_ctavalor; }
            set { m_nro_ctavalor = value; }
        }
        private string m_nro_ctavalor;

        public string mon_ctavalor
        {
            get { return m_mon_ctavalor; }
            set { m_mon_ctavalor = value; }
        }
        private string m_mon_ctavalor;

        public string nemoni_valor
        {
            get { return m_nemoni_valor; }
            set { m_nemoni_valor = value; }
        }
        private string m_nemoni_valor;

        public string nombre_valor
        {
            get { return m_nombre_valor; }
            set { m_nombre_valor = value; }
        }
        private string m_nombre_valor;

        public string tit_negociado
        {
            get { return m_tit_negociado; }
            set { m_tit_negociado = value; }
        }
        private string m_tit_negociado;

        public string pre_negociado
        {
            get { return m_pre_negociado; }
            set { m_pre_negociado = value; }
        }
        private string m_pre_negociado;

        public string dias_utiles
        {
            get { return m_dias_utiles; }
            set { m_dias_utiles = value; }
        }
        private string m_dias_utiles;

        public string ult_cotizacion
        {
            get { return m_ult_cotizacion; }
            set { m_ult_cotizacion = value; }
        }
        private string m_ult_cotizacion;

        public string modalidad_orden
        {
            get { return m_modalidad_orden; }
            set { m_modalidad_orden = value; }
        }
        private string m_modalidad_orden;

        public string admist_cartera
        {
            get { return m_admist_cartera; }
            set { m_admist_cartera = value; }
        }
        private string m_admist_cartera;

        public string des_operacion
        {
            get { return m_des_operacion; }
            set { m_des_operacion = value; }
        }
        private string m_des_operacion;

        public string nro_orden
        {
            get { return m_nro_orden; }
            set { m_nro_orden = value; }
        }
        private string m_nro_orden;

        public string nro_orden_cns
        {
            get { return m_nro_orden_cns; }
            set { m_nro_orden_cns = value; }
        }
        private string m_nro_orden_cns;

        public string imp_retenido
        {
            get { return m_imp_retenido; }
            set { m_imp_retenido = value; }
        }
        private string m_imp_retenido;

        public string tipo_cambio
        {
            get { return m_tipo_cambio; }
            set { m_tipo_cambio = value; }
        }
        private string m_tipo_cambio;

        public string fecha_orden
        {
            get { return m_fecha_orden; }
            set { m_fecha_orden = value; }
        }
        private string m_fecha_orden;

        public string hora_orden
        {
            get { return m_hora_orden; }
            set { m_hora_orden = value; }
        }
        private string m_hora_orden;

        public string cust_titulos
        {
            get { return m_cust_titulos; }
            set { m_cust_titulos = value; }
        }
        private string m_cust_titulos;

        public string nomb_custodio
        {
            get { return m_nomb_custodio; }
            set { m_nomb_custodio = value; }
        }
        private string m_nomb_custodio;

        public string imp_operacion
        {
            get { return m_imp_operacion; }
            set { m_imp_operacion = value; }
        }
        private string m_imp_operacion;

        public string imp_liquidacion
        {
            get { return m_imp_liquidacion; }
            set { m_imp_liquidacion = value; }
        }
        private string m_imp_liquidacion;

        public string ind_actualiz
        {
            get { return m_ind_actualiz; }
            set { m_ind_actualiz = value; }
        }
        private string m_ind_actualiz;

        public string ind_especial
        {
            get { return m_ind_especial; }
            set { m_ind_especial = value; }
        }
        private string m_ind_especial;

        public string sab_represen
        {
            get { return m_sab_represen; }
            set { m_sab_represen = value; }
        }
        private string m_sab_represen;

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


    public class VLA7_XMLNSCResponse
    {
        public VLA7_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLA7_IntegrationResponse m_integrationResponse;

    }


    public class VLA7_RootResponse
    {
        public VLA7_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLA7_XMLNSCResponse m_XMLNSC;

    }
}
