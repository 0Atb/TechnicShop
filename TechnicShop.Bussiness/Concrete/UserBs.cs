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
    public class UserBs : IUserBs
    {
        private readonly IUserRepository repo;

        public UserBs(IUserRepository repo)
        {
            this.repo = repo;
        }

        public User Delete(User entity)
        {
            return repo.Delete(entity);
        }

        public User DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public User Get(Expression<Func<User, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public User GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public User Insert(User entity)
        {
            return repo.Insert(entity);
        }

        public User Update(User entity)
        {
            return repo.Update(entity);
        }
    }
}
