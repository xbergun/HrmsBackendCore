using System;
using System.Collections.Generic;

#nullable disable

namespace HrmsGraphql.Models
{
    public partial class Employer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyWebAdress { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyEmail { get; set; }
    }
}
