using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name =
            "movie 1"
            };
            List<Movie> movies = new List<Movie>()
                {
                    new Movie{Name="movie 2"},
                    new Movie{Name="movie 3"},
                };
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }

        [HttpGet("Movie/released/{year}/{month}")]
        public IActionResult ByRelease(int year, int month)
        {
            return Content("Movie released in " + year + "/" + month);
        }


        public IActionResult FilmClient()
        {
            Movie movie = new Movie()
            {
                Name = "Napoleon"
            };
            List<Customer> customers = new List<Customer>()
                {
                    new Customer{Name="Mohsen"},
                    new Customer{Name="Zied"},
                    new Customer{Name="Khmayes"},
            };

            var viewModel = new FilmClientViewModel { movie= movie, customers= customers };

            return View(viewModel);
        }
    }
}
