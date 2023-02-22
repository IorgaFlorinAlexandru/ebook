using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context)
         : base(context)
    {
    }

    public async Task<List<Category>> GetAllCategories()
    {
        return await FindAll().AsNoTracking().ToListAsync();
    }

    public async Task<Category?> GetCategoryById(Guid Id)
    {
        return await FindByCondition(x => x.Id == Id).AsNoTracking().FirstOrDefaultAsync();
    }

    public void CreateCategory(Category category)
    {
        Create(category);
    }

    public void UpdateCategory(Category category)
    {
        Update(category);
    }

    public void DeleteCategory(Category category)
    {
        Delete(category);
    }
}