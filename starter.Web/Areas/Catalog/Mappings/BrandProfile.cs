using starter.Application.Features.Brands.Commands.Create;
using starter.Application.Features.Brands.Commands.Update;
using starter.Application.Features.Brands.Queries.GetAllCached;
using starter.Application.Features.Brands.Queries.GetById;
using starter.Web.Areas.Catalog.Models;
using AutoMapper;

namespace starter.Web.Areas.Catalog.Mappings
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