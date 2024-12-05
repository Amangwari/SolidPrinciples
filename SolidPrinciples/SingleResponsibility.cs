using System;

namespace SOLID_Principles.Controllers
{
    // ------------Example that violates/Breaching the Single Responsibility Principle
    public class Invoice
    {
        public void CalculateTotal()  //method
        {
            // Logic to calculate the total
            Console.WriteLine("Total calculated.");
        }

        public void PrintInvoice() // will invoice class if some kind of logic change
        {
            // Logic to print the invoice
            Console.WriteLine("Invoice printed.");
        }
    }


    //--------Example Following Single Responsibility Principle
    public class UserInvoice
    {
        public void CalculateTotal()
        {
            // Logic to calculate the total
            Console.WriteLine("Total calculated.");
        }
    }

    // Class responsible for printing the invoice
    public class InvoicePrinter
    {
        public void PrintInvoice()
        {
            // Logic to print the invoice
            Console.WriteLine("Invoice printed.");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Violation of SRP
    //        var invoice = new Invoice();
    //        invoice.CalculateTotal();
    //        invoice.PrintInvoice();

    //        Console.WriteLine("------");
    //        Console.WriteLine("------");

    //        // Following SRP
    //        var userInvoice = new UserInvoice();
    //        userInvoice.CalculateTotal();

    //        var printer = new InvoicePrinter();
    //        printer.PrintInvoice();
    //    }
    //}


}

