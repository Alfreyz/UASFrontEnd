using System;
using System.ComponentModel.DataAnnotations;

namespace UAS.Models
{
    public class Students
    {
        [StringLength(8,MinimumLength = 0)]
        public string studentID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}