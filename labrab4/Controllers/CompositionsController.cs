using labrab4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace labrab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompositionsController : ControllerBase
    {
        private readonly AppDbContext context;
        public CompositionsController(AppDbContext _context)
        {
            this.context = _context;
        }
        //list - display all items in the catalog
        //search - find items by query
        //add - add new item
        //del - delete item by full name
        //save - save items to disk
        //load - load items from disk
        //quit - exit

        // GET: api/<CompositionsController>/List
        [HttpGet("List")]
        public IEnumerable<Composition> Get()
        {
            return context.Compositions;
        }

        // GET api/<CompositionsController>/Search
        [HttpGet("Search")]
        public IEnumerable<Composition> Search(string query)
        {
            return context.Compositions.AsEnumerable().Where(x => x.SearchMatches(query));
        }

        // POST api/<CompositionsController>/Add
        [HttpPost("Add")]
        public void Add([FromBody] Composition value)
        {
            context.Compositions.Add(value);
            context.SaveChanges();
        }

        // PUT api/<CompositionsController>/Del
        [HttpDelete("Del")]
        public void Delete([FromBody] Composition value)
        {
            context.Compositions.Remove(value);
            context.SaveChanges();
        }
    }
}
