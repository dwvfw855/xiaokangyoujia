using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace Mk.Chain.Core.Repository.SqlServer
{
    public class ChargeLogsRepostory : BaseRepository<ChargeLogs>, IChargeLogsRepository
    {
        public List<ChargeLogs> getlist()
        {
           return Db.Queryable<ChargeLogs>().ToList();
        }
    }
}
