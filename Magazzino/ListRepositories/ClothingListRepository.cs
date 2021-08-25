using Magazzino.Entities;
using Magazzino.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.ListRepositories
{
    class ClothingListRepository : IClothingRepository
    {
        static List<Clothing> clothings = new List<Clothing>
        {
            new Clothing("AB01", 23.67, "Maglia a maniche corte", "Zara", "S", null),
            new Clothing("AB02", 9.99, "Costume", "Zara", "M", null)
        };
        public void Delete(Clothing clothing)
        {
            clothings.Remove(clothing);
        }

        public List<Clothing> Fetch()
        {
            return clothings;
        }

        public Clothing GetById(int id)
        {
            return clothings.Find(c => c.Id == id);
        }

        public List<Clothing> GetBySize(string size)
        {
            return clothings.Where(c => c.Size == size).ToList();
        }

        public void Insert(Clothing clothing)
        {
            clothings.Add(clothing);
        }

        public void Update(Clothing t)
        {
            throw new NotImplementedException();
        }
    }
}
