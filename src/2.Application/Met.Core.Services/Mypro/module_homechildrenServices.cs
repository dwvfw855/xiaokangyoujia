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
    public class module_homechildrenServices : BaseServices<module_homechildren>, Imodule_homechildrenServices
    {

        Imodule_homechildrenRepository _dal;

        public module_homechildrenServices(Imodule_homechildrenRepository dal)
        {
            _dal = dal;
        }

        public  List<module_homechildren> Query()
        {
            return  _dal.Query();
        }
    }
}
