﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Data_Access.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TeacherID { get; set; }
        public int Grade { get; set; }
        public int Duration { get; set; }
    }
}
