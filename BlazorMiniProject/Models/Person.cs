using System.ComponentModel.DataAnnotations;

namespace BlazorMiniProject.Models
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        [Required]
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        [Required]
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
    }
}
