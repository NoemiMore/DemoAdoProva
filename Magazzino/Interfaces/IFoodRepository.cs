using Magazzino.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.Interfaces
{
    interface IFoodRepository: IDbRepository<Food>
    {
        public List<Food> GetByDate(DateTime dt);
    }
}
