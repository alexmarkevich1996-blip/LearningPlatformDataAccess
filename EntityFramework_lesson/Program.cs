using Microsoft.EntityFrameworkCore;

namespace EntityFramework_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new ApplicationDbContext();

            var phone = new Phone
            {
                Name = "Samsung Galaxy S24",
                SoftwareUpdates = [
                    new SoftwareUpdate {Version = "1.0", ReleaseDate = new DateTime(2024, 1,1 )},
                    new SoftwareUpdate {Version = "1.1", ReleaseDate = new DateTime(2024, 3, 1)}
                    ]
            };

            dbContext.Phones.Add(phone);
            dbContext.SaveChanges();

        }
    }
}
