using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Approach.Models
{
    public class Exam
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }
        
        public int Grade { get; set; }

        public Student Student { get; set; }

        public Course  Course { get; set; }

    }
}
