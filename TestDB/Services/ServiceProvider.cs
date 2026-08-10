using stepik.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Services
{
    public static class ServiceProvider
    {
        public static IUsersService usersService = new ADO.NET.UsersService();
        public static ICoursesService coursesService = new ADO.NET.CoursesService();
        public static ICommentsService commentsService = new ADO.NET.CommentsService();
        public static ICertificatesService certificatesService = new ADO.NET.CertificatesService();
        public static UsersProcessing usersProcessing = new();
        public static WrongChoice wrongChoice = new();
    }
}
