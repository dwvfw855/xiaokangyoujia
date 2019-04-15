﻿using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.IServices
{
  public interface Ishop_typeServices : IBaseServices<shop_type> 
    {
        List<shop_type> Query();
    }
}
