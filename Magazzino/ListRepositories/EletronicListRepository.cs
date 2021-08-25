using Magazzino.Entities;
using Magazzino.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.ListRepositories
{
    class EletronicListRepository : IEletronicRepository
    {
        static List<Electronic> electronics = new List<Electronic>
        {
            new Electronic("EL01", 200, "Cuffie", "Samsung", "Cuffiette", null),
            new Electronic("EL02", 899.99, "Cellulare", "Samsung", "Cellulare", null)
        };
        public void Delete(Electronic eletronic)
        {
            electronics.Remove(eletronic);
        }

        public List<Electronic> Fetch()
        {
            return electronics;
        }

        public Electronic GetById(int id)
        {
            return electronics.Find(e => e.Id == id);
        }

        public List<Electronic> GetByProducer(string producer)
        {
            return electronics.Where(e => e.Producer == producer).ToList();
        }

        public void Insert(Electronic eletronic)
        {
            electronics.Add(eletronic);
        }

        public void Update(Electronic eletronic)
        {
            throw new NotImplementedException();
        }
    }
}
