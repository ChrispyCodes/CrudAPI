using ApiProject.Core.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, CreateProductDTO>();
            CreateMap<CreateProductDTO, Product>();
            CreateMap<Product, UpdateProductDTO>();
            CreateMap<UpdateProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
            
            CreateMap<Order, CreateOrderDTO>();
            CreateMap<CreateOrderDTO, Order>();
            CreateMap<Order, UpdateOrderDTO>();
            CreateMap<UpdateOrderDTO, Order>();
            CreateMap<Order, OrderDTO>();
        }
    }
}
