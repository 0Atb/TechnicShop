using Infrastructure.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicShop.DataAccess.Abstract;
using TechnicShop.Model.Entity;

namespace TechnicShop.DataAccess.Concrete.Repository
{
    public class EfCompantyRepository : EfRepositoryBase<Company, TechnicShopDbContext>, ICompanyRepository
    {
    }
}
