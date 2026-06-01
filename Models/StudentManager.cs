using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class StudentManager
    {
        private List<Student> _students = new List<Student>();
        private int _nextId = 1;

        // Create - Yangi talaba qo'shish
        public void Create(string name, int age, int teacherId)
        {
            Student newStudent = new Student
            {
                Id = _nextId++,
                Name = name,
                Age = age,
                TeacherId = teacherId
            };
            _students.Add(newStudent);
            Console.WriteLine("Talaba muvaffaqiyatli qo'shildi!");
        }

        // Read - Barcha talabalarni ko'rish
        public void ReadAll()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("Hozircha talabalar yo'q.");
                return;
            }

            Console.WriteLine("\n--- Talabalar Ro'yxati ---");
            foreach (var student in _students)
            {
                Console.WriteLine($"ID: {student.Id} | Ism: {student.Name} | Yosh: {student.Age} | O'qituvchi ID: {student.TeacherId}");
            }
        }

        // Update - Talaba ma'lumotlarini o'zgartirish
        public void Update(int id, string newName, int newAge, int newTeacherId)
        {
            Student student = _students.Find(s => s.Id == id);
            if (student != null)
            {
                student.Name = newName;
                student.Age = newAge;
                student.TeacherId = newTeacherId;
                Console.WriteLine("Talaba ma'lumotlari yangilandi!");
            }
            else
            {
                Console.WriteLine("Bunday ID dagi talaba topilmadi.");
            }
        }

        // Delete - Talabani o'chirish
        public void Delete(int id)
        {
            Student student = _students.Find(s => s.Id == id);
            if (student != null)
            {
                _students.Remove(student);
                Console.WriteLine("Talaba o'chirildi!");
            }
            else
            {
                Console.WriteLine("Bunday ID dagi talaba topilmadi.");
            }
        }
    }
}