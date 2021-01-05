using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTest.Data.Interfaces;
using ASPTest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPTest.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getCarById(int carId) => appDBContent.Car.FirstOrDefault(q => q.id == carId);
       
    }
}
