using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace Mk.Chain.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("any")]
    public class ValuesController : ControllerBase
    {
        //private readonly IChargeLogsServices _ChargeLogsServices;

        //private readonly ITaskServices _TaskServices;
        
        public ValuesController()
        {
           // _FILESServices = FILESServices;


        }
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            shop sp = new shop() { logo= "/static/img/life-index-logo.png", title= "极物商城" };
            shopBanner[] spList =new shopBanner[2];
            spList[0] = new shopBanner() { url= "javascript:", title= "送你一辆车", img= "/static/img/article-head.jpg" };
            spList[1] = new shopBanner() { url = "javascript:", title = "送你一辆车", img = "/static/img/article-head.jpg" };
            shopCat[] spcat = new shopCat[12];
            spcat[0] = new shopCat() { id = "chaju", text = "茶具", img = "/static/img/chaju.png" };
            spcat[1] = new shopCat() { id = "jiuju", text = "酒具", img = "/static/img/jiuju.png" };
            spcat[2] = new shopCat() { id = "chuanping", text = "床品", img = "/static/img/chuanping.png" };
            spcat[3] = new shopCat() { id = "huaqi", text = "花器", img = "/static/img/huaqi.png" };
            spcat[4] = new shopCat() { id = "canju", text = "餐具", img = "/static/img/canju.png" };
            spcat[5] = new shopCat() { id = "baoxiang", text = "包箱", img = "/static/img/baoxiang.png" };
            spcat[6] = new shopCat() { id = "jujia", text = "居家", img = "/static/img/jujia.png" };
            spcat[7] = new shopCat() { id = "ruanzhuan", text = "软装", img = "/static/img/ruanzhuan.png" };
            spcat[8] = new shopCat() { id = "shiping", text = "食品", img = "/static/img/shiping.png" };
            spcat[9] = new shopCat() { id = "wenju", text = "文具", img = "/static/img/wenju.png" };
            spcat[10] = new shopCat() { id = "xihu", text = "洗护", img = "/static/img/xihu.png" };
            spcat[11] = new shopCat() { id = "quanbu", text = "全部", img = "/static/img/quanbu.png" };

            floor1[] fl = new floor1[7];
            fl[0] = new floor1() { id = "a", img = "/static/img/article-default.png", title = "发现生活中的美" };
            fl[1] = new floor1() { id = "b", img = "/static/img/article-default.png", title = "发现生活中的美" };
            fl[2] = new floor1() { id = "c", img = "/static/img/article-default.png", title = "发现生活中的美" };
            fl[3] = new floor1() { id = "D", img = "/static/img/article-default.png", title = "发现生活中的美" };
            fl[4] = new floor1() { id = "E", img = "/static/img/article-default.png", title = "发现生活中的美" };
            fl[5] = new floor1() { id = "F", img = "/static/img/article-default.png", title = "发现生活中的美" };
            fl[6] = new floor1() { id = "G", img = "/static/img/article-default.png", title = "发现生活中的美" };

            recommendGoods[] rec = new recommendGoods[4];
            rec[0] = new recommendGoods() { id = "a", img = "/static/img/article-default.png", title = "发现生活中的美", price =998.00  };
            rec[1] = new recommendGoods() { id = "b", img = "/static/img/article-default.png", title = "发现生活中的美", price = 998.00 };
            rec[2] = new recommendGoods() { id = "c", img = "/static/img/article-default.png", title = "发现生活中的美", price = 998.00 };
            rec[3] = new recommendGoods() { id = "d", img = "/static/img/article-default.png", title = "发现生活中的美", price = 998.00 };




            JsonResult js = new JsonResult(new { shop = sp, shopBanner = spList , shopCat =spcat, floor1 =fl, recommendGoods = rec });


            return js;

            // List<ChargeLogs>   List= _ChargeLogsServices.Getlist();
           
        



        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
