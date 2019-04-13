using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mk.Chain.Core.IRepository.Base
{
   public interface ITaskRepository: ISysBaseRepository<Task>
    {

        List<Task> Get();


    }
}
