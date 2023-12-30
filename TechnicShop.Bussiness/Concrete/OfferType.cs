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
    public class OfferTypeBs : IOfferTypeBs
    {
        private readonly IOfferTypeRepository repo;

        public OfferTypeBs(IOfferTypeRepository repo)
        {
            this.repo = repo;
        }

        public OfferType Delete(OfferType entity)
        {
            return repo.Delete(entity);
        }

        public OfferType DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public OfferType Get(Expression<Func<OfferType, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<OfferType> GetAll(Expression<Func<OfferType, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public OfferType GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public OfferType Insert(OfferType entity)
        {
            return repo.Insert(entity);
        }

        public OfferType Update(OfferType entity)
        {
            return repo.Update(entity);
        }
    }
}
