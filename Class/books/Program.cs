using System;
using System.Collections.Generic;

namespace BooksLibrary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book("1984", "Джордж Оруэлл", 1949);
            Book book2 = new Book("Преступление и наказание", "Фёдор Достоевский", 1866);
            Book book3 = new Book("Война и мир", "Лев Толстой", 1869);

            Library.AddBook(book1);
            Library.AddBook(book2);
            Library.AddBook(book3);

            User user1 = new User("Иван Иванов", "ivan@mail.com");
            User user2 = new User("Мария Петрова", "maria@mail.com");

            user1.CheckOutBook(book1);
            user2.CheckOutBook(book2);

            user1.GetBooksCheckedOutInfo();
            user2.GetBooksCheckedOutInfo();

            Console.WriteLine($"Общее количество книг в библиотеке: {Library.GetTotalBooks()}");
            Console.WriteLine($"Количество книг, которые были взяты: {Library.GetCheckedOutBooksCount()}");
        }
    }
}
