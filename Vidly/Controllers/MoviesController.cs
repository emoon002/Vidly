using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        [Route("movies/all")]
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "The Last Samurai" },
                new Movie { Id = 3, Name = "Crouching Tiger Hidden Dragon" }
            };

            var viewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View("Movies", viewModel);
        }
    }
}