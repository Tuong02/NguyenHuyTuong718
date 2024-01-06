using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    [Table("Persons")]
    public class Person
    {
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}