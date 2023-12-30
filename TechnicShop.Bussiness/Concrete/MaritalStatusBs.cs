using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechnicShop.Bussiness.Abstract;
using TechnicShop.DataAccess.Abstract;
using TechnicShop.Model.Entity;

namespace TechnicShop.Bussiness.Concrete
{
    public class MaritalStatusBs : IMaritalStatusBs
    {
        private readonly IMaritalStatusRepository repo;

        public MaritalStatusBs(IMaritalStatusRepository repo)
        {
            this.repo = repo;
        }

        public MaritalStatus Delete(MaritalStatus entity)
        {
            return repo.Delete(entity);
        }

        public MaritalStatus DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public MaritalStatus Get(Expression<Func<MaritalStatus, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<MaritalStatus> GetAll(Expression<Func<MaritalStatus, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public MaritalStatus GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public MaritalStatus Insert(MaritalStatus entity)
        {
            return repo.Insert(entity);
        }

        public MaritalStatus Update(MaritalStatus entity)
        {
            return repo.Update(entity);
        }
    }
}
