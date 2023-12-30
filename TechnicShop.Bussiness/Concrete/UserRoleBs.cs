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
    public class UserRoleBs : IUserRoleBs
    {
        private readonly IUserRoleRepository repo;

        public UserRoleBs(IUserRoleRepository repo)
        {
            this.repo = repo;
        }

        public UserRole Delete(UserRole entity)
        {
            return repo.Delete(entity);
        }

        public UserRole DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public UserRole Get(Expression<Func<UserRole, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<UserRole> GetAll(Expression<Func<UserRole, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public UserRole GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public UserRole Insert(UserRole entity)
        {
            return repo.Insert(entity);
        }

        public UserRole Update(UserRole entity)
        {
            return repo.Update(entity);
        }
    }
}
