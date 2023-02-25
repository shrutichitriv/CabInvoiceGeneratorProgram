using CabInvoice;
using System.IO;

namespace CabInvoiceGenerator_244
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cab Invoice Generator Program");

            CabInvoiceGen cabInvoiceGenerator = new CabInvoiceGen(RideType.NORMAL);
            Console.WriteLine(cabInvoiceGenerator.CalculateFare(10, 15));
            Console.ReadLine();
        }
    }
}