
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

    //  GET /api/books
    [HttpGet]
    public IActionResult GetAllBooks()
    {
      return Ok(Books.ToList());
    }

    // GET /api/books/id
    [HttpGet ("{id}")]
    public IActionResult GetBook(int id)
    {
      if (1 <= id && id <= 3)
      {
        return Ok(Books[id-1]);
      }
      else
      {
        return BadRequest("Bad book ID");
      }
    }

  }
}
