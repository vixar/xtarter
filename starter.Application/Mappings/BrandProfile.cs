using starter.Application.Features.Brands.Commands.Create;
using starter.Application.Features.Brands.Queries.GetAllCached;
using starter.Application.Features.Brands.Queries.GetById;
using starter.Domain.Entities.Catalog;
using AutoMapper;

namespace starter.Application.Mappings
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