using OTS2023_V9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_V9.Services.Fakes
{
    public class FakeOrderService : IOrderService
    {
        public double TotalDiference { get; set; }
        public Order GetOrderById(Guid id)
        {
            return new Order
            {
                Id = Guid.Parse("5a55f1de-9f68-4e8b-b85e-27a49904d28e"),
                OrderCreatedDate = new DateTime(2000, 1, 1),
                OrderDeadlineDate = new DateTime(2000, 2, 1),
                Total = 100.0,
                Status = Status.Delivered
            };
        }

        public List<Order> GetUserOrdersWithDeadlineBetween(Guid userId, DateTime monthBefore, DateTime now)
        {
            Order order = new Order
            {
                Id = Guid.Parse("5a55f1de-9f68-4e8b-b85e-27a49904d28e"),
                OrderCreatedDate = new DateTime(2000, 1, 1),
                OrderDeadlineDate = new DateTime(2000, 2, 1),
                Total = 100.0,
                Status = Status.Delivered
            };
            return new List<Order> { order };
        }

        public void UpdateTotal(double difference)
        {
            TotalDiference = difference;
        }
    }
}
