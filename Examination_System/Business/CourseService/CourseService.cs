using Examination_System.Data_Access;
using ExaminationSystem.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Business
{
    public static class CourseService
    {
        public static DataTable GetAllCourses()
        {
            return CourseRepository.GetAllCourses();
        }
        public static DataTable GetAllCoursesWithTeacherID(int teacherID)
        {
            return CourseRepository.GetAllCoursesWithTeacherID(teacherID);
        }
        public static List<Course> GetAllCoursesListWithTeacherID(int teacherID)
        {
            return CourseRepository.GetAllCoursesListWithTeacherID(teacherID);
        }
        public static string GetCourseNameByCourseID(int courseID)
        {
            return CourseRepository.GetCourseNameByCourseID(courseID);
        }
    }
}
