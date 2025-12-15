using Management.Application.Services;
namespace Managment.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var studentService = new StudentService();
            studentService.AddStudent("Nodir", "Abdumurotov");
            studentService.AddStudent("Tohir", "Isomiddinov");
        }
    }
}