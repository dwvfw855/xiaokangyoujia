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
        public  List<shop_orderlist> Query(int pageindex, int pageSize, string type)
        {    
           


                return  Db.Queryable<shop_orderlist>().OrderBy(m=>m.CeateTime).Skip(pageSize*(pageindex-1)).Take(pageindex).ToList();
           
        }
    }
}
