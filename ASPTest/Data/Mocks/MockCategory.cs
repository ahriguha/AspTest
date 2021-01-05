using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTest.Data.Interfaces;
using ASPTest.Data.Models;

namespace ASPTest.Data.Mocks
{
    public class MockCategory : ICarCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category{ name = "Электродвигатель", description = "Автомобили с электродвигателем"},
                    new Category{ name = "ДВС", description = "Автомобили с двигателем внутреннего сгорания"},
                };
            }
        }

    }
}
