using System;

namespace HaiShop.Data.Infastructure
{
    public interface IDbFactory : IDisposable //giao tieeps ddeer khoi tao cac doi tuong entity, design pattern
    {
        HaiShopDbContext Init();
    }
} 