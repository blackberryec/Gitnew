using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;

namespace HaiShop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}