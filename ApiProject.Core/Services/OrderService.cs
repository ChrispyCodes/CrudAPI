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
}
