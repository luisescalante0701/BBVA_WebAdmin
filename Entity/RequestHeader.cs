using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class RequestHeader 
    {
        public string codigoEmpresa
        {
            get { return m_codigoEmpresa; }
            set { m_codigoEmpresa = value; }
        }
        private string m_codigoEmpresa = "";
        public string codigoTerminalEmpresa
        {
            get { return m_codigoTerminalEmpresa; }
            set { m_codigoTerminalEmpresa = value; }
        }
        private string m_codigoTerminalEmpresa = "";
        public string canal
        {
            get { return m_canal; }
            set { m_canal = value; }
        }
        private string m_canal = "";
        public string codigoAplicacion
        {
            get { return m_codigoAplicacion; }
            set { m_codigoAplicacion = value; }
        }
        private string m_codigoAplicacion = "";
        public string usuario
        {
            get { return m_usuario; }
            set { m_usuario = value; }
        }
        private string m_usuario = "";
        public string fechaHoraEnvio
        {
            get { return m_fechaHoraEnvio; }
            set { m_fechaHoraEnvio = value; }
        }
        private string m_fechaHoraEnvio = "";
        public string idSesion
        {
            get { return m_idSesion; }
            set { m_idSesion = value; }
        }
        private string m_idSesion = "";
        public string idPeticionEmpresa
        {
            get { return m_idPeticionEmpresa; }
            set { m_idPeticionEmpresa = value; }
        }
        private string m_idPeticionEmpresa = "";
        public string idPeticionBanco
        {
            get { return m_idPeticionBanco; }
            set { m_idPeticionBanco = value; }
        }
        private string m_idPeticionBanco = "";
        public string idOperacion
        {
            get { return m_idOperacion; }
            set { m_idOperacion = value; }
        }
        private string m_idOperacion = "";
        public string idServicio
        {
            get { return m_idServicio; }
            set { m_idServicio = value; }
        }
        private string m_idServicio = "";
        public string idInterconexion
        {
            get { return m_idInterconexion; }
            set { m_idInterconexion = value; }
        }
        private string m_idInterconexion = "";
    }

}
