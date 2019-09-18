using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAB_DetalleResponse
    {

        //Sin detalle 

    }


    public class VLAB_ListadoDetalle
    {

        //Sin detalle

    }


    public class VLAB_IntegrationResponse
    {

        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public string comvta
        {
            get { return m_comvta; }
            set { m_comvta = value; }
        }
        private string m_comvta;

        public int nro_conasev
        {
            get { return m_nro_conasev; }
            set { m_nro_conasev = value; }
        }
        private int m_nro_conasev;

        public string cta_economica
        {
            get { return m_cta_economica; }
            set { m_cta_economica = value; }
        }
        private string m_cta_economica;

        public string mon_economica
        {
            get { return m_mon_economica; }
            set { m_mon_economica = value; }
        }
        private string m_mon_economica;

        public string mon_orden
        {
            get { return m_mon_orden; }
            set { m_mon_orden = value; }
        }
        private string m_mon_orden;

        public string nemonico
        {
            get { return m_nemonico; }
            set { m_nemonico = value; }
        }
        private string m_nemonico;

        public string nombre_valor
        {
            get { return m_nombre_valor; }
            set { m_nombre_valor = value; }
        }
        private string m_nombre_valor;

        public double can_orden
        {
            get { return m_can_orden; }
            set { m_can_orden = value; }
        }
        private double m_can_orden;

        public double pre_negoc
        {
            get { return m_pre_negoc; }
            set { m_pre_negoc = value; }
        }
        private double m_pre_negoc;

        public double cup_corr
        {
            get { return m_cup_corr; }
            set { m_cup_corr = value; }
        }
        private double m_cup_corr;

        public int dias_vigenc
        {
            get { return m_dias_vigenc; }
            set { m_dias_vigenc = value; }
        }
        private int m_dias_vigenc;

        public string fech_vigenc
        {
            get { return m_fech_vigenc; }
            set { m_fech_vigenc = value; }
        }
        private string m_fech_vigenc;

        public double imp_retenido
        {
            get { return m_imp_retenido; }
            set { m_imp_retenido = value; }
        }
        private double m_imp_retenido;

        public double nro_retencion
        {
            get { return m_nro_retencion; }
            set { m_nro_retencion = value; }
        }
        private double m_nro_retencion;

        public string ofi_operante
        {
            get { return m_ofi_operante; }
            set { m_ofi_operante = value; }
        }
        private string m_ofi_operante;

        public string nro_bval
        {
            get { return m_nro_bval; }
            set { m_nro_bval = value; }
        }
        private string m_nro_bval;

        public string pre_asignacion
        {
            get { return m_pre_asignacion; }
            set { m_pre_asignacion = value; }
        }
        private string m_pre_asignacion;

        public string cod_custodio
        {
            get { return m_cod_custodio; }
            set { m_cod_custodio = value; }
        }
        private string m_cod_custodio;

        public string observacion1
        {
            get { return m_observacion1; }
            set { m_observacion1 = value; }
        }
        private string m_observacion1;

        public string observacion2
        {
            get { return m_observacion2; }
            set { m_observacion2 = value; }
        }
        private string m_observacion2;

        public string cod_gestor
        {
            get { return m_cod_gestor; }
            set { m_cod_gestor = value; }
        }
        private string m_cod_gestor;

        public int poliza
        {
            get { return m_poliza; }
            set { m_poliza = value; }
        }
        private int m_poliza;

        public string tip_comis
        {
            get { return m_tip_comis; }
            set { m_tip_comis = value; }
        }
        private string m_tip_comis;

        public string comision
        {
            get { return m_comision; }
            set { m_comision = value; }
        }
        private string m_comision;

        public string fec_orden
        {
            get { return m_fec_orden; }
            set { m_fec_orden = value; }
        }
        private string m_fec_orden;

        public string hor_orden
        {
            get { return m_hor_orden; }
            set { m_hor_orden = value; }
        }
        private string m_hor_orden;

        public string fec_alta
        {
            get { return m_fec_alta; }
            set { m_fec_alta = value; }
        }
        private string m_fec_alta;

        public string fec_modif
        {
            get { return m_fec_modif; }
            set { m_fec_modif = value; }
        }
        private string m_fec_modif;

        public string hor_modif
        {
            get { return m_hor_modif; }
            set { m_hor_modif = value; }
        }
        private string m_hor_modif;

        public string usu_modif
        {
            get { return m_usu_modif; }
            set { m_usu_modif = value; }
        }
        private string m_usu_modif;

        public string tip_canti
        {
            get { return m_tip_canti; }
            set { m_tip_canti = value; }
        }
        private string m_tip_canti;

        public string tip_cambio
        {
            get { return m_tip_cambio; }
            set { m_tip_cambio = value; }
        }
        private string m_tip_cambio;

        public string cod_broker
        {
            get { return m_cod_broker; }
            set { m_cod_broker = value; }
        }
        private string m_cod_broker;

        public double tit_asignacion
        {
            get { return m_tit_asignacion; }
            set { m_tit_asignacion = value; }
        }
        private double m_tit_asignacion;

        public string lug_negoc
        {
            get { return m_lug_negoc; }
            set { m_lug_negoc = value; }
        }
        private string m_lug_negoc;

        public string tip_orden
        {
            get { return m_tip_orden; }
            set { m_tip_orden = value; }
        }
        private string m_tip_orden;

        public int ord_cruzada
        {
            get { return m_ord_cruzada; }
            set { m_ord_cruzada = value; }
        }
        private int m_ord_cruzada;

        public string cta_cruzada
        {
            get { return m_cta_cruzada; }
            set { m_cta_cruzada = value; }
        }
        private string m_cta_cruzada;

        public int dias_plazo
        {
            get { return m_dias_plazo; }
            set { m_dias_plazo = value; }
        }
        private int m_dias_plazo;

        public string vcto_plazo
        {
            get { return m_vcto_plazo; }
            set { m_vcto_plazo = value; }
        }
        private string m_vcto_plazo;

        public string tem
        {
            get { return m_tem; }
            set { m_tem = value; }
        }
        private string m_tem;

        public double cupon_plazo
        {
            get { return m_cupon_plazo; }
            set { m_cupon_plazo = value; }
        }
        private double m_cupon_plazo;

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

        public int telef_dma
        {
            get { return m_telef_dma; }
            set { m_telef_dma = value; }
        }
        private int m_telef_dma;

        public string isin
        {
            get { return m_isin; }
            set { m_isin = value; }
        }
        private string m_isin;

        public int cantor
        {
            get { return m_cantor; }
            set { m_cantor = value; }
        }
        private int m_cantor;

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


    public class VLAB_XMLNSCResponse
    {
        public VLAB_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAB_IntegrationResponse m_integrationResponse;

    }


    public class VLAB_RootResponse
    {
        public VLAB_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAB_XMLNSCResponse m_XMLNSC;

    }
}
