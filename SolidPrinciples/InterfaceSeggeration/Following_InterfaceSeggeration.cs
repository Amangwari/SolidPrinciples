using System;

namespace ISP_FollowingExample
{
    // Interface for classes that can work
    public interface IWorkable
    {
        void Work();
    }

    // Interface for classes that need to eat
    public interface IEdible
    {
        void Eat();
    }

    // Worker class that implements both IWorkable and IEdible
    public class Worker : IWorkable, IEdible
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

    // Robot class only implements IWorkable, since it doesn't need to eat
    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot working...");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    IWorkable worker = new Worker();
        //    worker.Work();
        //    IEdible edibleWorker = new Worker();
        //    edibleWorker.Eat();

        //    IWorkable robot = new Robot();
        //    robot.Work();
        //    // Robot does not implement IEdible, so no need to call Eat
        //}
    }
}
