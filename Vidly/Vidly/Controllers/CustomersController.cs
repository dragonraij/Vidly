using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith",Id = 1},
                new Customer { Name = "Eric Andreas", Id = 2}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        //customer details
        [Route("customers/detail/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = new Customer();
            if (id == 1)
            {
                customer.Name = "John Smith";

            }
            else if (id == 2)
                customer.Name = "Eric Andreas";
            else
                return HttpNotFound();
            return View(customer);


        }


    }
}