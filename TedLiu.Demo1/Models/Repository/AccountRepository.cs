using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TedLiu.Demo1.Models.Repository
{
    interface IAccountRepository
    {
        void Login(AccountTable Model);
    }

    public class AccountRepository : IAccountRepository
    {
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["EFModel1"].ConnectionString;
        private string Table = "AccountTable";
        public void Login(AccountTable Model)
        {
            
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = $"select * from {Table} where Account=@Account and Password=@Password";


            }
        }
    }
}