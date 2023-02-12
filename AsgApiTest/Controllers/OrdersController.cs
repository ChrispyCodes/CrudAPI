using ApiProject.Core.Data.Models;
using ApiProject.Core.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetOrders()
        {
            var orders = await _orderService.GetAll();
            return Ok(_mapper.Map<IEnumerable<OrderDTO>>(orders));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDTO>> GetOrder(int id)
        {
            var order = await _orderService.Get(id);
            if (order == null)
                return NotFound();


            return Ok(_mapper.Map<OrderDTO>(order));
        }

        [HttpPost]
        public async Task<ActionResult<OrderDTO>> CreateOrder(CreateOrderDTO createOrderDto)
        {
            var order = await _orderService.Create(createOrderDto);
            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, UpdateOrderDTO updateOrderDto)
        {
            if (id != updateOrderDto.Id)
            {
                return BadRequest();
            }

            var result = await _orderService.Update(id, updateOrderDto);
            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _orderService.Delete(id);
            if (id == 0)
            {
                return NotFound();
            }
            await _orderService.Delete(id);

            return NoContent();
        }
    }
}
