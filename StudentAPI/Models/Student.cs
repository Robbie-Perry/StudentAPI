﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAPI.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Program { get; set; }
    }
}