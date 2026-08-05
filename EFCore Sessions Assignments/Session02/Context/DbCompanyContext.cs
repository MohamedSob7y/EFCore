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
           //this Constructor Will Chain For Constructor Base
           //Constructor Base Chain For Constructor Take Options
           //Constructor Take Option take Last Override For OnConfiguration عشان يعرف الConnection String + Last Override For OnmodelCreating For Applying all configuration Using Fluent Api Method Way For Mapping 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=DESKTOP-9DG3E18;Database=CompanyDB;Trusted_Connection=true;TrustServerCertificate=true");
        }

        //this Method Apply Fluent Api Mapping Configurations
        //Fluent Api Way دى طريقة تستخدم كلها For DBValidation Not Application Validation or UiHint if You Want App Validation in this Way Use CheckConstrain
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //دى الطريقة الاولى انى اعمل كل Configuration هنا 
            #region Fluent Api Part01

            modelBuilder.Entity<Employee>()
                .ToTable("EmployeesTable","Sales");//Will Change Table لما يتحول فى الDb هيبقى اسمه زى دا فكك بقا من اسمه اللى موجود فى الDBSet +كمان اقدر احدد هينزل فى انهى Schema دا فى حالة ان عندى اكتر من Schema in Database 
            //to Table Take Name of Table + Name of Schema + CheckConstrain
            //لو الSchema مش معمولة يبقى هيعملها طب لو معمولة خلاص ضيف الTable فيها 
            //Entity return Entity TypeBuilder
            //=======================================================================
            modelBuilder.Entity<Employee>().HasKey(T=>T.EmpId);//this Take FunC عشان الاسم يكون صح + Take Composit Pk لو عندى 
            //=======================================================================
            modelBuilder.Entity<Employee>().Property(T=>T.EmpId).UseIdentityColumn(10,10);
            //=======================================================================
            #region Explain Property
            modelBuilder.Entity<Employee>().Property("Empid"); //this Take Propertyname بس فى مشكلة لو مش نفس الاسم يبقى يعمل Throw Exception
            modelBuilder.Entity<Employee>().Property<int>("Emplid");//هنا لو موجودة بنفس الاسم يعملها عا\دى طب لو مش موجودة بنفس الاسم make this Property as Shadow Property in DB As Column عادى 
            //يعنى Orm هيشوف لو موجودة بنفس الاسم يعملها عادى لو مش موجودة يعمل Not make Exception just make Shodow Property as Column in Db ملهاش اى representation in Application 
            //يبقى لما اعوز اعمل column in Db ومش عايزه يتعمل فى الApplication Make this As Shadow Property
            modelBuilder.Entity<Employee>().Property(T => T.EmpId);
            #endregion
            //=======================================================================
            //modelBuilder.Entity<Employee>().Property(T=>T.EmpId).HasPrecision(10,2);
            modelBuilder.Entity<Employee>().Property(T => T.EmpName)
                .HasMaxLength(50);
            //=======================================================================
            modelBuilder.Entity<Employee>().Property(T => T.Salary)
                .HasColumnName("EmployeeSalary")
                .HasColumnType("decimal(10,2)");
            //=======================================================================
            modelBuilder.Entity<Employee>().Property(T => T.Email)
                .IsRequired();//Not Allow Null

            //modelBuilder.Entity<Employee>().Property(T => T.Email)
            //   .IsRequired(false);//this Allow Null
            //=======================================================================
            //For Application Validation Make CheckConstrain
            modelBuilder.Entity<Employee>()
                .ToTable(T => T.HasCheckConstraint("EmailFormatConstrain", "[Email] like '%@%.%'"));//_%@_%._%  this call Regix expression 
            modelBuilder.Entity<Employee>().Property(T => T.Password)
                .IsRequired(false);//allow Null


            modelBuilder.Entity<Employee>().Ignore(x => x.UserName);
            #endregion
            //=======================================================================
            #region  Fluent Api Configuration


            #endregion
        }
        #region All DbSet
        public DbSet<Employee> Employees { get; set; }
        #endregion
    }
}