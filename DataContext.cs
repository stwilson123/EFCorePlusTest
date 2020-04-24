using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFCorePlus.Test
{
    public class TestDbContext : DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=localhost;Database=7b3a57a9c18a4bc3b38276753ad67ae2;Integrated Security=True");
        }

       public  DbSet<TESTENTITY> tESTENTITies { set; get; }
    }
}
