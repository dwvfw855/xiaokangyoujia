using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace Mk.Chain.Core.Repository.SqlServer
{
    public class shop_typeRepository : BaseRepository<shop_detail>, Ishop_typeRepository
    {
        public  List<shop_type> Query()
        {
            
                return  Db.Queryable<shop_type>().ToList();
           
        }
    }
}
