using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    // IDatabaseFactory arayüzünü uygulayan sınıfları kullanarak temel işlemleri yapar
    public class ProductManager
    {
        
        Connection _connection;
        Command _command;
        public ProductManager(IDatabaseFactory databaseFactory)
        {
            _command = databaseFactory.CreateCommand();
            _connection = databaseFactory.CreateConnection();
        }

        public void RemoveById(int id)
        {
            _connection.Open();
            _command.ExecuteCommand("Delete...");
            _connection.Close();
        }
    }
}
