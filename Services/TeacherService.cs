using System;
using System.Collections.Generic;
using System.Linq;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public class TeacherService
    {
        private readonly Dictionary<Guid, Teacher> _teachers = new Dictionary<Guid, Teacher>();


        public void Create(Teacher teacher)
        {
            _teachers.Add(teacher.Id, teacher);
            Console.WriteLine("O'qituvchi muvaffaqiyatli qo'shildi!");
        }

        
        public void ReadAll()
        {
            if (_teachers.Count == 0)
            {
                Console.WriteLine("Hozircha o'qituvchilar mavjud emas.");
                return;
            }

            foreach (var teacher in _teachers.Values)
            {
                Console.WriteLine("=======================");
                Console.WriteLine($"Teacher ID : {teacher.Id}");
                Console.WriteLine($"First Name : {teacher.FirstName}");
                Console.WriteLine($"Last Name  : {teacher.LastName}");
                Console.WriteLine($"Address    : {teacher.Address}");
                Console.WriteLine($"Subject    : {teacher.Subject}");
                Console.WriteLine("=======================");
            }
        }

        
        public Teacher FindById(Guid id)
        {
            if (_teachers.ContainsKey(id))
            {
                return _teachers[id];
            }
            return null;
        }

    
        public bool Delete(Guid id)
        {
            return _teachers.Remove(id);
        }
    }
}