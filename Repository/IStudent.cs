using Repository_pattern.Models;

namespace Repository_pattern.Repository
{
    public interface IStudent
    {
         List<StudentModel> getAllStudent();
         StudentModel getStudentById(int id);
    }
}
