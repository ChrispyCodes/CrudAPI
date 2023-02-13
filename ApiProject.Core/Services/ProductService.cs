using ApiProject.Core.Data.Models;
using ApiProject.Core.Data;
using ApiProject.Core.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiProject.Core.Services.MyAPI.Services;

namespace ApiProject.Core.Services
{
    public class ProductService : CrudService<Product, CreateProductDTO, UpdateProductDTO, ProductDTO>, IProductService
    {
        public ProductService(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}