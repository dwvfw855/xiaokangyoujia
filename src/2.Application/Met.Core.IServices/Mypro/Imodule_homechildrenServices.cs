using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IServices
{
  public interface Imodule_homechildrenServices : IBaseServices<module_homechildren> 
    {
        List<module_homechildren> Query();
    }
}
