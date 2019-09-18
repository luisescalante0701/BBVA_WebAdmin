using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAH_DetalleResponse
    {

        public string codcom
        {
            get { return m_codcom; }
            set { m_codcom = value; }
        }
        private string m_codcom;

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

        public string import
        {
            get { return m_import; }
            set { m_import = value; }
        }
        private string m_import;

    }


    public class VLAH_ListadoDetalle
    {
        public List<VLAH_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAH_DetalleResponse> m_detalle;

    }


    public class VLAH_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAH_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAH_ListadoDetalle m_listadoDetalle;


        public string ind_actualiza
        {
            get { return m_ind_actualiza; }
            set { m_ind_actualiza = value; }
        }
        private string m_ind_actualiza;

        public string poliza
        {
            get { return m_poliza; }
            set { m_poliza = value; }
        }
        private string m_poliza;

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;

        public string mtoope
        {
            get { return m_mtoope; }
            set { m_mtoope = value; }
        }
        private string m_mtoope;

        public string intere
        {
            get { return m_intere; }
            set { m_intere = value; }
        }
        private string m_intere;

        public string totcom
        {
            get { return m_totcom; }
            set { m_totcom = value; }
        }
        private string m_totcom;

        public string mtopar
        {
            get { return m_mtopar; }
            set { m_mtopar = value; }
        }
        private string m_mtopar;

        public string mtoliq
        {
            get { return m_mtoliq; }
            set { m_mtoliq = value; }
        }
        private string m_mtoliq;

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


    public class VLAH_XMLNSCResponse
    {
        public VLAH_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAH_IntegrationResponse m_integrationResponse;

    }


    public class VLAH_RootResponse
    {
        public VLAH_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAH_XMLNSCResponse m_XMLNSC;

    }

}
