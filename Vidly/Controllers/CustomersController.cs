using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private static List<Customer> customers = new List<Customer>();

        static CustomersController()
        {
            customers.Add(new Customer(1, "Cust 1"));
            customers.Add(new Customer(2, "Cust 2"));
            customers.Add(new Customer(3, "Cust 3"));
            customers.Add(new Customer(4, "Cust 4"));
            customers.Add(new Customer(5, "Cust 5"));
        }

        // GET: Customers
        public ActionResult Index()
        {       
            CustomersViewModel viewModel = new CustomersViewModel();

            viewModel.Customers = customers;

            if (customers.Count > 0)
            {
                return View(viewModel);
            }
            else
            {
                return Content("We don't have any customers yet");
            }


        }

        public ActionResult Details(int id)
        {
            if (id > 0 && id < 6)
            {
                return View(customers[id - 1]);
            }
            else
            {
                return HttpNotFound();
            }

        }

        public ActionResult New()
        {
            //var viewModel = new NewCustomerViewModel
            //{
            //    MembershipTypes = membershipTypes
            //};

            return View();
        }
    }
}