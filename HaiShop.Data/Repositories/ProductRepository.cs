using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface IProductRepository
    {
        //phương thức thêm mới
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) 
            : base(dbFactory)
        {

        }
    }
}
