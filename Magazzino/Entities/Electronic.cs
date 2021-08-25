using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.Entities
{
    class Electronic: Product
    {
        public string Producer { get; set; }
        public string Model { get; set; }

        public Electronic(string code, double price, string description, string producer, string model, int? id)
           : base(code, price, description, id)
        {
            Producer = producer;
            Model = model;
        }

        public override string Print()
        {
            return $"{base.Print()} - {Producer} - {Model}";
        }
    }
}
