using Common;
using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//using System.Data.SqlClient;

namespace Logic
{
   public class Logic_Ordenes
    {
        int iCode_Error_Logic = Constantes.iCode_Error_Logic;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR CAPA LOGICA

        string sTAG = "Logic_Ordenes";
    

        string urlToPost = "";
        string resString = null;


        public async Task<Model>  mGetCriterio(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sUrlWebApi = ConfigWeb_.Url_WebApi ;
                string sMetodo = "api/bolsa/mGetCriterio";

                object data = await IConnectHttpClient_.ConnectHttpClientAsync(sUrlWebApi, sMetodo, "");

                modeloRpta = (Model)data;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public async Task<Model> mGetTipoNegociacion(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_, int iCodigoOpcion)
        {
            Model modeloRpta = new Model();

            try
            {
                string sUrlWebApi = ConfigWeb_.Url_WebApi;
                string sMetodo = "api/bolsa/mGetTipoNegociacion";
                string sParametros = "/" + iCodigoOpcion;
                object data = await IConnectHttpClient_.ConnectHttpClientAsync(sUrlWebApi, sMetodo, sParametros);

                modeloRpta = (Model)data;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public async Task<Model> mGetTipoOrden(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_, int iCodigoOpcion)
        {
            Model modeloRpta = new Model();

            try
            {
                string sUrlWebApi = ConfigWeb_.Url_WebApi;
                string sMetodo = "api/bolsa/mGetTipoOrden";
                string sParametros = "/" + iCodigoOpcion;
                object data = await IConnectHttpClient_.ConnectHttpClientAsync(sUrlWebApi, sMetodo, sParametros);

                modeloRpta = (Model)data;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public async Task<Model> mGetOrden(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_, int iCodigoOpcion)
        {
            Model modeloRpta = new Model();

            try
            {
                string sUrlWebApi = ConfigWeb_.Url_WebApi;
                string sMetodo = "api/bolsa/mGetOrden";
                string sParametros = "/" + iCodigoOpcion;
                object data = await IConnectHttpClient_.ConnectHttpClientAsync(sUrlWebApi, sMetodo, sParametros);

                modeloRpta = (Model)data;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }
        public async Task<Model> mGetTipoComision(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sUrlWebApi = ConfigWeb_.Url_WebApi;
                string sMetodo = "api/bolsa/mGetTipoComision";
                string sParametros = "";
                object data = await IConnectHttpClient_.ConnectHttpClientAsync(sUrlWebApi, sMetodo, sParametros);

                modeloRpta = (Model)data;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public async Task<Model> mGetTipoPrecio(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sUrlWebApi = ConfigWeb_.Url_WebApi;
                string sMetodo = "api/bolsa/mGetTipoPrecio";
                string sParametros = "";
                object data = await IConnectHttpClient_.ConnectHttpClientAsync(sUrlWebApi, sMetodo, sParametros);

                modeloRpta = (Model)data;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public async Task<Model> mGetMoneda(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sUrlWebApi = ConfigWeb_.Url_WebApi;
                string sMetodo = "api/bolsa/mGetMoneda";
                string sParametros = "";
                object data = await IConnectHttpClient_.ConnectHttpClientAsync(sUrlWebApi, sMetodo, sParametros);

                modeloRpta = (Model)data;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }




        public Model mSearchInfo(ConfigWeb ConfigWeb_, string sTypeSearch, string sValSearch, LoginUser modLoin)
        {
            Model modeloRpta = new Model();
          
            try
            {
                modeloRpta = mSearchInfo_All(ConfigWeb_, sTypeSearch, sValSearch, false, modLoin);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic; 
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message); 
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }


        public Model mGuardarCompraVenta(ConfigWeb ConfigWeb_,
            string sTipoOrden, string sTipoNegociacion, string sNemonico, string sISN,
            string sNumeroTitulos, string sValorPrecio, string sDiasVigencia, string sMoneda,
            string sTipoCambio, string sOtra, string sCuentaAbono, bool bRetencion, bool bFirma,
            string sObservaciones, string sRepresentante,string sCuentaValor, string sOptionRadio,
            string sOrden, string sTipoComision, string sComision,
            LoginUser modLoin)
        {
            Model modeloRpta = new Model();

            string sRpta = "";

            try
            {
                /* CEHU INICIO */
               // Transacciones.Transacciones oTransacciones = new Transacciones.Transacciones();
                VLA7_Request oTransaccionVLA7 = new VLA7_Request();
                VLA8_Request oTransaccionVLA8 = new VLA8_Request();
               // FormateoJSON oFormateoJSOn = new FormateoJSON();
                RootObject_VLA7 oRootObject_VLA7 = new RootObject_VLA7();
                RootObject_VLA8 oRootObject_VLA8 = new RootObject_VLA8();
                VLA7_RootResponse oVLA7_RootResponse = new VLA7_RootResponse();
                VLA8_RootResponse oVLA8_RootResponse = new VLA8_RootResponse();

                WebClient webClient = new WebClient();
                byte[] resByte = null;
                byte[] reqString = null;
                Utility util = new Utility();

                int TransaccionOK = 0;
                /* CEHU FIN */
                //   System.Net.NetworkCredential cred = (System.Net.NetworkCredential)System.Net.CredentialCache.DefaultCredentials;
                // oTransacciones.Credentials = cred;


                string strCadenaRespuesta = "";
                string strSiguienteRegistro;
                bool booMasPaginas = new bool();
                DataTable dtBusqueda = null;
               // UsuarioSesion oUsuario = new UsuarioSesion();
                StringCollection strCol = new StringCollection();
               // FormateadorBO oFormateador = new FormateadorBO();
              //  SessionManager.Open();
               // if (SessionManager.Contains(Constantes.USUARIO_SESION))
               // { oUsuario = (UsuarioSesion)SessionManager.Get(Constantes.USUARIO_SESION); }

                StringBuilder Entrada = new StringBuilder();

                Entrada.Append(sTipoOrden + Constantes.CARACTER_SEPARADOR);//05 VE01-TIPO-ORDEN
                Entrada.Append(sTipoNegociacion + Constantes.CARACTER_SEPARADOR);//05 VE01-LUGAR-NEGOC
                Entrada.Append(sNemonico + Constantes.CARACTER_SEPARADOR);//05 VE01-NEMONIC
                Entrada.Append(sISN + Constantes.CARACTER_SEPARADOR);//05 VE01-ISIN-ENTRADA

                /*if (ext3.Visible == true)
                {
                    Entrada.Append(FormatoDecimales(txtNroAccionesExt.Text.Trim()) + Constantes.CARACTER_SEPARADOR);//05 VE01-TIT-ORDENADOS          
                    Entrada.Append((txtValorPrecioExt.Text.Trim() == string.Empty ? "0" : FormatoDecimales(txtValorPrecioExt.Text.Trim())) + Constantes.CARACTER_SEPARADOR);//05 VE01-PRECIO
                }
                else
                {
                    Entrada.Append(FormatoDecimales(sNumeroTitulos) + Constantes.CARACTER_SEPARADOR);//05 VE01-TIT-ORDENADOS         
                    Entrada.Append((sValorPrecio == string.Empty ? "0" : FormatoDecimales(sValorPrecio)) + Constantes.CARACTER_SEPARADOR);//05 VE01-PRECIO
                }*/
                Entrada.Append(util.FormatoDecimales(sNumeroTitulos) + Constantes.CARACTER_SEPARADOR);//05 VE01-TIT-ORDENADOS         
                Entrada.Append((sValorPrecio == string.Empty ? "0" : util.FormatoDecimales(sValorPrecio)) + Constantes.CARACTER_SEPARADOR);//05 VE01-PRECIO


                Entrada.Append((sDiasVigencia == string.Empty ? "0" : sDiasVigencia) + Constantes.CARACTER_SEPARADOR);//05 VE01-DIA-VIGENCIA

                if (sCuentaAbono != "-1")
                {
                    Entrada.Append(sCuentaAbono + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-ECONOMICA
                }
                else
                {
                    switch (sOtra)
                    {
                        case "B":
                            Entrada.Append(sCuentaAbono + Constantes.CARACTER_SEPARADOR); //05 VE01-CTA-ECONOMICA   
                            break;
                        default:
                            Entrada.Append(sOtra + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-ECONOMICA             
                            break;
                    }
                }

                /*if (ext5.Visible == true)
                {
                    Entrada.Append((sMoneda) + Constantes.CARACTER_SEPARADOR);//05 VE01-MONEDA-EXTJ
                    Entrada.Append((sTipoCambio == string.Empty ? "" : util.FormatoDecimales(sTipoCambio)) + Constantes.CARACTER_SEPARADOR);//05 VE01-CAMBIO-EXTJ
                    Entrada.Append(ddlBroker.SelectedItem.Value.ToString().PadLeft(4, '0') + Constantes.CARACTER_SEPARADOR);//05 VE01-BROKER
                }
                else
                {
                    Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-MONEDA-EXTJ
                    Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-CAMBIO-EXTJ
                    Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-BROKER
                }*/

                Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-MONEDA-EXTJ
                Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-CAMBIO-EXTJ
                Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-BROKER


                Entrada.Append((bRetencion==true ? "S" : "N") + Constantes.CARACTER_SEPARADOR);//05 VE01-IND-RETENC
                Entrada.Append("A" + Constantes.CARACTER_SEPARADOR);//05 VE01-FUNCION  //TEST A=Alta

                //Entrada.Append("M" + Constantes.CARACTER_SEPARADOR);//05 VE01-FUNCION  //TEST M=Modificación
                //Entrada.Append("B" + Constantes.CARACTER_SEPARADOR);//05 VE01-FUNCION  //TEST M=Baja
                //Entrada.Append("C" + Constantes.CARACTER_SEPARADOR);//05 VE01-FUNCION  //TEST A=Correción

                //Entrada.Append((txtFirma.Text.Trim() == string.Empty ? "       " : ((string)(txtFirma.Text.Trim() + "       ")).Substring(0, 7)) + Constantes.CARACTER_SEPARADOR);//05 VE01-FIRMA
                Entrada.Append((bFirma==true ? "1111111" : "       ") + Constantes.CARACTER_SEPARADOR);//05 VE01-FIRMA

                //if (txtObservaciones.Text.Length >= 98) //PPR 14.02.17 - Adecuaciones al RAI
                if (sObservaciones.Length >= 91)
                {
                    Entrada.Append(sObservaciones.Substring(0, 50) + Constantes.CARACTER_SEPARADOR);//05 VE01-OBSERVACION1
                                                                                                           //Entrada.Append(txtObservaciones.Text.Substring(50, 48) + Constantes.CARACTER_SEPARADOR);//05 VE01-OBSERVACION2
                    Entrada.Append(sObservaciones.Substring(50, 41));//05 VE01-OBSERVACION2 - PPR 14.02.17 - Adecuaciones al RAI
                    Entrada.Append(sRepresentante.PadRight(7, ' ').ToUpper() + Constantes.CARACTER_SEPARADOR);
                }
                else
                {
                    if (sObservaciones.Trim().Length > 50)
                    {
                        Entrada.Append(sObservaciones.Trim().Substring(0, 50) + Constantes.CARACTER_SEPARADOR);//05 VE01-OBSERVACION1
                                                                                                                      //Entrada.Append(txtObservaciones.Text.Trim().Substring(50) + Constantes.CARACTER_SEPARADOR);//05 VE01-OBSERVACION2 //PPR 14.02.17 - Adecuaciones al RAI
                        Entrada.Append(sObservaciones.Trim().Substring(50).PadRight(41, ' '));
                        Entrada.Append(sRepresentante.PadRight(7, ' ').ToUpper() + Constantes.CARACTER_SEPARADOR);
                    }
                    else
                    {
                        Entrada.Append(sObservaciones.Trim() + Constantes.CARACTER_SEPARADOR);//05 VE01-OBSERVACION1
                                                                                                     //Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-OBSERVACION2 //PPR 14.02.17 - Adecuaciones al RAI
                        Entrada.Append(string.Empty.PadRight(41, ' '));
                        Entrada.Append(sRepresentante.PadRight(7, ' ').ToUpper() + Constantes.CARACTER_SEPARADOR);
                    }
                }

                Entrada.Append("0" + Constantes.CARACTER_SEPARADOR);//05 VE01-NUM-ORDEN - Solo si es C, M, B
                Entrada.Append(modLoin.sUsuario + Constantes.CARACTER_SEPARADOR);//05 VE01-USUARIO

                if (sCuentaValor != "")
                {
                    Entrada.Append(sCuentaValor.Substring(0, 4) + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-ENT
                    Entrada.Append(sCuentaValor.Substring(4, 4) + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-OFI
                    Entrada.Append(sCuentaValor.Substring(8, 2) + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-DCH
                    Entrada.Append(sCuentaValor.Substring(10, 2) + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-PRO
                    Entrada.Append(sCuentaValor.Substring(12, 8) + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-NRO
                }
                else
                {
                    Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-ENT
                    Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-OFI
                    Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-DCH
                    Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-PRO
                    Entrada.Append("" + Constantes.CARACTER_SEPARADOR);//05 VE01-CTA-VALOR-NRO
                }


                Entrada.Append(sTipoComision + Constantes.CARACTER_SEPARADOR);//VE01-TIPO-COMISIO          

                string comision = sComision.Trim();
                string decimales = ""; string entero = "";
                if (comision.Contains("."))
                {
                    decimales = comision.Substring(comision.LastIndexOf(".") + 1);
                    entero = comision.Substring(0, comision.LastIndexOf("."));
                }
                else
                {
                    decimales = "000000";
                    entero = comision;
                }
                comision = entero.PadLeft(12, '0') + decimales.PadRight(6, '0');

                Entrada.Append(comision + Constantes.CARACTER_SEPARADOR);//VE01-IMP-COMISION

                //Entrada.Append("");//VE01-IND-ACTUALIZ
                /* PET 201209020 -INI - Se agrega si negociacion se realizo por telefono EZS*/
                string strTelefono = "";
                //PPR: Adecuaciones al RAI
                //if (rbSi.Checked)
                //{
                //    strTelefono = "S";
                //}
                //if (rbNo.Checked)
                //{
                //    strTelefono = "N";
                //}

                if (sOptionRadio== "Telefono")
                    strTelefono = "T";
                if (sOptionRadio == "Escrita")
                    strTelefono = "E";

                /*if (rbDma.Checked)
                {
                    strTelefono = "D";
                }
                if (rbEscrita.Checked)
                {
                    strTelefono = "E";
                }
                if (rbCorreo.Checked)
                {
                    strTelefono = "C";
                }
                if (rbInternet.Checked)
                {
                    strTelefono = "I";
                }
                if (rbTelefono.Checked)
                {
                    strTelefono = "T";
                }*/


                //Entrada.Append("");//Portafolio
                Entrada.Append(strTelefono);//Portafolio
                                            /* PET 201209020 -FIN - Se agrega si negociacion se realizo por telefono EZS*/

                string mySession = "";
                //UsuarioSesion usu = SessionManager.GetUsuario();
                string sImp_operacion = string.Empty;
                string sImp_liquidacion = string.Empty;
                string sInd_especial = string.Empty;
                string sSab_represen = string.Empty;
                string sNro_Orden = string.Empty;


                switch (sOrden)
                {
                    case "C":
                        #region ColumnasCompra
                        strCol.Add("CtaCargo");
                        strCol.Add("MonCargo");
                        strCol.Add("NroCtaValor");
                        strCol.Add("MonCtaValor");
                        strCol.Add("Nenomico");
                        strCol.Add("NombreValor");
                        strCol.Add("TitNegociados");
                        strCol.Add("PreNegociado");
                        strCol.Add("DiasUtiles");
                        strCol.Add("UltCotizacion");
                        strCol.Add("ModOrden");
                        strCol.Add("AdmCatera");
                        strCol.Add("DesOpe");
                        strCol.Add("NroOrden");
                        strCol.Add("NroOrdenCNS");
                        strCol.Add("ImpRetenido");
                        strCol.Add("TipoCambio");
                        strCol.Add("FecOrden");
                        strCol.Add("HoraOrden");
                        strCol.Add("CustTitulos");
                        strCol.Add("NombCustodio");
                        strCol.Add("ImpOperacion");
                        strCol.Add("ImpLiquidacion");
                        strCol.Add("IndActualiza");
                        strCol.Add("Especial");
                        strCol.Add("Representante"); //PPR: Accenture 08.11.16
                        #endregion
                        /* CEHU INICIO */
                        //strCadenaRespuesta = oTransacciones.DarAltaOrdenCompraValores(usu.SessionId, Util.ObtenerIPCliente(this.Page.Request), oUsuario.Login, oUsuario.Password, Entrada.ToString());
                        oTransaccionVLA7 = this.CargaInformacionOrdenVLA7(Entrada.ToString());
                        oTransaccionVLA7.requestHeader = util.RetornaHeaderEnvio(ConfigWeb_,"VLA7", modLoin.sUsuario, modLoin.SessionId);
                        oRootObject_VLA7.integrationRequest = oTransaccionVLA7;


                        //**********************************************
                        string sTransaccion = "VLA7";
                        this.urlToPost = util.UrlHubIntegrador(ConfigWeb_, sTransaccion);
                        webClient.Headers.Add("Content-Type", "application/json");
                        reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(oRootObject_VLA7, Formatting.Indented));
                        // string serializedJson = JsonConvert.SerializeObject(RootVLA3_Request);
                        resByte = webClient.UploadData(this.urlToPost, "post", reqString);
                        this.resString = Encoding.Default.GetString(resByte);
                        // Console.WriteLine(resString);
                        webClient.Dispose();
                        //**********************************************

                        // capturar el formato JSON y deserializarlo en el objeto response para pasarlo a la grilla.
                        oVLA7_RootResponse = (VLA7_RootResponse)util.ResponseObjectTrama(sTransaccion, this.resString);
                            //*****oVLA7_RootResponse = (VLA7_RootResponse)oFormateoJSOn.ResponseObjectTrama("VLA7", cadenaRESPprueba);

                            if (oVLA7_RootResponse == null || oVLA7_RootResponse.XMLNSC == null)
                            {
                                Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                                obj_cadenaerror = (Error_RootResponse)util.ResponseObjectError(this.resString);
                                throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                                TransaccionOK = 0;
                            }
                            else
                            {
                                sImp_operacion = oVLA7_RootResponse.XMLNSC.integrationResponse.imp_operacion;
                                sImp_liquidacion = oVLA7_RootResponse.XMLNSC.integrationResponse.imp_liquidacion;
                                sInd_especial = oVLA7_RootResponse.XMLNSC.integrationResponse.ind_especial;
                                sSab_represen = oVLA7_RootResponse.XMLNSC.integrationResponse.sab_represen;
                                sNro_Orden = oVLA7_RootResponse.XMLNSC.integrationResponse.nro_orden;
                                TransaccionOK = 1;
                            }
                     
                        //dtBusqueda = oFormateador.RetornaDataTable_Trama(strCadenaRespuesta, strCol, out booMasPaginas, out strSiguienteRegistro, out mySession);                    
                        /* CEHU FIN */

                        break;
                    case "V":
                        #region ColumnasVenta
                        strCol.Add("CtaCargo");
                        strCol.Add("MonCargo");
                        strCol.Add("NroCtaValor");
                        strCol.Add("MonCtaValor");
                        strCol.Add("Nenomico");
                        strCol.Add("NombreValor");
                        strCol.Add("TitNegociados");
                        strCol.Add("PreNegociado");
                        strCol.Add("DiasUtiles");
                        strCol.Add("ModOrden");
                        strCol.Add("AdmCatera");
                        strCol.Add("DesOpe");
                        strCol.Add("NroOrden");
                        strCol.Add("NroOrdenCNS");
                        strCol.Add("ImpRetenido");
                        strCol.Add("TipoCambio");
                        strCol.Add("FecOrden");
                        strCol.Add("HoraOrden");
                        strCol.Add("CustTitulos");
                        strCol.Add("NombCustodio");
                        strCol.Add("ImpOperacion");
                        strCol.Add("ImpLiquidacion");
                        strCol.Add("IndActualiza");
                        strCol.Add("Especial");
                        strCol.Add("Representante"); //PPR: Accenture 08.11.16
                        #endregion
                        /* CEHU INICIO */
                        //strCadenaRespuesta = oTransacciones.DarAltaOrdenVentaValores(usu.SessionId, Util.ObtenerIPCliente(this.Page.Request), oUsuario.Login, oUsuario.Password, Entrada.ToString());
                        oTransaccionVLA8 = CargaInformacionOrdenVLA8(Entrada.ToString());
                        oTransaccionVLA8.requestHeader = util.RetornaHeaderEnvio(ConfigWeb_,"VLA8", modLoin.sUsuario, modLoin.SessionId);
                        oRootObject_VLA8.integrationRequest = oTransaccionVLA8;


                        //**********************************************
                        sTransaccion = "VLA8";
                        this.urlToPost = util.UrlHubIntegrador(ConfigWeb_, sTransaccion);
                        webClient.Headers.Add("Content-Type", "application/json");
                        reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(oRootObject_VLA8, Formatting.Indented));
                        // string serializedJson = JsonConvert.SerializeObject(RootVLA3_Request);
                        resByte = webClient.UploadData(this.urlToPost, "post", reqString);
                        this.resString = Encoding.Default.GetString(resByte);
                        // Console.WriteLine(resString);
                        webClient.Dispose();
                        //**********************************************

                            oVLA8_RootResponse = (VLA8_RootResponse)util.ResponseObjectTrama(sTransaccion, this.resString);
                            //****oVLA8_RootResponse = (VLA8_RootResponse)oFormateoJSOn.ResponseObjectTrama("VLA8", cadenaRES8Pprueba);

                            if (oVLA8_RootResponse == null || oVLA8_RootResponse.XMLNSC == null)
                            {
                                Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                                obj_cadenaerror = (Error_RootResponse)util.ResponseObjectError(this.resString);
                                throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                                TransaccionOK = 0;  
                            }
                            else
                            {
                                sImp_operacion = oVLA8_RootResponse.XMLNSC.integrationResponse.imp_operacion;
                                sImp_liquidacion = oVLA8_RootResponse.XMLNSC.integrationResponse.imp_liquidacion;
                                sInd_especial = oVLA8_RootResponse.XMLNSC.integrationResponse.ind_especial;
                                sSab_represen = oVLA8_RootResponse.XMLNSC.integrationResponse.sab_represen;
                                sNro_Orden = oVLA8_RootResponse.XMLNSC.integrationResponse.nro_orden;
                                TransaccionOK = 1;
                            }
                      
                        //dtBusqueda = oFormateador.RetornaDataTable_Trama(strCadenaRespuesta, strCol, out booMasPaginas, out strSiguienteRegistro, out mySession);                    
                        /* CEHU FIN */
                        break;
                }

                //************************************************
                if (TransaccionOK == 1)
                {
                  //  PnMensaje.Visible = true;
                    double ope;
                    double liq;

                    //if (dtBusqueda.Rows[0]["ImpOperacion"].ToString() != string.Empty)
                    //{ ope = Convert.ToDouble(dtBusqueda.Rows[0]["ImpOperacion"].ToString()); }
                    //else { ope = 0.0; }
                    if (sImp_operacion != string.Empty)
                    { ope = Convert.ToDouble(sImp_operacion); }
                    else { ope = 0.0; }

                    //if (dtBusqueda.Rows[0]["ImpLiquidacion"].ToString() != string.Empty)
                    //{ liq = Convert.ToDouble(dtBusqueda.Rows[0]["ImpLiquidacion"].ToString()); }
                    //else { liq = 0.0; }
                    if (sImp_liquidacion != string.Empty)
                    { liq = Convert.ToDouble(sImp_liquidacion); }
                    else { liq = 0.0; }
                    /*
                    if (ext1.Visible)
                    {
                        lblMontoBrutoExt.Visible = true;
                        lblMontoNetoExt.Visible = true;
                        lblMontoBrutoExt.Text = Util.FormatoMoneda((ope / 100), 2, "");
                        lblMontoNetoExt.Text = Util.FormatoMoneda((liq / 100), 2, "");
                    }
                    else
                    {
                        lblMontoBruto.Visible = true;
                        lblMontoNeto.Visible = true;
                        lblMontoBruto.Text = Util.FormatoMoneda((ope / 100), 2, "");
                        lblMontoNeto.Text = Util.FormatoMoneda((liq / 100), 2, "");
                    }
                    */

                    /*
                    lblMontoBruto.Visible = true;
                    lblMontoNeto.Visible = true;
                    lblMontoBruto.Text = util.FormatoMoneda((ope / 100), 2, "");
                    lblMontoNeto.Text = util.FormatoMoneda((liq / 100), 2, "");
                    */

                    //HabilitaControles(false);
                    //if (Convert.ToString(dtBusqueda.Rows[0]["Especial"]) == "S")
                    if (sInd_especial == "S")
                    {
                        sRpta = "La orden fue ingresada con éxito, número de orden generada: " + sNro_Orden + " (Especial).";
                       // LblExito.Text = "La orden fue ingresada con éxito, número de orden generada: " + sNro_Orden + " (Especial).";
                        //LblExito.Text = "La orden fue ingresada con éxito, número de orden generada: " + dtBusqueda.Rows[0]["NroOrden"].ToString() + " (Especial).";
                       // txtTipoOrdenValidado.Text = "Especial"; //PPR: Adecuaciones al RAI
                    }
                    else
                    {
                        sRpta = "La orden fue ingresada con éxito, número de orden generada: " + sNro_Orden;
                       // LblExito.Text = "La orden fue ingresada con éxito, número de orden generada: " + sNro_Orden;
                       // txtTipoOrdenValidado.Text = "Ordinaria"; //PPR: Adecuaciones al RAI
                    }
                    //txtRepresentante.Text = Convert.ToString(dtBusqueda.Rows[0]["Representante"]); //PPR: Adecuaciones al RAI
                    //txtRepresentante.Text = sSab_represen;

                    //BTN.Visible = false;
                    // btnCancelar.Visible = false;
                    //btnGuardar.Visible = false;


                    modeloRpta.bEstado = true;
                    modeloRpta.iCodigo = 0;
                }
                else
                {
                    modeloRpta.bEstado = false;
                    modeloRpta.iCodigo = 1;
                    //LblMensaje.Text = "La operacion no fue completada, vuelva a intentarlo.";
                    sRpta = "La operacion no fue completada, vuelva a intentarlo.";
                }


                modeloRpta.sRpta = sRpta;
                modeloRpta.obj = "";

            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }




        private Model mSearchInfo_All(ConfigWeb ConfigWeb_, string strTipoBusqueda, string strValorBusqueda, bool blnRetrocede, LoginUser modLoin)
        {
            Model modeloRpta = new Model();

            string sTransaccion = "";

            VLA2_Request oTransaccionVLA2 = new VLA2_Request();
            VLA3_Request oTransaccionVLA3 = new VLA3_Request();
            RootObject_VLA3 RootVLA3_Request = new RootObject_VLA3();
            RootObject_VLA2 RootVLA2_Request = new RootObject_VLA2();

            try
            {
                WebClient webClient = new WebClient();
                byte[] resByte = null;
                byte[] reqString = null;

                string strSiguienteRegistro = "";
                string strSiguienteRUT = "";
                bool booMasPaginas = new bool();
                DataTable dtBusqueda = new DataTable();
                Utility util = new Utility();

                StringCollection strCol = new StringCollection();
                StringCollection strColVLA3 = new StringCollection();

                strCol.Add("TipoDocumento");
                strCol.Add("NombreDocumento");
                strCol.Add("NumeroDocumento");
                strCol.Add("NombreRazonSocial");
                strCol.Add("RUT");

                string mySession = "";
                string[] oArray = strValorBusqueda.Split(Constantes.CARACTER_SEPARADOR);

                if (strTipoBusqueda == "A")
                {
                    oTransaccionVLA3.requestHeader = util.RetornaHeaderEnvio(ConfigWeb_, "VLA3", modLoin.sUsuario, modLoin.SessionId);
                    oTransaccionVLA3.nombre_clte1 = oArray[0].ToUpper();
                    oTransaccionVLA3.numcli = oArray[1];
                    oTransaccionVLA3.usuario = modLoin.sUsuario;
                    if (!(oArray[1] == "" || blnRetrocede))
                    { oTransaccionVLA3.arg_busqueda = oArray[0].ToUpper(); }

                    RootVLA3_Request.integrationRequest = oTransaccionVLA3;

                    //**********************************************
                    sTransaccion = "VLA3";
                    this.urlToPost = util.UrlHubIntegrador(ConfigWeb_, sTransaccion);
                    webClient.Headers.Add("Content-Type", "application/json");
                    reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(RootVLA3_Request, Formatting.Indented));
                    // string serializedJson = JsonConvert.SerializeObject(RootVLA3_Request);
                    resByte = webClient.UploadData(this.urlToPost, "post", reqString);
                    this.resString = Encoding.Default.GetString(resByte);
                    // Console.WriteLine(resString);
                    webClient.Dispose();
                    //**********************************************

                    dtBusqueda = util.ResponseDatatableTrama(sTransaccion, this.resString, strCol, out booMasPaginas, out strSiguienteRegistro, out strSiguienteRUT, out mySession);

                }
                else
                {
                    sTransaccion = "VLA2";

                    oTransaccionVLA2.requestHeader = util.RetornaHeaderEnvio(ConfigWeb_, sTransaccion, modLoin.sUsuario, modLoin.SessionId);
                    oTransaccionVLA2.tipo_consulta = strTipoBusqueda;
                    oTransaccionVLA2.dato_consulta = oArray[0].ToUpper();
                    //oTransaccionVLA2.ctaval_rein = oArray[1];
                    oTransaccionVLA2.usuario = modLoin.sUsuario;

                    RootVLA2_Request.integrationRequest = oTransaccionVLA2;

                    //**********************************************              
                    this.urlToPost = util.UrlHubIntegrador(ConfigWeb_, sTransaccion);
                    webClient.Headers.Add("Content-Type", "application/json");
                    reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(RootVLA2_Request, Formatting.Indented));
                    //string serializedJson = JsonConvert.SerializeObject(RootVLA2_Request);
                    resByte = webClient.UploadData(this.urlToPost, "post", reqString);
                    this.resString = Encoding.Default.GetString(resByte);
                    //Console.WriteLine(this.resString);
                    webClient.Dispose();
                    //**********************************************

                    dtBusqueda = util.ResponseDatatableTrama(sTransaccion, "0" + this.resString, strCol, out booMasPaginas, out strSiguienteRegistro, out strSiguienteRUT, out mySession);

                }


                if (dtBusqueda.Rows.Count > 0)
                {
                    dtBusqueda = new Utility().EliminarRepetidos(false, "TipoDocumento", "NumeroDocumento", dtBusqueda);

                    if (dtBusqueda.Rows.Count == 1)
                    {
                        DataRow row = dtBusqueda.Rows[0];

                        // Response.Redirect(ObtenerRutaDestino(dtBusqueda.Rows[0]));
                        modeloRpta = this.mGetInfo(dtBusqueda.Rows[0], ConfigWeb_, modLoin);
                       // modeloRpta.obj = JsonConvert.SerializeObject(ob); 
                    }
                }


                //modeloRpta.bEstado = true;
                //modeloRpta.iCodigo = 0;
                //modeloRpta.sRpta = "ok";
              //  modeloRpta.obj = dtBusqueda;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }
         
        private Model mGetInfo(DataRow drCliente, ConfigWeb ConfigWeb_, LoginUser modLoin)
        {
            Model modeloRpta = new Model();

            try
            {
                string rowTipoBusqueda = drCliente["TipoDocumento"].ToString();
                string rowValorBusqueda = drCliente["NumeroDocumento"].ToString();
                string rowNombreCliente = drCliente["NombreRazonSocial"].ToString();
              
                string tb = rowTipoBusqueda;
                string vb = rowValorBusqueda;


                CompraVenta_Info CompraVenta_Info_ = new CompraVenta_Info();

                Model objCargarCuenta = this.CargarCuentas(tb, vb, ConfigWeb_, modLoin);

                if (objCargarCuenta.bEstado) {
                    CargarCuenta CargarCuenta_ = (CargarCuenta)objCargarCuenta.obj;

                    CompraVenta_Info_.CuentasCliente = CargarCuenta_.dtInfo;
                    CompraVenta_Info_.CompraVenta_DatosPersonales = this.Load_DatosPersonales(CargarCuenta_.dtrInfoPersonal);

                    Model objCargarValores = this.CargarValores(CompraVenta_Info_.CompraVenta_DatosPersonales.NumeroCliente, "", "", ConfigWeb_, modLoin);

                    if (objCargarValores.bEstado) {

                        CompraVenta_Info_.CargarValores = (DataTable)objCargarValores.obj;

                        modeloRpta.bEstado = true;
                        modeloRpta.iCodigo = 0;
                        modeloRpta.sRpta = "";
                        modeloRpta.obj = JsonConvert.SerializeObject(CompraVenta_Info_); 
                    }
                }

            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        private Model CargarCuentas(string strTipoBusqueda, string strValorBusqueda, ConfigWeb ConfigWeb_, LoginUser modLoin)
        {
            Model modeloRpta = new Model();

            VLA2_Request oTransaccionVLA2 = new VLA2_Request();
            RootObject_VLA2 RootVLA2_Request = new RootObject_VLA2();
            Utility util = new Utility();
            WebClient webClient = new WebClient();
            byte[] resByte = null;
            byte[] reqString = null;

            try
            {
                //string strCadenaRespuesta = "";
                string strSiguienteRegistro = "";
                string strSiguienteRUT = "";
                bool booMasPaginas = false; // new bool();
                //bool booHayAnterior = new bool();
                DataTable dtGrid = new DataTable("Data");

                StringCollection strCol = new StringCollection();

                strCol.Add("CodigoTipoDocumento");
                strCol.Add("NombreTipoDocumento");
                strCol.Add("NumeroDocumento");
                strCol.Add("Cliente");
                strCol.Add("Direccion");
                strCol.Add("Telefonos1");
                strCol.Add("Telefonos2");
                strCol.Add("Telefonos3");
                strCol.Add("Email");
                strCol.Add("NumCli");
                strCol.Add("CtaValor");
                strCol.Add("Rut");
                strCol.Add("CuentaEconomicaCargo");
                strCol.Add("MonedaCuentaEconomicaCargo");
                strCol.Add("CuentaEconomicaAbono");
                strCol.Add("MonedaCuentaEconomicaAbono");
                strCol.Add("TipoComision");
                strCol.Add("ComisionCliente");
                strCol.Add("LugarNegociacion");//RCB

                string mySession = "";
                // UsuarioSesion usu = SessionManager.GetUsuario();
                string sTransaccion = "VLA2";

                oTransaccionVLA2.requestHeader = new Utility().RetornaHeaderEnvio(ConfigWeb_, "VLA2", modLoin.sUsuario, modLoin.SessionId);
                oTransaccionVLA2.tipo_consulta = strTipoBusqueda;
                oTransaccionVLA2.dato_consulta = strValorBusqueda;
                oTransaccionVLA2.usuario = modLoin.sUsuario;

                RootVLA2_Request.integrationRequest = oTransaccionVLA2;

                //**********************************************              
                this.urlToPost = util.UrlHubIntegrador(ConfigWeb_, sTransaccion);
                webClient.Headers.Add("Content-Type", "application/json");
                reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(RootVLA2_Request, Formatting.Indented));
                //string serializedJson = JsonConvert.SerializeObject(RootVLA2_Request);
                resByte = webClient.UploadData(this.urlToPost, "post", reqString);
                this.resString = Encoding.Default.GetString(resByte);
                //Console.WriteLine(this.resString);
                webClient.Dispose();
                //**********************************************

                // capturar el formato JSON y deserializarlo en el objeto response para pasarlo a la grilla.
                dtGrid = util.ResponseDatatableTrama(sTransaccion, "1" + this.resString, strCol,
                                                            out booMasPaginas, out strSiguienteRegistro,
                                                            out strSiguienteRUT, out mySession);

                int contador = 0;

                while (booMasPaginas)
                {
                    DataTable dtNuevo = new DataTable();

                    oTransaccionVLA2.ctaval_rein = strSiguienteRegistro;

                    //**********************************************              
                    this.urlToPost = util.UrlHubIntegrador(ConfigWeb_, sTransaccion);
                    webClient.Headers.Add("Content-Type", "application/json");
                    reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(RootVLA2_Request, Formatting.Indented));
                    //string serializedJson = JsonConvert.SerializeObject(RootVLA2_Request);
                    resByte = webClient.UploadData(this.urlToPost, "post", reqString);
                    this.resString = Encoding.Default.GetString(resByte);
                    //Console.WriteLine(this.resString);
                    webClient.Dispose();
                    //**********************************************

                    dtNuevo = util.ResponseDatatableTrama(sTransaccion, "1" + this.resString, strCol,
                                                        out booMasPaginas, out strSiguienteRegistro,
                                                        out strSiguienteRUT, out mySession);

                    foreach (DataRow drtableOld in dtNuevo.Rows)
                    {
                        dtGrid.ImportRow(drtableOld);
                    }

                    contador++;
                    if (contador > 20)
                        booMasPaginas = false;

                }

                AgregarMancomuno(ref dtGrid);

                StringCollection ColumnasConvertir = new StringCollection();
                ColumnasConvertir.Add("ComisionCliente" + Constantes.CARACTER_SEPARADOR + "4");


                CargarCuenta cuenta_ = new CargarCuenta();

             

                if (dtGrid.Rows.Count > 0)
                {
                    //RCB - INI
                    DataView vista = new DataView(dtGrid);
                    DataTable dtsindupl = vista.ToTable(true, "CodigoTipoDocumento", "NombreTipoDocumento",
                                                        "NumeroDocumento", "Cliente", "Direccion", "Telefonos1",
                                                        "Telefonos2", "Telefonos3", "Email", "NumCli", "CtaValor", "Rut",
                                                        "CuentaEconomicaCargo", "MonedaCuentaEconomicaCargo", "CuentaEconomicaAbono",
                                                        "MonedaCuentaEconomicaAbono", "Mancomunado");

                    this.AgregarRueda(dtGrid, ref dtsindupl);

                    cuenta_.dtInfo = dtsindupl;
                    cuenta_.dtrInfoPersonal = dtsindupl.Rows[0];
                }

                modeloRpta.bEstado = true;
                modeloRpta.iCodigo = 0;
                modeloRpta.sRpta = "";
                modeloRpta.obj = cuenta_;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public void AgregarMancomuno(ref DataTable dtTabla)
        {
            if (dtTabla != null)
            {
                dtTabla.Columns.Add("Mancomunado");
                string strMancomuno = string.Empty;
                foreach (DataRow dr in dtTabla.Rows)
                {
                    strMancomuno = dr["CtaValor"].ToString().Substring(4, 1);
                    dr["CtaValor"] = dr["CtaValor"].ToString().Substring(0, 4) + dr["CtaValor"].ToString().Substring(5);
                    if (strMancomuno == "S")
                    {
                        dr["Mancomunado"] = "Si";
                    }
                    else
                    {
                        dr["Mancomunado"] = "No";
                    }
                }
            }
        }
        
        public void AgregarRueda(DataTable dtTodo, ref DataTable dtTabla)
        {
            if (dtTabla != null)
            {
                dtTabla.Columns.Add("ComisionRueda");
                string lugarNegociacion = string.Empty;
                string ctaValorAnterior = string.Empty;
                string ctaValorNuevo = string.Empty;

                DataRow[] filtro = null;
                foreach (DataRow dr in dtTabla.Rows)
                {
                    filtro = dtTodo.Select("CtaValor='" + dr["CtaValor"] + "' AND LugarNegociacion='R'");

                    if (filtro.Length > 0)
                    {
                        if (filtro[0].ItemArray[16].ToString() == "D")
                        {
                            dr["ComisionRueda"] = "DEFECTO";
                        }
                        else
                        {
                            dr["ComisionRueda"] = filtro[0].ItemArray[17].ToString();
                        }
                    }
                    else
                    {
                        dr["ComisionRueda"] = "DEFECTO";
                    }
                }
            }
        }
        
        private CompraVenta_DatosPersonales Load_DatosPersonales(DataRow drDatoPersonal)
        {
            CompraVenta_DatosPersonales CompraVenta_DatosPersonales_ = new CompraVenta_DatosPersonales();

            CompraVenta_DatosPersonales_.Nombre = drDatoPersonal["Cliente"].ToString();
            CompraVenta_DatosPersonales_.TipoDocumento = drDatoPersonal["NombreTipoDocumento"].ToString();
            CompraVenta_DatosPersonales_.NumeroDocumento = drDatoPersonal["NumeroDocumento"].ToString();
            CompraVenta_DatosPersonales_.Direccion = drDatoPersonal["Direccion"].ToString();
            string strTelefonos = drDatoPersonal["Telefonos1"].ToString().Length > 0 ? drDatoPersonal["Telefonos1"].ToString() : "";
            strTelefonos = strTelefonos + (drDatoPersonal["Telefonos2"].ToString().Length > 0 ? " - " + drDatoPersonal["Telefonos2"].ToString() : "");
            strTelefonos = strTelefonos + (drDatoPersonal["Telefonos3"].ToString().Length > 0 ? " - " + drDatoPersonal["Telefonos3"].ToString() : "");
            CompraVenta_DatosPersonales_.Telefonos = strTelefonos;
            CompraVenta_DatosPersonales_.Email = drDatoPersonal["Email"].ToString();
            CompraVenta_DatosPersonales_.NumeroCliente = drDatoPersonal["NumCli"].ToString();

            return CompraVenta_DatosPersonales_;
        }
        
        private Model CargarValores(string strNumCliente, string strCtaValor, string strNemonico, ConfigWeb ConfigWeb_, LoginUser modLoin)
        {
            Model modeloRpta = new Model();


            /* CEHU INICIO */
            //Transacciones.Transacciones oTransacciones = new Transacciones.Transacciones();
            VLA5_Request oTransaccionVLA5 = new VLA5_Request();
            RootObject_VLA5 oRootObject_VLA5 = new RootObject_VLA5();
            Utility util = new Utility();
            WebClient webClient = new WebClient();
            byte[] resByte = null;
            byte[] reqString = null;

            DataTable dtGrid = new DataTable("Data");

            try
            {
                string strSiguienteCuentaValor = "";
                string strSiguienteNemonico = "";
                bool booMasPaginas = new bool();
              
                string sTransaccion = "VLA5";

                StringCollection strCol = new StringCollection();
                
                strCol.Add("CuentaValor");
                strCol.Add("Nemonico");
                strCol.Add("Moneda");
                strCol.Add("SaldoContable");
                strCol.Add("SaldoDisponible");
                strCol.Add("CompraNoLiquidada");
                strCol.Add("PrecioPromedio");
                strCol.Add("PrecioActual");
                strCol.Add("ValorizacionActual");
                strCol.Add("Utilidad");
                strCol.Add("SignoUtilidad");
                strCol.Add("Custodio");
                strCol.Add("IndicadorValor");
                string mySession = "";

                oTransaccionVLA5.requestHeader = util.RetornaHeaderEnvio(ConfigWeb_, sTransaccion, modLoin.sUsuario, modLoin.SessionId);
                oTransaccionVLA5.ctaval_rein = strCtaValor;
                oTransaccionVLA5.nemoni_rein = strNemonico;
                oTransaccionVLA5.usuario = modLoin.sUsuario;
                oTransaccionVLA5.numcli = strNumCliente;

                if (strNemonico != "" && strCtaValor != "")
                { oTransaccionVLA5.ind_paginacion = "S"; }

                oRootObject_VLA5.integrationRequest = oTransaccionVLA5;

                //**********************************************              
                this.urlToPost = util.UrlHubIntegrador(ConfigWeb_, sTransaccion);
                webClient.Headers.Add("Content-Type", "application/json");
                reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(oRootObject_VLA5, Formatting.Indented));
                //string serializedJson = JsonConvert.SerializeObject(RootVLA2_Request);
                resByte = webClient.UploadData(this.urlToPost, "post", reqString);
                this.resString = Encoding.Default.GetString(resByte);
                //Console.WriteLine(this.resString);
                webClient.Dispose();
                //**********************************************

                // capturar el formato JSON y deserializarlo en el objeto response para pasarlo a la grilla.
                dtGrid = util.ResponseDatatableTrama(sTransaccion, this.resString, strCol,
                                                        out booMasPaginas, out strSiguienteCuentaValor,
                                                        out strSiguienteNemonico, out mySession);

         
                    DataTable dtCloned = dtGrid.Clone();
                    dtCloned.Columns[6].DataType = typeof(string);
                    dtCloned.Columns[7].DataType = typeof(string);
                    dtCloned.Columns[8].DataType = typeof(string);
                    dtCloned.Columns[9].DataType = typeof(string);
                    foreach (DataRow row in dtGrid.Rows)
                    {
                        dtCloned.ImportRow(row);
                    }

                    dtGrid = dtCloned;

                /*
              //  util.ConcatenarCeros("SaldoContable", ref dtGrid);
              //  util.ConcatenarCeros("SaldoDisponible", ref dtGrid);
                StringCollection ColumnasConvertir = new StringCollection();
                ColumnasConvertir.Add("PrecioPromedio" + Constantes.CARACTER_SEPARADOR + "4");
                ColumnasConvertir.Add("PrecioActual" + Constantes.CARACTER_SEPARADOR + "4");
                ColumnasConvertir.Add("ValorizacionActual" + Constantes.CARACTER_SEPARADOR + "4");
                ColumnasConvertir.Add("Utilidad" + Constantes.CARACTER_SEPARADOR + "2");
               // ****ColumnasConvertir.Add("SaldoContable" + Constantes.CARACTER_SEPARADOR + "0");
               // ****ColumnasConvertir.Add("SaldoDisponible" + Constantes.CARACTER_SEPARADOR + "0");
               // ****dtGrid = oFormateador.RetornaDataTable_FormatearNumericos(dtGrid, ColumnasConvertir);
               // dtGrid = oFormateador.RetornaDataTable_FormatearMoneda(dtGrid, ColumnasConvertir);
                */

                /*
                if (booMasPaginas)
                    egvValoresCliente.ValorSiguiente = strSiguienteCuentaValor + "|" + strSiguienteNemonico;
                else
                    egvValoresCliente.ValorSiguiente = "";
                */
                /*if (dtGrid.Rows.Count > 0)
                {

                    if (egvValoresCliente.GetValoresAnteriores().Count > 0)
                    { booHayAnterior = true; }
                    else
                    { booHayAnterior = false; }

                    //Modificacion SaldoContable
                    //#region Modificacion SaldoContable
                    //for (int i = 0; i < dtGrid.Rows.Count; i++)
                    //{
                    //    dtGrid.Rows[i]["SaldoContable"] = (Convert.ToDecimal(Convert.ToString(dtGrid.Rows[i]["SaldoContable"]).Replace(",", "")) +
                    //                                      Convert.ToDecimal(Convert.ToString(dtGrid.Rows[i]["CompraNoLiquidada"]).Replace(",", ""))).ToString("N0");
                    //}
                    //#endregion

                    //LoadGrid(booMasPaginas, booHayAnterior, dtGrid);
                }*/



                modeloRpta.bEstado = true;
                modeloRpta.iCodigo = 0;
                modeloRpta.sRpta = "";
                modeloRpta.obj = dtGrid;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }





        private VLA7_Request CargaInformacionOrdenVLA7(string strEntrada)
        {
            string[] aValores;
            VLA7_Request oVLA7Request = new VLA7_Request();

            aValores = strEntrada.Split(Constantes.CARACTER_SEPARADOR);
            oVLA7Request.tipo_orden = aValores[0];
            oVLA7Request.lugar_negoc = aValores[1];
            oVLA7Request.nemonic = aValores[2];
            oVLA7Request.isin_entrada = aValores[3];
            oVLA7Request.tit_ordenados = aValores[4];
            oVLA7Request.precio = aValores[5];
            oVLA7Request.dia_vigencia = aValores[6];
            oVLA7Request.cta_economica = aValores[7];
            oVLA7Request.moneda_extj = aValores[8];
            oVLA7Request.cambio_extj = aValores[9];
            oVLA7Request.broker = aValores[10];
            oVLA7Request.ind_retenc = aValores[11];
            oVLA7Request.funcion = aValores[12];
            oVLA7Request.firma = aValores[13];
            oVLA7Request.observacion1 = aValores[14];
            oVLA7Request.observacion2 = aValores[15];
            oVLA7Request.num_orden = aValores[16];
            oVLA7Request.usuario = aValores[17];
            oVLA7Request.cta_valor_ent = aValores[18];
            oVLA7Request.cta_valor_ofi = aValores[19];
            oVLA7Request.cta_valor_dch = aValores[20];
            oVLA7Request.cta_valor_pro = aValores[21];
            oVLA7Request.cta_valor_nro = aValores[22];
            oVLA7Request.tip_comision = aValores[23];
            oVLA7Request.imp_comision = aValores[24];
            oVLA7Request.ind_portaf = aValores[25];

            return oVLA7Request;
        }

        private VLA8_Request CargaInformacionOrdenVLA8(string strEntrada)
        {
            string[] aValores;
            VLA8_Request oVLA8Request = new VLA8_Request();

            aValores = strEntrada.Split(Constantes.CARACTER_SEPARADOR);
            oVLA8Request.tipo_orden = aValores[0];
            oVLA8Request.lugar_negoc = aValores[1];
            oVLA8Request.nemonic = aValores[2];
            oVLA8Request.isin_entrada = aValores[3];
            oVLA8Request.tit_ordenados = aValores[4];
            oVLA8Request.precio = aValores[5];
            oVLA8Request.dia_vigencia = aValores[6];
            oVLA8Request.cta_economica = aValores[7];
            oVLA8Request.moneda_extj = aValores[8];
            oVLA8Request.cambio_extj = aValores[9];
            oVLA8Request.broker = aValores[10];
            oVLA8Request.ind_retenc = aValores[11];
            oVLA8Request.funcion = aValores[12];
            oVLA8Request.firma = aValores[13];
            oVLA8Request.observacion1 = aValores[14];
            oVLA8Request.observacion2 = aValores[15];
            oVLA8Request.num_orden = aValores[16];
            oVLA8Request.usuario = aValores[17];
            oVLA8Request.cta_valor_ent = aValores[18];
            oVLA8Request.cta_valor_ofi = aValores[19];
            oVLA8Request.cta_valor_dch = aValores[20];
            oVLA8Request.cta_valor_pro = aValores[21];
            oVLA8Request.cta_valor_nro = aValores[22];
            oVLA8Request.tip_comision = aValores[23];
            oVLA8Request.imp_comision = aValores[24];
            oVLA8Request.ind_portaf = aValores[25];

            return oVLA8Request;
        }



    }
}
