using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTest.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> shopItemsList { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }
        public List<ShopCartItem> GetShopItems()
        {
            //return appDBContent.ShopCartItem.AsQueryable().Include(s => s.car).Where(c => c.shopCartId == ShopCartId).ToList();
            /*var list = from p in appDBContent.ShopCartItem
                       where p.id == int.Parse(ShopCartId)
                       select new ShopCartItem
                       {
                           id = p.id,
                           car = p.car,
                           price = p.car.price
                       };
            return list.ToList(); ;*/
            return appDBContent.ShopCartItem                
                .Select(s => new ShopCartItem
                {
                    id = s.id,
                    car = s.car,
                    price = s.price,
                    shopCartId = s.shopCartId
                })                
                .Where(c => c.shopCartId == ShopCartId)
                .ToList();
               
        }
        public void AddToCart(Car car)
        {
            this.appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                shopCartId = ShopCartId,
                car = car,
                price = car.price
            });

            appDBContent.SaveChanges();
        }
        


    }
}
