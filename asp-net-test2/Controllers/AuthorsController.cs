
using Authorship.Models;
using Microsoft.AspNetCore.Mvc;


namespace Authorship.Controllers
{
  [ApiController]
  [Route("api/authors")]
  public class AuthorsController : ControllerBase
  {

    /*  private readonly ILogger<AuthorsController> _logger;
      public AuthorsController(ILogger<AuthorsController> logger)
      {
        _logger = logger;
      }
    */

    private readonly Author[] Authors =
    {
      new Author("Jan Guillou"),
      new Author("Boke Skrivarsson"),
      new Author("Jan Jansson"),
    };

    //  GET /api/authors
    [HttpGet]
    public IActionResult GetAllAuthors()
    {
      return Ok(Authors.ToList());
    }

    // GET /api/authors/id
    [HttpGet ("{id}")]
    public IActionResult GetAuthor(int id)
    {
      if (1 <= id && id <= 3)
      {
        return Ok(Authors[id-1]);
      }
      else
      {
        return BadRequest("Bad author ID");
      }
    }

  }
}
