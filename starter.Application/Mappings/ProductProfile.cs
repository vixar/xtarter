using starter.Application.Features.Products.Commands.Create;
using starter.Application.Features.Products.Queries.GetAllCached;
using starter.Application.Features.Products.Queries.GetAllPaged;
using starter.Application.Features.Products.Queries.GetById;
using starter.Domain.Entities.Catalog;
using AutoMapper;

namespace starter.Application.Mappings
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