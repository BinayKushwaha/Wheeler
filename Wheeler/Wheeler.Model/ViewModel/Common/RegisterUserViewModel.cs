﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wheeler.Model.ViewModel
{
    public class RegisterUserViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AppUserId { get; set; }
        public bool IsCompany { get; set; }
        public bool IsEmployee { get; set; }
        public string Email { get; set; }
    }
}
