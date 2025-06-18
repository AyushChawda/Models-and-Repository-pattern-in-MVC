namespace Repository_pattern.Models
{
    public class FormModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gendar gander { get; set; }
        public bool married { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }   
    }
    public enum Gendar
    {
        male, female
    }
}
