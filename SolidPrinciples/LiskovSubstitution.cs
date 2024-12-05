using System;

namespace LSP_Principles.Controllers
{
    // ------------Example that violates/Breaching the Liskov Substitution Principle 
    public class MyBird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    // Derived class - Eagle
    public class Eagle : MyBird
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle is flying high.");
        }
    }

    // Derived class - Penguin (violates LSP)
    public class Penguin : MyBird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("Penguins cannot fly.");
        }
    }
    // ------------Example that violates/Breaching the Liskov Substitution Principle







    // ------------Example that Following the Liskov Substitution Principle
    // Base class - Bird
    public abstract class Bird
    {
        public abstract void Eat();
    }

    // Interface for flying birds
    public interface IFlyable
    {
        void IsFly();
    }


    public class Eagles : Bird, IFlyable // Derived class - Eagle (implements IFlyable)
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle is eating.");
        }

        public void IsFly()
        {
            Console.WriteLine("Eagle is flying high.");
        }
    }

    // Derived class - Penguin (does not implement IFlyable)
    public class Penguins : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Penguin is eating.");
        }

        // Penguins do not fly, so no Fly method here
    }
    // ------------Example that Following the Liskov Substitution Principle






    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Violation of LSP'
        //    //MyBird eagle = new Eagle();
        //    //eagle.Fly();  // Works fine
        //    //MyBird penguin = new Penguin();
        //    //penguin.Fly();  // Throws an exception, breaking expected behavior



        //    // Following LSP
        //    Bird myeagle = new Eagles();
        //    myeagle.Eat();  // Eagle eats
        //    IFlyable flyableEagle = myeagle as IFlyable;
        //    flyableEagle?.IsFly();  // Eagle flies

        //    Bird mypenguin = new Penguins();
        //    mypenguin.Eat();  // Penguin eats and  No need to call Fly on Penguin, it doesn't support it

        //}
    }


}

