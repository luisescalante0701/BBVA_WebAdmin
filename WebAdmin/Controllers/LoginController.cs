using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Common;

using WebAdmin.Models;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Net;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Entity;
using System.Data;
//using Entity;

namespace WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        int iCode_Error_Controller = Constantes.iCode_Error_Controller;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR EN CONTROLLER

        string sTAG = "LoginController";

        IConfiguration _myConfiguration;
        ConfigWeb ConfigWeb_;
        IHttpContextAccessor _httpContextAccessor;

        public LoginController(IConfiguration myConfiguration
            //, IHttpContextAccessor httpContextAccessor
            )
        {
            //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            _myConfiguration = myConfiguration;
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



        // GET: Login
        public ActionResult Index()
        {
            //  AppSetting_ = new AppSettings();
            //  _myConfiguration.GetSection("AppSettings").Bind(AppSetting_);
            //this.HttpContext.Session.SetString("", "");// = "";

            //var conn1 = ConfigurationManager.ConnectionStrings["Url_WebApi"].ConnectionString;

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


        public string GetCookie(string key)
        {
            return Request.Cookies[key];
        }

        public void SetCookie(string key, string value, double? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(1);
            Response.Cookies.Append(key, value, option);
        }

        public void RemoveCookie(string key)
        {
            Response.Cookies.Delete(key);
        }


        [HttpPost]
        public object mLogin(string sUsuario, string sPassword)
        {
            object objResult = null;
            Model modeloRpta = new Model();

            try
            {
                /*
                LoginUser modLogin = new LoginUser();
                modLogin.sUsuario = "luis";
                modLogin.sPassword = "1234";
                modLogin.SessionId = "00001";
                */

                Model modelo = new Login().mLogin(ConfigWeb_, sUsuario, sPassword);
                //   Model modelo = new Model();//.mLogin(ConfigWeb_, sUsuario, sPassword);
                modeloRpta.bEstado = modelo.bEstado;
                modeloRpta.iCodigo = modelo.iCodigo;
                modeloRpta.sRpta = modelo.sRpta;
                // modeloRpta.obj = "ok";

                if (modeloRpta.bEstado)
                {
                    TempData["LoginUser"] = modelo.obj;// JsonConvert.SerializeObject(modLogin) ;
                }
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Controller;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message); ;
                modeloRpta.obj = null;
            }

            // modeloRpta.obj = "1";
            objResult = JsonConvert.SerializeObject(modeloRpta);

            return Json(objResult);
        }




        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.


        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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