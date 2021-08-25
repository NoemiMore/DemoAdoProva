using Concessionario.Entities;
using Concessionario.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionario.ThirdMethodRepository
{
    class CarTMRepository : ICarDbManager
    {
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                         "Initial Catalog = Magazzino3;" +
                                         "Integrated Security = true;";

        const string _discriminator = "Car";
        public void Delete(Car car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "delete from Vehicle where Id = @id";
                command.Parameters.AddWithValue("@id", car.Id);

                command.ExecuteNonQuery();
            }
        }

        public List<Car> Fetch()
        {
            List<Car> cars = new List<Car>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Vehicle where Discriminator = @discriminator";
                command.Parameters.AddWithValue("@discriminator", _discriminator);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var brand = (string)reader["Brand"];
                    var model = (string)reader["Model"];
                    var supply = (PowerSupply)reader["Supply"];
                    var doors = (int)reader["DoorsNumber"];
                    var id = (int)reader["Id"];

                    Car car = new Car(brand, model, supply, doors, id);
                    cars.Add(car);
                }
            }
            return cars;
        }

        public Car GetById(int? id)
        {
            Car car = new Car();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Vehicle where Id = @id";
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var brand = (string)reader["Brand"];
                    var model = (string)reader["Model"];
                    var supply = (PowerSupply)reader["Supply"];
                    var doors = (int)reader["DoorsNumber"];

                    car = new Car(brand, model, supply, doors, id);
                }
            }
            return car;
        }

        public void Insert(Car car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                //  insert into Vehicle values('Brand di prova', 'Model di prova', 1111, null, null, null, 'Motocycle')
                command.CommandText = "insert into Vehicle values (@brand, @model, @year, @supply, @doors, @seats, @discriminator)";
                command.Parameters.AddWithValue("@brand", car.Brand);
                command.Parameters.AddWithValue("@model", car.Model);
                command.Parameters.AddWithValue("@year", DBNull.Value);
                command.Parameters.AddWithValue("@supply", car.Supply);
                command.Parameters.AddWithValue("@doors", car.DoorsNumber);
                command.Parameters.AddWithValue("@seats", DBNull.Value);
                command.Parameters.AddWithValue("@discriminator", _discriminator);

                command.ExecuteNonQuery();
            }
        }

        public void Update(Car car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "update Vehicle " +
                                      "set Brand = @brand, Model = @model, ProductionYear = @year, " +
                                      "Supply = @supply, DoorsNumber = @doors, SeatsNumber = @seats, Discriminator = @discriminator" +
                                      "where Id = @id";
                command.Parameters.AddWithValue("@brand", car.Brand);
                command.Parameters.AddWithValue("@model", car.Model);
                command.Parameters.AddWithValue("@year", DBNull.Value);
                command.Parameters.AddWithValue("@supply", car.Supply);
                command.Parameters.AddWithValue("@doors", car.DoorsNumber);
                command.Parameters.AddWithValue("@seats", DBNull.Value);
                command.Parameters.AddWithValue("@discriminator", _discriminator);

                command.ExecuteNonQuery();
            }
        }
    }
}
