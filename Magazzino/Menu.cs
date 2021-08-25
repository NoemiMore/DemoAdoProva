using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class Menu
    {
        internal static void Start()
        {
            bool continuare = true;
            int scelta;

            while (continuare)
            {
                Console.WriteLine("Premi 1 per vedere tutti i prodotti");
                Console.WriteLine("Premi 2 per filtrare i prodotti per prezzo");
                Console.WriteLine("Premi 3 per filtrare gli alimentari per data");
                Console.WriteLine("Premi 4 per filtrare l'abbigliamento per taglia");
                Console.WriteLine("Premi 5 per filtrare gli elettrodomestici per marca");
                Console.WriteLine("Premi 0 per uscire");

                do
                {
                    Console.WriteLine("Fai la tua scelta");
                } while (!int.TryParse(Console.ReadLine(), out scelta));

                switch (scelta)
                {
                    case 1:
                        {
                            MagazzinoManager.ShowProduct();
                            break;
                        }
                    case 2:
                        {
                            MagazzinoManager.FilterByPrice();
                            break;
                        }
                    case 3:
                        {
                            MagazzinoManager.FilterByDate();
                            break;
                        }
                    case 4:
                        {
                            MagazzinoManager.FilterBySize();
                            break;
                        }
                    case 5:
                        {
                            MagazzinoManager.FilterByProducer();
                            break;
                        }
                    case 0:
                        {
                            continuare = false;
                            break;
                        }
                }
            }
        }
    }
}
