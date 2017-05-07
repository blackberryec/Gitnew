namespace HaiShop.Data.Infastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
        private HaiShopDbContext dbContext;

        public HaiShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HaiShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}