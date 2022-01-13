using System;
using System.Collections.Generic;

#nullable disable

namespace HrmsGraphql.Models
{
    public partial class Employeer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PositionId { get; set; }
    }
}
