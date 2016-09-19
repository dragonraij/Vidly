using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "The Incredibles", Id = 1},
                new Movie { Name = "Legend of Moana", Id = 2}
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);

        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers,
                Movie = movie
            };

            return View(viewModel);
            //return Content("Hello World");
            // return HttpNotFound();
            // return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //movies
        public ActionResult Index2(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageindex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/detail/{id}")]
        public ActionResult Details(int id)
        {
            var movie = new Movie();

            if (id == 1)
                movie.Name = "The Incredibles";
            else if (id == 2)
                movie.Name = "The Legend of Moana";
            else
                return HttpNotFound();
            return
                View(movie);

        }
    }
}