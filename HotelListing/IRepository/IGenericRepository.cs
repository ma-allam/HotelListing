using System.Linq.Expressions;

namespace HotelListing.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T,bool>> expression=null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderBy=null,
            List<string> includes=null);

        Task<T> Get(Expression<Func<T, bool>> expression = null,List<string> includes = null);
        Task Insert(T entity);
        void Update(T entity);
        Task Delete(int Id);
        Task InsertRange(IQueryable<T> entities);
        void DeleteRange(IQueryable<T> entities);

    }
}
