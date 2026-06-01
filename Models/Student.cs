using System;

namespace StudentManagement
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TeacherId { get; set; } // Talabaning o'qituvchisi kimligini bilish uchun
    }
}