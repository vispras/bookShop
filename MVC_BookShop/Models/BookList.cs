using System.Data.Entity;

namespace MVC_BookShop.Models
{
    public class BookList
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class BookListDBContext : DbContext
    {
        public DbSet<BookList> BookLists { get; set; }
    }
}