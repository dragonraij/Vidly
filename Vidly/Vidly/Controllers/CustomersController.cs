﻿using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customers
        public ViewResult Index()
        {


            var customers = _context.Customers.Include(c => c.MembershipType).ToList();


            return View(customers);
        }



        //customer details
        [Route("customers/detail/{id}")]
        public ActionResult Details(int id)
        {

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);


        }

        public ActionResult New()
        {
            return View();
        }


    }
}