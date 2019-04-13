

using Mk.Chain.Core.IRepository;
using Mk.Chain.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mk.Chain.Core.Services
{
    public class SysBaseServices<TEntity> : ISysBaseServices<TEntity> where TEntity : class, new()
    {
        //public IBaseRepository<TEntity> baseDal = new BaseRepository<TEntity>();
        public IBaseRepository<TEntity> baseDal;//通过在子类的构造函数中注入，这里是基类，不用构造函数

      

        //TEntity IBaseServices<TEntity>.QueryByID(object objId)
        //{
        //    return baseDal.QueryByID(objId);
        //}
    }
}
