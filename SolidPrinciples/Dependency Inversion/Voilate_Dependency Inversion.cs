using System;

namespace DIP_ViolatingExample
{
    // Low-level module (Database)
    public class Database
    {
        public void Save(string data)
        {
            Console.WriteLine("Data saved to SQL Database.");
        }
    }

    // High-level module (UserService)
    public class UserService
    {
        private Database _database;

        public UserService()
        {
            _database = new Database(); // Direct dependency on Database
        }

        public void SaveUser(string user)
        {
            _database.Save(user); // Direct call to Database class
            Console.WriteLine($"User {user} saved.");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        UserService userService = new UserService();
    //        userService.SaveUser("John Doe");
    //    }
    //}
}
