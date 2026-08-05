using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sessions_Assignments.Session02.Models
{
    #region Mapping Using Data Annotations
    //[Table("EmployeesTable")]//this DBValidation Take NameofTable + Name of Schema
    //public class Employee
    //{
    //    [Key]//this DbValidation
    //    public int EmpId { get; set; }
    //    //==================================================
    //    [MaxLength(50,ErrorMessage ="Name be 50 Character by Max")]//this Error Message when Creating object in Application Not Validation in Database 
    //    [MinLength(3, ErrorMessage = "Name be 3 Character by Min")]//this   is Application Valiation تظهر when Creating object from this Class in Application 
    //    [StringLength(50,MinimumLength =3,ErrorMessage ="Your string is Between 3 and 50")]//This Annotation Contain MaxLength دى الوحيدة اللى هتكون DbValidation الباقى Application Validation 
    //    [Length(3,50,ErrorMessage ="Your String Must Between 50 and 3")]//this Annotation كله DbValidation When Creating Object From this يعنى كله حتى الMaxLength اللى فيه 
    //    public string EmpName { get; set; }
    //    //==================================================
    //    [Precision(10,2)]//this DbValidation 
    //    [Column("EmpSalary",TypeName ="decimal(10,2)")]//this DbValidation 
    //    public decimal Salary { get; set; }
    //    //==================================================
    //    [Range(22,40)]//this Application Validation
    //    [AllowedValues(24,26,28,30)]//Application Validation
    //    [DeniedValues(20,22)]//Application Validation
    //    public int Age { get; set; }
    //    //==================================================
    //    [Required(ErrorMessage ="You Must insert Value in Email")]//this DbValidation not allow Null
    //    //but Errormessage Is ApplicationValidation not DbValidation
    //    [DataType(DataType.EmailAddress)]//this UiHint For Developer
    //    [EmailAddress]//this Annotation is Application Validation When Cretaing Object ولما اجى احط الEmail دا يخلينى احط الEmail With Format
    //    public string Email { get; set; }//دا كدة من غير Annotation Required Not Allow Null be default
    //    //public required string Email { get; set; }//this Application Validation when creating object
    //    //public string? Email { get; set; }//this New Syntax For allowing Null
    //    //==================================================
    //    [DataType(DataType.Password)]//this UiHint For Developer
    //    public string? Password { get; set; }
    //    //==================================================
    //    [DataType(DataType.PhoneNumber)]//this UiHint For Developer
    //    [Phone]//this Application Validation عشان اكتب الformat PhoneNumber كما هو مطلوب 
    //    [Required(ErrorMessage ="Must Be insert Phone Number")]
    //    public int PhoneNumber { get; set; }
    //    //==================================================
    //    [NotMapped]//this DbValidation as this Column is AutoComputed مش هيتحول الى column in Database 
    //    public string UserName =>Email.Split('@')[0];  

    //}

    //ORM Make Convetion Way For Mapping First then  بعد كدة يشوف لو انا عامله اى طريقة تانيه للMapping يروح هو عامل override على الطريقة اللى عملها 
    //يعنى اول طريقة هو بيعملها هى Convetion وبعد كدة يشوف لو انا مطبق اى طريقة تانيه يعملها override 
    #endregion
    //========================================
    #region using Fluent Api
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public int PhoneNumber { get; set; }
        public string UserName => Email.Split('@')[0];
    }
    #endregion
}
