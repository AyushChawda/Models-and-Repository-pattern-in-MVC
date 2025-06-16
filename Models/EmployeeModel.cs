namespace Repository_pattern.Models
{

    // employ model for the about page to pass the model data to the view 
    public class EmployeeModel
    {
        public int eId { get; set; }
        public string eName { get; set; }
        public int eAge { get; set; }

        public string ePosition { get; set; }
    }
}
