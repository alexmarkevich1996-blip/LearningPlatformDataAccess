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
            var dbContext = new ApplicationDbContext();
            return dbContext.Comments
                .AsNoTracking()
                .Where(c => c.Id == id)
                .ToList();
        }

        /// <summary>
        /// Удаление комментария пользователя
        /// </summary>
        /// <param name="id">id комментария</param>
        /// <returns>Удалось ли удалить комментарий</returns>
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
