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
    public class OrderBs : IOrderBs
    {
        private readonly IOrderRepository repo;

        public OrderBs(IOrderRepository repo)
        {
            this.repo = repo;
        }

        public Order Delete(Order entity)
        {
            return repo.Delete(entity);
        }

        public Order DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Order Get(Expression<Func<Order, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Order GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Order Insert(Order entity)
        {
            return repo.Insert(entity);
        }

        public Order Update(Order entity)
        {
            return repo.Update(entity);
        }
    }
}
