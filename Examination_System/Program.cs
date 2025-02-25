using Examination_System.Presentation;
using Examination_System.Presentation.TeacherForms;
using ExaminationSystem;
using ExaminationSystem.Data_Access.Models;
using ExaminationSystem.Presentation;

namespace Examination_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            General.frmLogin = new frmLogin();
            //General.primarycolor = getfromdatabase();
            Application.Run(General.frmLogin);
            //Application.Run(new frmStudentExamsHistory(13));
            //Application.Run(new frmStudentProfile());
            //Application.Run(new frmStudentCourses(13));
            //Application.Run(new frmStudentExam(13));

            //Application.Run(new frmTeacherProfile());
            //Application.Run(new FormInsertQuestionsToExam(new Exam() {ID=1002, NoOfQuestions=9,CourseID=100 }));
            //Application.Run(new FormManageQuestions());
            //Application.Run(new FormAddExam());
        }
    }
}