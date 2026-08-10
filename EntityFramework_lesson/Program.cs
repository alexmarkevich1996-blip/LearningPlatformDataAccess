using Microsoft.EntityFrameworkCore;

namespace EntityFramework_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new ApplicationDbContext();
            dbContext.Database.Migrate();

        }
    }
}
