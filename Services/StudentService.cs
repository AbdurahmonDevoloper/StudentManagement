using System;
using System.Collections.Generic;
using System.Linq;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public class StudentService
    {
        
        private readonly Dictionary<Guid, Student> _students = new Dictionary<Guid, Student>();

        
        public void Create(Student student)
        {
            _students.Add(student.Id, student);
            Console.WriteLine("Student muvaffaqiyatli qo'shildi!");
        }

        
        public void ReadAll()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("Hozircha studentlar mavjud emas.");
                return;
            }

            foreach (var student in _students.Values)
            {
                PrintStudentInfo(student);
            }
        }

        
        public Student FindById(Guid id)
        {
            if (_students.ContainsKey(id))
            {
                return _students[id];
            }
            return null;
        }

        
        public bool Update(Guid id, string newFirstName, string newLastName, string newAddress, double newGPA, string newClassName)
        {
            var student = FindById(id);
            if (student != null)
            {
                student.FirstName = newFirstName;
                student.LastName = newLastName;
                student.Address = newAddress;
                student.GPA = newGPA;
                student.ClassName = newClassName;
                return true;
            }
            return false;
        }

        
        public bool Delete(Guid id)
        {
            return _students.Remove(id);
        }

        
        public void PrintClassStatistics()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("Statistika uchun ma'lumot yetarli emas.");
                return;
            }

            var classStats = _students.Values
                .GroupBy(s => s.ClassName)
                .OrderBy(g => g.Key);

            Console.WriteLine("\n=== SINFLAR STATISTIKASI ===");
            foreach (var group in classStats)
            {
                Console.WriteLine($"Sinf: {group.Key} -> O'quvchilar soni: {group.Count()} ta");
            }
            Console.WriteLine("=============================");
        } 

        
        public void PrintStudentInfo(Student student)
        {
            Console.WriteLine("=======================");
            Console.WriteLine($"Student ID : {student.Id}");
            Console.WriteLine($"Sinf       : {student.ClassName}");
            Console.WriteLine($"First Name : {student.FirstName}");
            Console.WriteLine($"Last Name  : {student.LastName}");
            Console.WriteLine($"Address    : {student.Address}");
            Console.WriteLine($"GPA        : {student.GPA}");
            Console.WriteLine("=======================");
        }
    }
}