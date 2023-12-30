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
    public class OrderDetailBs : IOrderDetailBs
    {
        private readonly IOrderDetailRepository repo;

        public OrderDetailBs(IOrderDetailRepository repo)
        {
            this.repo = repo;
        }

        public OrderDetail Delete(OrderDetail entity)
        {
            return repo.Delete(entity);
        }

        public OrderDetail DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public OrderDetail Get(Expression<Func<OrderDetail, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<OrderDetail> GetAll(Expression<Func<OrderDetail, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public OrderDetail GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public OrderDetail Insert(OrderDetail entity)
        {
            return repo.Insert(entity);
        }

        public OrderDetail Update(OrderDetail entity)
        {
            return repo.Update(entity);
        }
    }
}
