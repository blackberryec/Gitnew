using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface ISupportOnlineRepository
    {

    }
    public class SupportOnlineRepository : RepositoryBase<SupportOnline>
    {
        public SupportOnlineRepository(IDbFactory dbfactory) : base (dbfactory)
        {

        }
    }
}
