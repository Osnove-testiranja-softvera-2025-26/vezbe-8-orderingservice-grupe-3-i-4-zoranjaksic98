using OTS2023_V9.Models;
using OTS2023_V9.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_V9.Services.Fakes
{
    public class FakeCouponService : ICouponService
    {
        // moze i ovako
        // public Coupon coupon { get; set;}
        public Guid CouponId { get; set; }
        public Coupon GetCouponById(Guid id)
        {
           // return new Coupon();
           Coupon coupon = new Coupon();
            coupon.Id = Guid.Parse("5a55f1de-9f68-4e8b-b85e-27a49904d28e");
            coupon.Code = "FAKECODE";
            coupon.Amount = 101.0;
            coupon.Used = false;
            return coupon;
         //   throw new NotImplementedException();
        }

        public void UseCoupon(Guid id)
        {
            // coupon.Id = id;
            CouponId = id;
         //   throw new NotImplementedException();
        }
    }
}
