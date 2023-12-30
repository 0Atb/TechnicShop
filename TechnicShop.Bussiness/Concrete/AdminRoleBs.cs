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
    public class AdminRoleBs : IAdminRoleBs
    {
        private readonly IAdminRoleRepository repo;

        public AdminRoleBs(IAdminRoleRepository repo)
        {
            this.repo = repo;
        }

        public AdminRole Delete(AdminRole entity)
        {
            return repo.Delete(entity);
        }

        public AdminRole DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public AdminRole Get(Expression<Func<AdminRole, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<AdminRole> GetAll(Expression<Func<AdminRole, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public AdminRole GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public AdminRole Insert(AdminRole entity)
        {
            return repo.Insert(entity);
        }

        public AdminRole Update(AdminRole entity)
        {
            return repo.Update(entity);
        }
    }
}
