using SIMA.Application.Features.Products.Commands.Create;
using SIMA.Application.Features.Products.Queries.GetAllCached;
using SIMA.Application.Features.Products.Queries.GetAllPaged;
using SIMA.Application.Features.Products.Queries.GetById;
using SIMA.Domain.Entities.Catalog;
using AutoMapper;

namespace SIMA.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}