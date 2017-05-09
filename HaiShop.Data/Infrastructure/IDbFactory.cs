using System;

namespace HaiShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HaiShopDbContext Init();
    }
}