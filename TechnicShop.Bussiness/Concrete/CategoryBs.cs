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
    public class CategoryBs : ICategoryBs
    {
        private readonly ICategoryRepository repo;

        public CategoryBs(ICategoryRepository repo)
        {
            this.repo = repo;
        }

        public Category Delete(Category entity)
        {
            return repo.Delete(entity);
        }

        public Category DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Category Get(Expression<Func<Category, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Category GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Category Insert(Category entity)
        {
            return repo.Insert(entity);
        }

        public Category Update(Category entity)
        {
            return repo.Update(entity);
        }
    }
}
