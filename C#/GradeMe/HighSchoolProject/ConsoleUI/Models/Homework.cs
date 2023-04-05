﻿namespace ConsoleUI.Models
{
    public class Homework : IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? IsComplete { get; set; }
        public int? Grade { get; set; }
    }
}
