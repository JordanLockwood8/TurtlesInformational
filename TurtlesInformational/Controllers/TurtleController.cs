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
        public IActionResult ViewByTurtleID(int id)
        {
            var turtle = repo.GetTurtle(id);
            return View(turtle);
        }
        public IActionResult ViewByCategory(int id)
        {
            var turtle = repo.GetByCategoryID(id);
            return View(turtle);
        }
        public IActionResult ShowSearchResults(string SearchPhrase)
        {
            var filteredTurtle = repo.SearchTurtle(SearchPhrase);
            return View(filteredTurtle);
        }
    }
}
