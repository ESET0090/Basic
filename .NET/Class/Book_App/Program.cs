using System;
using System.Collections.Generic;

namespace Book_APP
{
    internal class Program
    {
        static void Main()
        {
            // Lists to store our books and sales
            List<string> bookTitles = new List<string>();
            List<string> bookAuthors = new List<string>();
            List<double> bookPrices = new List<double>();
            List<int> bookQuantities = new List<int>();



            bool running = true;

            while (running)
            {
                // Show the menu
                Console.WriteLine("\n=== BOOK STORE MENU ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sell Book");
                Console.WriteLine("3. View Books");
                Console.WriteLine("4. View Sales");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option (1-5): ");

                // Get user choice
                string choice = Console.ReadLine();

                // Handle the choice
                if (choice == "1")
                {
                    AddBook(books);

                }
                else if (choice == "2")
                {
                    SellBook(books, sales);
                }
                else if (choice == "3")
                {
                    ViewBooks(books);
                }
                else if (choice == "4")
                {
                    ViewSales(sales);
                }
                else  (choice == "5")
                {
                    Console.WriteLine("Thank you for using Book Store!");
                    running = false;
                }
                
            }
        }


        // Method to add a book
        static void AddBook(List<string> books)
        {
            Console.Write("Enter book title: ");
            string bookTitle = Console.ReadLine();

            if (bookTitle != "")
            {
                books.Add(bookTitle);
                Console.WriteLine($"Added: {bookTitle}");
            }
            else
            {
                Console.WriteLine("Book title cannot be empty!");
            }
            Console.Write("Enter author: ")
            string Author = Console.ReadLine();

            if (Author != "")
            {
                books.Add(Author);
                Console.WriteLine($"Added: {Author}");
            }
            else
            {
                Console.WriteLine("Book Author is not defined")
            }
            if (Enter_Price = Console.ReadLine())
            {
                books.Add(Book_Price)
                Console.WriteLine($"Added: {Price)"}
            }
            
