using Examination_System.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation.StudentForms
{
    public partial class frmStudentHomeUc : UserControl
    {
        private User _user;

        public frmStudentHomeUc(User user)
        {
            InitializeComponent();
            _user = user; // Store the user object
            DisplayWelcomeMessage();
        }

        private void DisplayWelcomeMessage()
        {
            // Check if the user object and name are not null
            if (_user != null && !string.IsNullOrEmpty(_user.FirstName))
            {
                // Customize the welcome message
                lblWelcome.Text = $"Welcome, {_user.FirstName}!";
            }
            else
            {
                // Default message if the name is not available
                lblWelcome.Text = "Welcome!";
            }
        }
    }
}
