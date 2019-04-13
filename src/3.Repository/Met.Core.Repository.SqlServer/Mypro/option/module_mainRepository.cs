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
        public  List<module_main> Query()
        {
            
                return  Db.Queryable<module_main>().ToList();
           
        }
    }
}
