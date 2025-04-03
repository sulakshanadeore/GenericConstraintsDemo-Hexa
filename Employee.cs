using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGenericConstraintsLibrary
{
    public class Employee
    {
        public string City { get; set; }
        public string Name { get; set; }
    }
    public class Manager : Employee 
    {

        public int Deptno { get; set; }
        public string DeptName { get; set; }

    }
}
