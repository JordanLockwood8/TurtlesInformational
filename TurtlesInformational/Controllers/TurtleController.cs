using Microsoft.AspNetCore.Mvc;

namespace TurtlesInformational.Controllers
{
    public class TurtleController : Controller
    {
        private readonly ITurtleRepository repo;

        public TurtleController(ITurtleRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var turtles = repo.GetAllTurtles();
            return View(turtles);
        }
    }
}
