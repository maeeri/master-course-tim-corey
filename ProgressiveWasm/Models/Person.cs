using System.ComponentModel.DataAnnotations;

namespace ProgressiveWasm.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
