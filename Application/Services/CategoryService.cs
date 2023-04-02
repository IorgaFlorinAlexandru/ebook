using Application.DataTransferObjects;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

namespace Application.Services;

public class CategoryService : ICategoryService
{
    private readonly IRepositoryWrapper _repository;
    private readonly IMapper _mapper;

    public CategoryService(IRepositoryWrapper repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<CategoryDto>> GetAllProductCategoriesAsync()
    {
        var categoriesResult = await _repository.Category.GetAllCategories();

        var categories = _mapper.Map<List<CategoryDto>>(categoriesResult);

        return categories;
    }

    public async Task<CategoryDto> GetCategoryByIdAsync(Guid Id)
    {
        var categoryEntity = await _repository.Category.GetCategoryById(Id);

        if (categoryEntity == null) throw new NotFoundException(nameof(Category), Id.ToString());

        var category = _mapper.Map<CategoryDto>(categoryEntity);

        return category;
    }

    public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto category)
    {
        var categoryEntity = _mapper.Map<Category>(category);

        _repository.Category.CreateCategory(categoryEntity);

        await _repository.SaveAsync();

        var createdCategory = _mapper.Map<CategoryDto>(categoryEntity);

        return createdCategory;
    }

    public async Task DeleteCategoryAsync(Guid Id)
    {
        var categoryEntity = await _repository.Category.GetCategoryById(Id);

        if (categoryEntity == null) throw new NotFoundException(nameof(Category), Id.ToString());

        _repository.Category.DeleteCategory(categoryEntity);

        await _repository.SaveAsync();

    }

    public async Task UpdateCategoryAsync(Guid Id, CreateCategoryDto category)
    {
        var categoryEntity = await _repository.Category.GetCategoryById(Id);

        if (categoryEntity == null) throw new NotFoundException(nameof(Category), Id.ToString());

        categoryEntity.Name = category.Name;
        categoryEntity.Description = category.Description;

        _repository.Category.UpdateCategory(categoryEntity);

        await _repository.SaveAsync();

    }

    public async Task ToggleFeaturedStatus(Guid Id)
    {
        var category = await _repository.Category.GetCategoryById(Id);

        if (category == null) throw new NotFoundException(nameof(Category), Id.ToString());

        category.IsFeatured = !category.IsFeatured;

        _repository.Category.UpdateCategory(category);

        await _repository.SaveAsync();
    }
}