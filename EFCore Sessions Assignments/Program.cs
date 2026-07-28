//using EFCore_Sessions_Assignments.Context;
using EFCore_Sessions_Assignments.Assignment_Session_01.Context;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Sessions_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session01
            //===================================================
            #region Open Connection using Object from DbContext
            //creating object From DbContext To open Connection 
            //DbCompanyContext context = new DbCompanyContext();
            //this object is unmanged resource يعنى الClr لما يكون unreachable مش هيعرف يعمله حاجة لازم الDeveloper هو اللى يمسحه من الHeap
            //هو كدة موجود فى الheap طب انا ببقى عايز اقفل الconnection يبقى روح امسحه من الheap عشان هو unmanged resource ولما انا امسحه من الheap كدة خلاص close connection 

            //First Way To Close connection 
            //try
            //{
            //    //Do some Code
            //}catch (Exception ex)
            //{
            //    context.Dispose();//Close Connection لو حصلت مشكلة طب لو محصلشى كدة مش هيقفل ال connection 
            //    //so Dispose دى تمسح الobject From Heap تعمله deallocate
            //}

            //Second Way To Close Connection يعنى نجح او منجحشى نفذ الcloseing برضو 
            //try
            //{

            //}finally
            //{
            //    context.Dispose();//Close Connection + Deallocate object From Heap
            //}



            //New Way
            //using DbCompanyContext context = new DbCompanyContext()
            //{
            //    //استخدم الobject دا فقط فى الScobe دا فقط وهو بيقفله automatic اول ماتخلص الscobe دا 
            //    //يعنى اكتب هنا الكود ولما يخلص وتخرج هو بيقفله لوحده بس اهم حاجة يكون داخل الScobe 
            //};



            //using DbCompanyContext context = new DbCompanyContext();//this Syntax Exsist in C#8
                                                                    //This object at Scobe of Main Function 
                                                                    //After Finish All Code in this Function Main=> Close Connection Automatic




            #region Apply All Migrations Automatic
            /*context.Database.Migrate();*///Apply All Migration to Database دى طريق بدل ال update-database 
           //بس هنا بيشوف لو فى اى migration in Application لسة متعملهاش اى Apply خلاص ضيفها واعملها apply Automatic عشان منساش 
            //كل لما اعمل Run Check if application has Pending Migrations if Yes Apply this If Not Donothing يعنى شغال على طول ودى مشكلة طب لو اصلا مفيش اى Pending Migration وانا متاكد دى كدة مع كل Run لازم يروح يعمل Checking 
            #endregion

            #endregion
            //===================================================
            #region Open Connection With DbContext ITI For ASsignment 

           using  ITIDbContext context = new ITIDbContext();
            #endregion




            #endregion
            //==========================
            #region Session02

            #endregion
            //==========================
            #region Session03

            #endregion
            //==========================
            #region Session04

            #endregion
            //==========================
            #region Session05

            #endregion
        }
    }
}
