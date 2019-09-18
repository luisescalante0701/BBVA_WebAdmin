using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Common;
using Entity;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
    public class OrdenesController : Controller
    {
        int iCode_Error_Controller = Constantes.iCode_Error_Controller;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR EN CONTROLLER

        string sTAG = "OrdenesController";
   

        IConfiguration _myConfiguration;
        ConfigWeb ConfigWeb_;
        private readonly IConnectHttpClient IConnectHttpClient_;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public OrdenesController(IConfiguration myConfiguration, IConnectHttpClient _IConnectHttpClient_)
        {
            //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            _myConfiguration = myConfiguration;

            IConnectHttpClient_ = _IConnectHttpClient_;

          //  _httpContextAccessor = httpContextAccessor;
            //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

            ConfigWeb_ = new ConfigWeb();

            _myConfiguration.GetSection("ConfigWeb").Bind(ConfigWeb_);

            ConnectionStringsX ConnectionStrings_ = new ConnectionStringsX();
            _myConfiguration.GetSection("ConnectionStringsX").Bind(ConnectionStrings_);
            ConfigWeb_.ConnectionStrings_ = ConnectionStrings_;

            AppSettings AppSettings_ = new AppSettings();
            _myConfiguration.GetSection("AppSettings").Bind(AppSettings_);
            ConfigWeb_.AppSettings_ = AppSettings_;

        }



        // GET: Ordenes
        public ActionResult Index()
        {

            TempData["Url_WebAdmin"] = ConfigWeb_.Url_WebAdmin;
            TempData["Url_WebApi"] = ConfigWeb_.Url_WebApi;

            string sUrl_WeAdmin = "", sUrl_WebApi = "";
            if (TempData.ContainsKey("Url_WebAdmin"))
                sUrl_WeAdmin = TempData["Url_WebAdmin"].ToString();
            if (TempData.ContainsKey("Url_WebApi"))
                sUrl_WebApi = TempData["Url_WebApi"].ToString();


            ViewBag.sUrlWebApi = sUrl_WeAdmin;


            return View();
        }
        // GET: Ordenes
        public ActionResult CompraVenta()
        {
            try
            {

                TempData["Url_WebAdmin"] = ConfigWeb_.Url_WebAdmin;
                TempData["Url_WebApi"] = ConfigWeb_.Url_WebApi;

                string sUrl_WeAdmin = "", sUrl_WebApi = "";
                if (TempData.ContainsKey("Url_WebAdmin"))
                    sUrl_WeAdmin = TempData["Url_WebAdmin"].ToString();
                if (TempData.ContainsKey("Url_WebApi"))
                    sUrl_WebApi = TempData["Url_WebApi"].ToString();

                ViewBag.sUrlWebApi = sUrl_WeAdmin;

                // string sLayoutUsuario = modLogin.sNombres;
                TempData["_Layout_Usuario"] = "Usuario nombre";
                TempData["Controller"] = "Ordenes";
                TempData["Action"] = "CompraVenta";
                TempData["PaginaDescripcion"] = "Relación de Ordenes";

                TempData.Keep("LoginUser");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        [HttpPost]
        public async Task<object> mGetCriterio()
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                //  modeloRpta = new Login().mLogin(sUsuario, sPassword);
                   modeloRpta = await new Ordenes().mGetCriterio(this.ConfigWeb_,this.IConnectHttpClient_);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message); 
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }

        [HttpPost]
        public async Task<object> mGetTipoNegociacion(int iCodigoOpcion)
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                //  modeloRpta = new Login().mLogin(sUsuario, sPassword);
                modeloRpta = await new Ordenes().mGetTipoNegociacion(this.ConfigWeb_, this.IConnectHttpClient_, iCodigoOpcion);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }

        [HttpPost]
        public async Task<object> mGetTipoOrden(int iCodigoOpcion)
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                modeloRpta = await new Ordenes().mGetTipoOrden(this.ConfigWeb_, this.IConnectHttpClient_, iCodigoOpcion);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }

        [HttpPost]
        public async Task<object> mGetOrden(int iCodigoOpcion)
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                modeloRpta = await new Ordenes().mGetOrden(this.ConfigWeb_, this.IConnectHttpClient_, iCodigoOpcion);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }

        public async Task<object> mGetTipoComision()
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                modeloRpta = await new Ordenes().mGetTipoComision(this.ConfigWeb_, this.IConnectHttpClient_);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }

        public async Task<object> mGetTipoPrecio()
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                modeloRpta = await new Ordenes().mGetTipoPrecio(this.ConfigWeb_, this.IConnectHttpClient_);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }

        public async Task<object> mGetMoneda()
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                modeloRpta = await new Ordenes().mGetMoneda(this.ConfigWeb_, this.IConnectHttpClient_);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }



        [HttpPost]
        public object mSearchInfo(string sTypeSearch, string sValSearch)
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                object obLoginUser = TempData["LoginUser"];
                TempData.Keep("LoginUser");

                string sJson = obLoginUser.ToString();               
                LoginUser modLoin = JsonConvert.DeserializeObject<LoginUser>(sJson);

                modeloRpta = new Ordenes().mSearchInfo(this.ConfigWeb_, sTypeSearch, sValSearch, modLoin);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller; 
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        } 

        [HttpPost]
        public object mGuardarCompraVenta(
            string sTipoOrden, string sTipoNegociacion, string sNemonico, string sISN,
            string sNumeroTitulos, string sValorPrecio, string sDiasVigencia, string sMoneda,
            string sTipoCambio, string sOtra, string sCuentaAbono, bool bRetencion, bool bFirma,
            string sObservaciones, string sRepresentante, string sCuentaValor, string sOptionRadio,
            string sOrden, string sTipoComision, string sComision)
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                object obLoginUser = TempData["LoginUser"];
                TempData.Keep("LoginUser");

                string sJson = obLoginUser.ToString();
                LoginUser modLoin = JsonConvert.DeserializeObject<LoginUser>(sJson);

                modeloRpta = new Ordenes().mGuardarCompraVenta(this.ConfigWeb_,
             sTipoOrden, sTipoNegociacion, sNemonico, sISN,
             sNumeroTitulos, sValorPrecio, sDiasVigencia, sMoneda,
             sTipoCambio, sOtra, sCuentaAbono, bRetencion, bFirma,
             sObservaciones, sRepresentante, sCuentaValor, sOptionRadio,
             sOrden, sTipoComision, sComision,
             modLoin);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }













        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::



        // GET: Ordenes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ordenes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ordenes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ordenes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ordenes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ordenes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ordenes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}