using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ResponseHeader
    {

        public string idSesion
        {
            get { return m_idSesion; }
            set { m_idSesion = value; }
        }
        private string m_idSesion;

        public string idPeticionEmpresa
        {
            get { return m_idPeticionEmpresa; }
            set { m_idPeticionEmpresa = value; }
        }
        private string m_idPeticionEmpresa;

        public string idPeticionBanco
        {
            get { return m_idPeticionBanco; }
            set { m_idPeticionBanco = value; }
        }
        private string m_idPeticionBanco;


        public string idOperacion
        {
            get { return m_idOperacion; }
            set { m_idOperacion = value; }
        }
        private string m_idOperacion;


        public string codigoError
        {
            get { return m_codigoError; }
            set { m_codigoError = value; }
        }
        private string m_codigoError;

        public string mensajeError
        {
            get { return m_mensajeError; }
            set { m_mensajeError = value; }
        }
        private string m_mensajeError;


    }

}
