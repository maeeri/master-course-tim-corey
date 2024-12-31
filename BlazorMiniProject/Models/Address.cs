using System.ComponentModel.DataAnnotations;

namespace BlazorMiniProject.Models
{
    public class Address
    {
        [Required]
        private string _street;
        [Required]
        private string _city;
        [Required]
        private string _country;
        [Required]
        private string _postalCode;
        [Required]
        public string Street
        {
            get => _street;
            set => _street = value;
        }
        [Required]
        public string City
        {
            get => _city;
            set => _city = value;
        }
        [Required]
        public string Country
        {
            get => _country;
            set => _country = value;
        }
        [Required]
        public string PostalCode
        {
            get => _postalCode;
            set => _postalCode = value;
        }
    }
}
