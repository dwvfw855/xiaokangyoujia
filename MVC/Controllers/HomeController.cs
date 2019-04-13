using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Imodule_mainServices _module_mainServicesServices;

        public HomeController(Imodule_mainServices module_mainServicesServices)
        {
            _module_mainServicesServices = module_mainServicesServices;
        }
        public  IActionResult Index()
        {
             List<module_main> List =   _module_mainServicesServices.Query();

            ViewBag.list = List;
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
