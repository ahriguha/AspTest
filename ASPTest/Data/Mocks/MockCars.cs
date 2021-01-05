using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTest.Data.Interfaces;
using ASPTest.Data.Models;

namespace ASPTest.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarCategory CarCategory = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                    new Car {name = "Tesla",
                    shortDescription = "Тесла",
                    fullDescription = "Ну это Тесла",
                    image = "https://images.drive.ru/i/0/5ea6dd8dec05c41134000004.jpg",
                    price = 12000,
                    isFavourite = true,
                    available = true,
                    Category = CarCategory.AllCategories.First()
                    },
                    new Car {name = "BMW",
                    shortDescription = "Бэха",
                    fullDescription = "Ну это бэха",
                    image = "https://lh3.googleusercontent.com/proxy/TMUTNWZj4iSXW" +
                    "tVehDTJRRNgWBxFhZCKHhHvi9Y1uPnfXsgYZ17hc7tanUZabhCOXKslBj6Ts5-vWGPDP1FNp2V4rg",
                    price = 7000,
                    isFavourite = true,
                    available = true,
                    Category = CarCategory.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getCarById(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
