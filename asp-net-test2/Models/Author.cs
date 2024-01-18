
namespace Authorship.Models
{
  public class Author(string Name)
  {
    public string Name { get; set; } = Name;

    public List<Book> Books { get; set; } = [];
  }
}
