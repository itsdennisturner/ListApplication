using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Step1
    {

        [Range(0, 200)]
        [Required]
        public int MyNum { get; set; }
    }
}
