﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wheeler.Model.DbEntities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Desigination { get; set; }
        public int AppUserId { get; set; }
        public bool IsActive { get;set; }
        public AppUsers AppUsers { get; set; }
    }
}
