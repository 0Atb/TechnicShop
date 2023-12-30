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
    public class ProductPriceBs : IProductPriceBs
    {
        private readonly IProductPriceRepository repo;

        public ProductPriceBs(IProductPriceRepository repo)
        {
            this.repo = repo;
        }

        public ProductPrice Delete(ProductPrice entity)
        {
            return repo.Delete(entity);
        }

        public ProductPrice DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public ProductPrice Get(Expression<Func<ProductPrice, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<ProductPrice> GetAll(Expression<Func<ProductPrice, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public ProductPrice GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public ProductPrice Insert(ProductPrice entity)
        {
            return repo.Insert(entity);
        }

        public ProductPrice Update(ProductPrice entity)
        {
            return repo.Update(entity);
        }
    }
}
