using Examination_System.Business;
using Examination_System.Business.Enums;
using Examination_System.Data_Access.Models;
using Examination_System.Presentation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.Presentation.AdminForms
{
    public partial class frmAdminActivityUc : UserControl
    {

        public frmAdminActivityUc()
        {
            InitializeComponent();


            // Clear existing columns (if needed)
            dgv_logs.Columns.Clear();

            // Configure DataGridView for Horizontal Scrolling
            dgv_logs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv_logs.ScrollBars = ScrollBars.Both; // Enable horizontal scroll
            dgv_logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_logs.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Add a single wide column
            DataGridViewColumn logColumn = new DataGridViewTextBoxColumn();
            logColumn.Name = "Log";
            logColumn.HeaderText = "Log";
            logColumn.Width = 1500; // Set a large width to enable horizontal scroll
            dgv_logs.Columns.Add(logColumn);

            // Get and add data
            List<ActivityLog> activityLogs = UserService.GetRecentAllActivities();
            foreach (ActivityLog item in activityLogs)
            {
                dgv_logs.Rows.Add(item.ToString());
            }

            // Allow horizontal scrolling
            dgv_logs.AllowUserToResizeColumns = true;
            dgv_logs.AllowUserToResizeRows = false;
        }


        
    }
}
