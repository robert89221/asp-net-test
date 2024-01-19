
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

    static private List<Author> Authors = new()
    {
      new Author("Jan Guillou"),
      new Author("Boke Skrivarsson"),
      new Author("Jan Jansson"),
    };

    //  GET /api/authors
    [HttpGet]
    public IActionResult GetAllAuthors()
    {
      return Ok(Authors);
    }

    // GET /api/authors/id
    [HttpGet ("{id}")]
    public IActionResult GetAuthor(int id)
    {
      if (1 <= id && id <= Authors.Count)
      {
        return Ok(Authors[id - 1]);
      }
      else
      {
        return BadRequest("Bad author ID");
      }
    }

    //  POST /api/authors
    [HttpPost]
    public IActionResult PostAuthor([FromBody] Author author)
    {
      Authors.Add(author);
      return Ok(Authors.Last());
    }

    //  DELETE /api/authors/id
    [HttpDelete ("{id}")]
    public IActionResult DeleteAuthor(int id)
    {
      if (1 <= id && id <= Authors.Count)
      {
        Authors.RemoveAt(id - 1);
        return Ok();
      }
      else
      {
        return BadRequest("Bad author ID");
      }
    }

  }
}
