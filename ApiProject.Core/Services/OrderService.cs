using ApiProject.Core.Data;
using ApiProject.Core.Data.Models;
using ApiProject.Core.Services.Interfaces;
using ApiProject.Core.Services.MyAPI.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Core.Services
{
    public class OrderService : CrudService<Order, CreateOrderDTO, UpdateOrderDTO, OrderDTO>, IOrderService
    {
        public OrderService(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }

    //public class OrderService : IOrderService
    //{
    //    private readonly ApplicationDbContext _dbContext;
    //    private readonly IMapper _mapper;

    //    public OrderService(ApplicationDbContext dbContext, IMapper mapper)
    //    {
    //        _dbContext = dbContext;
    //        _mapper = mapper;
    //    }

    //    //get all orders
    //    public async Task<IEnumerable<OrderDTO>> GetAllOrders()
    //    {
    //        var orders = await _dbContext.Orders.ToListAsync();
    //        return _mapper.Map<IEnumerable<OrderDTO>>(orders);
    //    }

    //    public async Task<OrderDTO> GetOrderById(int id)
    //    {
    //        var order = await _dbContext.Orders.FindAsync(id);
    //        if (order == null)
    //        {
    //            throw new Exception("Order not found");
    //        }
    //        return _mapper.Map<OrderDTO>(order);
    //    }

    //    public async Task<OrderDTO> CreateOrder(CreateOrderDTO createOrderDto)
    //    {
    //        var order = _mapper.Map<Order>(createOrderDto);
    //        await _dbContext.Orders.AddAsync(order);
    //        await _dbContext.SaveChangesAsync();
    //        return _mapper.Map<OrderDTO>(order);
    //    }

    //    public async Task<OrderDTO> UpdateOrder(int id, UpdateOrderDTO updateOrderDto)
    //    {
    //        var order = await _dbContext.Orders.FindAsync(updateOrderDto.Id);
    //        if (order == null)
    //        {
    //            throw new Exception("Order not found");
    //        }

    //        order = _mapper.Map(updateOrderDto, order);
    //        _dbContext.Orders.Update(order);
    //        await _dbContext.SaveChangesAsync();
    //        return _mapper.Map<OrderDTO>(order);
    //    }

    //    public async Task DeleteOrder(int id)
    //    {
    //        var order = await _dbContext.Orders.FindAsync(id);
    //        if (order == null)
    //        {
    //            throw new Exception("Order not found");
    //        }

    //        _dbContext.Orders.Remove(order);
    //        await _dbContext.SaveChangesAsync();
    //    }

    //}

}
