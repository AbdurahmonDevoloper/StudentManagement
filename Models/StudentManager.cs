using System;
using System.Collections.Generic;
using System.Linq;

public class StudentManager
{
    private Student[] _studentArray = new Student[0];
    
    private List<Student> _studentList = new List<Student>();
    private int _nextId = 1;

    public void Create(string name)
    {
        Student student = new Student { Id = _nextId++, Name = name };
        _studentList.Add(student);
        SyncArray(); 
    }

    public void ReadAll()
    {
        if (!_studentList.Any())
        {
            Console.WriteLine("Talabalar ro'yxati bo'sh!");
            return;
        }
        foreach (var student in _studentList)
        {
            Console.WriteLine($"ID: {student.Id}, Ismi: {student.Name}");
        }
    }

    public void Update(int id, string newName)
    {
        var student = _studentList.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            student.Name = newName;
            SyncArray();
        }
    }

    public void Delete(int id)
    {
        var student = _studentList.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            _studentList.Remove(student);
            SyncArray();
        }
    }

    public void GetStudentsByName(string name)
    {
        var result = _studentList.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine($"\n--- '{name}' qatnashgan talabalar ---");
        foreach (var s in result) Console.WriteLine($"ID: {s.Id}, Ismi: {s.Name}");
    }

    public void GetPaginatedStudents(int page, int pageSize)
    {
        var result = _studentList
            .OrderBy(s => s.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        Console.WriteLine($"\n--- Sahifa: {page}, Soniv: {pageSize} (Alifbo bo'yicha) ---");
        foreach (var s in result) Console.WriteLine($"ID: {s.Id}, Ismi: {s.Name}");
    }

    public void GetStudentsCount()
    {
        int count = _studentList.Count();
        Console.WriteLine($"\nUmumiy talabalar soni: {count} ta");
    }

    public void AddStudentRange(params Student[] students)
    {
        foreach (var s in students)
        {
            s.Id = _nextId++;
            _studentList.Add(s);
        }
        SyncArray();
        Console.WriteLine($"\n{students.Length} ta talaba guruh bo'lib qo'shildi.");
    }

    private void SyncArray()
    {
        _studentArray = _studentList.ToArray();
    }
}