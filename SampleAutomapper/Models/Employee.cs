using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAutomapper.Models
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

    }
}