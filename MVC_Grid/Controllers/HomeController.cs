using MVC_Grid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Grid.Controllers
{
    public class HomeController : Controller
    {
        tbl_studentModel db = new tbl_studentModel();
        public ActionResult Create()
        {
            ////var values = db.tbl_student.ToList();

            //ViewModel vm = new ViewModel();

            //vm.tbl_students = null;

            //vm.GridModels = db.tbl_student.ToList();

            return View();
        }

        public ActionResult Grid()
        {
            //var values = db.GridModels.ToList();

            return View();
        }


    }
}