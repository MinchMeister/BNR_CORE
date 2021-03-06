﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BNR.DAL.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Credentials { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }
        public string Games { get; set; }
    }
}
