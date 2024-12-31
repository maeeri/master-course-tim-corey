using System.ComponentModel.DataAnnotations;

namespace BlazorServerMessageWall.Models
{
    public class MessageModel
    {
        [Required]
        [MinLength(1), MaxLength(10)]
        public string Message { get; set; }
    }
}
