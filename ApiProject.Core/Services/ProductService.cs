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

    //public class ProductService : IProductService
    //{
    //    private readonly ApplicationDbContext _dbContext;
    //    private readonly IMapper _mapper;

    //    public ProductService(ApplicationDbContext dbContext, IMapper mapper)
    //    {
    //        _dbContext = dbContext;
    //        _mapper = mapper;
    //    }
    //    public async Task<IEnumerable<ProductDTO>> GetAllProducts()
    //    {
    //        var products = await _dbContext.Products.ToListAsync();
    //        return _mapper.Map<IEnumerable<ProductDTO>>(products);
    //    }

    //    public async Task<ProductDTO> GetProductById(int id)
    //    {
    //        var product = await _dbContext.Products.FindAsync(id);
    //        return _mapper.Map<ProductDTO>(product);
    //    }

    //    public async Task<ProductDTO> CreateProduct(CreateProductDTO productDto)
    //    {


    //        var product = _mapper.Map<Product>(productDto);
    //        _dbContext.Products.Add(product);
    //        await _dbContext.SaveChangesAsync();

    //        return _mapper.Map<ProductDTO>(product);

    //    }

    //    public async Task<ProductDTO> UpdateProduct(int id, UpdateProductDTO productDto)
    //    {
    //        var product = await _dbContext.Products.FindAsync(id);
    //        _mapper.Map(productDto, product);
    //        await _dbContext.SaveChangesAsync();
    //        return _mapper.Map<ProductDTO>(product);
    //    }

    //    public async Task DeleteProduct(int id)
    //    {
    //        var product = await _dbContext.Products.FindAsync(id);
    //        _dbContext.Products.Remove(product);
    //        await _dbContext.SaveChangesAsync();
    //    }



    //}
}