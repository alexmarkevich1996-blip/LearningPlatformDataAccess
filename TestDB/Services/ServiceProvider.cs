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
        public static IUsersService usersService = new EF.UsersService();
        public static ICoursesService coursesService = new EF.CoursesService();
        public static ICommentsService commentsService = new EF.CommentsService();
        public static ICertificatesService certificatesService = new EF.CertificatesService();
        public static UsersProcessing usersProcessing = new();
        public static WrongChoice wrongChoice = new();
    }
}
