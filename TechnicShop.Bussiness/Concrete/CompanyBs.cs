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
    public class CompanyBs : ICompanyBs
    {
        private readonly ICompanyRepository repo;

        public CompanyBs(ICompanyRepository repo)
        {
            this.repo = repo;
        }

        public Company Delete(Company entity)
        {
            return repo.Delete(entity);
        }

        public Company DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Company Get(Expression<Func<Company, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Company> GetAll(Expression<Func<Company, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Company GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Company Insert(Company entity)
        {
            return repo.Insert(entity);
        }

        public Company Update(Company entity)
        {
            return repo.Update(entity);
        }
    }
}
