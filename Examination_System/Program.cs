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
            Application.Run(General.frmLogin);
            //Application.Run(new frmAdmin());


            //Application.Run(new frmTeacherProfile());
            //Application.Run(new FormInsertQuestionsToExam(new Exam() {ID=1002, NoOfQuestions=9,CourseID=100 }));
            //Application.Run(new FormManageQuestions());
            //Application.Run(new FormAddExam());
        }
    }
}