using Management.Infrastructure.Data;
using ManagementDomain.Models;

namespace Management.Application.Services
{
    public class StudentService
    {
        public DbContext DbContext { get; set; }

        public StudentService()
        {
            this.DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
        {
            Student newStudent = new Student
            {
                Id = new Random().Next(1, 1000).ToString(),
                FirstName = firstName,
                LastName = lastName
            };

            this.DbContext.Students[this.DbContext.StudentCount] = newStudent;
            this.DbContext.StudentCount++;
        }
    }
}
