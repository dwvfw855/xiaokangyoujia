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
            if (Redis.StringGet("ccc") == null)
            {
                List = await Db.Queryable<module_main>().ToListAsync();
                Redis.StringSet("ccc", Newtonsoft.Json.JsonConvert.SerializeObject(List));
            }
            else
            {
                // string vaulse=     ;
                List = Newtonsoft.Json.JsonConvert.DeserializeObject<List<module_main>>(Redis.StringGet("ccc"));



            }

            return List;

          //  return await Db.Queryable<module_main>().ToListAsync();

        }
    }
}
