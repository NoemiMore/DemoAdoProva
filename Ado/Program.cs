using System;

namespace Ado
{
    class Program
    {
        static void Main(string[] args)
        {
            DbManagerConnectedMode dbm = new DbManagerConnectedMode();

            dbm.Count();

            //Book book = new Book("Decamerone", "Pluto", 15.2, 9);

            ////Modifica l'autore (Console writeline)
            //string author = "Omero"; //Prendo in ingresso dalla readline

            //book.Author = author;

            Book book = new Book("Decamerone", "Giovanni Boccaccio", 32.6, 10);

            dbm.Update(book);

            dbm.DeleteById(4);

            dbm.Insert("1984", "George Orwell", 20.5);

            dbm.GetById(2);

            dbm.Fetch();


        }
    }
}
