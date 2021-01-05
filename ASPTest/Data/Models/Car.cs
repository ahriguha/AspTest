using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTest.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string fullDescription { get; set; }
        public string image { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public virtual  Category Category { get; set; }
    }
}
