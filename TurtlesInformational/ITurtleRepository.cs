using TurtlesInformational.Models;

namespace TurtlesInformational
{
    public interface ITurtleRepository
    {
        public IEnumerable<Turtle> GetAllTurtles();
        public Turtle GetTurtle(int id);
        public IEnumerable<Turtle> GetByCategoryID(int id);
        public IEnumerable<Turtle> SearchTurtle(string SearchPhrase);
    }   
}
