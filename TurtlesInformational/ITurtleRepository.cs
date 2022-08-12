using TurtlesInformational.Models;

namespace TurtlesInformational
{
    public interface ITurtleRepository
    {
        public IEnumerable<Turtle> GetAllTurtles();


    }
}
