
using Authorship.Models;
using Microsoft.AspNetCore.Mvc;


namespace Authorship.Controllers
{
  [ApiController]
  [Route("api/books")]
  public class BooksController : ControllerBase
  {

    /*  private readonly ILogger<BooksController> _logger;
      public BooksController(ILogger<BooksController> logger)
      {
        _logger = logger;
      }
    */

    private readonly Book[] Books =
    {
      new Book(1980, "Ondskan"),
      new Book(2010, "Boken"),
      new Book(2012, "Äventyret"),
    };

    [HttpGet("{id}")]
    public IActionResult GetBooks(string id)
    {
      if (id.ToLower() == "all")
      {
        return Ok(Books.ToList());
      }
      else if (Int32.TryParse(id, out int n))
      {
        if (0 <= n && n <= 2)
        {
          return Ok(Books[n]);
        }
      }

      return BadRequest("Bad book ID");
    }

  }
}
