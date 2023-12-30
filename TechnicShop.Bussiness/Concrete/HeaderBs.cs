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
    public class HeaderBs : IHeaderBs
    {
        private readonly IHeaderRepository repo;

        public HeaderBs(IHeaderRepository repo)
        {
            this.repo = repo;
        }

        public Header Delete(Header entity)
        {
            return repo.Delete(entity);
        }

        public Header DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Header Get(Expression<Func<Header, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Header> GetAll(Expression<Func<Header, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Header GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Header Insert(Header entity)
        {
            return repo.Insert(entity);
        }

        public Header Update(Header entity)
        {
            return repo.Update(entity);
        }
    }
}
