using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        
        public ActionResult Index() {


            CustomerList cl = new CustomerList();
            cl.Customers = new List<Customer>
            {
                new Customer {Name = "Pera", Id=1 },
                new Customer {Name = "Zika", Id=2 }
            };

            return View(cl);
        }

        public ActionResult Details(int id)
        {
            List<Customer> cl =  new List<Customer>
            {
                new Customer {Name = "Pera", Id=1 },
                new Customer {Name = "Zika", Id=2 }
            };

            foreach (var cust in cl)
            {
                if (cust.Id == id)
                {
                    return View(cust);
                }
            }

            return Content("Nema takvog korisnika");
        }
    }


}