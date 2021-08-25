using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.Entities
{
    class Food: Product
    {
        public DateTime ExpirationDate { get; set; }

        public Food(string code, double price, string description, DateTime expirationDate, int? id)
            : base(code, price, description, id)
        {
            ExpirationDate = expirationDate;
        }


        public override string Print()
        {
            return $"{base.Print()} - {ExpirationDate}";
        }
    }
}
