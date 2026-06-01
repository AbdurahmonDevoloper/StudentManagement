using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class TeacherManager
    {
        private List<Teacher> _teachers = new List<Teacher>();
        private int _nextId = 1;

        // Create - Yangi o'qituvchi qo'shish
        public void Create(string name, string subject)
        {
            Teacher newTeacher = new Teacher
            {
                Id = _nextId++,
                Name = name,
                Subject = subject
            };
            _teachers.Add(newTeacher);
            Console.WriteLine("O'qituvchi muvaffaqiyatli qo'shildi!");
        }

        // Read - Barcha o'qituvchilarni ko'rish
        public void ReadAll()
        {
            if (_teachers.Count == 0)
            {
                Console.WriteLine("Hozircha o'qituvchilar yo'q.");
                return;
            }

            Console.WriteLine("\n--- O'qituvchilar Ro'yxati ---");
            foreach (var teacher in _teachers)
            {
                Console.WriteLine($"ID: {teacher.Id} | Ism: {teacher.Name} | Fan: {teacher.Subject}");
            }
        }

        // Update - O'qituvchi ma'lumotlarini o'zgartirish
        public void Update(int id, string newName, string newSubject)
        {
            Teacher teacher = _teachers.Find(t => t.Id == id);
            if (teacher != null)
            {
                teacher.Name = newName;
                teacher.Subject = newSubject;
                Console.WriteLine("O'qituvchi ma'lumotlari yangilandi!");
            }
            else
            {
                Console.WriteLine("Bunday ID dagi o'qituvchi topilmadi.");
            }
        }

        // Delete - O'qituvchini o'chirish
        public void Delete(int id)
        {
            Teacher teacher = _teachers.Find(t => t.Id == id);
            if (teacher != null)
            {
                _teachers.Remove(teacher);
                Console.WriteLine("O'qituvchi o'chirildi!");
            }
            else
            {
                Console.WriteLine("Bunday ID dagi o'qituvchi topilmadi.");
            }
        }

        // Qo'shimcha metod: Id bo'yicha tekshirish uchun
        public bool Exists(int id)
        {
            return _teachers.Exists(t => t.Id == id);
        }
    }
}