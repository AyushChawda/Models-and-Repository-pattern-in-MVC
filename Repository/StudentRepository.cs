using Repository_pattern.Models;

namespace Repository_pattern.Repository
{
    public class StudentRepository : IStudent
    {
        // method to get the list of all the students 
        public List<StudentModel> getAllStudent()
        {
            return DataContext();
        }

        // Method to get the student by roll number 
        public StudentModel getStudentById(int id)
        {
            return DataContext().Where(x => x.rollNo == id).FirstOrDefault();
        }

        // next we connect to database and get this data 
        private List<StudentModel> DataContext()
        {
            return new List<StudentModel>
        {
            new StudentModel{rollNo=1,name="Gautam",gander="male",standard=12},
            new StudentModel{rollNo=2,name="Animesh",gander="male",standard=8},
            new StudentModel{rollNo=3,name="Vishnu",gander="male",standard=9},
            new StudentModel{rollNo=4,name="Raghav",gander="male",standard=11},
            new StudentModel{rollNo=5,name="Surbhi",gander="female",standard=10},
        };
        }
    }
}
