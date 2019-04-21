using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace Mk.Chain.Core.Repository.SqlServer
{
    public class shop_orderlistRepository : BaseRepository<shop_orderlist>, Ishop_orderlistRepository
    {


        public shop_orderlistRepository():base(1)
        {

        }
        public int insert(shop_orderlist sp)
        {
            return Db.Insertable<shop_orderlist>(sp).ExecuteCommand();
        }

        public  List<shop_orderlist> Query(int pageindex, int pageSize, string type)
        {
            //缓存
            List<shop_orderlist> List = null;

            if (Redis.StringGet("shop_orderlist") ==null)
            {
                List= Db.Queryable<shop_orderlist>().OrderBy(m => m.CeateTime).Skip(pageSize * (pageindex - 1)).Take(pageSize).ToList();
                Redis.StringSet("shop_orderlist", List);

            }
            else
            {
                List = Newtonsoft.Json.JsonConvert.DeserializeObject<List<shop_orderlist>>(Redis.StringGet("shop_orderlist"));
                
            }

            return List;
           
        }



    }
}
