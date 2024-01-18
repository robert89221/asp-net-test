
namespace asp_net_test2.Models
{
    public class Book(int Year, string Title)
    {
      public int Year { get; set; } = Year;
      public string Title { get; set; } = Title;

      List<Author> Authors { get; set; } = [];
    }
}
