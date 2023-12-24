using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TechnicShop.Bussiness.Abstract
{
    public interface IBussinessBase<TEntity>
        where TEntity : AudiTableEntity,IBaseDomain,new()
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includelist);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includelist);
        TEntity Insert(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity DeleteById(int id);
        TEntity GetById(int id, params string[] includelist);
    }
}
