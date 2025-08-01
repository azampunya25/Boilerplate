using SIMA.Application.Features.Brands.Commands.Create;
using SIMA.Application.Features.Brands.Queries.GetAllCached;
using SIMA.Application.Features.Brands.Queries.GetById;
using SIMA.Domain.Entities.Catalog;
using AutoMapper;

namespace SIMA.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}