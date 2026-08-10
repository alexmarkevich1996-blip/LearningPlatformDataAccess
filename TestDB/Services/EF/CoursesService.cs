using MySql.Data.MySqlClient;
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
            throw new NotImplementedException();
        }

        public int GetTotalCount()
        {
            throw new NotImplementedException();
        }
    }

}
