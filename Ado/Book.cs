using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }

        public Book(string title, string author, double price, int id)
        {
            Title = title;
            Author = author;
            Price = price;
            Id = id;
        }

    }
}
