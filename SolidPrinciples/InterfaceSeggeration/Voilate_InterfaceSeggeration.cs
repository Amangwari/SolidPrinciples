using System;

namespace ISP_ViolatingExample
{
    // ------Large Interface - Violates Interface Segregation Principle 
    public interface IWorker
    {
        void Work();      // All workers must implement this
        void Eat();       // All workers must implement this, even if not needed
    }

    // Worker class that implements the IWorker interface
    public class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working...");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Robot class - Doesn't need Eat method, but is forced to implement it
    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot working...");
        }

        public void Eat()
        {
            // Robots don't eat, but still forced to implement
            Console.WriteLine("Robot doesn't eat.");
        }
    }
    // ------Large Interface - Violates Interface Segregation Principle 




    class Program
    {
        //static void Main(string[] args)
        //{
        //    IWorker worker = new Worker();
        //    worker.Work();
        //    worker.Eat();

        //    IWorker robot = new Robot();
        //    robot.Work();
        //    robot.Eat();  // This violates the ISP because robots don't need to eat!
        //}
    }
}
