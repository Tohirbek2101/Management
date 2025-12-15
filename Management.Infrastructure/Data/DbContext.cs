using ManagementDomain.Models;
namespace Management.Infrastructure.Data
{
    public class DbContext
    {
        public DbContext()
        {
            this.Students = new Student[12]; 
        }
        public Student[] Students { get; set; }
    }
}
