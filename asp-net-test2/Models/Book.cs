
namespace Authorship.Models
{
  public class Book(int Year, string Title)
  {
    public int Year { get; set; } = Year;
    public string Title { get; set; } = Title;

    public List<Author> Authors { get; set; } = [];
  }
}
