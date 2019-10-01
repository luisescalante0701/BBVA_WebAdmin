using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Entity;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebAdmin.Controllers
{
    public class ConsultasController : Controller
    {

        int iCode_Error_Controller = Constantes.iCode_Error_Controller;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR EN CONTROLLER

        string sTAG = "ConsultasController";


        IConfiguration _myConfiguration;
        ConfigWeb ConfigWeb_;
        private readonly IConnectHttpClient IConnectHttpClient_;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public ConsultasController(IConfiguration myConfiguration, IConnectHttpClient _IConnectHttpClient_)
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

            // GET: Consultas
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


        public ActionResult ConsultaCliente()
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
                TempData["Controller"] = "Consultas";
                TempData["Action"] = "ConsultaCliente";
                TempData["PaginaDescripcion"] = "Relación Clientes";

                TempData.Keep("LoginUser");

            }

            CorreoBO _correoBO = new CorreoBO();
            Correo _correo = _correoBO.SeleccionarCorreo(Convert.ToInt32(Util.LeerConfig("IdCorreoOperacionesDiarias")));
            StringBuilder _sbMensaje = new StringBuilder();
            _sbMensaje.Append("Estimado(a) Sr(a)(ta): " + Uc_DatosPersonalesCliente1.Nombre);
            _sbMensaje.Append("\n");
            _sbMensaje.Append(_correo.Detalle[0].Mensaje1);
            txtMensaje.Text = _sbMensaje.ToString().Replace("<br />", "\n");

        }




        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.


        // GET: Consultas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Consultas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultas/Create
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

        // GET: Consultas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Consultas/Edit/5
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

        // GET: Consultas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Consultas/Delete/5
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