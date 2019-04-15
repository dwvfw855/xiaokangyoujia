using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace MVC.Controllers
{
    public class IntegralController : Controller
    {
        private readonly IShop_DetailServices _IShop_DetailServices;

        private readonly Ishop_orderlistServices _Ishop_orderlistServices;
        private readonly Ishop_typeServices _Ishop_typeServices;
        public IntegralController(IShop_DetailServices IShop_DetailServices, Ishop_orderlistServices Ishop_orderlistServices, Ishop_typeServices Ishop_typeServices)
        {
            _IShop_DetailServices = IShop_DetailServices;
            _Ishop_orderlistServices = Ishop_orderlistServices;
            _Ishop_typeServices = Ishop_typeServices;
        }
        public IActionResult MainShop(int pageindex,int pageSize,string type)
        {
            pageindex = 1;
            pageSize = 10;
            type = "1";

         List<shop_orderlist>   orderList= _Ishop_orderlistServices.Query(pageindex, pageSize, type);
            
            ViewBag.OrderList = orderList;
           

            return View();
        }
    }
}