using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.Services.Base
{
    //IChargeLogs :IBaseServices<ChargeLogs>
    public class Shop_DetailtServices : BaseServices<shop_detail>, IShop_DetailServices
    {

        IShop_DetailRepository _dal;

        public Shop_DetailtServices(IShop_DetailRepository dal)
        {
            _dal = dal;
        }

        public  List<shop_detail> Query()
        {
            return  _dal.Query();
        }
    }
}
