using System;
using System.Collections.Generic;

namespace BooksLibrary
{
    public class Book
    {
        // поля
        private string title;
        private string author;
        private int year;
        private bool isCheckedOut;

        // конструктор
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.isCheckedOut = false;
        }

        // деструктор
        ~Book()
        {
            Console.WriteLine($"Книга'{title}' была удалена.");
        }
        // свойства доступа
        public string Title => title;
        public string Author => author;
        public int Year => year;
        public bool IsCheckedOut => isCheckedOut;


        public void CheckOut()
        {
            isCheckedOut = true;
        }
        public void Return()
        {
            isCheckedOut = false;
        }

        public string GetBookInfo()
        {
            return $"Название: {title}, Год: {year}, Статус: {(isCheckedOut ? "Взята" : "Доступна")}";
        }
    }

}