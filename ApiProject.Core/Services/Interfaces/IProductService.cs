using ApiProject.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Services.Interfaces
{
    public interface IProductService : ICrudService<Product, CreateProductDTO, UpdateProductDTO, ProductDTO>
    {
        //Task<IEnumerable<ProductDTO>> GetAllProducts();
        //Task<ProductDTO> GetProductById(int id);
        //Task<ProductDTO> CreateProduct(CreateProductDTO product);
        //Task<ProductDTO> UpdateProduct(int id, UpdateProductDTO product);
        //Task DeleteProduct(int id);
    }
}
