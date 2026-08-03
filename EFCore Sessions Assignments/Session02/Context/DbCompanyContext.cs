using EFCore_Sessions_Assignments.Session02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sessions_Assignments.Context
{
    public class DbCompanyContext : DbContext
    {
        public DbCompanyContext() : base()
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=DESKTOP-9DG3E18;Database=CompanyDB;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #region All DbSet
       public DbSet<Employee> Employees { get; set; }
        #endregion
    }
}