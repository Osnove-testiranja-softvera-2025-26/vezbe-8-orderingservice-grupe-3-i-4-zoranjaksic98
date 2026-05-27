using NUnit.Framework;
using OTS2023_V9.Services;
using OTS2023_V9.Services.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingService.Test
{
    [TestFixture]
    public class CalculationServiceTest
    {
        [Test]
        public void CheckCouponValidity_ShouldReturnTrue_FakeImplementation() 
        {
            // AARANGE
            FakeCouponService fakeCouponService = new FakeCouponService();
            FakeOrderService fakeOrderService = new FakeOrderService();
            CalculationService calculationService = new CalculationService(fakeOrderService, fakeCouponService, null);

            //ACT



            //ASSERT
        }
    }
}
