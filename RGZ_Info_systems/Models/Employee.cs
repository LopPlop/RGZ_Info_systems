using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_Info_systems.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public int Position { get; set; }  
        public int Department { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
