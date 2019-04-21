using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ShoppingController : Controller
    {
        /// <summary>
        /// 购物车
        /// </summary>
        /// <returns></returns>
        public IActionResult Cart()
        {
            return View();
        }
        /// <summary>
        /// 购买
        /// </summary>
        /// <returns></returns>
        public IActionResult orderSrue()
        {


            return View();

        }


        public IActionResult success()
        {




            return View();
        }


    }
}