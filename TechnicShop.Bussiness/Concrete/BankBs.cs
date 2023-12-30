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
    public class BankBs : IBankBs
    {
        private readonly IBankRepository repo;

        public BankBs(IBankRepository repo)
        {
            this.repo = repo;
        }

        public Bank Delete(Bank entity)
        {
            return repo.Delete(entity);
        }

        public Bank DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Bank Get(Expression<Func<Bank, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Bank> GetAll(Expression<Func<Bank, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Bank GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Bank Insert(Bank entity)
        {
            return repo.Insert(entity);
        }

        public Bank Update(Bank entity)
        {
            return repo.Update(entity);
        }
    }
}
