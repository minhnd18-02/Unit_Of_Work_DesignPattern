using SignalRAssignment.Interface;
using SignalRAssignmentRazorPages.Models;

namespace SignalRAssignment.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(PizzaStoreContext context) : base(context)
        {
        }

        //public override Task<bool> AddEntity(Order entity)
        //{
        //    try
        //    {
        //        var order = new Order();


        //    }catch (Exception ex)
        //    {
        //        throw new Exception($"Add not success. Error: {ex.Message}");
        //    }
        //}
    }
}
