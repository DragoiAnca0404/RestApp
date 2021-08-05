
using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        // public string Id { get; set; }

        /*public string HowTo { get; set; }

        public string Line { get; set; }

        public string Platform { get; set; }*/

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}