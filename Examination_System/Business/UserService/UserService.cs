using Examination_System.Business.Enums;
using Examination_System.Data_Access;
using Examination_System.Data_Access.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;


namespace Examination_System.Business
{
    public static class UserService
    {
        public static Tuple<string, User> Login(string usernameOrEmail, string password)
        {
			try
			{
                Tuple<int, User> result = UserRepository.GetLogin(usernameOrEmail, password);
                switch (result.Item1)
                {
                    case 0:
                        return (new Tuple<string, User>("Login successful.", result.Item2));
                    case 1:
                        return (new Tuple<string, User>("Invalid username or email.", result.Item2));
                    case 2:
                        return (new Tuple<string, User>("Incorrect password.", result.Item2));
                    default:
                        return (new Tuple<string, User>("Unknown error.", result.Item2));
                }
            }
			catch (Exception ex)
			{

				throw ex;
			}
        }
        
        public static void Logout()
        {
            General.LoggedUser = null;
        }

        public static Tuple<string, int> UpdateUserData(User updatedData)
        {
            try
            {
                int result = UserRepository.UpdateUserData(updatedData);
                switch (result)
                {
                    case 0:
                        return (new Tuple<string, int>("Error: Data was not saved", result));
                    case 1:
                        return (new Tuple<string, int>("Success: Data was saved successfully!", result));

                    case -1:
                        return (new Tuple<string, int>("User was not found", result));

                    default:
                        return (new Tuple<string, int>("Unknown error.", result));
                       
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void SetUserImage(PictureBox pic, User user)
        {
            string imagePath = Path.Combine(General.rootPath, "Images");
            if (user.UserImg != null)
            {
                using (MemoryStream stream = new MemoryStream(user.UserImg))
                {

                    pic.Image = Image.FromStream(stream);
                }
            } else
            {
                string imageFileName = user.Gender == Business.Enums.Gender.Male
                ? "man.png"
                : "woman.png";


                string fullImagePath = Path.Combine(imagePath, imageFileName);


                if (File.Exists(fullImagePath))
                {
                    pic.Image = new Bitmap(fullImagePath);
                }
                else
                {
                    // Handle the case when the image file doesn't exist
                    MessageBox.Show("Profile image not found at: " + fullImagePath);
                }
            }

            
        }

        public static DataTable GetAllTeachers()
        {
            return UserRepository.GetAllTeachers();
        }

        public static DataTable GetAllCoursesStudentEnrolledIn(int studentId)
        {
            try
            {
                return UserRepository.GetAllCoursesStudentEnrolledIn(studentId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable GetAllStudents()
        {
            return UserRepository.GetAllStudents();
        }

        public static DataTable GetAllStudentsByTeacherId(int teacherId)
        {
            return UserRepository.GetAllStudentsByTeacherId(teacherId);
        }

        public static DataTable GetStudentsByCourseId(int courseId)
        {
            return UserRepository.GetStudentsByCourseId(courseId);
        }

        public static DataTable GetStudentsByTeacherAndCourse(int courseId, int teacherId)
        {
            if(courseId == 0 && teacherId != 0)
            {
                return GetAllStudentsByTeacherId(teacherId);
            } else if(teacherId == 0 && courseId != 0)
            {
                return GetStudentsByCourseId(courseId);
            } else if(courseId != 0 & teacherId != 0)
            {
                return UserRepository.GetStudentsByTeacherAndCourse(courseId, teacherId);
            } else
            {
                return GetAllStudents();
            }
        }
        public static DataTable FilterStudents(int courseId, int teacherId)
        {
            return UserRepository.FilterStudents(teacherId, courseId);
        }

        public static User GetUsrById(int userId)
        {
            return UserRepository.GetUsrById(userId);
        }

        public static int DeleteUserById(int userId)
        {
            try
            {
                return UserRepository.DeleteUsrById(userId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public static int CreateUpdateUser(User user, List<int> coursesIds, OperationMode operationMode)
        {
            try
            {
                return UserRepository.CreateUpdateUser(user, coursesIds, operationMode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable GetStudentCourses(int studentId)
        {
            SqlCommand cmd = new SqlCommand($"select c.Id, c.CourseName, u.FirstName +' '+ u.LastName as [TeacherName], c.Grade, c.Duration from Courses c\r\n  join StudentCourses sc \r\n  on sc.CourseID = c.ID\r\n  join Users u \r\n  on u.id = c.TeacherID\r\n  where sc.StudentID = {studentId}");
            return UserRepository.UserDAL(cmd);
        }

        public static DataTable GetStudentExams(int studentId, int courseId)
        {
            SqlCommand cmd = new SqlCommand($"select E.Id as ExamId,\r\n  case \r\n\twhen E.ExamType = 0 then 'Practice Exam' \r\n\telse 'Final Exam'\r\n\tend as [Exam Type],\r\n  c.CourseName, \r\n  E.StartTime,\r\n  E.EndTime,\r\n  E.Duration,\r\n  E.NoOFQuestions,\r\n  case\r\n\twhen E.Status = 0 then 'Pending'\r\n\twhen E.Status = 1 then 'Started'\r\n\telse 'Finished' end as [Exam Status]\r\n\r\n  from Exam E\r\n  join StudentCourses sc \r\n  join Courses C\r\n  on C.id = sc.CourseID\r\n  on sc.CourseID = E.CourseID\r\n  join Users u \r\n  on u.ID = sc.StudentID\r\n  where u.id = {studentId} and c.ID = {courseId}");
            return UserRepository.UserDAL(cmd);
        }

        public static DataTable GetStudentExamQuestions(int studentId, int examId)
        {
            SqlCommand cmd = new SqlCommand($"select distinct Q.*, Eq.ExamID from Questions Q\r\n\tjoin ExamQuestion EQ\r\n\ton Q.id = EQ.QuestionID\r\n\tjoin StudentCourses SC\r\n\ton Q.CourseID = SC.CourseID\r\nwhere sc.StudentID = {studentId} and EQ.ExamID = {examId}");
            return UserRepository.UserDAL(cmd);
        }

        public static DataTable GetStudentExamQuestionAnswers(int questionId)
        {
            SqlCommand cmd = new SqlCommand($"select * from Answers where QuestionID = {questionId}");
            return UserRepository.UserDAL(cmd);
        }

    }
}
