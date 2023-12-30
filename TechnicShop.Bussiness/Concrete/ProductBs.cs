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
    public class ProductBs : IProductBs
    {
        private readonly IProductRepository repo;

        public ProductBs(IProductRepository repo)
        {
            this.repo = repo;
        }

        public Product Delete(Product entity)
        {
            return repo.Delete(entity);
        }

        public Product DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Product GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Product Insert(Product entity)
        {
            return repo.Insert(entity);
        }

        public Product Update(Product entity)
        {
            return repo.Update(entity);
        }
    }
}
