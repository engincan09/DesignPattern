using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    public class ProductManager
    {
        IDatabaseFactory _databaseFactory;
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
