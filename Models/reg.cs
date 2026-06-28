
using System.ComponentModel.DataAnnotations;


namespace labtask.net.Models
{
    public class reg
    {

        [Required]

        public string name { get; set; }

        [Required]
        public int age { get; set; }

        [Required]
        public string email { get; set; }

    }
}
