using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class VLA7_Request
    {
        public RequestHeader requestHeader
        {
            get { return m_requestHeader; }
            set { m_requestHeader = value; }
        }
        private RequestHeader m_requestHeader;

        public string tipo_orden
        {
            get { return m_tipo_orden; }
            set { m_tipo_orden = value; }
        }
        private string m_tipo_orden = "";

        public string lugar_negoc
        {
            get { return m_lugar_negoc; }
            set { m_lugar_negoc = value; }
        }
        private string m_lugar_negoc = "";

        public string nemonic
        {
            get { return m_nemonic; }
            set { m_nemonic = value; }
        }
        private string m_nemonic = "";

        public string isin_entrada
        {
            get { return m_isin_entrada; }
            set { m_isin_entrada = value; }
        }
        private string m_isin_entrada = "";

        public string tit_ordenados
        {
            get { return m_tit_ordenados; }
            set { m_tit_ordenados = value; }
        }
        private string m_tit_ordenados = "";

        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio = "";

        public string dia_vigencia
        {
            get { return m_dia_vigencia; }
            set { m_dia_vigencia = value; }
        }
        private string m_dia_vigencia = "";

        public string cta_economica
        {
            get { return m_cta_economica; }
            set { m_cta_economica = value; }
        }
        private string m_cta_economica = "";

        public string moneda_extj
        {
            get { return m_moneda_extj; }
            set { m_moneda_extj = value; }
        }
        private string m_moneda_extj = "";

        public string cambio_extj
        {
            get { return m_cambio_extj; }
            set { m_cambio_extj = value; }
        }
        private string m_cambio_extj = "";

        public string broker
        {
            get { return m_broker; }
            set { m_broker = value; }
        }
        private string m_broker = "";

        public string ind_retenc
        {
            get { return m_ind_retenc; }
            set { m_ind_retenc = value; }
        }
        private string m_ind_retenc = "";

        public string funcion
        {
            get { return m_funcion; }
            set { m_funcion = value; }
        }
        private string m_funcion = "";

        public string firma
        {
            get { return m_firma; }
            set { m_firma = value; }
        }
        private string m_firma = "";

        public string observacion1
        {
            get { return m_observacion1; }
            set { m_observacion1 = value; }
        }
        private string m_observacion1 = "";

        public string observacion2
        {
            get { return m_observacion2; }
            set { m_observacion2 = value; }
        }
        private string m_observacion2 = "";

        public string num_orden
        {
            get { return m_num_orden; }
            set { m_num_orden = value; }
        }
        private string m_num_orden = "";

        public string usuario
        {
            get { return m_usuario; }
            set { m_usuario = value; }
        }
        private string m_usuario = "";

        public string cta_valor_ent
        {
            get { return m_cta_valor_ent; }
            set { m_cta_valor_ent = value; }
        }
        private string m_cta_valor_ent = "";

        public string cta_valor_ofi
        {
            get { return m_cta_valor_ofi; }
            set { m_cta_valor_ofi = value; }
        }
        private string m_cta_valor_ofi = "";

        public string cta_valor_dch
        {
            get { return m_cta_valor_dch; }
            set { m_cta_valor_dch = value; }
        }
        private string m_cta_valor_dch = "";

        public string cta_valor_pro
        {
            get { return m_cta_valor_pro; }
            set { m_cta_valor_pro = value; }
        }
        private string m_cta_valor_pro = "";

        public string cta_valor_nro
        {
            get { return m_cta_valor_nro; }
            set { m_cta_valor_nro = value; }
        }
        private string m_cta_valor_nro = "";

        public string tip_comision
        {
            get { return m_tip_comision; }
            set { m_tip_comision = value; }
        }
        private string m_tip_comision = "";

        public string imp_comision
        {
            get { return m_imp_comision; }
            set { m_imp_comision = value; }
        }
        private string m_imp_comision = "";

        public string ind_portaf
        {
            get { return m_ind_portaf; }
            set { m_ind_portaf = value; }
        }
        private string m_ind_portaf = "";




    }




    public class RootObject_VLA7
    {
        public VLA7_Request integrationRequest
        {
            get { return m_integrationRequest; }
            set { m_integrationRequest = value; }
        }
        private VLA7_Request m_integrationRequest;
    }



}
