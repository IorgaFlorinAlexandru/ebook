using Domain.Entities;

namespace Domain.Repositories;

public interface ICategoryRepository : IRepositoryBase<Category>
{
    Task<List<Category>> GetAllCategories();
    Task<Category> GetCategoryById(Guid Id);
    void CreateCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(Category category);
}