using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using stepik.Data;
using stepik.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Services.EF
{
    public class CoursesService : ICoursesService
    {
        public List<Course> Get(string fullName)
        {
            var dbContext = new ApplicationDbContext();
            return dbContext.UserCourses
                .AsNoTracking()
                .Where(uc => uc.User.FullName == fullName && uc.User.IsActive)
                .OrderByDescending(uc => uc.LastViewed)
                .Select(uc => uc.Course)
                .ToList();
        }

        public int GetTotalCount()
        {
            var dbContext = new ApplicationDbContext();
            return dbContext.Courses
                .AsNoTracking()
                .Count();
        }
    }

}
