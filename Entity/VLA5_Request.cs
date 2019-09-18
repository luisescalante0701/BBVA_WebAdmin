using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class VLA5_Request
    {
        public RequestHeader requestHeader
        {
            get { return m_requestHeader; }
            set { m_requestHeader = value; }
        }
        private RequestHeader m_requestHeader;

        public string nombre_clte1
        {
            get { return m_nombre_clte1; }
            set { m_nombre_clte1 = value; }
        }
        private string m_nombre_clte1 = "";

        public string tipo_consulta
        {
            get { return m_tipo_consulta; }
            set { m_tipo_consulta = value; }
        }
        private string m_tipo_consulta = "";

        public string dato_consulta
        {
            get { return m_dato_consulta; }
            set { m_dato_consulta = value; }
        }
        private string m_dato_consulta = "";

        public string ctaval_rein
        {
            get { return m_ctaval_rein; }
            set { m_ctaval_rein = value; }
        }
        private string m_ctaval_rein = "";

        public string nemoni_rein
        {
            get { return m_nemoni_rein; }
            set { m_nemoni_rein = value; }
        }
        private string m_nemoni_rein = "";

        public string usuario
        {
            get { return m_usuario; }
            set { m_usuario = value; }
        }
        private string m_usuario = "";

        public string numcli
        {
            get { return m_numcli; }
            set { m_numcli = value; }
        }
        private string m_numcli = "";

        public string ind_paginacion
        {
            get { return m_ind_paginacion; }
            set { m_ind_paginacion = value; }
        }
        private string m_ind_paginacion = "";

        public string arg_busqueda
        {
            get { return m_arg_busqueda; }
            set { m_arg_busqueda = value; }
        }
        private string m_arg_busqueda = "";
    }


    public class RootObject_VLA5
    {
        public VLA5_Request integrationRequest
        {
            get { return m_integrationRequest; }
            set { m_integrationRequest = value; }
        }
        private VLA5_Request m_integrationRequest;
    }


}
