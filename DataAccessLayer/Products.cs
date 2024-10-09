using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Product //dependent entity
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }  //foreign key
        public Category Category { get; set; }  //navigation property
    }
}
