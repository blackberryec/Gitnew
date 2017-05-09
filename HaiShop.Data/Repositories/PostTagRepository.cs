using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {

    }
    public class PostTagRepository : RepositoryBase<PostTag>
    {
        public PostTagRepository(IDbFactory dbFactory) : base (dbFactory)
        {

        }
    }
}
