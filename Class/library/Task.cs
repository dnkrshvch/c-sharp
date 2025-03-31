using System;
using System.Collections.Generic;

namespace ContactApp {
        // Структура хранения информации о задаче
    public struct Task
    {
        public string Description { get; }
        public DateTime DueDate { get; }
        public int Priority { get; }

        // Конструктор
        public Task(string description, DateTime dueDate, int priority)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
            DueDate = dueDate;
            Priority = priority;
        }

        // перешрузка метода вывода информации о человеке
        public override string ToString()
        {
            return $"Description: {Description}, DueDate: {DueDate.ToShortDateString()}, Priority: {Priority}";
        }
    }
}