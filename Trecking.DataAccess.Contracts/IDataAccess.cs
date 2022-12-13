namespace Trecking.DataAccess.Contracts
{
    using System.Threading.Tasks;
    using Trecking.Common.Models;

    public interface IDataAccess<T>
    {
        Task<T> GetAsync(int id);

        Task<ListResult<T>> GetAllAsync(T searchBase);

        Task<T> UpdateAsync(T entity);

        Task<T> SaveAsync(T dto);

        Task<bool> DeleteAsync(int id);
    }
}
