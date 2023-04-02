using Application.DataTransferObjects;

namespace Application.Interfaces;

public interface ICategoryService
{
    Task<List<CategoryDto>> GetAllProductCategoriesAsync();
    Task<CategoryDto> GetCategoryByIdAsync(Guid Id);
    Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto category);
    Task UpdateCategoryAsync(Guid Id, CreateCategoryDto category);
    Task DeleteCategoryAsync(Guid Id);
    Task ToggleFeaturedStatus(Guid Id);
}