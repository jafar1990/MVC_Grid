using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Grid.Models
{
    [Table("tbl_student")]
    public class GridModel
    {
        [Key]
        public int std_id { get; set; }

        public string std_name { get; set; }

        public int std_age { get; set; }

        public string std_email_id { get; set; }

        public string std_phonenumber { get; set; }

        public string std_password { get; set; }

    }
}