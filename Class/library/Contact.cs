using System;
using System.Collections.Generic;

namespace ContactApp
{
    public class Contact
    {
        //поля
        private string name;
        private string phoneNumber;
        private string email;
        // конструктор
        public Contact(string name, string phoneNumber, string email)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.phoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
        }
        // свойства доступа
        public string Name
        {
            get { return name; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        public string Email
        {
            get { return email; }
        }
        // перешрузка метода вывода информации о человеке
        public override string ToString()
        {
            return $"Name: {Name}, Phone: {PhoneNumber}, Email: {Email}";
        }
    }
}