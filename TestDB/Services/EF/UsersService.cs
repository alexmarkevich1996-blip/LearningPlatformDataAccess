using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using stepik.Data;
using stepik.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return dbContext.Users.FirstOrDefault(x => x.FullName == fullName && x.IsActive);
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
            using ApplicationDbContext dbContext = new();

            var topUsers = dbContext.Users
                .Where(u => u.IsActive)
                .AsNoTracking()
                .OrderByDescending(u => u.Knowledge)
                .Take(10)
                .Select(u => new
                {
                    u.FullName,
                    u.Knowledge,
                    u.Reputation
                })
                .ToList();

            var dataTable = new DataTable("UserRating");
            dataTable.Columns.Add("full_name", typeof(string));
            dataTable.Columns.Add("knowledge", typeof(int));
            dataTable.Columns.Add("reputation", typeof(int));

            foreach (var user in topUsers)
            {
                dataTable.Rows.Add(user.FullName, user.Knowledge, user.Reputation);
            }

            var dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        public DataSet GetUserSocialInfo(string userName)
        {
            using var dbContext = new ApplicationDbContext();

            var socialInfos = (
                from u in dbContext.Users
                join usp in dbContext.UserSocialProviders on u.Id equals usp.UserId
                join sp in dbContext.SocialProviders on usp.SocialProviderId equals sp.Id
                where u.FullName == userName
                orderby sp.Name
                select new
                {
                    sp.Name,
                    usp.ConnectUrl
                }
            ).ToList();

            var dataTable = new DataTable("user_social_providers");
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("connect_url", typeof(string));

            foreach (var info in socialInfos)
            {
                dataTable.Rows.Add(info.Name, info.ConnectUrl);
            }

            var dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            return dataSet;
        }
    }
}
