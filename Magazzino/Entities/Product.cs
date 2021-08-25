using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.Entities
{
    class Product
    {
        public string Code { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int? Id { get; set; }

        public Product(string code, double price, string description, int? id)
        {
            Code = code;
            Price = price;
            Description = description;
        }

        public virtual string Print()
        {
            return $"{Code} - {Description} - {Price}";
        }
    }
}
