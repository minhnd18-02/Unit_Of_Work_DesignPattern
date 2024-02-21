
using SignalRAssignmentRazorPages.Models;

namespace SignalRAssignment.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetByID(int id);
        Task<bool> AddEntity(T entity);
        Task<bool> DeleteEntity(int id);
        Task<bool> UpdateEntity(T entity);
        Task<Account> Login(T login);
    }
}
