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
    public class Module_mainServices : BaseServices<module_main>, Imodule_mainServices
    {

        Imodule_mainRepository _dal;

        public Module_mainServices(Imodule_mainRepository dal)
        {
            _dal = dal;
        }

        public  List<module_main> Query()
        {
            return  _dal.Query();
        }
    }
}
