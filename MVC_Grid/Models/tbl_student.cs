using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Grid.Models
{
    public class tbl_student
    {
        [Key]
        public int std_id { get; set; }
        [DisplayName("Student Name")]
        public string std_name { get; set; }
        [DisplayName("Age")]
        [Range(5, 50)]
        public int std_age { get; set; }
        [DisplayName("E-mail-Id")]
        [DataType(DataType.EmailAddress)]
        public string std_email_id { get; set; }
        [DisplayName("Phone Number")]
        public string std_phonenumber { get; set; }
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string std_password { get; set; }

        [NotMapped]
        [DisplayName("Name As You Like")]
        [Compare("std_password")]
        public string std_confirmpassword { get; set; }
    }
}