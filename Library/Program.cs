using System;
using System.Collections;
using System.Linq;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agregar a la base de datos
            InsertData();
            ListData();
            string read = Console.ReadLine();
            Console.Clear();
            ModifyData();
            ListData();
            read = Console.ReadLine();
            Console.Clear();
            DeleteData();
            ListData();
            read = Console.ReadLine();
            Console.Clear();

        }

        public static void InsertData()
        {
            using (var context = new BookContext())
            {
                context.Books.Add(new Book() { Title = "Fundamentals of Computer Programming with C#" });
                context.Books.Add(new Book() { Title = "Java: A Beginner's Guide" });
                context.Books.Add(new Book() { Title = "Learn VB.NET" });
                context.Books.Add(new Book() { Title = "C# Fundamentals for Absolute Beginners" });
                context.Books.Add(new Book() { Title = "SQL: The Ultimate Beginners Guide" });
                context.SaveChanges();
            }
        }

        public static void ListData()
        {
            using (var context = new BookContext())
            {
                var books = context.Books.ToList();
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }

        public static void ModifyData()
        {
            using (var context = new BookContext())
            {
                var book = context.Books.FirstOrDefault();
                book.Title = "Voy a borrar este libro";
                context.SaveChanges();
            }
        }

        public static void DeleteData()
        {
            using (var context = new BookContext())
            {
                var Book = context.Books.Where(a => a.Title == "Voy a borrar este libro").FirstOrDefault();
                context.Books.Remove(Book);
                context.SaveChanges();
            }
        }
    }
}
