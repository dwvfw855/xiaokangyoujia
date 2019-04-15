using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IServices
{
  public interface Ishop_orderlistServices : IBaseServices<shop_orderlist> 
    {
        List<shop_orderlist> Query(int pageindex,int pageSize,string type);
    }
}
