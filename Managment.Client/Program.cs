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
            int counter = 0;
            Console.Write("Salom, dasturga hush kelibsiz.");

            do
            {
                Console.Write("Parolingizni kiriting: ");
                string password = Console.ReadLine();
                if (password == PASSWORD)
                {
                    ShowStudengMenu();
                }
                else
                {
                    Console.WriteLine("Parol noto'g'ri, qayta urinib ko'ring.");
                }
            } while (counter++ < 3);
        }
        public static void ShowStudengMenu()
        {
            Console.WriteLine("1. Talaba qo'shish");
            Console.WriteLine("2. Talabalarni ko'rish");
            Console.WriteLine("3. Qabul soni");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
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
                default:
                    Console.WriteLine("Noto'g'ri tanlov");
                    break;
            }
        }
        public static void AddStudent()
        {

            Console.Write("Talabaning ismini kiriting: ");
            string firstName = Console.ReadLine();
            Console.Write("Talabaning familiyasini kiriting: ");
            string lastName = Console.ReadLine();
            studentService.AddStudent(firstName, lastName);
            Console.WriteLine("Muvaffaqiyatli kiritldi");

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
            Console.WriteLine($"Bizda {studentService.StudentsCApasity()} o'rin bor");
        }
     }
        }