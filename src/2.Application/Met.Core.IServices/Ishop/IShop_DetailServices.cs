using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IServices
{
  public interface IShop_DetailServices : IBaseServices<shop_detail> 
    {
        List<shop_detail> Query();
    }
}
