using System;
using System.Collections.Generic;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var contact1 = new Contact("Person1", "+1234567890", "person1@example.com");
            var contact2 = new Contact("Person2", "+9876543210", "person2@example.com");

            // создание задач
            var task1 = new Task("Finish the report", DateTime.Now.AddDays(2), 1);
            var task2 = new Task("Call the client", DateTime.Now.AddDays(1), 2);
            var task3 = new Task("Prepare for the meeting", DateTime.Now.AddDays(3), 1);

            // создание объектов
            var contactWithTasks1 = new ContactWithTasks(contact1);
            contactWithTasks1.AddTask(task1);
            contactWithTasks1.AddTask(task2);

            var contactWithTasks2 = new ContactWithTasks(contact2);
            contactWithTasks2.AddTask(task3);

            //вывод информации
            Console.WriteLine(contactWithTasks1.Contact);
            foreach (var task in contactWithTasks1.Tasks)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine(contactWithTasks2.Contact);
            foreach (var task in contactWithTasks2.Tasks)
            {
                Console.WriteLine(task);
            }

            //использование метода для подст=чета задач
            int highPriorityCount = TaskManager.CountTaskByPriority(contactWithTasks1.Tasks, 1);
            Console.WriteLine($"Высокий приоритет для задач: {contactWithTasks1.Contact.Name}: {highPriorityCount}");
        }
    }
}