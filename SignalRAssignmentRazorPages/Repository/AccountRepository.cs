using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using SignalRAssignment.Repository;
using SignalRAssignmentRazorPages.Interface;
using SignalRAssignmentRazorPages.Models;

namespace SignalRAssignmentRazorPages.Repository
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(PizzaStoreContext context) : base(context)
        {
        }

        public override async Task<Account> Login(Account login)
        {
            try
            {
                var checkLogin = await _dbSet.Where(x => x.UserName.Equals(login.UserName)
                && x.Password.Equals(login.Password))
                    .FirstOrDefaultAsync();
                if (checkLogin == null)
                {
                    throw new Exception("invalid account");
                }
                return checkLogin;
            }
            catch (Exception ex)
            {
                throw new Exception($"Login not success. Error: {ex.Message}");
            }

        }
    }
}
