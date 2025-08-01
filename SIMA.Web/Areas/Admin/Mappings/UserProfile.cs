using SIMA.Infrastructure.Identity.Models;
using SIMA.Web.Areas.Admin.Models;
using AutoMapper;

namespace SIMA.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}