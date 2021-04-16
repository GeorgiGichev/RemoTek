using Newtonsoft.Json;
using RemoTek.Services.DTOModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RemoTek.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public OrderService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<OrdersModel> GetLatestTenOrders()
        {
            var textJson = File.ReadAllText("../RemoTek.Data/data.json");
         
            var orders = JsonConvert.DeserializeObject<OrdersModel>(textJson);
           

            return orders;
        }
    }
}
