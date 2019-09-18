using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Text;

using Common;
using Entity;
using Newtonsoft.Json;

namespace Logic
{
   public class Logic_Login 
    {
        int iCode_Error_Logic = Constantes.iCode_Error_Logic;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR CAPA LOGICA

        string sTAG = "Logic_Login";

        private string urlToPost = "";
        public string resString = null;

        RequestHeader objHeader = new RequestHeader();
        RootObject_VLA0 oRootTransaccionVLA0 = new RootObject_VLA0();
        VLA0_Request oRequestTransaccionVLA0 = new VLA0_Request();
        VLA0_RootResponse oTransaccionVLA0Response = new VLA0_RootResponse();
        Error_RootResponse obj_cadenaerror = new Error_RootResponse();

        public Model mLogin(ConfigWeb ConfigWeb_, string sUsuario, string sPassword)
        {
            Model modeloRpta = new Model();
            //string sUrlWebApi = ConfigurationManager.ConnectionStrings["Url_WebApi"].ConnectionString.ToString();

            Utility util = new Utility();

            try
            {
                String strSesion = "00001";
                string sTransaccion = "VLA0";

                LoginUser modLogin = new LoginUser();
                modLogin.sUsuario = sUsuario;
                modLogin.sPassword = sPassword;
                modLogin.SessionId = strSesion;


                WebClient webClient = new WebClient();
                byte[] resByte = null;
                byte[] reqString = null;

                objHeader = new Utility().RetornaHeaderEnvio(ConfigWeb_, sTransaccion, sUsuario, strSesion);
                oRequestTransaccionVLA0.requestHeader = objHeader;
                oRequestTransaccionVLA0.asunto1 = sUsuario;
                oRequestTransaccionVLA0.asunto2 = sPassword;
                oRootTransaccionVLA0.integrationRequest = oRequestTransaccionVLA0;
                
                urlToPost = this.UrlHubIntegrador(ConfigWeb_, sTransaccion);
                webClient.Headers.Add("Content-Type", "application/json");
                reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(oRootTransaccionVLA0, Formatting.Indented));
                //string serializedJson = JsonConvert.SerializeObject(oRootTransaccionVLA0);
                resByte = webClient.UploadData(this.urlToPost, "post", reqString);
                resString = Encoding.Default.GetString(resByte);
               // Console.WriteLine(resString);
                webClient.Dispose();

                // capturar el formato JSON y deserializarlo en el objeto response para pasarlo a la grilla.
                //dtTabla = oFormateoJSOn.ResponseDatatableTrama("VLA0", oFormateoJSOn.resString, strCol, out booMasPaginas, out strSiguienteRegistro, out strSiguienteRegistro2, out mySession);
                oTransaccionVLA0Response = (VLA0_RootResponse)util.ResponseObjectTrama("VLA0", resString);
                if (oTransaccionVLA0Response.XMLNSC == null)
                {
                    obj_cadenaerror = (Error_RootResponse)util.ResponseObjectError(resString);

                    string sCodigoError = obj_cadenaerror.integrationResponse.responseHeader.codigoError;
                    string sIdSesion = obj_cadenaerror.integrationResponse.responseHeader.idSesion;
                    string sMensajeError = obj_cadenaerror.integrationResponse.responseHeader.mensajeError;

                    modeloRpta.bEstado = false;
                    modeloRpta.iCodigo = 1;
                    modeloRpta.sRpta = "CodigoError: "+ sCodigoError + " / IdSesion: " + sIdSesion + " / Msg: "+ sMensajeError;
                    modeloRpta.obj = null;

                }
                else
                {
                    /** Comentado por cambio solicitado: WO0000000100275
                    oUsuario = oFormateador.RetornaUsuarioSesion(strCadenaRespuesta);
                    **/

                    if (oTransaccionVLA0Response.XMLNSC.integrationResponse.cod_ret == "00")
                    {
                        //oUsuario.HuboError = false;
                        //oUsuario.SessionId = "00001";

                        modeloRpta.bEstado = true;
                        modeloRpta.iCodigo = 0;
                        modeloRpta.sRpta = "SessionId: 00001";
                        modeloRpta.obj = JsonConvert.SerializeObject(modLogin);  
                    }
                    else
                    {
                        //oUsuario.HuboError = true;
                        //oUsuario.SessionId = "00001";

                        modeloRpta.bEstado = false;
                        modeloRpta.iCodigo = 1;
                        modeloRpta.sRpta = "mLogin - SessionId: 00001";
                        modeloRpta.obj = null;
                    }


                }

            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                //modeloRpta.dt = dt;
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }



        private string UrlHubIntegrador(ConfigWeb ConfigWeb_,string Transaccion)
        {
            string UrlReturn = new Utility().ServidorHI(ConfigWeb_) + new Utility().RetornaServicioHubIntegrador(ConfigWeb_,Transaccion).ToLower();

            return UrlReturn;
        }


        public object ResponseObjectError(string resString)
        {
            object ObjectReturn = null;
            Error_RootResponse obj_Error = new Error_RootResponse();
            obj_Error = JsonConvert.DeserializeObject<Error_RootResponse>(resString);

            ObjectReturn = obj_Error;

            return ObjectReturn;
        }




    }
}
