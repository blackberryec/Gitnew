namespace HaiShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}