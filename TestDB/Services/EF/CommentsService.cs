using MySql.Data.MySqlClient;
using stepik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace stepik.Services.EF
{
    using MySql.Data.MySqlClient;

    public class CommentsService : ICommentsService
    {
        /// <summary>
        /// Получение всех комментариев к курсу
        /// </summary>
        /// <param name="id">id курса</param>
        /// <returns>Список комментариев</returns>
        public List<Comment> Get(int id)
        {
            throw new NotImplementedException();
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
