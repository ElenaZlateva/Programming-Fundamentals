using System;

namespace _1._Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();


        }
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void PrintReceiptFooter() {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }
    }
}
