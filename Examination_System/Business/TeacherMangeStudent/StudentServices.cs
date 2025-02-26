using ExaminationSystem.Data_Access;
using ExaminationSystem.Data_Access.Models;
using System.Data;
using Microsoft.Data.SqlClient;


namespace ExaminationSystem.Business.StudentService
{
    public class StudentService
    {
        private StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public DataTable GetAllStudents(int teacherId)
        {
            return _studentRepository.GetStudentsOfTeacher(teacherId);
        }

        public DataTable SearchStudentsByName(int teacherId, string fullName)
        {
            var parts = fullName.Trim().Split(' ');
            string firstName = parts[0];
            string lastName = parts.Length > 1 ? parts[1] : string.Empty;
            return _studentRepository.GetStudentsByName(teacherId, firstName, lastName);
        }

        public DataTable FilterStudentsByGender(int teacherId, bool isMale)
        {
            int genderValue = isMale ? 0 : 1;
            return _studentRepository.GetStudentsByGender(teacherId, genderValue);
        }

        public DataTable FilterStudentsByCourses(int teacherId, List<string> selectedCourses)
        {
            return _studentRepository.GetStudentsByCourses(teacherId, selectedCourses);
        }

        public List<string> GetTeacherCourses(int teacherId)
        {
            return _studentRepository.GetTeacherCourses(teacherId);
        }
        public DataTable FilterStudents(int teacherId, string name, int? gender, List<string> selectedCourses)
        {
            return _studentRepository.GetFilteredStudents(teacherId, name, gender, selectedCourses);
        }

    }
}
