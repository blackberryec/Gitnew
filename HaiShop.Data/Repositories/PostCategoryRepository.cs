using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface IPostCategoryRepository
    {

    }
    public class PostCategoryRepository : RepositoryBase<PostCategory> 
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base (dbFactory)
        {

        }
    }
}
