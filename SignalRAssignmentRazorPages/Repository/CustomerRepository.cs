using Microsoft.EntityFrameworkCore;
using SignalRAssignment.Interface;
using SignalRAssignmentRazorPages.Models;
using SignalRAssignmentRazorPages.Pages;

namespace SignalRAssignment.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(PizzaStoreContext context) : base(context)
        {
        }

        public override async Task<bool> UpdateEntity(Customer entity)
        {
            try
            {
                var existID = await _dbSet.FirstOrDefaultAsync(item => item.CustomerID == entity.CustomerID);
                if (existID != null)
                {
                    existID.ContactName = entity.ContactName;
                    existID.Address = entity.Address;
                    existID.Phone = entity.Phone;
                    existID.Password = entity.Password;
                    return true;
                }
                else
                {
                    return false;
                }

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public override async Task<bool> DeleteEntity(int entity)
        {
            var existID = await _dbSet.FirstOrDefaultAsync(x => x.CustomerID == entity);
            if (existID != null)
            {
                _dbSet.Remove(existID);
                return true;
            }else { return false; }
        }

        public override async Task<bool> AddEntity(Customer entity)
        {
            try
            {

                int newCustomerId = await _dbSet.MaxAsync(x => x.CustomerID) + 1;

                Customer newCustomer = new Customer
                {
                    CustomerID = newCustomerId,
                    ContactName = entity.ContactName,
                    Password = entity.Password,
                    Address = entity.Address,
                    Phone = entity.Phone
                };

                await _dbSet.AddAsync(newCustomer);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Add not success. Error: {ex.Message}");
            }
        }
    }
}

