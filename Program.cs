using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== AMALIY VAZIFA ===\n");

        StudentManager studentManager = new StudentManager();
        TeacherManager teacherManager = new TeacherManager();

        studentManager.Create("Alijon");
        studentManager.Create("Valijon");
        studentManager.Create("Zilola");

        studentManager.AddStudentRange(
            new Student { Name = "Botir" },
            new Student { Name = "Anvar" },
            new Student { Name = "Madina" }
        );

        Console.WriteLine("\nBarcha talabalar:");
        studentManager.ReadAll();

        studentManager.GetStudentsByName("jon");

        studentManager.GetPaginatedStudents(1, 2);

        studentManager.GetStudentsCount();


        Console.WriteLine("\n----------------------------------");
        teacherManager.Create("Eshmat aka");
        teacherManager.AddTeacherRange(new Teacher { Name = "Toshmat aka" }, new Teacher { Name = "Asqar aka" });
        teacherManager.GetTeachersCount();

        Console.ReadKey();
    }
}