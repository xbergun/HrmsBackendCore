using System;
using System.Collections.Generic;

#nullable disable

namespace HrmsGraphql.Models
{
    public partial class JobAdvertisement
    {
        public int Id { get; set; }
        public string Employer { get; set; }
        public string JobPosition { get; set; }
        public string City { get; set; }
        public string JobDescription { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public string WorkType { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
