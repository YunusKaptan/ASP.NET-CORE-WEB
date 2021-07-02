using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CoreAndFoodWeb.Data.Models
{
    public class Context:DbContext

    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "server=DESKTOP-MBBGFAA\\SQLEXPRESS; database=DbCoreFood; integrated security=true");
    }

    public DbSet<Food> Foods { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Admin> Admins { get; set; }

    }
}
