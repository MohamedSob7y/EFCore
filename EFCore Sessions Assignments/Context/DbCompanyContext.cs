using EFCore_Sessions_Assignments.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sessions_Assignments.Context
{
    public class DbCompanyContext:DbContext
    {
        public DbCompanyContext():base()
        {
            //this Constructor Chain on Base Constructor in DbContext Class
            //class DbContext has Constructor chain on Constructor that take Options والConstructor دا ياخد Options يعنى ياخد اخر override اتعمل  لل onmodelCreating
            //اى حاجة اخرها builder use internally or Built based on Builder Design Pattern

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #region Old Way
            //optionsBuilder.UseSqlServer("DataSource=DESKTOP-9DG3E18;Initial_Catalog=;IntegratedSecurity=true;Trust Server Certificate=true");
            #endregion
            //======================================================================
            #region New Way with Connection String
            //Connection string Contain = Servername+ Databasename+ Authentication Way + Certificate For Connection
            optionsBuilder.UseSqlServer("Server=DESKTOP-9DG3E18;Database=;Trusted_Connection=true;Trust Server Certificate=true");
            //لو فى شركة بنكتب بدل الTrusted_Connection =>uid= ; pwd=
            #endregion
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #region All DbSet
        public DbSet<Employee> Employees {  get; set; }//دا اسمه لما يتحول الى table in Database 

        #endregion
    }
}
