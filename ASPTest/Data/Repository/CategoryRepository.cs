using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTest.Data.Interfaces;
using ASPTest.Data.Models;

namespace ASPTest.Data.Repository
{
    public class CategoryRepository : ICarCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
