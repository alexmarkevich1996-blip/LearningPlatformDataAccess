using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using stepik.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Services.EF
{
    public class CertificatesService : ICertificatesService
    {
        public DataSet Get(string fullName)
        {
            var dbContext = new ApplicationDbContext();

            var userCertificates = dbContext.Certificates
                .AsNoTracking()
                .Include(c => c.Course)
                .Where(c => c.User.FullName == fullName)
                .OrderByDescending(c => c.IssueDate)
                .Select(c => new
                {
                    c.Course.Title,
                    c.IssueDate,
                    c.Grade
                })
                .ToList();

            var dataTable = new DataTable("UserCertificates");
            dataTable.Columns.Add("title", typeof(string));
            dataTable.Columns.Add("issue_date", typeof(DateTime));
            dataTable.Columns.Add("grade", typeof(int));

            foreach (var certificate in userCertificates)
            {
                dataTable.Rows.Add(certificate.Title, certificate.IssueDate, certificate.Grade);
            }

            var dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            return dataSet;


        }
    }
}
