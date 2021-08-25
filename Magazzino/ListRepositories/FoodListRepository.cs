using Magazzino.Entities;
using Magazzino.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.ListRepositories
{
    class FoodListRepository : IFoodRepository
    {
        static List<Food> foods = new List<Food>
        {
            new Food("AL01", 3.50, "Gelato", new DateTime(2021, 12,31), null),
            new Food("AL02", 1.99, "Jogurt", new DateTime(2021, 08,30), null)
        };
        public void Delete(Food food)
        {
            foods.Remove(food);
        }

        public List<Food> Fetch()
        {
            return foods;
        }

        public List<Food> GetByDate(DateTime dt)
        {
            throw new NotImplementedException();
        }

        public Food GetById(int id)
        {
            return foods.Find(f => f.Id == id);
        }

        public void Insert(Food food)
        {
            foods.Add(food);
        }

        public void Update(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
