using ApiProject.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Services.Interfaces
{
    public interface IOrderService : ICrudService<Order, CreateOrderDTO, UpdateOrderDTO, OrderDTO>
    {
        
        //Task<IEnumerable<OrderDTO>> GetAllOrders();
        //Task<OrderDTO> GetOrderById(int id);
        //Task<OrderDTO> CreateOrder(CreateOrderDTO order);
        //Task<OrderDTO> UpdateOrder(int id, UpdateOrderDTO order);
        //Task DeleteOrder(int id);

    }
}
