using Management.Application.Services;
using ManagementDomain.Models;
namespace Managment.Client
{
    public class Program
    {
        static StudentService studentService = new StudentService();
        private const string PASSWORD = "admin123";
        public static void Main(string[] args)
        {
            int attempts = 0, maxAttempts = 3;
            bool isLoggedIn = false;
            Console.WriteLine("Salom, dasturga hush kelibsiz.");

            while (attempts < maxAttempts)
            {
                Console.Write("Parolingizni kiriting: ");
                string password = Console.ReadLine();

                if (password == PASSWORD)
                {
                    Console.WriteLine("Tizimga muvaffaqiyatli kirdingiz!");
                    ShowStudengMenu();
                    return; 
                }
                else
                {
                    attempts++;
                    int remaining = maxAttempts - attempts;

                    if (remaining > 0)
                    {
                        Console.WriteLine("Parol noto'g'ri!");
                        Console.WriteLine($"Sizda {remaining} ta urinish qoldi.");
                    }
                    else
                    {
                        Console.WriteLine("Parol noto'g'ri!");
                        Console.WriteLine("Sizning urinishlaringiz tugadi. Dastur yopildi.");
                    }
                }
            }
        }
        public static void ShowStudengMenu()
        {
            bool isRunning = true;
            do
            {
                Console.WriteLine("\n1. Talaba qo'shish");
                Console.WriteLine("2. Talabalarni ko'rish");
                Console.WriteLine("3. Qabul soni");
                Console.WriteLine("0. Chiqish");

                Console.Write("Tanlovingizni kiriting: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Iltimos, raqam kiriting!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        PrintAllStudents();
                        break;
                    case 3:
                        PrintStudentCApasity();
                        break;
                    case 0:
                        Console.WriteLine("Dasturdan chiqilyapti...");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Noto'g'ri tanlov, qayta urinib ko'ring.");
                        break;
                }
            }while (isRunning);
        }
        public static void AddStudent()
        {
            if (studentService.StudentsCApasity() <= studentService.DbContext.StudentCount)
            {
                Console.WriteLine("Sizning limitingiz tugadi! Yana talaba qo'shib bo'lmaydi.");
                return; 
            }

            Console.Write("Talabaning ismini kiriting: ");
            string firstName = Console.ReadLine();
            Console.Write("Talabaning familiyasini kiriting: ");
            string lastName = Console.ReadLine();

            studentService.AddStudent(firstName, lastName);

            int remaining = studentService.StudentsCApasity() - studentService.DbContext.StudentCount;
            if (remaining > 0)
            {
                Console.WriteLine($"Muvaffaqiyatli kiritildi! Sizda {remaining} o'rin qoldi.");
            }
            else
            {
                Console.WriteLine("Muvaffaqiyatli kiritildi! Sizning limitingiz tugadi.");
            }
        }
        private static void PrintAllStudents()
        {
            Student[] students = studentService.GetStudents();
            foreach (Student student in studentService.GetStudents())
            {
                if (student != null)
                {
                    Console.WriteLine($"ID: {student.Id}, Ismi: {student.FirstName}, Familiyasi: {student.LastName}");
                }
            }
        }
            private static void PrintStudentCApasity()
        {
            int remaining = studentService.StudentsCApasity() - studentService.DbContext.StudentCount;

            if (remaining > 0)
                Console.WriteLine($"Sizda {remaining} limit bor");
            else
                Console.WriteLine("Sizning limitingiz tugadi");
        }
    
           }
        }