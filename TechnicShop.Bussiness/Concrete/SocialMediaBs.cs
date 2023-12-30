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
    public class SocialMediaBs : ISocialMediaBs
    {
        private readonly ISocialMediaRepository repo;

        public SocialMediaBs(ISocialMediaRepository repo)
        {
            this.repo = repo;
        }

        public SocialMedia Delete(SocialMedia entity)
        {
            return repo.Delete(entity);
        }

        public SocialMedia DeleteById(int id)
        {
            return repo.DeleteById(id);
        }

        public SocialMedia Get(Expression<Func<SocialMedia, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<SocialMedia> GetAll(Expression<Func<SocialMedia, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public SocialMedia GetById(int id, params string[] includelist)
        {
            return repo.GetById(id, includelist);
        }

        public SocialMedia Insert(SocialMedia entity)
        {
            return repo.Insert(entity);
        }

        public SocialMedia Update(SocialMedia entity)
        {
            return repo.Update(entity);
        }
    }
}
