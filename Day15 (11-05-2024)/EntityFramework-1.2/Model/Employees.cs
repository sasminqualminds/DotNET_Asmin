using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Model
{
    
    public class Employees
    {
        [Key]
        public int EmpId { get; set; } 
        public string EmpName { get; set; }

        public int EmpAge { get; set; }

        public string EmpGrade { get; set; }    

    }
}
