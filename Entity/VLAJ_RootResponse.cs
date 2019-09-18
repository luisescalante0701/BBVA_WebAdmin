using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAJ_DetalleResponse
    {

        public int orden
        {
            get { return m_orden; }
            set { m_orden = value; }
        }
        private int m_orden;

        public string fecha_orden
        {
            get { return m_fecha_orden; }
            set { m_fecha_orden = value; }
        }
        private string m_fecha_orden;

        public string nemonico
        {
            get { return m_nemonico; }
            set { m_nemonico = value; }
        }
        private string m_nemonico;

        public string tip_canti
        {
            get { return m_tip_canti; }
            set { m_tip_canti = value; }
        }
        private string m_tip_canti;

        public int rut
        {
            get { return m_rut; }
            set { m_rut = value; }
        }
        private int m_rut;

        public string situacion
        {
            get { return m_situacion; }
            set { m_situacion = value; }
        }
        private string m_situacion;

        public string comvta
        {
            get { return m_comvta; }
            set { m_comvta = value; }
        }
        private string m_comvta;

        public string lugneg
        {
            get { return m_lugneg; }
            set { m_lugneg = value; }
        }
        private string m_lugneg;

        public string lugneg_d
        {
            get { return m_lugneg_d; }
            set { m_lugneg_d = value; }
        }
        private string m_lugneg_d;

        public double can_orden
        {
            get { return m_can_orden; }
            set { m_can_orden = value; }
        }
        private double m_can_orden;

        public string tip_orden
        {
            get { return m_tip_orden; }
            set { m_tip_orden = value; }
        }
        private string m_tip_orden;

        public string ctavalor
        {
            get { return m_ctavalor; }
            set { m_ctavalor = value; }
        }
        private string m_ctavalor;

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;

        public double mto_operacion
        {
            get { return m_mto_operacion; }
            set { m_mto_operacion = value; }
        }
        private double m_mto_operacion;

        public double mto_liquidacion
        {
            get { return m_mto_liquidacion; }
            set { m_mto_liquidacion = value; }
        }
        private double m_mto_liquidacion;

        public string nombre_clie
        {
            get { return m_nombre_clie; }
            set { m_nombre_clie = value; }
        }
        private string m_nombre_clie;

        public string codigo_clie
        {
            get { return m_codigo_clie; }
            set { m_codigo_clie = value; }
        }
        private string m_codigo_clie;

        public int nro_poliza
        {
            get { return m_nro_poliza; }
            set { m_nro_poliza = value; }
        }
        private int m_nro_poliza;

        public int campo_aux01
        {
            get { return m_campo_aux01; }
            set { m_campo_aux01 = value; }
        }
        private int m_campo_aux01;

        public int campo_aux02
        {
            get { return m_campo_aux02; }
            set { m_campo_aux02 = value; }
        }
        private int m_campo_aux02;

        public string campo_aux03
        {
            get { return m_campo_aux03; }
            set { m_campo_aux03 = value; }
        }
        private string m_campo_aux03;

        public string campo_aux04
        {
            get { return m_campo_aux04; }
            set { m_campo_aux04 = value; }
        }
        private string m_campo_aux04;

    }


    public class VLAJ_ListadoDetalle
    {
        public List<VLAJ_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAJ_DetalleResponse> m_detalle;

    }


    public class VLAJ_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAJ_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAJ_ListadoDetalle m_listadoDetalle;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public string cta_valor_sgte
        {
            get { return m_cta_valor_sgte; }
            set { m_cta_valor_sgte = value; }
        }
        private string m_cta_valor_sgte;

        public string nro_orden_sgte
        {
            get { return m_nro_orden_sgte; }
            set { m_nro_orden_sgte = value; }
        }
        private string m_nro_orden_sgte;

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


    public class VLAJ_XMLNSCResponse
    {
        public VLAJ_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAJ_IntegrationResponse m_integrationResponse;

    }


    public class VLAJ_RootResponse
    {
        public VLAJ_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAJ_XMLNSCResponse m_XMLNSC;

    }
}
