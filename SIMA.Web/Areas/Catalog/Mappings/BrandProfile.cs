using SIMA.Application.Features.Brands.Commands.Create;
using SIMA.Application.Features.Brands.Commands.Update;
using SIMA.Application.Features.Brands.Queries.GetAllCached;
using SIMA.Application.Features.Brands.Queries.GetById;
using SIMA.Web.Areas.Catalog.Models;
using AutoMapper;

namespace SIMA.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}