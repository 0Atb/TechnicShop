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
    public class ProductImageBs : IProductImageBs
    {
        private readonly IProductImageRepository repo;

        public ProductImageBs(IProductImageRepository repo)
        {
            this.repo = repo;
        }

        public ProductImage Delete(ProductImage entity)
        {
            return repo.Delete(entity);
        }

        public ProductImage DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public ProductImage Get(Expression<Func<ProductImage, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<ProductImage> GetAll(Expression<Func<ProductImage, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public ProductImage GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public ProductImage Insert(ProductImage entity)
        {
            return repo.Insert(entity);
        }

        public ProductImage Update(ProductImage entity)
        {
            return repo.Update(entity);
        }
    }
}
