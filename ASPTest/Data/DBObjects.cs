using ASPTest.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTest.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {  
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla",
                         shortDescription = "Тесла",
                         fullDescription = "Ну это Тесла",
                         image = "https://images.drive.ru/i/0/5ea6dd8dec05c41134000004.jpg",
                         price = 12000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Электродвигатель"]
                     },
                    new Car
                    {
                        name = "BMW",
                        shortDescription = "Бэха",
                        fullDescription = "Ну это бэха",
                        image = "https://autoua.net/media/uploads/bmw/bmw-serie-8-gran-coupe-2020.jpg",
                        price = 7000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["ДВС"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get { 
                if(category == null)
                {
                    var list = new Category[] {
                        new Category{ name = "Электродвигатель", description = "Автомобили с электродвигателем"},
                        new Category{ name = "ДВС", description = "Автомобили с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                        category.Add(element.name, element);
                }

                return category;
            }
        }
    }
}
