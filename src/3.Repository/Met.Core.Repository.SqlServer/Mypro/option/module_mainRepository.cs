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

        public module_mainRepository():base(1)
        {

        }

        public async Task<List<module_main>> Query()
        {
            List<module_main> List = null;
            #region hash存储
            //if (Redis.HashGet<List<module_main>>("module", "module_main") == null)
            //{
            //    List = await Db.Queryable<module_main>().ToListAsync();
            //    Redis.HashSet("module", "module_main", List);
            //    //"module_main", Newtonsoft.Json.JsonConvert.SerializeObject(List),new TimeSpan(1,0,0)
            //}
            //else
            //{
            //    // string vaulse=     ;

            //    List = Redis.HashGet<List<module_main>>("module", "module_main");


            //} 
            #endregion
            #region string 存储
            if (Redis.StringGet("module_main") == null)
            {
                List = await Db.Queryable<module_main>().ToListAsync();
                Redis.StringSet("module_main", List, new TimeSpan(1, 0, 0));
                //"module_main", Newtonsoft.Json.JsonConvert.SerializeObject(List),new TimeSpan(1,0,0)
            }
            else
            {
                // string vaulse=     ;

                List = Newtonsoft.Json.JsonConvert.DeserializeObject <List< module_main >>( Redis.StringGet("module_main"));


            }
            #endregion
            return List;

          //  return await Db.Queryable<module_main>().ToListAsync();

        }
    }
}
