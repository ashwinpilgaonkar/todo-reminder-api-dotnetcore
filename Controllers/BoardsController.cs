using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todo_reminder_api_dotnetcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoardsController : ControllerBase
    {
        // GET: api/<BoardsController> -- List all Boards
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Board 1", "Board 2" };
        }

        // POST api/<BoardsController> -- Add a new Board
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Console.WriteLine($"Added new Board {value}");
        }

        // PUT api/<BoardsController>/5 -- Edit a Board
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine($"Modified board {id} with {value}");
        }

        // DELETE api/<BoardsController>/5 -- Remove a Board
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine($"Deleted board {id}");
        }
    }
}
