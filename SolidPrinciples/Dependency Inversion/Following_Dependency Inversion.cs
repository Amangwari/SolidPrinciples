using System;

namespace DIP_FollowingExample
{
    // Abstraction (Database Interface)
    public interface IDatabase
    {
        void Save(string data);
    }

    // Low-level module (SQL Database)
    public class SqlDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine("Data saved to SQL Database.");
        }
    }

    // High-level module (UserService)
    public class UserService
    {
        private IDatabase _database;

        // Dependency Injection via constructor
        public UserService(IDatabase database)
        {
            _database = database; // Dependency injected
        }

        public void SaveUser(string user)
        {
            _database.Save(user); // Now calls the abstract interface
            Console.WriteLine($"User {user} saved.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Injecting SqlDatabase into UserService
            IDatabase database = new SqlDatabase();
            UserService userService = new UserService(database);
            userService.SaveUser("John Doe");
        }
    }
}
