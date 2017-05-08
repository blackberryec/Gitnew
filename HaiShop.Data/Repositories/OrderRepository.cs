using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface IOrderRepository
    {

    }
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
  
}
