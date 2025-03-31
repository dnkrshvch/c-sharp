using System;
using System.Collections.Generic;

namespace ContactApp
{
    // стат. класс для для управления задачами
    public static class TaskManager
    {
        // стат. метод для подстчета задач по приоритету
        public static int CountTaskByPriority(List<Task> tasks, int priority)
        {
            int count = 0;
            foreach (var task in tasks)
            {
                if (task.Priority == priority)
                {
                    count++;
                }
            }
            return count;
        }

    }
}