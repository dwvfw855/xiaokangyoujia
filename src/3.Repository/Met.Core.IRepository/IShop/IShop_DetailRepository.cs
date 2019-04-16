using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IRepository.Base
{
   public interface IShop_DetailRepository : ISysBaseRepository<shop_detail>
    {
        List<shop_detail> Query();

        int Insert(shop_detail sp);

    }
}
