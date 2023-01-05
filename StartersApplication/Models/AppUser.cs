using System;
using System.Collections.Generic;

namespace StartersApplication.Models
{
    public partial class AppUser
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? Email { get; set; }
        public string? Squestion { get; set; }
        public string? Sanswer { get; set; }
    }
}
