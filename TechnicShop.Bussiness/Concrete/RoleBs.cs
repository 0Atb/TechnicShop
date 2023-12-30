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
    public class RoleBs : IRoleBs
    {
        private readonly IRoleRepository repo;

        public RoleBs(IRoleRepository repo)
        {
            this.repo = repo;
        }

        public Role Delete(Role entity)
        {
            return repo.Delete(entity);
        }

        public Role DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Role Get(Expression<Func<Role, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Role> GetAll(Expression<Func<Role, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Role GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Role Insert(Role entity)
        {
            return repo.Insert(entity);
        }

        public Role Update(Role entity)
        {
            return repo.Update(entity);
        }
    }
}
