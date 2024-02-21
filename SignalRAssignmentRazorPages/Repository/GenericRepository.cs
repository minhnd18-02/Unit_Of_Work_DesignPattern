using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SignalRAssignment.Interface;
using SignalRAssignmentRazorPages.Models;

namespace SignalRAssignment.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PizzaStoreContext _context;
        internal DbSet<T> _dbSet;
        public GenericRepository(PizzaStoreContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public virtual Task<bool> AddEntity(T entity)
        {
            //await _dbSet.AddAsync(entity);
            //return true; 
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByID(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual Task<bool> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Account> Login(T login)
        {
            throw new NotImplementedException();
        }

    }
}
