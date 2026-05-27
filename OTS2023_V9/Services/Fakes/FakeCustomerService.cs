using OTS2023_V9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_V9.Services.Fakes
{
    public class FakeCustomerService : ICustomerService
    {
        public Customer GetCustomerById(Guid id)
        {
            return new Customer
            {
                Id = Guid.Parse("576d10a2-4c6b-4bbc-9f69-5de84b4a2638\r\n02b61707-13da-44f6-a25c-0a63f93d83ac")
            };
        }
    }
}
