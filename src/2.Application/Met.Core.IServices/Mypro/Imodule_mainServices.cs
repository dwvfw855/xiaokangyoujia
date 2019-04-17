using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IServices
{
  public interface Imodule_mainServices : IBaseServices<module_main> 
    {
        Task<List<module_main>> Query();
    }
}
