using SignalRAssignment.Interface;
using SignalRAssignmentRazorPages.Interface;
using SignalRAssignmentRazorPages.Models;
using SignalRAssignmentRazorPages.Repository;

namespace SignalRAssignment.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PizzaStoreContext _context;

        public ICustomerRepository CustomerRepository { get; private set; }
        public IOrderRepository OrderRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public IAccountRepository AccountRepository { get; private set; }


        public UnitOfWork(PizzaStoreContext context)
        {
            _context = context;
            CustomerRepository = new CustomerRepository(context);
            OrderRepository = new OrderRepository(context);
            CategoryRepository = new CategoryRepository(context);
            AccountRepository = new AccountRepository(context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
