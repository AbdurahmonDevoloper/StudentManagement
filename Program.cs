using System;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherManager teacherManager = new TeacherManager();
            StudentManager studentManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("\n=== StudentManagement Tizimi ===");
                Console.WriteLine("1. O'qituvchi qo'shish (Create)");
                Console.WriteLine("2. O'qituvchilarni ko'rish (Read)");
                Console.WriteLine("3. O'qituvchini yangilash (Update)");
                Console.WriteLine("4. O'qituvchini o'chirish (Delete)");
                Console.WriteLine("5. Talaba qo'shish (Create)");
                Console.WriteLine("6. Talabalarni ko'rish (Read)");
                Console.WriteLine("7. Talabani yangilash (Update)");
                Console.WriteLine("8. Talabani o'chirish (Delete)");
                Console.WriteLine("0. Chiqish");
                Console.Write("Tanlovingizni kiriting: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("O'qituvchi ismi: ");
                        string tName = Console.ReadLine();
                        Console.Write("Fani: ");
                        string tSubject = Console.ReadLine();
                        teacherManager.Create(tName, tSubject);
                        break;

                    case "2":
                        teacherManager.ReadAll();
                        break;

                    case "3":
                        Console.Write("Yangilanadigan o'qituvchi IDsi: ");
                        int tUpdateId = int.Parse(Console.ReadLine());
                        Console.Write("Yangi ism: ");
                        string tNewName = Console.ReadLine();
                        Console.Write("Yangi fan: ");
                        string tNewSubject = Console.ReadLine();
                        teacherManager.Update(tUpdateId, tNewName, tNewSubject);
                        break;

                    case "4":
                        Console.Write("O'chiriladigan o'qituvchi IDsi: ");
                        int tDeleteId = int.Parse(Console.ReadLine());
                        teacherManager.Delete(tDeleteId);
                        break;

                    case "5":
                        Console.Write("Talaba ismi: ");
                        string sName = Console.ReadLine();
                        Console.Write("Yoshi: ");
                        int sAge = int.Parse(Console.ReadLine());
                        Console.Write("O'qituvchi IDsi: ");
                        int sTeacherId = int.Parse(Console.ReadLine());

                        // O'qituvchi borligini tekshirish
                        if (teacherManager.Exists(sTeacherId))
                        {
                            studentManager.Create(sName, sAge, sTeacherId);
                        }
                        else
                        {
                            Console.WriteLine("Xatolik: Bunday ID dagi o'qituvchi mavjud emas! Avval o'qituvchi yarating.");
                        }
                        break;

                    case "6":
                        studentManager.ReadAll();
                        break;

                    case "7":
                        Console.Write("Yangilanadigan talaba IDsi: ");
                        int sUpdateId = int.Parse(Console.ReadLine());
                        Console.Write("Yangi ism: ");
                        string sNewName = Console.ReadLine();
                        Console.Write("Yangi yosh: ");
                        int sNewAge = int.Parse(Console.ReadLine());
                        Console.Write("Yangi o'qituvchi IDsi: ");
                        int sNewTeacherId = int.Parse(Console.ReadLine());

                        if (teacherManager.Exists(sNewTeacherId))
                        {
                            studentManager.Update(sUpdateId, sNewName, sNewAge, sNewTeacherId);
                        }
                        else
                        {
                            Console.WriteLine("Xatolik: Bunday o'qituvchi yo'q!");
                        }
                        break;

                    case "8":
                        Console.Write("O'chiriladigan talaba IDsi: ");
                        int sDeleteId = int.Parse(Console.ReadLine());
                        studentManager.Delete(sDeleteId);
                        break;

                    case "0":
                        Console.WriteLine("Dastur tugatildi. Sog' bo'ling!");
                        return;

                    default:
                        Console.WriteLine("Noto'g'ri buyruq! Qaytadan urinib ko'ring.");
                        break;
                }
            }
        }
    }
}