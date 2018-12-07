using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SectionEcommerce5.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Column(TypeName ="decimal(18,2)")]
        public decimal TotalHours { get; set; }
        public ICollection<Enrollment> UserList { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category _Category { get; set; }
    }
}
