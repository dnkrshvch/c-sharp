using System;
using System.Collections.Generic;

namespace ContactApp
{
    // для работы с людьми и задачами
    public class ContactWithTasks
    {
        public Contact Contact { get; set; }
        public List<Task> Tasks { get; set; }


        public ContactWithTasks(Contact contact)
        {
            Contact = contact;
            Tasks = new List<Task>();
        }

        // для добавления задач
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}