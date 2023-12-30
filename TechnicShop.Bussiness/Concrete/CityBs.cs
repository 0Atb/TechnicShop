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
    public class CityBs : ICityBs
    {
        private readonly ICityRepository repo;

        public CityBs(ICityRepository repo)
        {
            this.repo = repo;
        }

        public City Delete(City entity)
        {
            return repo.Delete(entity);
        }

        public City DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public City Get(Expression<Func<City, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<City> GetAll(Expression<Func<City, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public City GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public City Insert(City entity)
        {
            return repo.Insert(entity);
        }

        public City Update(City entity)
        {
            return repo.Update(entity);
        }
    }
}
