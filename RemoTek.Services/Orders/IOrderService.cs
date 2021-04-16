using RemoTek.Services.DTOModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemoTek.Services.Orders
{
    public interface IOrderService
    {
        Task<OrdersModel> GetLatestTenOrders();
    }
}
