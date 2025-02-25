using System;
using System.Collections.Generic;
using System.Text;
using examSystem.Models;
using Microsoft.EntityFrameworkCore;



namespace examSystem.Data
{

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Questions> Questions { get; set; }
    }
}