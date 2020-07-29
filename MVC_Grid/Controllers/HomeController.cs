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


            return View();
        }

        public ActionResult Grid()
        {

            return View();
        }


    }
}