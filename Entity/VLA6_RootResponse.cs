using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLA6_DetalleResponse
    {

        public string fecha_mov
        {
            get { return m_fecha_mov; }
            set { m_fecha_mov = value; }
        }
        private string m_fecha_mov;

        public string entr_sali
        {
            get { return m_entr_sali; }
            set { m_entr_sali = value; }
        }
        private string m_entr_sali;

        public string can_titulos
        {
            get { return m_can_titulos; }
            set { m_can_titulos = value; }
        }
        private string m_can_titulos;

        public string nro_cerfica
        {
            get { return m_nro_cerfica; }
            set { m_nro_cerfica = value; }
        }
        private string m_nro_cerfica;

        public string motivo
        {
            get { return m_motivo; }
            set { m_motivo = value; }
        }
        private string m_motivo;

    }


    public class VLA6_ListadoDetalle
    {
        public List<VLA6_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLA6_DetalleResponse> m_detalle;

    }


    public class VLA6_IntegrationResponse
    {

        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLA6_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLA6_ListadoDetalle m_listadoDetalle;

        public string hay_mas
        {
            get { return m_hay_mas; }
            set { m_hay_mas = value; }
        }
        private string m_hay_mas;

        public string sgte_movi
        {
            get { return m_sgte_movi; }
            set { m_sgte_movi = value; }
        }
        private string m_sgte_movi;

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


    public class VLA6_XMLNSCResponse
    {
        public VLA6_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLA6_IntegrationResponse m_integrationResponse;

    }


    public class VLA6_RootResponse
    {
        public VLA6_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLA6_XMLNSCResponse m_XMLNSC;

    }

}
