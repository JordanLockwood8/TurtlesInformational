using Dapper;
using System.Data;
using TurtlesInformational.Models;

namespace TurtlesInformational
{
    public class TurtleRepository : ITurtleRepository
    {
        private IDbConnection _conn;

        public TurtleRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Turtle> GetAllTurtles()
        {
            return _conn.Query<Turtle>("SELECT * FROM turtlespecies;");
        }

    }
}
