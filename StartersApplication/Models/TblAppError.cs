using System;
using System.Collections.Generic;

namespace StartersApplication.Models
{
    public partial class TblAppError
    {
        public int ErrorId { get; set; }
        public string? ErrorUrl { get; set; }
        public string? ErrorMessage { get; set; }
        public int? StatusCode { get; set; }
    }
}
