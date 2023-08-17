using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thi_Data.Data
{
    public class ThiDbC6 : DbContext
    {
        public ThiDbC6()
        {
        }

        public ThiDbC6(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-OKDB069;Initial Catalog=DB_Thi_C6;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FileData> FileDatas { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
