using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {

        //Se defineste randurile din baza de date
        // public int Id { get; set; }
        // public string HowTo { get; set; }
        // public string Line { get; set; }
        // public string Platform { get; set; }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }

    }
}