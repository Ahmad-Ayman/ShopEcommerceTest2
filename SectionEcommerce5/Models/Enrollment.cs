using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SectionEcommerce5.Models
{
    public class Enrollment
    {
       
        public int UserId { get; set; }
        public User _User { get; set; }
        public int CourseId { get; set; }
        public Course _Course { get; set; }
    }
}
