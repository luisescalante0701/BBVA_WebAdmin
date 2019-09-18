using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLA9_DetalleResponse
    {

        //Sin detalle 

    }


    public class VLA9_ListadoDetalle
    {

        //Sin detalle

    }


    public class VLA9_IntegrationResponse
    {

        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public string con_orden
        {
            get { return m_con_orden; }
            set { m_con_orden = value; }
        }
        private string m_con_orden;

        public string con_orden_cns
        {
            get { return m_con_orden_cns; }
            set { m_con_orden_cns = value; }
        }
        private string m_con_orden_cns;

        public string plz_orden
        {
            get { return m_plz_orden; }
            set { m_plz_orden = value; }
        }
        private string m_plz_orden;

        public string plz_orden_cns
        {
            get { return m_plz_orden_cns; }
            set { m_plz_orden_cns = value; }
        }
        private string m_plz_orden_cns;

        public string imp_retenido
        {
            get { return m_imp_retenido; }
            set { m_imp_retenido = value; }
        }
        private string m_imp_retenido;

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

        public string vigencia_orden
        {
            get { return m_vigencia_orden; }
            set { m_vigencia_orden = value; }
        }
        private string m_vigencia_orden;

        public string vcto_plazo
        {
            get { return m_vcto_plazo; }
            set { m_vcto_plazo = value; }
        }
        private string m_vcto_plazo;

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


    public class VLA9_XMLNSCResponse
    {
        public VLA9_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLA9_IntegrationResponse m_integrationResponse;

    }


    public class VLA9_RootResponse
    {
        public VLA9_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLA9_XMLNSCResponse m_XMLNSC;

    }

}
