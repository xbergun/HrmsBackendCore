using System;
using System.Collections.Generic;

#nullable disable

namespace HrmsGraphql.Models
{
    public partial class Cv
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmpAddress { get; set; }
        public string School { get; set; }
        public string WorkExperience { get; set; }
        public string CoverLetter { get; set; }
        public string Github { get; set; }
        public string Images { get; set; }
    }
}
