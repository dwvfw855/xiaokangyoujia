﻿using System;
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

        private readonly Imodule_homechildrenServices _module_homechildrenServices;

        public HomeController(Imodule_mainServices module_mainServicesServices, Imodule_homechildrenServices module_homechildrenServices)
        {
            _module_mainServicesServices = module_mainServicesServices;
            _module_homechildrenServices= module_homechildrenServices;
        }
        public  async Task<IActionResult> Index()
        {
            //获取主菜单
             List<module_main> List =   await _module_mainServicesServices.Query();
            ViewBag.Homelist = List;
            //获取首页下的功能菜单
            List<module_homechildren> childrenList = _module_homechildrenServices.Query();
            ViewBag.childrenList = childrenList;




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
