﻿using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IRepository.Base
{
   public interface Imodule_mainRepository : ISysBaseRepository<module_main>
    {
        Task<List<module_main>> Query();



    }
}
