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
    public class CommunicationBs : ICommunicationBs
    {
        private readonly ICommunicationRepository repo;

        public CommunicationBs(ICommunicationRepository repo)
        {
            this.repo = repo;
        }

        public Communication Delete(Communication entity)
        {
            return repo.Delete(entity);
        }

        public Communication DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public Communication Get(Expression<Func<Communication, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Communication> GetAll(Expression<Func<Communication, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Communication GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public Communication Insert(Communication entity)
        {
            return repo.Insert(entity);
        }

        public Communication Update(Communication entity)
        {
            return repo.Update(entity);
        }
    }
}
