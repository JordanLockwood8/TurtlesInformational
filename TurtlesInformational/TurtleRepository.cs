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
        public Turtle GetTurtle(int id)
        {
            return _conn.QuerySingle<Turtle>("SELECT * FROM turtlespecies WHERE TurtleID = @id", new { id = id });
        }

        public IEnumerable<Turtle> GetByCategoryID(int id)
        {
            return _conn.Query<Turtle>("SELECT * FROM turtlespecies WHERE CategoryID = @id;", new { id = id });
        }
        public IEnumerable<Turtle> SearchTurtle(string SearchPhrase)
        {
            return _conn.Query<Turtle>($"SELECT * FROM turtlespecies Where name LIKE'%{SearchPhrase}%';");
        }

    }
}
