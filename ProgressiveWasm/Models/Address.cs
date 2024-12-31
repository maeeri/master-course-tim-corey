using System.ComponentModel.DataAnnotations;

namespace ProgressiveWasm.Models
{
    public class Address
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
