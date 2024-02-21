using SignalRAssignmentRazorPages.Interface;

namespace SignalRAssignment.Interface
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IAccountRepository AccountRepository { get; }
        Task CompleteAsync();
    }
}
