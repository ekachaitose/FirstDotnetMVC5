using FirstDotnetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstDotnetMVC.ViewModels;

namespace FirstDotnetMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movie = GetMovie();

         
            //var customer = new List<Customer>
            //{
            //    new Customer {Name = "Customer 1"},
            //    new Customer {Name = "Customer 3"}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customer
            //};

            return View(movie);
        }

        private IEnumerable<Movie> GetMovie()
        {
            return new List<Movie>
            {
                new Movie {Name = "Fantastic Beats"},
                new Movie {Name = "The Lord of The Ring"}
            };
        }
        //public ActionResult Edit(int id)
        //{
        //    return Content("Id = "+id);
        //}

       

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)  } ")]
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}