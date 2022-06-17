using System;
using System.Collections.Generic;
using System.Text;

namespace School_Register.Data.Models
{
    public class StudentAccount : BaseAccount
    {
        public ICollection<Mark> Marks { get; set; }

        public int Grade { get; set; }

        public int ClassNumber { get; set; }
        
        public int StudentNumber { get; set; }
    }
}
