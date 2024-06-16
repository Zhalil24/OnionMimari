﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using YoutubeApi.Application.DTOs;
using YoutubeApi.Application.Interfaces.AutoMapper;
using YoutubeApi.Application.Interfaces.UnitOfWorks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync(include: x=>x.Include(b => b.Brand));

            var brand = mapper.Map<BrandDTO, Brand>(new Brand());
            
            //List<GetAllProductsQueryResponse> response = new();

           // foreach (var product in products)
           // {
           //     response.Add(new GetAllProductsQueryResponse
           //     {
           //         Title = product.Title,
           //         Description = product.Description,
           //         Discount = product.Discount,
           //         Price = product.Price - (product.Price * product.Discount / 100),
           //     });
           // }

            var map = mapper.Map<GetAllProductsQueryResponse, Product>(products);
            foreach (var item in products)
                item.Price -= (item.Price * item.Discount / 100);


            return map ;
        }
    }
}
