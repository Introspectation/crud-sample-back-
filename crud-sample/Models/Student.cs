﻿namespace crud_sample.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
