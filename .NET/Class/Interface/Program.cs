using System;
using System.Collections.Generic;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printer Interface Demo");
            Console.WriteLine("=====\n");

            // Create different printers
            IPrinter basicPrinter = new BasicPrinter("Office Printer");
            IPrinter colorPrinter = new ColorPrinter("Art Department Printer");
            IPrinter laserPrinter = new LaserPrinter("HR Laser Printer");

            // Store all printers in a list
            List<IPrinter> printers = new List<IPrinter>
            {
                basicPrinter,
                colorPrinter,
                laserPrinter
            };

            // Display printer status
            Console.WriteLine("Printer Status:");
            foreach (var printer in printers)
            {
                Console.WriteLine($"- {printer.GetStatus()}");
            }

            // Print documents
            Console.WriteLine("\n Printing Documents:");
            PrintDocument(basicPrinter, "Monthly Report");
            PrintDocument(colorPrinter, "Company Brochure");
            PrintDocument(laserPrinter, "Confidential Memo");

            // Print on all printers
            Console.WriteLine("\n Printing on all printers:");
            foreach (var printer in printers)
            {
                printer.Print("Important Announcement");
            }

            Console.WriteLine("\n Printing completed!");
        }

        // Method that works with ANY printer
        static void PrintDocument(IPrinter printer, string document)
        {
            Console.WriteLine($"\nSending to {printer.GetStatus()}...");
            printer.Print(document);
        }
    }
}