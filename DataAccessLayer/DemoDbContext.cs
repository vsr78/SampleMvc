using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class DemoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Data Source=a;Initial Catalog=DB;Integrated Security=true";
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
