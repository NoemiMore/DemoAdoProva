using Magazzino.Entities;
using Magazzino.ListRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class MagazzinoManager
    {
        public static ClothingListRepository clothingRepository = new ClothingListRepository();
        public static FoodListRepository foodRepository = new FoodListRepository();
        public static EletronicListRepository electronicRepository = new EletronicListRepository();
        public static ProductListRepository productRepository = new ProductListRepository();
        internal static void ShowProduct()
        {
            List<Product> prodotti = productRepository.Fetch();
            Print(prodotti);
        }

        private static void Print(List<Product> prodotti)
        {
            foreach (var prodotto in prodotti)
            {
                prodotto.Print();
            }
        }

        internal static void FilterByPrice()
        {
            double price = AskPrice();
            List<Product> prodotti = productRepository.GetByPrice(price);
            Print(prodotti);
        }

        private static double AskPrice()
        {
            double price;
            do
            {
                Console.WriteLine("Inserisci il prezzo");
            } while (!double.TryParse(Console.ReadLine(), out price));

            return price;
        }

        internal static void FilterByDate()
        {
            DateTime dt = AskDate();
            List<Food> foods = foodRepository.GetByDate(dt);
            Print(foods);
        }
        private static void Print(List<Food> prodotti)
        {
            foreach (var prodotto in prodotti)
            {
                prodotto.Print();
            }
        }

        internal static void FilterByProducer()
        {
            string producer = AskProducer();
            List<Electronic> electronics = electronicRepository.GetByProducer(producer);
            Print(electronics);
        }

        private static void Print(List<Electronic> electronics)
        {
            foreach (var prodotto in electronics)
            {
                prodotto.Print();
            }
        }

        private static string AskProducer()
        {
            string producer;
            do
            {
                Console.WriteLine("Inserisci il produttore");
                producer = Console.ReadLine();
            } while (String.IsNullOrEmpty(producer));

            return producer;
        }

        internal static void FilterBySize()
        {
            string size = AskSize();
            List<Clothing> clothings = clothingRepository.GetBySize(size);
            Print(clothings);
        }
        private static void Print(List<Clothing> prodotti)
        {
            foreach (var prodotto in prodotti)
            {
                prodotto.Print();
            }
        }
        private static string AskSize()
        {
            string size;
            do
            {
                Console.WriteLine("Inserisci una data");
                size = Console.ReadLine();
            } while (String.IsNullOrEmpty(size));

            return size;
        }

        private static DateTime AskDate()
        {
            DateTime dt;
            do
            {
                Console.WriteLine("Inserisci una data");
            } while (!DateTime.TryParse(Console.ReadLine(), out dt));

            return dt;
        }
    }
}
