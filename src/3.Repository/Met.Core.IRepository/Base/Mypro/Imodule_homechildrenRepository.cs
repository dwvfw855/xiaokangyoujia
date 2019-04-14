using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IRepository.Base
{
   public interface Imodule_homechildrenRepository : ISysBaseRepository<module_homechildren>
    {
        List<module_homechildren> Query();



    }
}
