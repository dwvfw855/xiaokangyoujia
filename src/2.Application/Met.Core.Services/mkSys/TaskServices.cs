using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mk.Chain.Core.Services.Base
{
    //IChargeLogs :IBaseServices<ChargeLogs>
    public class TaskServices : SysBaseServices<ChargeLogs>, ITaskServices
    {

        ITaskRepository _dal;
        public TaskServices(
        ITaskRepository dal)
        {
            _dal = dal;
        }

        public List<Task> Get()
        {

            return _dal.Get();
       
        }
    }
}
