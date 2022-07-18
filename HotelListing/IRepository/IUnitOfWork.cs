using HotelListing.Data;

namespace HotelListing.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<Country> Counties { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}
