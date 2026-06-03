using System;
using System.Collections.Generic;
using System.Linq;

public class TeacherManager
{
    private Teacher[] _teacherArray = new Teacher[0];
    private List<Teacher> _teacherList = new List<Teacher>();
    private int _nextId = 1;

    public void Create(string name)
    {
        Teacher teacher = new Teacher { Id = _nextId++, Name = name };
        _teacherList.Add(teacher);
        SyncArray();
    }

    public void ReadAll()
    {
        if (!_teacherList.Any())
        {
            Console.WriteLine("O'qituvchilar ro'yxati bo'sh!");
            return;
        }
        foreach (var teacher in _teacherList)
        {
            Console.WriteLine($"ID: {teacher.Id}, Ismi: {teacher.Name}");
        }
    }

    public void Update(int id, string newName)
    {
        var teacher = _teacherList.FirstOrDefault(t => t.Id == id);
        if (teacher != null)
        {
            teacher.Name = newName;
            SyncArray();
        }
    }

    public void Delete(int id)
    {
        var teacher = _teacherList.FirstOrDefault(t => t.Id == id);
        if (teacher != null)
        {
            _teacherList.Remove(teacher);
            SyncArray();
        }
    }

    public void GetTeachersByName(string name)
    {
        var result = _teacherList.Where(t => t.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine($"\n--- '{name}' qatnashgan o'qituvchilar ---");
        foreach (var t in result) Console.WriteLine($"ID: {t.Id}, Ismi: {t.Name}");
    }

    public void GetPaginatedTeachers(int page, int pageSize)
    {
        var result = _teacherList
            .OrderBy(t => t.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        Console.WriteLine($"\n--- Sahifa: {page}, Soniv: {pageSize} (Alifbo bo'yicha) ---");
        foreach (var t in result) Console.WriteLine($"ID: {t.Id}, Ismi: {t.Name}");
    }

    public void GetTeachersCount()
    {
        int count = _teacherList.Count();
        Console.WriteLine($"\nUmumiy o'qituvchilar soni: {count} ta");
    }

    public void AddTeacherRange(params Teacher[] teachers)
    {
        foreach (var t in teachers)
        {
            t.Id = _nextId++;
            _teacherList.Add(t);
        }
        SyncArray();
        Console.WriteLine($"\n{teachers.Length} ta o'qituvchi guruh bo'lib qo'shildi.");
    }

    private void SyncArray()
    {
        _teacherArray = _teacherList.ToArray();
    }
}