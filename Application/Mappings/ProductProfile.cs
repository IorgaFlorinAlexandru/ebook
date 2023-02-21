using Application.DataTransferObjects;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product,ProductDto>();
        CreateMap<CreateProductDto,Product>();
    }
}