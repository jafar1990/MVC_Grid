using MVC_Grid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Grid.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            using (tbl_studentModel db = new tbl_studentModel())
            {
                CustomersViewModel model = new CustomersViewModel();
                model.Customers = db.Customer.OrderBy(
                        m => m.CustomerID).Take(5).ToList();
                model.SelectedCustomer = null;
                return View(model);
            }
           
        }

        [HttpPost]
        public ActionResult New()
        {
            using (tbl_studentModel db = new tbl_studentModel())
            {
                CustomersViewModel model = new CustomersViewModel();
                model.Customers = db.Customer.OrderBy(
                               m => m.CustomerID).Take(5).ToList();
                model.SelectedCustomer = null;
                model.DisplayMode = "WriteOnly";
                return View("Index", model);
            }
        }


        [HttpPost]
        public ActionResult Insert(Customer obj)
        {
            using (tbl_studentModel db = new tbl_studentModel())
            {
                db.Customer.Add(obj);
                db.SaveChanges();

                CustomersViewModel model = new CustomersViewModel();
                model.Customers = db.Customer.OrderBy(
                                 m => m.CustomerID).Take(5).ToList();
                model.SelectedCustomer = db.Customer.Find(obj.CustomerID);
                model.DisplayMode = "ReadOnly";
                return View("Index", model);
            }
        }


        [HttpPost]
        public ActionResult Select(string id)
        {
            using (tbl_studentModel db = new tbl_studentModel())
            {
                CustomersViewModel model = new CustomersViewModel();
                model.Customers = db.Customer.OrderBy(
                            m => m.CustomerID).Take(5).ToList();
                model.SelectedCustomer = db.Customer.Find(id);
                model.DisplayMode = "ReadOnly";
                return View("Index", model);
            }
        }


        [HttpPost]
        public ActionResult Edit(string id)
        {
            using (tbl_studentModel db = new tbl_studentModel())
            {
                CustomersViewModel model = new CustomersViewModel();
                model.Customers = db.Customer.OrderBy(
                                m => m.CustomerID).Take(5).ToList();
                model.SelectedCustomer = db.Customer.Find(id);
                model.DisplayMode = "ReadWrite";
                return View("Index", model);
            }
        }


        [HttpPost]
        public ActionResult Update(Customer obj)
        {
            using (tbl_studentModel db = new tbl_studentModel())
            {
                Customer existing = db.Customer.Find(obj.CustomerID);
                existing.CompanyName = obj.CompanyName;
                existing.ContactName = obj.ContactName;
                existing.Country = obj.Country;
                db.SaveChanges();

                CustomersViewModel model = new CustomersViewModel();
                model.Customers = db.Customer.OrderBy(
                              m => m.CustomerID).Take(5).ToList();

                model.SelectedCustomer = existing;
                model.DisplayMode = "ReadOnly";
                return View("Index", model);
            }
        }


        [HttpPost]
        public ActionResult Delete(string id)
        {
            using (tbl_studentModel db = new tbl_studentModel())
            {
                Customer existing = db.Customer.Find(id);
                db.Customer.Remove(existing);
                db.SaveChanges();

                CustomersViewModel model = new CustomersViewModel();
                model.Customers = db.Customer.OrderBy(
                                  m => m.CustomerID).Take(5).ToList();

                model.SelectedCustomer = null;
                model.DisplayMode = "";
                return View("Index", model);
            }
        }


        [HttpPost]
        public ActionResult Cancel(string id)
        {
            using (tbl_studentModel db = new tbl_studentModel())
            {
                CustomersViewModel model = new CustomersViewModel();
                model.Customers = db.Customer.OrderBy(
                                  m => m.CustomerID).Take(5).ToList();
                model.SelectedCustomer = db.Customer.Find(id);
                model.DisplayMode = "ReadOnly";
                return View("Index", model);
            }
        }


    }


}