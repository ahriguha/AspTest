using System;
using System.Collections.Generic;
using System.Linq;
using ASPTest.Data.Models;
using System.Threading.Tasks;

namespace ASPTest.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> GetFavCars { get;}
        Car getCarById(int carId);
    }
}
