using System;
using System.Collections.Generic;

namespace BooksLibrary
{
    class User
    {
        private string name;
        private string email;
        private List<Book> booksCheckedOut;


        // конструктор
        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
            this.booksCheckedOut = new List<Book>();
        }

        public string Name => name;
        public string Email => email;

        public void CheckOutBook(Book book)
        {
            if (!book.IsCheckedOut)
            {
                book.CheckOut();
                booksCheckedOut.Add(book);
                Console.WriteLine($"{name} взял книгу: {book.Title}");
            }
            else
            {
                Console.WriteLine($"Книга '{book.Title}' уже взята");
            }
        }
        public void GetBooksCheckedOutInfo()
        {
            if (booksCheckedOut.Count == 0)
            {
                Console.WriteLine($"{name} не взял ни одной книги.");
                return;
            }
            Console.WriteLine($"{name} взял следующие книги: ");
            foreach (var book in booksCheckedOut)
            {
                Console.WriteLine(book.GetBookInfo());
            }
        }
    }
}