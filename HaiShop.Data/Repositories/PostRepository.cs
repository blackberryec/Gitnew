using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {

    }
    public class PostRepository : RepositoryBase<Post>
    {
        public PostRepository(IDbFactory dbFactory)
            : base (dbFactory)
        {

        }
    }
}
