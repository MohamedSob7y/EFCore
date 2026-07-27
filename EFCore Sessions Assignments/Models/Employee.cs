using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sessions_Assignments.Models
{
    //this Model-Entity-PocoClass will be represented as table in database 
    //طالما دا class هيتحول الى table in Database يبقى لازم مايكونشى فى اى logic or Method just For Property 
    //عشان EFCore يفهم ان الclass دا يتحول الى table => First Make DbSetOf this Class in DbContext
    public class Employee
    {
        public int Id { get; set; }//this PK
        public string? Name { get; set; }//Convert This to nvarchar(max)+ Allow Null
        public decimal Salary { get; set; }//Convert this to decimal(18,2) With Pricesion 18 كام رقم قبل وبعد العلامة  and 2 is class Scall of Numbers كام رقم بعد العلامة لان داالdefault    + Not Allow Null
        public int Age { get; set; }//Convert this to int 
    }
    //ازاى الEfcore بيعمل Id is Pk+ Identical(1,1)=>
    //1: Search For Property int يكون اسمها Id or nameofclass+Id
    //2: Search For Property from type String or Guid واسمها يكون Id or EmployeeId هيخليها هى الPk But not make Identity
}
