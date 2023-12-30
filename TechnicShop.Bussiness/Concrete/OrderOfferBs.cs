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
    public class OrderOfferBs : IOrderOfferBs
    {
        private readonly IOrderOfferRepository repo;

        public OrderOfferBs(IOrderOfferRepository repo)
        {
            this.repo = repo;
        }

        public OrderOffer Delete(OrderOffer entity)
        {
            return repo.Delete(entity);
        }

        public OrderOffer DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public OrderOffer Get(Expression<Func<OrderOffer, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<OrderOffer> GetAll(Expression<Func<OrderOffer, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public OrderOffer GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public OrderOffer Insert(OrderOffer entity)
        {
            return repo.Insert(entity);
        }

        public OrderOffer Update(OrderOffer entity)
        {
            return repo.Update(entity);
        }
    }
}
