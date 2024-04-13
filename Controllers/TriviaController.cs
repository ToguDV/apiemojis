using apiemojis.Data;
using apiemojis.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace apiemojis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriviaController : ControllerBase
    {
        private readonly DataContext _context;
        public TriviaController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Trivia
        [HttpGet]
        [EnableCors("MyPolicy")]
        public ActionResult<IEnumerable<Trivia>> GetTrivias()
        {
            return _context.Trivias.ToList();
        }
    }
}
