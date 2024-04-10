using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todo_reminder_api_dotnetcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        // GET api/<ToDoController>/5 -- Get all To-Dos on a Specific Board
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Board {id}";
        }

        // POST api/<ToDoController> -- Add a new To-Do to a Board
        [HttpPost]
        public void Post([FromBody] string value, int boardId)
        {
            Console.WriteLine($"Added new To-Do {value} to Board {boardId}");
        }

        // PUT api/<ToDoController>/5 -- Edit a To-Do
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine($"Modified To-Do {id} with {value}");
        }

        // DELETE api/<ToDoController>/5 -- Remove a To-Do
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine($"Deleted To-Do {id}");
        }
    }
}
