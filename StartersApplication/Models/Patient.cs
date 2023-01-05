using System;
using System.Collections.Generic;

namespace StartersApplication.Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string? PatientName { get; set; }
        public string? Email { get; set; }
        public long? Contact { get; set; }
        public string? PatientHistory { get; set; }
    }
}
