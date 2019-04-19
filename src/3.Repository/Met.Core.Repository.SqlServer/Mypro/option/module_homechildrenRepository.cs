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
            List<module_homechildren> List = null;
            if (Redis.HashGet<List<module_homechildren>>("module", "module_homechildren") == null)
            {
                List =  Db.Queryable<module_homechildren>().ToList();
                Redis.HashSet("module", "module_homechildren", List);
               
            }
            else
            {
                // string vaulse=     ;
                List = Redis.HashGet<List<module_homechildren>>("module", "module_homechildren");



            }


            return List;

          //  return  Db.Queryable<module_homechildren>().ToList();
           
        }
    }
}
