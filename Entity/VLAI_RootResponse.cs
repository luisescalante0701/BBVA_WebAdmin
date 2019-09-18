using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAI_DetalleResponse
    {

        public string codcom
        {
            get { return m_codcom; }
            set { m_codcom = value; }
        }
        private string m_codcom;

        public string porcom
        {
            get { return m_porcom; }
            set { m_porcom = value; }
        }
        private string m_porcom;

        public string descom
        {
            get { return m_descom; }
            set { m_descom = value; }
        }
        private string m_descom;

        public double impcom
        {
            get { return m_impcom; }
            set { m_impcom = value; }
        }
        private double m_impcom;

        public double totcom
        {
            get { return m_totcom; }
            set { m_totcom = value; }
        }
        private double m_totcom;

    }


    public class VLAI_DetalleResponseF
    {

        public double titneg
        {
            get { return m_titneg; }
            set { m_titneg = value; }
        }
        private double m_titneg;

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;

        public double import
        {
            get { return m_import; }
            set { m_import = value; }
        }
        private double m_import;

    }


    public class VLAI_ListadoDetalle
    {
        public List<VLAI_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAI_DetalleResponse> m_detalle;

    }


    public class VLAI_ListadoDetalleF
    {
        public List<VLAI_DetalleResponseF> detalleF
        {
            get { return m_detalleF; }
            set { m_detalleF = value; }
        }
        private List<VLAI_DetalleResponseF> m_detalleF;
    }


    public class VLAI_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;

        public VLAI_ListadoDetalleF listadoDetalleF
        {
            get { return m_listadoDetalleF; }
            set { m_listadoDetalleF = value; }
        }
        private VLAI_ListadoDetalleF m_listadoDetalleF;


        public VLAI_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAI_ListadoDetalle m_listadoDetalle;

        public string nropol
        {
            get { return m_nropol; }
            set { m_nropol = value; }
        }
        private string m_nropol;

        public string polanu
        {
            get { return m_polanu; }
            set { m_polanu = value; }
        }
        private string m_polanu;

        public string tipope
        {
            get { return m_tipope; }
            set { m_tipope = value; }
        }
        private string m_tipope;

        public string feceje
        {
            get { return m_feceje; }
            set { m_feceje = value; }
        }
        private string m_feceje;

        public string codmon
        {
            get { return m_codmon; }
            set { m_codmon = value; }
        }
        private string m_codmon;

        public string moneda
        {
            get { return m_moneda; }
            set { m_moneda = value; }
        }
        private string m_moneda;

        public string fecliq
        {
            get { return m_fecliq; }
            set { m_fecliq = value; }
        }
        private string m_fecliq;

        public string impnet
        {
            get { return m_impnet; }
            set { m_impnet = value; }
        }
        private string m_impnet;

        public string nombtr
        {
            get { return m_nombtr; }
            set { m_nombtr = value; }
        }
        private string m_nombtr;

        public string nombcl
        {
            get { return m_nombcl; }
            set { m_nombcl = value; }
        }
        private string m_nombcl;

        public string docume
        {
            get { return m_docume; }
            set { m_docume = value; }
        }
        private string m_docume;

        public string direc1
        {
            get { return m_direc1; }
            set { m_direc1 = value; }
        }
        private string m_direc1;

        public string direc2
        {
            get { return m_direc2; }
            set { m_direc2 = value; }
        }
        private string m_direc2;

        public string correo
        {
            get { return m_correo; }
            set { m_correo = value; }
        }
        private string m_correo;

        public string rut
        {
            get { return m_rut; }
            set { m_rut = value; }
        }
        private string m_rut;

        public string ctaval
        {
            get { return m_ctaval; }
            set { m_ctaval = value; }
        }
        private string m_ctaval;

        public string ctaeco
        {
            get { return m_ctaeco; }
            set { m_ctaeco = value; }
        }
        private string m_ctaeco;

        public string tipoliq
        {
            get { return m_tipoliq; }
            set { m_tipoliq = value; }
        }
        private string m_tipoliq;

        public string tottit
        {
            get { return m_tottit; }
            set { m_tottit = value; }
        }
        private string m_tottit;

        public string totimp
        {
            get { return m_totimp; }
            set { m_totimp = value; }
        }
        private string m_totimp;

        public string tipo_rta
        {
            get { return m_tipo_rta; }
            set { m_tipo_rta = value; }
        }
        private string m_tipo_rta;

        public string valor_neg
        {
            get { return m_valor_neg; }
            set { m_valor_neg = value; }
        }
        private string m_valor_neg;

        public string modalidad
        {
            get { return m_modalidad; }
            set { m_modalidad = value; }
        }
        private string m_modalidad;

        public string mdo_inter
        {
            get { return m_mdo_inter; }
            set { m_mdo_inter = value; }
        }
        private string m_mdo_inter;

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

    public class VLAI_XMLNSCResponse
    {
        public VLAI_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAI_IntegrationResponse m_integrationResponse;
    }

    public class VLAI_RootResponse
    {
        public VLAI_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAI_XMLNSCResponse m_XMLNSC;
    }

}
