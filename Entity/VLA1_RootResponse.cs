using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLA1_DetalleResponse
    {

        public string codsab
        {
            get { return m_codsab; }
            set { m_codsab = value; }
        }
        private string m_codsab;

        public string fecord
        {
            get { return m_fecord; }
            set { m_fecord = value; }
        }
        private string m_fecord;

        public string nroord
        {
            get { return m_nroord; }
            set { m_nroord = value; }
        }
        private string m_nroord;

        public string horord
        {
            get { return m_horord; }
            set { m_horord = value; }
        }
        private string m_horord;

        public string lugneg
        {
            get { return m_lugneg; }
            set { m_lugneg = value; }
        }
        private string m_lugneg;

        public string tipcli
        {
            get { return m_tipcli; }
            set { m_tipcli = value; }
        }
        private string m_tipcli;

        public string codcli
        {
            get { return m_codcli; }
            set { m_codcli = value; }
        }
        private string m_codcli;

        public string comven
        {
            get { return m_comven; }
            set { m_comven = value; }
        }
        private string m_comven;

        public string tipope
        {
            get { return m_tipope; }
            set { m_tipope = value; }
        }
        private string m_tipope;

        public string flgins
        {
            get { return m_flgins; }
            set { m_flgins = value; }
        }
        private string m_flgins;

        public string nemoni
        {
            get { return m_nemoni; }
            set { m_nemoni = value; }
        }
        private string m_nemoni;

        public string cantit
        {
            get { return m_cantit; }
            set { m_cantit = value; }
        }
        private string m_cantit;

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;

        public string mtoord
        {
            get { return m_mtoord; }
            set { m_mtoord = value; }
        }
        private string m_mtoord;

        public string flgpre
        {
            get { return m_flgpre; }
            set { m_flgpre = value; }
        }
        private string m_flgpre;

        public string monord
        {
            get { return m_monord; }
            set { m_monord = value; }
        }
        private string m_monord;

        public string doccli
        {
            get { return m_doccli; }
            set { m_doccli = value; }
        }
        private string m_doccli;

        public string apepat
        {
            get { return m_apepat; }
            set { m_apepat = value; }
        }
        private string m_apepat;

        public string apemat
        {
            get { return m_apemat; }
            set { m_apemat = value; }
        }
        private string m_apemat;

        public string nombre
        {
            get { return m_nombre; }
            set { m_nombre = value; }
        }
        private string m_nombre;

        public string razsoc
        {
            get { return m_razsoc; }
            set { m_razsoc = value; }
        }
        private string m_razsoc;

        public string fecins
        {
            get { return m_fecins; }
            set { m_fecins = value; }
        }
        private string m_fecins;

    }

    public class VLA1_ListadoDetalle
    {
        public List<VLA1_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLA1_DetalleResponse> m_detalle;

    }

    public class VLA1_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLA1_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLA1_ListadoDetalle m_listadoDetalle;


        public string cod_retorno
        {
            get { return m_cod_retorno; }
            set { m_cod_retorno = value; }
        }
        private string m_cod_retorno;

        public string mas_datos
        {
            get { return m_mas_datos; }
            set { m_mas_datos = value; }
        }
        private string m_mas_datos;

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

    public class VLA1_XMLNSCResponse
    {
        public VLA1_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLA1_IntegrationResponse m_integrationResponse;
    }

    public class VLA1_RootResponse
    {
        public VLA1_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLA1_XMLNSCResponse m_XMLNSC;
    }
}
