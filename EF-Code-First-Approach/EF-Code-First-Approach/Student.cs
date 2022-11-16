using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Approach
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public List<Course> Courses { get; set; }
    }
}
