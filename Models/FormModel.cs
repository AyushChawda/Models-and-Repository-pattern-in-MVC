using System.ComponentModel.DataAnnotations;

namespace Repository_pattern.Models
{
    public class FormModel
    {
        //public string Name { get; set; }
        //public int Age { get; set; }
        //public Gendar gander { get; set; }
        //public bool married { get; set; }
        //public string Email { get; set; }

        //public string Password { get; set; }   


        // model validation 

        [Required(ErrorMessage ="Enter you name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter you age")]

        [Range(18,45, ErrorMessage = "Age must be 18 to 45")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Select you gander")]
        public Gendar gander { get; set; }

        [Required(ErrorMessage = "Select you status")]
        public bool married { get; set; }

        [Required(ErrorMessage = "Enter you Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter you Password")]
        public string Password { get; set; }
    }
    public enum Gendar
    {
        male, female
    }
}
