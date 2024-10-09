using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Category  //  principal entity
    {
        [Key]
        public int CategoryID { get; set; } // principal key
        public string? CategoryName { get; set; }
        public List<Product>? Products { get; set; } //navigation key

    }
}
