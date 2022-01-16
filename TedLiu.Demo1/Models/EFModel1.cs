using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TedLiu.Demo1.Models
{
    public partial class EFModel1 : DbContext
    {
        public EFModel1()
            : base("name=EFModel1")
        {
        }

        public virtual DbSet<AddressBook> AddressBooks { get; set; }
        public virtual DbSet<AccountTable> AccountTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressBook>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<AddressBook>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<AccountTable>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<AccountTable>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
