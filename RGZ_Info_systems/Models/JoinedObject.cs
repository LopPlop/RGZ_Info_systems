using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_Info_systems.Models
{
    internal class JoinedObject
    {
        public DateTime DateOfPassage { get; set; }
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Position { get; set; }
        public DateTime EmployeeDate { get; set; }
        public string CourseName { get; set; }
        public int CourseId { get; set; }
        public int Duration { get; set; }
        public int Purpose { get; set; }
        public decimal Summary { get; set; }
    }
}
