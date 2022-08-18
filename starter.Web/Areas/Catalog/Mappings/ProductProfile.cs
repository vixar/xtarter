﻿using starter.Application.Features.Products.Commands.Create;
using starter.Application.Features.Products.Commands.Update;
using starter.Application.Features.Products.Queries.GetAllCached;
using starter.Application.Features.Products.Queries.GetById;
using starter.Web.Areas.Catalog.Models;
using AutoMapper;

namespace starter.Web.Areas.Catalog.Mappings
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