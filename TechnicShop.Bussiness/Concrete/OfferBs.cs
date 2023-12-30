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
    public class OfferBs : IOfferBs
    {
        private readonly IOfferRepository repo;

        public OfferBs(IOfferRepository repo)
        {
            this.repo = repo;
        }

        public Offer Delete(Offer entity)
        {
            return repo.Delete(entity);
        }

        public Offer DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Offer Get(Expression<Func<Offer, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Offer> GetAll(Expression<Func<Offer, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Offer GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Offer Insert(Offer entity)
        {
            return repo.Insert(entity);
        }

        public Offer Update(Offer entity)
        {
            return repo.Update(entity);
        }
    }
}
