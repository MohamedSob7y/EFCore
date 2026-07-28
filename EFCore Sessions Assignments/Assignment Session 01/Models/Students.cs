using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sessions_Assignments.Assignment_Session_01.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public int Age {  get; set; }
        public string? Address { get; set; }
    }
}
