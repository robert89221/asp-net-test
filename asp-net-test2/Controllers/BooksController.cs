
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

    static private List<Book> Books = new()
    {
      new Book(1980, "Ondskan"),
      new Book(2010, "Boken"),
      new Book(2012, "Äventyret"),
    };

    //  GET /api/books
    [HttpGet]
    public IActionResult GetAllBooks()
    {
      return Ok(Books);
    }

    // GET /api/books/id
    [HttpGet ("{id}")]
    public IActionResult GetBook(int id)
    {
      if (1 <= id && id <= Books.Count)
      {
        return Ok(Books[id - 1]);
      }
      else
      {
        return BadRequest("Bad book ID");
      }
    }

    //  POST /api/books
    [HttpPost]
    public IActionResult PostBook([FromBody]Book book)
    {
      Books.Add(book);
      return Ok(Books.Last());
    }

    //  DELETE /api/books/id
    [HttpDelete ("{id}")]
    public IActionResult DeleteBook(int id)
    {
      if (1 <= id && id <= Books.Count)
      {
        Books.RemoveAt(id - 1);
        return Ok();
      }
      else
      {
        return BadRequest("Bad book ID");
      }
    }


  }
}
