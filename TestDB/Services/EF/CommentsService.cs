using MySql.Data.MySqlClient;
using stepik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.EntityFrameworkCore;

namespace stepik.Services.EF
{
    using MySql.Data.MySqlClient;
    using stepik.Data;

    public class CommentsService : ICommentsService
    {
        /// <summary>
        /// Получение всех комментариев к курсу
        /// </summary>
        /// <param name="id">id курса</param>
        /// <returns>Список комментариев</returns>
        public List<Comment> Get(int id)
        {
            using ApplicationDbContext dbContext = new();
            return dbContext.Comments
                .AsNoTracking()
                .Where(c =>
                        c.Step.Lesson.UnitLessons
                            .Any(ul => ul.Unit.Course.Id == id)
                        && c.ReplyCommentId == null)
                .OrderByDescending(c => c.Time)
                .ToList();
        }

        /// <summary>
        /// Удаление комментария пользователя
        /// </summary>
        /// <param name="id">id комментария</param>
        /// <returns>Удалось ли удалить комментарий</returns>
        public bool Delete(int id)
        {
            using var dbContext = new ApplicationDbContext();


            try
            {
                var courseReviews = dbContext.CourseReviews
                    .Where(cr => cr.CommentId == id)
                    .ToList();

                var replyComments = dbContext.Comments
                    .Where(c => c.ReplyCommentId == id)
                    .ToList();

                var comment = dbContext.Comments.FirstOrDefault(c => c.Id == id);

                dbContext.CourseReviews.RemoveRange(courseReviews);
                dbContext.Comments.RemoveRange(replyComments);

                if(comment != null)
                {
                    dbContext.Comments.Remove(comment);
                }
                dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
