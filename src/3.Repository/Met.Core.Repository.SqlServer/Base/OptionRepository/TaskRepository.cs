using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mk.Chain.Core.Repository.SqlServer
{
    public class TaskRepository : SysBaseRepository<Task>, ITaskRepository
    {
        public List<Task> Get()
        {

            return SysDb.Queryable<Task>().Where(c => c.P1 != null).ToList();
        
        }
    }
}
