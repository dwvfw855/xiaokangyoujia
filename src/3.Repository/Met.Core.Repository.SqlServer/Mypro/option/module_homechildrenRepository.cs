using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace Mk.Chain.Core.Repository.SqlServer
{
    public class module_homechildrenRepository : BaseRepository<module_homechildren>, Imodule_homechildrenRepository
    {

        public module_homechildrenRepository():base(1)
        {

        }
        public  List<module_homechildren> Query()
        {
            
                return  Db.Queryable<module_homechildren>().ToList();
           
        }
    }
}
