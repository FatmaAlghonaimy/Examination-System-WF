using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class CombinedDateTimePicker : UserControl
    {
        public event EventHandler ValueChanged;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Value
        {
            get
            {
                return dateTimePickerDate.Value.Date + dateTimePickerTime.Value.TimeOfDay;
            }
            set
            {
                dateTimePickerDate.Value = value.Date;
                dateTimePickerTime.Value = value;
            }
        }
        public CombinedDateTimePicker()
        {
            InitializeComponent();
            dateTimePickerDate.Value = DateTime.Today;
            dateTimePickerTime.Value = DateTime.Now;
            dateTimePickerDate.ValueChanged += DateTimePicker_ValueChanged;
            dateTimePickerTime.ValueChanged += DateTimePicker_ValueChanged;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
