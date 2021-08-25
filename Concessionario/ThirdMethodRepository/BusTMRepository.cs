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
    class BusTMRepository : IBusDbManager
    { const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                         "Initial Catalog = Magazzino3;" +
                                         "Integrated Security = true;";
         const string _discriminator = "Car";
 }