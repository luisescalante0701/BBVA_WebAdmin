using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAL_DetalleResponse
    {

        public string con_plz
        {
            get { return m_con_plz; }
            set { m_con_plz = value; }
        }
        private string m_con_plz;

        public int codcom
        {
            get { return m_codcom; }
            set { m_codcom = value; }
        }
        private int m_codcom;

        public string descri
        {
            get { return m_descri; }
            set { m_descri = value; }
        }
        private string m_descri;

        public string tipcom
        {
            get { return m_tipcom; }
            set { m_tipcom = value; }
        }
        private string m_tipcom;

        public string porcen
        {
            get { return m_porcen; }
            set { m_porcen = value; }
        }
        private string m_porcen;

        public double import
        {
            get { return m_import; }
            set { m_import = value; }
        }
        private double m_import;

    }


    public class VLAL_ListadoDetalle
    {
        public List<VLAL_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAL_DetalleResponse> m_detalle;

    }


    public class VLAL_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAL_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAL_ListadoDetalle m_listadoDetalle;

        public string tipo_orden
        {
            get { return m_tipo_orden; }
            set { m_tipo_orden = value; }
        }
        private string m_tipo_orden;

        public string nemonic
        {
            get { return m_nemonic; }
            set { m_nemonic = value; }
        }
        private string m_nemonic;

        public string titulos
        {
            get { return m_titulos; }
            set { m_titulos = value; }
        }
        private string m_titulos;

        public string fecha_negocia
        {
            get { return m_fecha_negocia; }
            set { m_fecha_negocia = value; }
        }
        private string m_fecha_negocia;

        public string fecha_liquida
        {
            get { return m_fecha_liquida; }
            set { m_fecha_liquida = value; }
        }
        private string m_fecha_liquida;

        public string cta_economica
        {
            get { return m_cta_economica; }
            set { m_cta_economica = value; }
        }
        private string m_cta_economica;

        public string precio_con
        {
            get { return m_precio_con; }
            set { m_precio_con = value; }
        }
        private string m_precio_con;

        public string mtoope_con
        {
            get { return m_mtoope_con; }
            set { m_mtoope_con = value; }
        }
        private string m_mtoope_con;

        public double intere_con
        {
            get { return m_intere_con; }
            set { m_intere_con = value; }
        }
        private double m_intere_con;

        public double totcom_con
        {
            get { return m_totcom_con; }
            set { m_totcom_con = value; }
        }
        private double m_totcom_con;

        public double mtopar_con
        {
            get { return m_mtopar_con; }
            set { m_mtopar_con = value; }
        }
        private double m_mtopar_con;

        public double mtoliq_con
        {
            get { return m_mtoliq_con; }
            set { m_mtoliq_con = value; }
        }
        private double m_mtoliq_con;

        public string precio_plz
        {
            get { return m_precio_plz; }
            set { m_precio_plz = value; }
        }
        private string m_precio_plz;

        public double mtoope_plz
        {
            get { return m_mtoope_plz; }
            set { m_mtoope_plz = value; }
        }
        private double m_mtoope_plz;

        public double intere_plz
        {
            get { return m_intere_plz; }
            set { m_intere_plz = value; }
        }
        private double m_intere_plz;

        public double totcom_plz
        {
            get { return m_totcom_plz; }
            set { m_totcom_plz = value; }
        }
        private double m_totcom_plz;

        public double mtopar_plz
        {
            get { return m_mtopar_plz; }
            set { m_mtopar_plz = value; }
        }
        private double m_mtopar_plz;

        public double mtoliq_plz
        {
            get { return m_mtoliq_plz; }
            set { m_mtoliq_plz = value; }
        }
        private double m_mtoliq_plz;

        public string nombre_clie
        {
            get { return m_nombre_clie; }
            set { m_nombre_clie = value; }
        }
        private string m_nombre_clie;

        public string rut_cliente
        {
            get { return m_rut_cliente; }
            set { m_rut_cliente = value; }
        }
        private string m_rut_cliente;

        public string correo_clie
        {
            get { return m_correo_clie; }
            set { m_correo_clie = value; }
        }
        private string m_correo_clie;

        public string moneda
        {
            get { return m_moneda; }
            set { m_moneda = value; }
        }
        private string m_moneda;

        public string lug_negocia
        {
            get { return m_lug_negocia; }
            set { m_lug_negocia = value; }
        }
        private string m_lug_negocia;

        public string lug_negocia_d
        {
            get { return m_lug_negocia_d; }
            set { m_lug_negocia_d = value; }
        }
        private string m_lug_negocia_d;

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


    public class VLAL_XMLNSCResponse
    {
        public VLAL_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAL_IntegrationResponse m_integrationResponse;

    }


    public class VLAL_RootResponse
    {
        public VLAL_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAL_XMLNSCResponse m_XMLNSC;

    }

}
