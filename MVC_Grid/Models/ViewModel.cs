using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Grid.Models
{
    public class ViewModel
    {
        public tbl_student tbl_students { get; set; }
        public List<GridModel> GridModels { get; set; }
    }
}