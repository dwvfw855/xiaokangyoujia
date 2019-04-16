using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mk.Chain.Core.IRepository.Base;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace Mk.Chain.Core.Repository.SqlServer
{
    public class Shop_DetailRepository : BaseRepository<shop_detail>, IShop_DetailRepository
    {
        public  List<shop_detail> Query()
        {
            
                return  Db.Queryable<shop_detail>().ToList();
           
        }

        public int Insert(shop_detail sp)
        {

            return Db.Insertable<shop_detail>(sp).ExecuteCommand();


        }


        public shop_detail GetDetailForGuid(string ID)
        {
            shop_detail sp = null;
         var shop_detailqure=   Db.Queryable<shop_detail>().Where(m => m.MainGUID == ID);
            if (shop_detailqure.Count()>0)
            {
                sp= shop_detailqure.First();
            }


            return sp;
        }



    }
}
