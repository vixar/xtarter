using starter.Infrastructure.Identity.Models;
using starter.Web.Areas.Admin.Models;
using AutoMapper;

namespace starter.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}