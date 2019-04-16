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
    public class shop_orderlistServices : BaseServices<shop_orderlist>, Ishop_orderlistServices
    {

        Ishop_orderlistRepository _dal;

        public  shop_orderlistServices(Ishop_orderlistRepository dal)
        {
            _dal = dal;
        }

        public int insert(shop_orderlist sp)
        {
            return _dal.insert(sp);
        }

        public  List<shop_orderlist> Query(int pageindex, int pageSize, string type)
        {
            return  _dal.Query(pageindex, pageSize, type);
        }
    }
}
