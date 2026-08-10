using MySql.Data.MySqlClient;
using stepik.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using stepik.Data;
using System.Globalization;

namespace stepik.Services.EF
{
    public class UsersService : IUsersService
    {
        /// <summary>
        /// Добавление нового пользователя в таблицу users
        /// </summary>
        /// <param name="user">Новый пользователь</param>
        /// <returns>Удалось ли добавить пользователя</returns>
        public bool Add(User user)
        {
            try
            {
                using ApplicationDbContext dbContext = new();
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Форматирование показателей пользователя
        /// </summary>
        /// <param name="number">Число для форматирования</param>
        /// <returns>Отформатированное число</returns>
        public string? FormatUserMetrics(int number)
        {
            if (number < 1000)
            {
                return number.ToString();
            }
            else
            {
                double formattedNumber = number / 1000.0;
                string formattedString = formattedNumber
                    .ToString("0.0K", CultureInfo.InvariantCulture)
                    .Replace(".0K", "K");
                return formattedString;
            }
        }

        /// <summary>
        /// Получение пользователя из таблицы users
        /// </summary>
        /// <param name="fullName">Полное имя пользователя</param>
        /// <returns>User</returns>
        public User? Get(string fullName)
        {
            using var dbContext = new ApplicationDbContext();
            return dbContext.Users.FirstOrDefault(x => x.full_name == fullName && x.is_active);
        }

        /// <summary>
        /// Получение общего количества пользователей
        /// </summary>
        public int GetTotalCount()
        {
            using var dbContext = new ApplicationDbContext();
            return dbContext.Users.Count();
        }

        /// <summary>
        /// Рейтинг пользователей
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetUserRating()
        {
            throw new NotImplementedException();
        }

        public DataSet GetUserSocialInfo(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
