using System;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            TeacherService teacherService = new TeacherService(); 
            bool running = true;

            
            studentService.Create(new Student { FirstName = "Ali", LastName = "Aliyev", Address = "Moskva", GPA = 4.5, ClassName = "11-B" });
            studentService.Create(new Student { FirstName = "Vali", LastName = "Valiyev", Address = "Petr", GPA = 4.4, ClassName = "10-A" });
            
            
            teacherService.Create(new Teacher { FirstName = "Asror", LastName = "Qodirov", Address = "Toshkent", Subject = "Matematika" });

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== ASOSIY MENYU ===");
                Console.WriteLine("1. Student bo'limi");
                Console.WriteLine("2. Teacher bo'limi"); 
                Console.WriteLine("3. Sinflar Statistikasi (Vazifa)");
                Console.WriteLine("4. Chiqish");
                Console.Write("Tanlang: ");
                string mainChoice = Console.ReadLine();

                if (mainChoice == "1") 
                {
                    Console.Clear();
                    Console.WriteLine("--- Student Bo'limi ---");
                    Console.WriteLine("1. CREATE (Qo'shish)\n2. READ (Ko'rish)\n3. UPDATE (Yangilash)\n4. DELETE (O'chirish)");
                    Console.Write("Tanlang: ");
                    string subChoice = Console.ReadLine();

                    switch (subChoice)
                    {
                        case "1":
                            Console.Clear();
                            Student yangiStudent = new Student();
                            Console.Write("Ismi: "); yangiStudent.FirstName = Console.ReadLine();
                            Console.Write("Familiyasi: "); yangiStudent.LastName = Console.ReadLine();
                            Console.Write("Manzili: "); yangiStudent.Address = Console.ReadLine();
                            Console.Write("Sinfi: "); yangiStudent.ClassName = Console.ReadLine();
                            Console.Write("GPA: "); yangiStudent.GPA = double.Parse(Console.ReadLine() ?? "0");
                            studentService.Create(yangiStudent);
                            break;
                        case "2":
                            Console.Clear();
                            studentService.ReadAll();
                            break;
                        
                    }
                }
                else if (mainChoice == "2") 
                {
                    Console.Clear();
                    Console.WriteLine("--- Teacher Bo'limi ---");
                    Console.WriteLine("1. CREATE (O'qituvchi Qo'shish)\n2. READ (Hamma O'qituvchilarni Ko'rish)");
                    Console.Write("Tanlang: ");
                    string subChoice = Console.ReadLine();

                    switch (subChoice)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("--- Yangi O'qituvchi Qo'shish ---");
                            Teacher yangiTeacher = new Teacher();
                            Console.Write("Ismi: "); yangiTeacher.FirstName = Console.ReadLine();
                            Console.Write("Familiyasi: "); yangiTeacher.LastName = Console.ReadLine();
                            Console.Write("Manzili: "); yangiTeacher.Address = Console.ReadLine();
                            Console.Write("Dars beradigan fani: "); yangiTeacher.Subject = Console.ReadLine();
                            
                            teacherService.Create(yangiTeacher); 
                            break;

                        case "2":
                            Console.Clear();
                            teacherService.ReadAll(); 
                            break;
                    }
                }
                else if (mainChoice == "3")
                {
                    Console.Clear();
                    studentService.PrintClassStatistics();
                }
                else if (mainChoice == "4")
                {
                    running = false;
                    break;
                }

                Console.Write("\nDasturni davom ettirishni xohlaysizmi? (ha/yoq): ");
                string status = Console.ReadLine()?.ToLower();
                if (status != "ha") running = false;
            }
        }
    }
}