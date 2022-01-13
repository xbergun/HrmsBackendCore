using System;
using System.Collections.Generic;

#nullable disable

namespace HrmsGraphql.Models
{
    public partial class JobSeeker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
