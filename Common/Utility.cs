using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
     
    public class Utility
    {
        // public ConfigWeb ConfigWeb_ { get; set; }

        private string FORMATO_FECHA = "yyyyMMddHHmmss";
        public char CARACTER_SEPARACION = '|';

        public RequestHeader RetornaHeaderEnvio(ConfigWeb ConfigWeb_ ,string Transaccion, string Usuario, string Session)
        {
            RequestHeader CabeceraAux = new RequestHeader();

            CabeceraAux.codigoEmpresa =  ConfigWeb_.AppSettings_.codigoEmpresa;
            CabeceraAux.codigoTerminalEmpresa =  ConfigWeb_.AppSettings_.codigoTerminalEmpresa;
            CabeceraAux.canal =  ConfigWeb_.AppSettings_.canal;
            CabeceraAux.codigoAplicacion =  ConfigWeb_.AppSettings_.codigoAplicacionHeader;
            CabeceraAux.usuario = Usuario;
            CabeceraAux.fechaHoraEnvio = DateTime.Now.ToString( FORMATO_FECHA);
            CabeceraAux.idSesion = Session;
            //AAAAMMDDHHmmSSssssss+CodAplicacion+Usuario
            CabeceraAux.idPeticionEmpresa = CabeceraAux.fechaHoraEnvio + CabeceraAux.codigoAplicacion + CabeceraAux.usuario;
            CabeceraAux.idPeticionBanco =  ConfigWeb_.AppSettings_.idPeticionBanco;
            CabeceraAux.idOperacion =  this.RetornaServicioHubIntegrador(ConfigWeb_,Transaccion).ToUpper();
            CabeceraAux.idServicio =  ConfigWeb_.AppSettings_.idServicioHeader;
            CabeceraAux.idInterconexion =  ConfigWeb_.AppSettings_.idInterconexionHeader;

            return CabeceraAux;
        }


        public string ServidorHI(ConfigWeb ConfigWeb_)
        {
            return  ConfigWeb_.AppSettings_.ServidorHI; //config.ServidorHI;
        }


        public string FormateoCadenaRespuestaJSon(string CadenaInicial)
        {
            string CadenaFinal = "";

            CadenaFinal = CadenaInicial.Replace(@",""detalleF"":", " , ");
            CadenaFinal = CadenaFinal.Replace(@",""detalle"":", " , ");
            CadenaFinal = CadenaFinal.Replace("}},", " } ] } , ");
            CadenaFinal = CadenaFinal.Replace("}}}}", " } ] }}} ");
            CadenaFinal = CadenaFinal.Replace(@"{""detalleF"":", @"{""detalleF"":[ ");
            CadenaFinal = CadenaFinal.Replace(@"{""detalle"":", @"{""detalle"":[ ");

            return CadenaFinal;
        }


        public string RetornaServicioHubIntegrador(ConfigWeb ConfigWeb_ ,string Transaccion)
        {
            string resultado = "";

            switch (Transaccion)
            {
                case "VLA0":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA0;
                    break;
                case "VLA1":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA1;
                    break;
                case "VLA2":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA2;
                    break;
                case "VLA3":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA3;
                    break;
                case "VLA4":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA4;
                    break;
                case "VLA5":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA5;
                    break;
                case "VLA6":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA6;
                    break;
                case "VLA7":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA7;
                    break;
                case "VLA8":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA8;
                    break;
                case "VLA9":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLA9;
                    break;
                case "VLAA":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAA;
                    break;
                case "VLAB":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAB;
                    break;
                case "VLAC":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAC;
                    break;
                case "VLAD":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAD;
                    break;
                case "VLAE":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAE;
                    break;
                case "VLAF":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAF;
                    break;
                case "VLAG":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAG;
                    break;
                case "VLAH":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAH;
                    break;
                case "VLAI":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAI;
                    break;
                case "VLAJ":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAJ;
                    break;
                case "VLAK":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAK;
                    break;
                case "VLAL":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAL;
                    break;
                case "VLAM":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAM;
                    break;
                case "VLAN":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAN;
                    break;
                case "VLAO":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAO;
                    break;
                case "VLAP":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAP;
                    break;
                case "VLAQ":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAQ;
                    break;
                case "VLAR":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAR;
                    break;
                case "VLAS":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAS;
                    break;
                case "VLAT":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAT;
                    break;
                case "VLAU":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAU;
                    break;
                case "VLAV":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAV;
                    break;
                case "VLAW":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLAW;
                    break;
                case "VLIF":
                    resultado = ConfigWeb_.AppSettings_.OperacionHubIntegradorVLIF;
                    break;

            }

            return resultado;
        }



        public DataTable ResponseDatatableTrama(string Transaccion, string resString, StringCollection NombreCampos, out bool blnPaginasAdicionales, out string strSiguienteRegistro1, out string strSiguienteRegistro2, out string strSesion)
        {
            DataTable dtlocal = null;
            int contadorColumnas = 0;

            blnPaginasAdicionales = false;
            strSiguienteRegistro1 = "";
            strSiguienteRegistro2 = "";
            strSesion = "";

            string CadenaRespuesta = FormateoCadenaRespuestaJSon(resString);



            switch (Transaccion)
            {
                case "VLA0":
                    //No retorna un datatable.
                    break;
                case "VLA1":
                    VLA1_RootResponse ObjJson1 = new VLA1_RootResponse();
                    ObjJson1 = JsonConvert.DeserializeObject<VLA1_RootResponse>(CadenaRespuesta);
                    if (ObjJson1 == null || ObjJson1.XMLNSC == null)
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    if (ObjJson1.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJson1.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLA2":
                    VLA2_RootResponse ObjJson2 = new VLA2_RootResponse();
                    string flagTipoTabla = CadenaRespuesta.Substring(0, 1);
                    CadenaRespuesta = CadenaRespuesta.Substring(1, CadenaRespuesta.Length - 1);
                    ObjJson2 = JsonConvert.DeserializeObject<VLA2_RootResponse>(CadenaRespuesta);
                    if (ObjJson2.XMLNSC != null)
                    {
                        if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJson2.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                            strSesion = ObjJson2.XMLNSC.integrationResponse.responseHeader.idSesion;
                            strSiguienteRegistro1 = ObjJson2.XMLNSC.integrationResponse.ctaval_sgte;
                            strSiguienteRegistro2 = ObjJson2.XMLNSC.integrationResponse.nume_doc;

                            dtlocal = ConvertToDataTable(ObjJson2.XMLNSC.integrationResponse.listadoDetalle.detalle);
                            if (flagTipoTabla == "0") dtlocal = AddColNomDocTablaVLA2(dtlocal, ObjJson2);
                            else dtlocal = AddColNomDocTablaVLA2_1(dtlocal, ObjJson2);
                        }
                        //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                        //strSesion=ObjJson.XMLNSC.integrationResponse.

                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    break;
                case "VLA3":
                    VLA3_RootResponse ObjJson3 = new VLA3_RootResponse();
                    ObjJson3 = JsonConvert.DeserializeObject<VLA3_RootResponse>(CadenaRespuesta);
                    if (ObjJson3.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJson3.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    dtlocal = AddColNomDocTablaVLA3(dtlocal);
                    if (ObjJson3.XMLNSC.integrationResponse.cod_error_dev == "S") throw new Exception(ObjJson3.XMLNSC.integrationResponse.var1_error);

                    if (ObjJson3.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                    strSesion = ObjJson3.XMLNSC.integrationResponse.responseHeader.idSesion;
                    strSiguienteRegistro1 = ObjJson3.XMLNSC.integrationResponse.sgte_cliente;

                    break;
                case "VLA4":
                    VLA4_RootResponse ObjJson4 = new VLA4_RootResponse();
                    VLA4_ListadoDetalle oVLA4_ListadoDetalle = new VLA4_ListadoDetalle();

                    ObjJson4 = JsonConvert.DeserializeObject<VLA4_RootResponse>(CadenaRespuesta);
                    if (ObjJson4.XMLNSC.integrationResponse.cod_error_dev == "S") throw new Exception(ObjJson4.XMLNSC.integrationResponse.var1_error);
                    oVLA4_ListadoDetalle = ListarDetalleVLA4(ObjJson4);
                    if (oVLA4_ListadoDetalle.detalle.Count > 0) dtlocal = ConvertToDataTable(oVLA4_ListadoDetalle.detalle);

                    break;
                case "VLA5":
                    VLA5_RootResponse ObjJson5 = new VLA5_RootResponse();
                    ObjJson5 = JsonConvert.DeserializeObject<VLA5_RootResponse>(CadenaRespuesta);

                    if (ObjJson5 == null || ObjJson5.XMLNSC == null)
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    if (ObjJson5.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJson5.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLA6":
                    VLA6_RootResponse ObjJson6 = new VLA6_RootResponse();
                    ObjJson6 = JsonConvert.DeserializeObject<VLA6_RootResponse>(CadenaRespuesta);
                    if (ObjJson6 == null || ObjJson6.XMLNSC == null)
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    if (ObjJson6.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJson6.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLA7":
                    VLA7_RootResponse ObjJson7 = new VLA7_RootResponse();
                    ObjJson7 = JsonConvert.DeserializeObject<VLA7_RootResponse>(CadenaRespuesta);
                    //****if (ObjJson7.XMLNSC != null) dtlocal = UtilHI.ConvertToDataTable(ObjJson7.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLA8":
                    VLA8_RootResponse ObjJson8 = new VLA8_RootResponse();
                    ObjJson8 = JsonConvert.DeserializeObject<VLA8_RootResponse>(CadenaRespuesta);
                    //****if (ObjJson8.XMLNSC != null) dtlocal = UtilHI.ConvertToDataTable(ObjJson8.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLA9":
                    //No retorna un datatable.
                    break;
                case "VLAA":
                    VLAA_RootResponse ObjJsonA = new VLAA_RootResponse();
                    ObjJsonA = JsonConvert.DeserializeObject<VLAA_RootResponse>(CadenaRespuesta);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    if (ObjJsonA.XMLNSC != null)
                    {
                        if (ObjJsonA.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonA.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonA.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                            strSiguienteRegistro1 = ObjJsonA.XMLNSC.integrationResponse.cta_valor_sgte;
                            strSiguienteRegistro2 = ObjJsonA.XMLNSC.integrationResponse.nro_orden_sgte;
                            if (ObjJsonA.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonA.XMLNSC.integrationResponse.listadoDetalle.detalle);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    break;
                case "VLAB":
                    //No retorna un datatable.
                    break;
                case "VLAC":
                    //No retorna un datatable.
                    break;
                case "VLAD":
                    VLAD_RootResponse ObjJsonD = new VLAD_RootResponse();
                    ObjJsonD = JsonConvert.DeserializeObject<VLAD_RootResponse>(CadenaRespuesta);
                    if (ObjJsonD == null || ObjJsonD.XMLNSC == null)
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    if (ObjJsonD.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJsonD.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLAE":
                    VLAE_RootResponse ObjJsonE = new VLAE_RootResponse();
                    ObjJsonE = JsonConvert.DeserializeObject<VLAE_RootResponse>(CadenaRespuesta);
                    if (ObjJsonE == null || ObjJsonE.XMLNSC == null)
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    if (ObjJsonE.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJsonE.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLAF":
                    VLAF_RootResponse ObjJsonF = new VLAF_RootResponse();
                    ObjJsonF = JsonConvert.DeserializeObject<VLAF_RootResponse>(CadenaRespuesta);
                    if (ObjJsonF == null || ObjJsonF.XMLNSC == null)
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    if (ObjJsonF.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJsonF.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLAG":
                    //No retorna un datatable.
                    break;
                case "VLAH":
                    VLAH_RootResponse ObjJsonH = new VLAH_RootResponse();
                    ObjJsonH = JsonConvert.DeserializeObject<VLAH_RootResponse>(CadenaRespuesta);
                    if (ObjJsonH == null || ObjJsonH.XMLNSC == null)
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    if (ObjJsonH.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJsonH.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLAI":
                    VLAI_RootResponse ObjJsonI = new VLAI_RootResponse();
                    ObjJsonI = JsonConvert.DeserializeObject<VLAI_RootResponse>(CadenaRespuesta);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    if (ObjJsonI.XMLNSC != null)
                    {
                        if (ObjJsonI.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonI.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonI.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonI.XMLNSC.integrationResponse.listadoDetalle.detalle);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    break;
                case "VLAIF":
                    VLAI_RootResponse ObjJsonIF = new VLAI_RootResponse();
                    ObjJsonIF = JsonConvert.DeserializeObject<VLAI_RootResponse>(CadenaRespuesta);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    if (ObjJsonIF.XMLNSC != null)
                    {
                        if (ObjJsonIF.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonIF.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonIF.XMLNSC.integrationResponse.listadoDetalleF != null)
                                dtlocal = ConvertToDataTable(ObjJsonIF.XMLNSC.integrationResponse.listadoDetalleF.detalleF);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }

                    break;

                case "VLAJ":
                    VLAJ_RootResponse ObjJsonJ = new VLAJ_RootResponse();
                    ObjJsonJ = JsonConvert.DeserializeObject<VLAJ_RootResponse>(CadenaRespuesta);
                    if (ObjJsonJ.XMLNSC != null)
                    {
                        if (ObjJsonJ.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonJ.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonJ.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                            strSiguienteRegistro1 = ObjJsonJ.XMLNSC.integrationResponse.cta_valor_sgte;
                            strSiguienteRegistro2 = ObjJsonJ.XMLNSC.integrationResponse.nro_orden_sgte;
                            strSesion = ObjJsonJ.XMLNSC.integrationResponse.responseHeader.idSesion;

                            if (ObjJsonJ.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonJ.XMLNSC.integrationResponse.listadoDetalle.detalle);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    break;
                case "VLAK":
                    VLAK_RootResponse ObjJsonK = new VLAK_RootResponse();
                    ObjJsonK = JsonConvert.DeserializeObject<VLAK_RootResponse>(CadenaRespuesta);
                    if (ObjJsonK.XMLNSC != null)
                    {
                        if (ObjJsonK.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonK.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonK.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                            strSiguienteRegistro1 = ObjJsonK.XMLNSC.integrationResponse.cta_valor_sgte;
                            strSiguienteRegistro2 = ObjJsonK.XMLNSC.integrationResponse.nro_orden_sgte;
                            strSesion = ObjJsonK.XMLNSC.integrationResponse.responseHeader.idSesion;

                            if (ObjJsonK.XMLNSC.integrationResponse.listadoDetalle != null)
                            {
                                dtlocal = ConvertToDataTable(ObjJsonK.XMLNSC.integrationResponse.listadoDetalle.detalle);
                            }
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }


                    break;
                case "VLAL":
                    VLAL_RootResponse ObjJsonL = new VLAL_RootResponse();
                    ObjJsonL = JsonConvert.DeserializeObject<VLAL_RootResponse>(CadenaRespuesta);
                    if (ObjJsonL.XMLNSC != null)
                    {
                        if (ObjJsonL.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonL.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            strSesion = ObjJsonL.XMLNSC.integrationResponse.responseHeader.idSesion;

                            if (ObjJsonL.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonL.XMLNSC.integrationResponse.listadoDetalle.detalle);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }

                    break;
                case "VLAM":
                    VLAM_RootResponse ObjJsonM = new VLAM_RootResponse();
                    ObjJsonM = JsonConvert.DeserializeObject<VLAM_RootResponse>(CadenaRespuesta);
                    if (ObjJsonM.XMLNSC != null || ObjJsonM != null)
                    {
                        if (ObjJsonM.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonM.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonM.XMLNSC.integrationResponse.listadoDetalle != null)
                            {
                                dtlocal = ConvertToDataTable(ObjJsonM.XMLNSC.integrationResponse.listadoDetalle.detalle);
                                if (ObjJsonM.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                                strSiguienteRegistro1 = ObjJsonM.XMLNSC.integrationResponse.nemotec_sgte;
                                strSesion = ObjJsonM.XMLNSC.integrationResponse.responseHeader.idSesion;
                            }
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }

                    break;
                case "VLAN":
                    VLAN_RootResponse ObjJsonN = new VLAN_RootResponse();
                    ObjJsonN = JsonConvert.DeserializeObject<VLAN_RootResponse>(CadenaRespuesta);
                    if (ObjJsonN.XMLNSC != null)
                    {
                        if (ObjJsonN.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonN.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonN.XMLNSC.integrationResponse.listadoDetalle != null)
                            {
                                dtlocal = ConvertToDataTable(ObjJsonN.XMLNSC.integrationResponse.listadoDetalle.detalle);
                                if (ObjJsonN.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                                strSiguienteRegistro1 = ObjJsonN.XMLNSC.integrationResponse.broker_sgte.ToString();
                                strSesion = ObjJsonN.XMLNSC.integrationResponse.responseHeader.idSesion;
                            }
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    break;
                case "VLAO":
                    VLAO_RootResponse ObjJsonO = new VLAO_RootResponse();
                    ObjJsonO = JsonConvert.DeserializeObject<VLAO_RootResponse>(CadenaRespuesta);
                    if (ObjJsonO.XMLNSC != null)
                    {
                        if (ObjJsonO.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonO.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonO.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonO.XMLNSC.integrationResponse.listadoDetalle.detalle);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }

                    break;
                case "VLAP":
                    VLAP_RootResponse ObjJsonP = new VLAP_RootResponse();
                    ObjJsonP = JsonConvert.DeserializeObject<VLAP_RootResponse>(CadenaRespuesta);
                    if (ObjJsonP.XMLNSC != null)
                    {
                        if (ObjJsonP.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonP.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonP.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonP.XMLNSC.integrationResponse.listadoDetalle.detalle);
                            // Se agrega las columnas en posicion inicial
                            dtlocal = AddColNomDocTablaVLAP(dtlocal, ObjJsonP);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }

                    break;
                case "VLAQ":
                    VLAQ_RootResponse ObjJsonQ = new VLAQ_RootResponse();
                    ObjJsonQ = JsonConvert.DeserializeObject<VLAQ_RootResponse>(CadenaRespuesta);
                    if (ObjJsonQ.XMLNSC != null)
                    {
                        if (ObjJsonQ.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonQ.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonQ.XMLNSC.integrationResponse.listadoDetalle != null)
                            {
                                dtlocal = ConvertToDataTable(ObjJsonQ.XMLNSC.integrationResponse.listadoDetalle.detalle);
                                if (ObjJsonQ.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                                strSiguienteRegistro1 = ObjJsonQ.XMLNSC.integrationResponse.ult_orden.ToString();
                                strSesion = ObjJsonQ.XMLNSC.integrationResponse.responseHeader.idSesion;
                            }
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    break;
                case "VLAR":
                    VLAR_RootResponse ObjJsonR = new VLAR_RootResponse();
                    ObjJsonR = JsonConvert.DeserializeObject<VLAR_RootResponse>(CadenaRespuesta);
                    if (ObjJsonR != null || ObjJsonR.XMLNSC != null)
                    {
                        dtlocal = ConvertToDataTable(ObjJsonR.XMLNSC.integrationResponse.listadodetalle.detalle);
                    }
                    break;
                case "VLAS":
                    VLAS_RootResponse ObjJsonS = new VLAS_RootResponse();
                    ObjJsonS = JsonConvert.DeserializeObject<VLAS_RootResponse>(CadenaRespuesta);
                    if (ObjJsonS.XMLNSC != null)
                    {
                        if (ObjJsonS.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonS.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonS.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                            strSiguienteRegistro1 = ObjJsonS.XMLNSC.integrationResponse.codvalor_sgte;
                            strSiguienteRegistro2 = ObjJsonS.XMLNSC.integrationResponse.precio_sgte;
                            strSesion = ObjJsonS.XMLNSC.integrationResponse.responseHeader.idSesion;

                            if (ObjJsonS.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonS.XMLNSC.integrationResponse.listadoDetalle.detalle);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }

                    break;
                case "VLAT":
                    VLAT_RootResponse ObjJsonT = new VLAT_RootResponse();
                    ObjJsonT = JsonConvert.DeserializeObject<VLAT_RootResponse>(CadenaRespuesta);
                    if (ObjJsonT.XMLNSC != null)
                    {
                        if (ObjJsonT.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonT.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonT.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                            strSiguienteRegistro1 = ObjJsonT.XMLNSC.integrationResponse.orden_sgte;
                            //****strSiguienteRegistro2 = ObjJsonT.XMLNSC.integrationResponse.orden_sgte;
                            strSesion = ObjJsonT.XMLNSC.integrationResponse.responseHeader.idSesion;

                            if (ObjJsonT.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonT.XMLNSC.integrationResponse.listadoDetalle.detalle);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    break;
                case "VLAU":
                    VLAU_RootResponse ObjJsonU = new VLAU_RootResponse();
                    ObjJsonU = JsonConvert.DeserializeObject<VLAU_RootResponse>(CadenaRespuesta);
                    if (ObjJsonU.XMLNSC != null)
                    {
                        if (ObjJsonU.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonU.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonU.XMLNSC.integrationResponse.hay_mas == "S") blnPaginasAdicionales = true;
                            strSiguienteRegistro1 = ObjJsonU.XMLNSC.integrationResponse.cta_valor_sgte;
                            //*** validar strSiguienteRegistro2 = ObjJsonU.XMLNSC.integrationResponse.nro_orden_sgte;
                            strSesion = ObjJsonU.XMLNSC.integrationResponse.responseHeader.idSesion;

                            if (ObjJsonU.XMLNSC.integrationResponse.listadoDetalle != null)
                                dtlocal = ConvertToDataTable(ObjJsonU.XMLNSC.integrationResponse.listadoDetalle.detalle);
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }

                    break;
                case "VLAV":
                    VLAV_RootResponse ObjJsonV = new VLAV_RootResponse();
                    ObjJsonV = JsonConvert.DeserializeObject<VLAV_RootResponse>(CadenaRespuesta);
                    if (ObjJsonV == null || ObjJsonV.XMLNSC == null)
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }
                    if (ObjJsonV.XMLNSC != null) dtlocal = ConvertToDataTable(ObjJsonV.XMLNSC.integrationResponse.listadoDetalle.detalle);
                    //if (ObjJson.XMLNSC.integrationResponse.hay_mas=="S") blnPaginasAdicionales = true;  
                    //strSesion=ObjJson.XMLNSC.integrationResponse.
                    //if (ObjJson2.XMLNSC.integrationResponse.cod_error_dev  == "S")  throw new Exception(ObjJson2.XMLNSC.integrationResponse.var1_error);
                    break;
                case "VLAW":
                    VLAW_RootResponse ObjJsonW = new VLAW_RootResponse();
                    ObjJsonW = JsonConvert.DeserializeObject<VLAW_RootResponse>(CadenaRespuesta);
                    if (ObjJsonW.XMLNSC != null || ObjJsonW != null)
                    {
                        if (ObjJsonW.XMLNSC.integrationResponse.cod_error_dev != "")
                        {
                            throw new Exception(ObjJsonW.XMLNSC.integrationResponse.var1_error);
                        }
                        else
                        {
                            if (ObjJsonW.XMLNSC.integrationResponse.indicador_paginaci == "S") blnPaginasAdicionales = true;
                            strSiguienteRegistro1 = ObjJsonW.XMLNSC.integrationResponse.argumento_busqueda;
                            strSesion = ObjJsonW.XMLNSC.integrationResponse.responseHeader.idSesion;
                            if (ObjJsonW.XMLNSC.integrationResponse.listadoDetalle != null)
                            {
                                dtlocal = ConvertToDataTable(ObjJsonW.XMLNSC.integrationResponse.listadoDetalle.detalle);
                                strSesion = ObjJsonW.XMLNSC.integrationResponse.responseHeader.idSesion;
                            }
                        }
                    }
                    else
                    {
                        Error_RootResponse obj_cadenaerror = new Error_RootResponse();
                        obj_cadenaerror = (Error_RootResponse)ResponseObjectError(CadenaRespuesta);
                        throw new Exception(obj_cadenaerror.integrationResponse.responseHeader.mensajeError);
                    }

                    break;
            }
            if (dtlocal != null)
            {
                foreach (string strNombreColumnas in NombreCampos)
                {
                    dtlocal.Columns[contadorColumnas].ColumnName = strNombreColumnas;
                    contadorColumnas = contadorColumnas + 1;
                }
            }
            return dtlocal;
        }



        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }



        private DataTable AddColNomDocTablaVLAP(DataTable TablaInicial, VLAP_RootResponse ObjVLAlocalP)
        {
            DataTable Tablalocal = new DataTable();

            Tablalocal = TablaInicial;

            Tablalocal.Columns.Add("PrecioContado", typeof(String)).SetOrdinal(0);
            Tablalocal.Columns.Add("MontoOperacionContado", typeof(String)).SetOrdinal(1);
            Tablalocal.Columns.Add("InteresCorridoContado", typeof(String)).SetOrdinal(2);
            Tablalocal.Columns.Add("TotalComisionContado", typeof(String)).SetOrdinal(3);
            Tablalocal.Columns.Add("MontoParcialContado", typeof(String)).SetOrdinal(4);
            Tablalocal.Columns.Add("MontoTotalLiquidacionContado", typeof(String)).SetOrdinal(5);
            Tablalocal.Columns.Add("PrecioPlazo", typeof(String)).SetOrdinal(6);
            Tablalocal.Columns.Add("MontoOperacionPlazo", typeof(String)).SetOrdinal(7);
            Tablalocal.Columns.Add("InteresCorridoPlazo", typeof(String)).SetOrdinal(8);
            Tablalocal.Columns.Add("TotalComisionPlazo", typeof(String)).SetOrdinal(9);
            Tablalocal.Columns.Add("MontoParcialPlazo", typeof(String)).SetOrdinal(10);
            Tablalocal.Columns.Add("MontoTotalLiquidacionPlazo", typeof(String)).SetOrdinal(11);
            Tablalocal.Columns.Add("FechaVencimiento", typeof(String)).SetOrdinal(12);
            Tablalocal.Columns.Add("TipoCambio", typeof(String)).SetOrdinal(13);
            Tablalocal.Columns.Add("TEM", typeof(String)).SetOrdinal(14);
            Tablalocal.Columns.Add("TasaUtilidad", typeof(String)).SetOrdinal(15);
            Tablalocal.Columns.Add("MontoUtilidad", typeof(String)).SetOrdinal(16);

            foreach (DataRow row in Tablalocal.Rows)
            {
                row[0] = ObjVLAlocalP.XMLNSC.integrationResponse.precio_con;
                row[1] = ObjVLAlocalP.XMLNSC.integrationResponse.mtoope_con;
                row[2] = ObjVLAlocalP.XMLNSC.integrationResponse.int_corr_con;
                row[3] = ObjVLAlocalP.XMLNSC.integrationResponse.totcom_con;
                row[4] = ObjVLAlocalP.XMLNSC.integrationResponse.mtopar_con;
                row[5] = ObjVLAlocalP.XMLNSC.integrationResponse.mtot_liq_con;
                row[6] = ObjVLAlocalP.XMLNSC.integrationResponse.precio_plz;
                row[7] = ObjVLAlocalP.XMLNSC.integrationResponse.mtoope_plz;
                row[8] = ObjVLAlocalP.XMLNSC.integrationResponse.int_corr_plz;
                row[9] = ObjVLAlocalP.XMLNSC.integrationResponse.totcom_plz;
                row[10] = ObjVLAlocalP.XMLNSC.integrationResponse.mtopar_plz;
                row[11] = ObjVLAlocalP.XMLNSC.integrationResponse.mtot_liq_plz;
                row[12] = ObjVLAlocalP.XMLNSC.integrationResponse.fecha_vcto;
                row[13] = ObjVLAlocalP.XMLNSC.integrationResponse.tipo_cambio;
                row[14] = ObjVLAlocalP.XMLNSC.integrationResponse.tem;
                row[15] = ObjVLAlocalP.XMLNSC.integrationResponse.tasa_utilidad;
                row[16] = ObjVLAlocalP.XMLNSC.integrationResponse.monto_util;
            }


            return Tablalocal;
        }
        
        private DataTable AddColNomDocTablaVLA2(DataTable TablaInicial, VLA2_RootResponse ObjVLAlocal2)
        {
            DataTable Tablalocal = new DataTable();
            string strMonedaTemporal = "";
            string strCuentaValor = "";

            Tablalocal = TablaInicial;

            Tablalocal.Columns.Add("TipoDocumento", typeof(String)).SetOrdinal(0);
            Tablalocal.Columns.Add("NombreDocumento", typeof(String)).SetOrdinal(1);
            Tablalocal.Columns.Add("NumeroDocumento", typeof(String)).SetOrdinal(2);
            Tablalocal.Columns.Add("NombreRazonSocial", typeof(String)).SetOrdinal(3);

            foreach (DataRow row in Tablalocal.Rows)
            {
                row[0] = ObjVLAlocal2.XMLNSC.integrationResponse.tipo_doc;
                row[1] = RetornaNombreTipoDocumento(ObjVLAlocal2.XMLNSC.integrationResponse.tipo_doc);
                row[2] = ObjVLAlocal2.XMLNSC.integrationResponse.nume_doc;
                row[3] = ObjVLAlocal2.XMLNSC.integrationResponse.cliente;

                strMonedaTemporal = row[4].ToString().Substring(0, 3);
                strCuentaValor = "0011" + row[4].ToString().Substring(3) + " - " + strMonedaTemporal;
                row[4] = strCuentaValor;

                row[6] = row[6] + " - " + row[7];
                row[8] = row[8] + " - " + row[9];

            }


            return Tablalocal;
        }

        private DataTable AddColNomDocTablaVLA2_1(DataTable TablaInicial, VLA2_RootResponse ObjVLAlocal2)
        {
            DataTable Tablalocal = new DataTable();
            string strMonedaTemporal = "";
            string strCuentaValor = "";

            Tablalocal = TablaInicial;

            Tablalocal.Columns.Add("CodigoTipoDocumento", typeof(String)).SetOrdinal(0);
            Tablalocal.Columns.Add("NombreTipoDocumento", typeof(String)).SetOrdinal(1);
            Tablalocal.Columns.Add("NumeroDocumento", typeof(String)).SetOrdinal(2);
            Tablalocal.Columns.Add("Cliente", typeof(String)).SetOrdinal(3);
            Tablalocal.Columns.Add("Direccion", typeof(String)).SetOrdinal(4);
            Tablalocal.Columns.Add("Telefonos1", typeof(String)).SetOrdinal(5);
            Tablalocal.Columns.Add("Telefonos2", typeof(String)).SetOrdinal(6);
            Tablalocal.Columns.Add("Telefonos3", typeof(String)).SetOrdinal(7);
            Tablalocal.Columns.Add("Email", typeof(String)).SetOrdinal(8);
            Tablalocal.Columns.Add("NumCli", typeof(String)).SetOrdinal(9);
            //Tablalocal.Columns.Add("CtaValor", typeof(String)).SetOrdinal(10);

            foreach (DataRow row in Tablalocal.Rows)
            {
                row[0] = ObjVLAlocal2.XMLNSC.integrationResponse.tipo_doc;
                row[1] = RetornaNombreTipoDocumento(ObjVLAlocal2.XMLNSC.integrationResponse.tipo_doc);
                row[2] = ObjVLAlocal2.XMLNSC.integrationResponse.nume_doc;
                row[3] = ObjVLAlocal2.XMLNSC.integrationResponse.cliente;
                row[4] = ObjVLAlocal2.XMLNSC.integrationResponse.direccion;
                row[5] = ObjVLAlocal2.XMLNSC.integrationResponse.telefonos1;
                row[6] = ObjVLAlocal2.XMLNSC.integrationResponse.telefonos2;
                row[7] = ObjVLAlocal2.XMLNSC.integrationResponse.telefonos3;
                row[8] = ObjVLAlocal2.XMLNSC.integrationResponse.email;
                row[9] = ObjVLAlocal2.XMLNSC.integrationResponse.numcli;
                //  row[10] = ObjVLAlocal2.XMLNSC.integrationResponse.ctaval_sgte;

                strMonedaTemporal = row[10].ToString().Substring(0, 3);
                strCuentaValor = "0011" + row[10].ToString().Substring(3) + " - " + strMonedaTemporal;
                row[10] = strCuentaValor;

                row[12] = row[12] + " - " + row[13];
                row[14] = row[14] + " - " + row[15];



            }


            return Tablalocal;
        }

        private DataTable AddColNomDocTablaVLA3(DataTable TablaInicial)
        {
            DataTable Tablalocal;

            Tablalocal = TablaInicial;

            Tablalocal.Columns.Add("NombreDocumento", typeof(String)).SetOrdinal(1);

            foreach (DataRow row in Tablalocal.Rows)
            {
                row[1] = RetornaNombreTipoDocumento(row[0].ToString());
            }

            return Tablalocal;
        }


        public VLA4_ListadoDetalle ListarDetalleVLA4(VLA4_RootResponse ObjJson4)
        {
            VLA4_ListadoDetalle oVLA4_ListadoDetalle = new VLA4_ListadoDetalle();
            oVLA4_ListadoDetalle.detalle = new List<VLA4_DetalleResponse>();
            VLA4_DetalleResponse oVLA4_DetalleResponse;

            if (ObjJson4.XMLNSC.integrationResponse.deta10 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta10.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta10.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta10.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta20 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta20.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta20.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta20.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta30 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta30.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta30.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta30.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta40 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta40.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta40.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta40.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta50 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta50.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta50.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta50.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta60 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta60.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta60.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta60.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta70 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta70.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta70.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta70.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta80 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta80.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta80.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta80.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta90 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta90.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta90.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta90.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta100 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta100.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta100.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta100.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta110 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta110.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta110.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta110.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta120 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta120.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta120.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta120.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta130 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta130.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta130.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta130.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta140 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta140.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta140.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta140.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta150 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta150.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta150.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta150.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta160 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta160.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta160.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta160.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta170 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta170.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta170.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta170.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta180 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta180.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta180.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta180.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta190 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta190.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta190.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta190.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta200 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta200.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta200.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta200.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta210 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta210.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta210.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta210.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta220 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta220.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta220.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta220.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta230 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta230.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta230.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta230.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta240 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta240.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta240.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta240.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta250 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta250.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta250.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta250.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta260 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta260.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta260.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta260.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta270 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta270.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta270.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta270.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta280 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta280.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta280.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta280.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta290 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta290.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta290.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta290.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta300 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta300.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta300.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta300.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta310 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta310.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta310.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta310.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta320 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta320.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta320.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta320.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta330 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta330.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta330.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta330.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta340 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta340.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta340.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta340.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta350 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta350.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta350.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta350.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta360 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta360.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta360.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta360.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta370 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta370.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta370.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta370.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta380 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta380.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta380.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta380.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta390 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta390.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta390.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta390.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            if (ObjJson4.XMLNSC.integrationResponse.deta400 != String.Empty)
            {
                oVLA4_DetalleResponse = new VLA4_DetalleResponse();
                oVLA4_DetalleResponse.transaccion_s = ObjJson4.XMLNSC.integrationResponse.deta400.Substring(0, 4).ToString();
                oVLA4_DetalleResponse.tecla_s = ObjJson4.XMLNSC.integrationResponse.deta400.Substring(4, 2).ToString();
                oVLA4_DetalleResponse.facultad = ObjJson4.XMLNSC.integrationResponse.deta400.Substring(6, 1).ToString();
                oVLA4_ListadoDetalle.detalle.Add(oVLA4_DetalleResponse);
            }

            return oVLA4_ListadoDetalle;
        }


        public object ResponseObjectError(string resString)
        {
            object ObjectReturn = null;
            Error_RootResponse obj_Error = new Error_RootResponse();
            obj_Error = JsonConvert.DeserializeObject<Error_RootResponse>(resString);

            ObjectReturn = obj_Error;

            return ObjectReturn;
        }



        public  string RetornaNombreTipoDocumento(string strCodigo)
        {
            switch (strCodigo)
            {
                case "A": return "Nombre/Razón Social";

                case "D": return "Carné  Diplomático";

                case "E": return "Carné Extranjeria";

                case "L": return "D.N.I";

                case "M": return "Carné de Identificación Militar";

                case "P": return "Pasaporte";

                case "R": return "R.U.C";

                case "T": return "Carné de Fuerzas Policiales";

                case "U": return "R.U.S";
                case "W": return "R.U.T";


                default: return " ";

            }
        }



        public string resString = null;

        public object ResponseObjectTrama(string Transaccion, string resString)
        {
            object ObjectReturn = null;
            string CadenaRespuesta = new Utility().FormateoCadenaRespuestaJSon(resString);

            if (Transaccion == "VLIF")
            {
                CadenaRespuesta = resString;
            }

            switch (Transaccion)
            {
                case "VLA0":
                    VLA0_RootResponse ObjJson0 = new VLA0_RootResponse();
                    ObjJson0 = JsonConvert.DeserializeObject<VLA0_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJson0;
                    break;
                case "VLA1":
                    VLA1_RootResponse ObjJson1 = new VLA1_RootResponse();
                    ObjJson1 = JsonConvert.DeserializeObject<VLA1_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJson1;
                    break;
                case "VLA2":
                    break;
                case "VLA3":
                    break;
                case "VLA4":
                    VLA4_RootResponse ObjJson4 = new VLA4_RootResponse();
                    ObjJson4 = JsonConvert.DeserializeObject<VLA4_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJson4;
                    break;
                case "VLA5":
                    break;
                case "VLA6":
                    break;
                case "VLA7":
                    VLA7_RootResponse ObjJson7 = new VLA7_RootResponse();
                    ObjJson7 = JsonConvert.DeserializeObject<VLA7_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJson7;
                    break;
                case "VLA8":
                    VLA8_RootResponse ObjJson8 = new VLA8_RootResponse();
                    ObjJson8 = JsonConvert.DeserializeObject<VLA8_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJson8;
                    break;
                case "VLA9":
                    VLA9_RootResponse ObjJson9 = new VLA9_RootResponse();
                    ObjJson9 = JsonConvert.DeserializeObject<VLA9_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJson9;
                    break;
                case "VLAA":
                    break;
                case "VLAB":
                    VLAB_RootResponse ObjJsonB = new VLAB_RootResponse();
                    ObjJsonB = JsonConvert.DeserializeObject<VLAB_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJsonB;
                    break;
                case "VLAC":
                    VLAC_RootResponse ObjJsonC = new VLAC_RootResponse();
                    ObjJsonC = JsonConvert.DeserializeObject<VLAC_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJsonC;
                    break;
                case "VLAD":
                    break;
                case "VLAE":
                    break;
                case "VLAF":
                    break;
                case "VLAG":
                    VLAG_RootResponse ObjJsonG = new VLAG_RootResponse();
                    ObjJsonG = JsonConvert.DeserializeObject<VLAG_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJsonG;
                    break;
                case "VLAH":
                    VLAH_RootResponse ObjJsonH = new VLAH_RootResponse();
                    ObjJsonH = JsonConvert.DeserializeObject<VLAH_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJsonH;
                    break;
                case "VLAI":
                    VLAI_RootResponse ObjJsonI = new VLAI_RootResponse();
                    ObjJsonI = JsonConvert.DeserializeObject<VLAI_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJsonI;
                    break;
                case "VLAJ":
                    break;
                case "VLAK":
                    break;
                case "VLAL":
                    VLAL_RootResponse ObjJsonL = new VLAL_RootResponse();
                    ObjJsonL = JsonConvert.DeserializeObject<VLAL_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJsonL;
                    break;
                case "VLAM":
                    break;
                case "VLAN":
                    break;
                case "VLAO":
                    break;
                case "VLAP":
                    break;
                case "VLAQ":
                    break;
                case "VLAR":
                    VLAR_RootResponse ObjJsonR = new VLAR_RootResponse();
                    ObjJsonR = JsonConvert.DeserializeObject<VLAR_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJsonR;
                    break;
                case "VLAS":
                    break;
                case "VLAT":
                    break;
                case "VLAU":
                    break;
                case "VLAV":
                    break;
                case "VLAW":
                    VLAW_RootResponse ObjJsonW = new VLAW_RootResponse();
                    ObjJsonW = JsonConvert.DeserializeObject<VLAW_RootResponse>(CadenaRespuesta);
                    ObjectReturn = ObjJsonW;
                    break;
                case "VLIF":
                    VLIF_RootResponse objJsonIF = new VLIF_RootResponse();
                    objJsonIF = JsonConvert.DeserializeObject<VLIF_RootResponse>(CadenaRespuesta);
                    break;
            }

            return ObjectReturn;
        }



        public string UrlHubIntegrador(ConfigWeb ConfigWeb_, string Transaccion)
        {
            string UrlReturn = this.ServidorHI(ConfigWeb_) + this.RetornaServicioHubIntegrador(ConfigWeb_, Transaccion).ToLower();

            return UrlReturn;
        }



        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..

        public DataTable RetornaDataTable_Trama(string strCadenaDevuelta, StringCollection NombreCampos, out bool blnPaginasAdicionales, out string strSiguienteRegistro, out string strSesion)
        {
            string[] Campos = null;
            DataTable dtTabla;
            string[] Filas;
            string[] Columnas;
            DataRow drwFila;
            int i = 0;
            int j = 0;
            if (strCadenaDevuelta == null || strCadenaDevuelta.Trim() == "")
            {
                throw new Exception(Constantes.MENSAJE_CADENA_DEVUELTA_VACIA);

            }
            Campos = strCadenaDevuelta.Split(Constantes.CARACTER_SEPARADOR);
            if (Campos.GetLength(0) == 1)
            {
                throw new Exception(Campos[0]);
            }
            strSesion = Campos[0];
            if (Campos[1] == "S")
            {
                //Hubo Error
                throw new Exception(Campos[2]);

            }
            //Creamos el DataTable con sus columnas
            dtTabla = new DataTable();
            foreach (string strNombreColumnas in NombreCampos)
            {
                dtTabla.Columns.Add(strNombreColumnas);
            }
            //Ahora Procesamos la data
            Filas = Campos[3].Split(Constantes.CARACTER_SEPARADOR_FILAS);
            if (Campos[4] == "S")
            {
                blnPaginasAdicionales = true;
            }
            else
            {
                blnPaginasAdicionales = false;
            }
            strSiguienteRegistro = Campos[5];
            foreach (string strFila in Filas)
            {
                drwFila = dtTabla.NewRow();
                Columnas = strFila.Split(Constantes.CARACTER_SEPARADOR_COLUMNAS);
                j = 0;
                foreach (string strColumna in Columnas)
                {
                    drwFila[j] = strColumna;
                    j++;
                }
                dtTabla.Rows.Add(drwFila);
            }
            return dtTabla;
        }



        //::::::::::::::::::::

        public string mErrorParse(string sTAG,string StackTrace, string Message)
        {
            string sError = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", sTAG, StackTrace, Message);
            sError = Regex.Replace(sError, @"[^0-9A-Za-z]", " ", RegexOptions.None);
            sError = Regex.Replace(sError, @"[^\w\.@-]", " ", RegexOptions.None);
            sError = sError.Replace("'", "");
            return sError;
        }



        public DataTable EliminarRepetidos(bool blnOrdenarCampos, string strCampo1, string strCampo2, DataTable dtTablaOriginal)
        {
            DataTable dtTablaDestino = null;
            if (dtTablaOriginal != null)
            {
                if (blnOrdenarCampos)
                {
                    DataView dv = dtTablaOriginal.DefaultView;
                    dv.Sort = strCampo1 + "," + strCampo2;
                    dtTablaOriginal = dv.ToTable();
                }
                dtTablaDestino = new DataTable();
                foreach (DataColumn dc in dtTablaOriginal.Columns)
                { dtTablaDestino.Columns.Add(dc.ColumnName); }
                string strValorCampo1 = "";
                string strValorCampo2 = "";
                if (dtTablaOriginal.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtTablaOriginal.Rows)
                    {
                        if ((strValorCampo1 != Convert.ToString(dr[strCampo1])) || (strValorCampo2 != Convert.ToString(dr[strCampo2])))
                        {
                            strValorCampo1 = Convert.ToString(dr[strCampo1]);
                            strValorCampo2 = Convert.ToString(dr[strCampo2]);
                            dtTablaDestino.ImportRow(dr);
                        }
                    }
                }
            }
            return dtTablaDestino;
        }


        public string FormatoDecimales(string valor)
        {
            if (valor.Trim() == string.Empty)
            { return ""; }
            if (!valor.Contains("."))
            { return valor.Trim() + "0000"; }
            string decimales = (valor.Substring(valor.LastIndexOf(".")) + "00000");
            return valor.Substring(0, valor.LastIndexOf(".")) + decimales.Substring(1, 4);
        }


        public string FormatoMoneda(double numero, int numeroDecimales, string simbolo)
        {
            System.Globalization.NumberFormatInfo nfi = new System.Globalization.NumberFormatInfo();
            nfi.CurrencyDecimalDigits = numeroDecimales;
            nfi.CurrencyDecimalSeparator = ".";
            nfi.CurrencyGroupSeparator = ",";
            nfi.CurrencySymbol = simbolo;
            // 0 -> $n, 2 -> $ n
            nfi.CurrencyPositivePattern = 2;
            // 0 -> ($n), 1 -> -$n
            nfi.CurrencyNegativePattern = 0;

            return numero.ToString("C", nfi);
        }

    }



    // class ConfigWeb
    //{
    //    public string Url_WeAdmin { get; set; }
    //    public string Url_WebApi { get; set; }
    //    public  ConnectionStringsX ConnectionStrings_ { get; set; }
    //    public AppSettings AppSettings_ { get; set; }

    //}


    //  class AppSettings
    //{

    //    public bool CrystalImageCleaner_AutoStart { get; set; }
    //    public int CrystalImageCleaner_Sleep { get; set; }
    //    public int CrystalImageCleaner_Age { get; set; }
    //    public string ServidorCorreo { get; set; }
    //    public int PuertoCorreo { get; set; }
    //    public string CorreoRemitente { get; set; }
    //    public string CorreoDestinatarioTemporal { get; set; }
    //    public int FechasPorCliente { get; set; }
    //    public int FechasDelDia { get; set; }
    //    public string Ambiente_Desarrollo { get; set; }
    //    public int IdentificadorComisionSABSimulador { get; set; }
    //    public int IdCorreoPolizas { get; set; }
    //    public int IdCorreoPrePolizas { get; set; }
    //    public int IdCorreoOperacionesDiarias { get; set; }
    //    public int IdCorreoSimuladorReporte { get; set; }
    //    public int IdCorreoCuentaEfectivo { get; set; }
    //    public int SetCountNemonicos { get; set; }


    //    public string ServidorHI { get; set; }

    //    public string idServicioHeader { get; set; }
    //    public string codigoAplicacionHeader { get; set; }
    //    public string v { get; set; }
    //    public string idInterconexionHeader { get; set; }
    //    public string codigoEmpresa { get; set; }
    //    public string codigoTerminalEmpresa { get; set; }
    //    public string canal { get; set; }
    //    public string idPeticionBanco { get; set; }

    //    public string OperacionHubIntegradorVLA0 { get; set; }
    //    public string OperacionHubIntegradorVLA1 { get; set; }
    //    public string OperacionHubIntegradorVLA2 { get; set; }
    //    public string OperacionHubIntegradorVLA3 { get; set; }
    //    public string OperacionHubIntegradorVLA4 { get; set; }
    //    public string OperacionHubIntegradorVLA5 { get; set; }
    //    public string OperacionHubIntegradorVLA6 { get; set; }
    //    public string OperacionHubIntegradorVLA7 { get; set; }
    //    public string OperacionHubIntegradorVLA8 { get; set; }
    //    public string OperacionHubIntegradorVLA9 { get; set; }
    //    public string OperacionHubIntegradorVLAA { get; set; }
    //    public string OperacionHubIntegradorVLAB { get; set; }
    //    public string OperacionHubIntegradorVLAC { get; set; }
    //    public string OperacionHubIntegradorVLAD { get; set; }
    //    public string OperacionHubIntegradorVLAE { get; set; }
    //    public string OperacionHubIntegradorVLAF { get; set; }
    //    public string OperacionHubIntegradorVLAG { get; set; }
    //    public string OperacionHubIntegradorVLAH { get; set; }
    //    public string OperacionHubIntegradorVLAI { get; set; }
    //    public string OperacionHubIntegradorVLAJ { get; set; }
    //    public string OperacionHubIntegradorVLAK { get; set; }
    //    public string OperacionHubIntegradorVLAL { get; set; }
    //    public string OperacionHubIntegradorVLAM { get; set; }
    //    public string OperacionHubIntegradorVLAN { get; set; }
    //    public string OperacionHubIntegradorVLAO { get; set; }
    //    public string OperacionHubIntegradorVLAP { get; set; }
    //    public string OperacionHubIntegradorVLAQ { get; set; }
    //    public string OperacionHubIntegradorVLAR { get; set; }
    //    public string OperacionHubIntegradorVLAS { get; set; }
    //    public string OperacionHubIntegradorVLAT { get; set; }
    //    public string OperacionHubIntegradorVLAU { get; set; }
    //    public string OperacionHubIntegradorVLAV { get; set; }
    //    public string OperacionHubIntegradorVLAW { get; set; }
    //    public string OperacionHubIntegradorVLIF { get; set; }


    //}

    // class ConnectionStringsX
    //{
    //    public string connectionString_SQL_TEST { get; set; }
    //    public string connectionString_SQL_CALIDAD { get; set; }
    //    public string connectionString_SQL_PROD { get; set; }

    //}


}
