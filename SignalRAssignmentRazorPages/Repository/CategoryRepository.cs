using Microsoft.EntityFrameworkCore;
using SignalRAssignment.Interface;
using SignalRAssignmentRazorPages.Models;


namespace SignalRAssignment.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(PizzaStoreContext context) : base(context)
        {
        }

        public override async Task<bool> AddEntity(Category entity)
        {
            try
            {
                var newCate = new Category();
                int maxCategoryId = await _dbSet.MaxAsync(c => (int?)c.CategoryID) ?? 0;
                
                newCate.CategoryID = maxCategoryId + 1;
                newCate.Description = entity.Description;
                newCate.CategoryName = entity.CategoryName;
                newCate.Products = entity.Products;

                await _dbSet.AddAsync(newCate);
                return true;

            }catch (Exception ex)
            {
                throw new Exception($"Add not success. Error: {ex.Message}");
            }
        }

        public override async Task<bool> DeleteEntity(int id)
        {
            var existId = await _dbSet.FirstOrDefaultAsync( x => x.CategoryID == id );
            if ( existId != null )
            {
                _dbSet.Remove( existId );
                return true;
            }else { return false; }
        }

        public override async Task<bool> UpdateEntity(Category entity)
        {
            try
            {
                var existId = await _dbSet.FirstOrDefaultAsync(x => x.CategoryID == entity.CategoryID);
                if (existId != null)
                {
                    existId.CategoryName = entity.CategoryName;
                    existId.Description = entity.Description;
                    existId.Products = entity.Products;
                    return true;
                }
                else { return false; }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
