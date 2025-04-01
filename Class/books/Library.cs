using System;
using System.Collections.Generic;

namespace BooksLibrary
{
    public static class Library
    {
        private static List<Book> allBooks = new List<Book>();
        public static void AddBook(Book book)
        {
            allBooks.Add(book);
        }
        public static int GetTotalBooks()
        {
            return allBooks.Count;
        }
        public static int GetCheckedOutBooksCount()
        {
            int count = 0;
            foreach (var book in allBooks)
            {
                if (book.IsCheckedOut)
                {
                    count++;
                }
            }
            return count;
        }
    }
}