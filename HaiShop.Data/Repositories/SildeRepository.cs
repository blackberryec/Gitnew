using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface ISildeRepository : IRepository<Slide>
    {

    }
    public class SildeRepository : RepositoryBase<Slide>, ISildeRepository
    {
        public SildeRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
