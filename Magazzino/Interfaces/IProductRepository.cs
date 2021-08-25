using Magazzino.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.Interfaces
{
    interface IProductRepository: IDbRepository<Product>
    {
        public List<Product> GetByPrice(double price);
    }
}
