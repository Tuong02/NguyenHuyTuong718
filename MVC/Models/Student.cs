using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
    }
}
