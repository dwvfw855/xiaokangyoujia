using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IRepository.Base
{
   public interface Ishop_orderlistRepository : ISysBaseRepository<shop_orderlist>
    {
        List<shop_orderlist> Query(int pageindex, int pageSize, string type);



    }
}
