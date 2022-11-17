using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Approach.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
