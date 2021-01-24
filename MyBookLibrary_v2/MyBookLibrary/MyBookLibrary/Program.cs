using System;
using MyBookLibrary01;
namespace MyBook
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager book = new BookManager();
            do
            {
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Update Book");
                Console.WriteLine("3.Delete Book");
                Console.WriteLine("4.Show Book");
                Console.WriteLine("5.Quit");
                Console.WriteLine("Enter your choice:");
                string yourChoice = Console.ReadLine();
                switch (yourChoice)
                {
                    case "1":
                        //add book
                        book.addBook();
                        break;
                    case "2":
                        //update book
                        book.updateBook();
                        break;
                    case "3":
                        book.deleteBook();
                        break;
                    case "4":
                        //show book
                        book.showAll();
                        break;
                    case "5":
                        //quit                     
                        Console.WriteLine("GoodBye!!!!");
                        System.Environment.Exit(1);
                        break;

                }
            } while (true);
        }
    }
}
    

