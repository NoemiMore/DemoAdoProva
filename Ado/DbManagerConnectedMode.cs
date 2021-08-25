using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado
{
    class DbManagerConnectedMode
    {
        // Server  -> (localdb)\MSSQLLocalDB
        // Nome del database -> DemoAdo
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                      "Initial Catalog = DemoAdo;" +
                                      "Integrated Security = true;";

        public void Fetch()
        {
            //Creo la connessione
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Apro la connessione
                connection.Open();

                // Definisco i comandi
                SqlCommand command = new SqlCommand();

                // Definisco i tipo
                command.CommandType = System.Data.CommandType.Text;

                // Associo il comando alla connessione
                command.Connection = connection;

                // Definisco la query
                command.CommandText = "select * from dbo.Book";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Per ogni riga leggo le colonne attraverso il nome
                    var title = reader["Title"];
                    var author = reader["Author"];
                    var price = reader["Price"];
                    var id = reader["Id"];

                    Console.WriteLine($"{title}, {author}, {price}, {id}");

                    // Per ogni riga leggo le colonne attraverso la posizione

                    var title2 = reader[0];
                    var author2 = reader[1];
                    var price2 = reader[2];
                    var id2 = reader[3];

                    Console.WriteLine($"{title2}, {author2}, {price2}, {id2}");
                }
                
                //Facoltativo se utilizzo la using della SqlConnection
                //connection.Close();
            }

        }

        public void GetById(int id)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                // Ai parametri posso dare il nome che voglio preceduto da @
                command.CommandText = "select * from dbo.Book where Id = @id";

                // Se ho dei parametri vado a definirli
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    var title = reader["Title"];
                    var author = reader["Author"];
                    var price = reader["Price"];
                    var id2 = reader["Id"];

                    Console.WriteLine($"{title}, {author}, {price}, {id2}");
                }
            }
        }

        public void Insert(string title, string author, double price)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "insert into dbo.Book values(@title, @author, @price)";

                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@price", price);

                //Non mi aspetto nessuna riga di ritorno(non legge nulla)
                command.ExecuteNonQuery();

            }
        }

        public void DeleteById(int id)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "delete dbo.Book where Id = @id";
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }

        public void Update(Book book)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "update dbo.Book " +
                                      "set Title = @title, Author = @author, Price = @price " +
                                      "where Id = @id";

                command.Parameters.AddWithValue("@title", book.Title);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@price", book.Price);
                command.Parameters.AddWithValue("@id", book.Id);

                command.ExecuteNonQuery();

            }
        }

        public void Count()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "select count(*) from dbo.Book";

                var numBooks = (int)command.ExecuteScalar();
            }
        }
        public List<Book> FetchToCount()
        {
            List<Book> books = new List<Book>();

            //Creo la connessione
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Apro la connessione
                connection.Open();

                // Definisco i comandi
                SqlCommand command = new SqlCommand();

                // Definisco i tipo
                command.CommandType = System.Data.CommandType.Text;

                // Associo il comando alla connessione
                command.Connection = connection;

                // Definisco la query
                command.CommandText = "select * from dbo.Book";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Per ogni riga leggo le colonne attraverso il nome
                    var title = reader["Title"];
                    var author = reader["Author"];
                    var price = reader["Price"];
                    var id = reader["Id"];

                    Book book = new Book((string)title, (string)author, (double)price, (int)id);

                    books.Add(book);
                }
            }

            return books;
        }
        public void CountWithCrud()
        {
            List<Book> books = FetchToCount();
            int numBooks = books.Count();
        }

    }
}
