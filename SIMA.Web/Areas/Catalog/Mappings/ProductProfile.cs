using SIMA.Application.Features.Products.Commands.Create;
using SIMA.Application.Features.Products.Commands.Update;
using SIMA.Application.Features.Products.Queries.GetAllCached;
using SIMA.Application.Features.Products.Queries.GetById;
using SIMA.Web.Areas.Catalog.Models;
using AutoMapper;

namespace SIMA.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}