using Magazzino.Entities;
using Magazzino.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino.ListRepositories
{
    class ProductListRepository : IProductRepository
    {
        public static ClothingListRepository clothingRepository = new ClothingListRepository();
        public static FoodListRepository foodRepository = new FoodListRepository();
        public static EletronicListRepository eletronicRepository = new EletronicListRepository();

        static List<Product> products = new List<Product>();

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> Fetch()
        {
            products.Clear();

            products.AddRange(clothingRepository.Fetch());
            products.AddRange(foodRepository.Fetch());
            products.AddRange(eletronicRepository.Fetch());

            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByPrice(double price)
        {
            return products.Where(p => p.Price <= price).ToList(); ;
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
