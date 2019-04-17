using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace Mk.Chain.Core.Repository.SqlServer
{
    public class module_mainRepository : BaseRepository<module_main>, Imodule_mainRepository
    {
        public async Task<List<module_main>> Query()
        {

            return await Db.Queryable<module_main>().ToListAsync();
           
        }
    }
}
