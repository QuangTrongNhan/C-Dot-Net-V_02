using System;
using System.Collections.Generic;
using System.Text;

namespace MyBookLibrary01
{
   public class BookManager
    {
        List<Book> listBooks = new List<Book>();
        public Book book = new Book();
        Utils utils = new Utils();

        //add book
        public void addBook()
        {
            string id, name,publisher;
            float price;
            int check = 0;
            do
            {
                Console.WriteLine("==========================================");
                id = utils.getCode("Enter your id: ");
                check = checkBookExist(id);
            } while (check == -1);
            name = utils.getName("Enter name: ");
            publisher = utils.getName("Enter publisher: ");
            price = utils.getPrice("Enter price", "Price must be than 0", "Price must be digit");

            Book book = new Book(id, name,publisher, price);
            listBooks.Add(book);
            Console.WriteLine("Add success");
            Console.WriteLine("==========================================");
        }

        //update book
        public void updateBook()
        {
            int check = 0;
            if (listBooks.Count == 0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("List items is empty!!!");
                Console.WriteLine("===============================");
            }
            else
            {
                Console.WriteLine("Enter id you want to update: ");
                string updateID = Console.ReadLine();
                check = checkBookExist(updateID);
                if (check == 1)
                {
                    Console.WriteLine("Book is not found!!!");
                    Console.WriteLine("=================================");
                }
                if (check == -1)
                {
                    for (var i = 0; i < listBooks.Count; i++)
                    {
                        if (listBooks[i].ID.Equals(updateID))
                        {
                            int index = i;
                            string name = utils.getName("Enter new name: ");
                            string publisher = utils.getName("Enter new Publisher: ");
                            float price = utils.getPrice("Enter new Price", "Price must be than 0", "Price must be charater");
                            Book bookUpdate = new Book(listBooks[i].ID, listBooks[i].Name = name,listBooks[i].Publisher = publisher ,listBooks[i].Price = price);
                            listBooks.RemoveAt(index);
                            listBooks.Add(bookUpdate);
                            Console.WriteLine("Update success!!!");
                            break;
                        }
                    }
                }             
                }
            }

        

        //delete book
        public void deleteBook()
        {
            int checkID = 0;
            if (listBooks.Count == 0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("List Book is empty!!!");
                Console.WriteLine("===============================");
            }
            else
            {
                Console.WriteLine("Input code you want to delete: ");
                string id = Console.ReadLine();
                checkID = checkBookExist(id);
                if (checkID == -1) //code exist
                {
                    for (int i = 0; i < listBooks.Count; i++)
                    {
                        if (listBooks[i].ID.Equals(id))
                        {
                            Console.WriteLine("Are you sure to delete? y/n");
                            string confirms = Console.ReadLine();
                            if (confirms.Equals("y"))
                            {
                                int index = i;
                                listBooks.RemoveAt(index);
                                Console.WriteLine("Delete success!!!!");
                                break;
                            }                     
                        }
                    }
                    
                }
            }

        }
        public int checkBookExist(string id)
        {
            for (int i = 0; i < listBooks.Count; i++)
            {
                if (listBooks[i].ID.Equals(id))
                {
                    Console.WriteLine("Id exist");
                    return -1;
                }
            }
            return 1;
        }

        public void showAll()
        {
            if (listBooks.Count == 0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("List items is empty!!!");
                Console.WriteLine("===============================");
            }
            for (var i = 0; i < listBooks.Count; i++)
            {
                Console.WriteLine("ID: {0}   Name: {1}   Publisher:{2}   Price: {3}", listBooks[i].ID, listBooks[i].Name, listBooks[i].Publisher,listBooks[i].Price);
                Console.WriteLine("=============================");
            }
        }
    }
}
