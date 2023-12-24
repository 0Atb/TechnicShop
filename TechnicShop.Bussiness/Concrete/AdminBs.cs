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
    public class AdminBs : IAdminBs
    {
        private readonly IAdminRepository repo;

        public AdminBs(IAdminRepository repo)
        {
            this.repo = repo;
        }

        public Admin Delete(Admin entity)
        {
            return repo.Delete(entity);
        }

        public Admin DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Admin Get(Expression<Func<Admin, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Admin GetById(int id, params string[] includelist)
        {
           return repo.GetById(id, includelist);
        }

        public Admin Insert(Admin entity)
        {
            return repo.Insert(entity);
        }

        public Admin Update(Admin entity)
        {
            return repo.Update(entity);
        }
    }
}
