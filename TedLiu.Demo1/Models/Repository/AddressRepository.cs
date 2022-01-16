using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace TedLiu.Demo1.Models.Repository
{
    interface IAddressRepository
    {
        void Create(AddressBook model);
        void Delete(int id);
        void Update(int id,AddressBook model);
        AddressBook getid(int id);
        IEnumerable<AddressBook> getAll();

    }


    public class AddressRepository : IAddressRepository
    {
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["EFModel1"].ConnectionString;
        private string Table="AddressBook";

        public void Create(AddressBook model)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = $"INSERT INTO {Table}(Name,Phone,Email,Address)Values(@Name,@Phone,@Email,@Address)";
                conn.Execute(sql,model);
            }
            
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = $"Delete From {Table} where id =@id";
                conn.Execute(sql, new { id});
            }
        }

        public IEnumerable<AddressBook> getAll()
        {
            using (var conn=new SqlConnection(ConnectionString))
            {
                var sql = $"select * from {Table}";
                return conn.Query<AddressBook>(sql);
            }
            
        }

        public AddressBook getid(int id)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = $"select * from {Table} where id =@id";
                //var data = conn.QuerySingleOrDefault<AddressBook>(sql, new { id});
                //var data = conn.Query<AddressBook>(sql, new { id});
                var data = conn.QueryFirst<AddressBook>(sql,new { id});
                return data;
            }
        }

        public void Update(int id, AddressBook model)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = $"Update {Table} set Name=@Name,Phone=@Phone,Email=@Email,Address=@Address where id =@id";
                conn.Execute(sql,model);
            }
        }
    }
}