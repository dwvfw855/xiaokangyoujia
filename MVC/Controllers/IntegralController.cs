﻿using System;
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


        public IActionResult ShopDetail(string guid) {



            Mk.Chain.Core.Models.shop_detail sp= _IShop_DetailServices.GetShop_Detail(guid);


            return View(sp);

        }




        public IActionResult InsertOrdertest()
        {

            shop_orderlist shopOrderList = new shop_orderlist();
            shopOrderList.CeateTime = DateTime.Now.ToString();
            shopOrderList.GUID = Guid.NewGuid().ToString("N");
            shopOrderList.OrderImgUrl = "images/jifen/sp.png";
            shopOrderList.ShopMoney = "100";
            shopOrderList.ShopType = "3";
            shopOrderList.ShopName = "测试商品";
            _Ishop_orderlistServices.insert(shopOrderList);





            return Ok("1");
        }



        //public IActionResult Detail(string ID)
        //{

             

        //}



    }
}