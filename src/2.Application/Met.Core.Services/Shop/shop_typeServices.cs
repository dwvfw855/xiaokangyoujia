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
    public class shop_typeServices : BaseServices<shop_type>, Ishop_typeServices
    {

        Ishop_typeRepository _dal;

        public shop_typeServices(Ishop_typeRepository dal)
        {
            _dal = dal;
        }

        public  List<shop_type> Query()
        {
            return  _dal.Query();
        }
    }
}
