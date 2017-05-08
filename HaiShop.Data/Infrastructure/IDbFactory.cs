using System;

namespace HaiShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable //giao tieeps ddeer khoi tao cac doi tuong entity, design pattern
    {
        HaiShopDbContext Init();
    }
} 