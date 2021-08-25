using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.Entities
{
    class Clothing: Product
    {
        public string Brand { get; set; }
        public string Size { get; set; }

        public Clothing(string code, double price, string description, string brand, string size, int? id)
            : base(code, price, description, id)
        {
            Brand = brand;
            Size = size;
        }

        public override string Print()
        {
            return $"{base.Print()} - {Brand} - {Size}";
        }
    }
}
