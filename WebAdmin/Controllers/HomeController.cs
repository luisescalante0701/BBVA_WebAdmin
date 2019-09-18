using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        //private IOptions<ConfigWeb> appSettings;
        IConfiguration _myConfiguration;
      
        public HomeController(IConfiguration myConfiguration)
        {
            _myConfiguration = myConfiguration;
        }

        public IActionResult Index()
        {
            //string conString = Microsoft
            //.Extensions
            //.Configuration
            //.ConfigurationExtensions
            //.GetConnectionString(_myConfiguration, "Connection_SQL");

            //var ConfigWeb_ = new ConfigWeb();
            //_myConfiguration.GetSection("ConfigWeb").Bind(ConfigWeb_);
            ////ConfigWeb a = ConfigWeb_;

            //var AppSetting_ = new AppSetting();
            //_myConfiguration.GetSection("AppSetting").Bind(AppSetting_);
            //AppSetting ax = AppSetting_;

            TempData["_Layout_Usuario"] = "Usuario nombre";
            TempData["Controller"] = "Home";
            TempData["Action"] = "Index";
            TempData["PaginaDescripcion"] = "Pagina inicial";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
