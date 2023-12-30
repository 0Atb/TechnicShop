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
    public class GenderBs : IGenderBs
    {
        private readonly IGenderRepository repo;

        public GenderBs(IGenderRepository repo)
        {
            this.repo = repo;
        }

        public Gender Delete(Gender entity)
        {
            return repo.Delete(entity);
        }

        public Gender DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Gender Get(Expression<Func<Gender, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Gender> GetAll(Expression<Func<Gender, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Gender GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Gender Insert(Gender entity)
        {
            return repo.Insert(entity);
        }

        public Gender Update(Gender entity)
        {
            return repo.Update(entity);
        }
    }
}
