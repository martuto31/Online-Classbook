using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School_Register.Data.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        public int Evaluation { get; set; }
        public StudentAccount StudentAccount { get; set; }

        public SubjectEnum Subject { get; set; }



        public string Message { get; set; }
    }
}
