using ApiProject.Core.Data.Models;
using ApiProject.Core.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        
        [HttpGet(Name = "GetProducts")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            var products = await _productService.GetAll();
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(products));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProduct(int id)
        {
            var product = await _productService.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ProductDTO>(product));
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct(CreateProductDTO createProductDto)
        {
            var product = await _productService.Create(createProductDto);
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, UpdateProductDTO updateProductDto)
        {
            if (id != updateProductDto.Id)
            {
                return BadRequest();
            }
            
            var result = await _productService.Update(id, updateProductDto);
            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if(id == 0) 
            {
                return BadRequest();
            }
            
            await _productService.Delete(id);

            return NoContent();
        }
    }

}
