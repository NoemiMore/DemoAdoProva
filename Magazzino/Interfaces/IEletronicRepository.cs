using Magazzino.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.Interfaces
{
    interface IEletronicRepository: IDbRepository<Electronic>
    {
        public List<Electronic> GetByProducer(string producer);
    }
}
