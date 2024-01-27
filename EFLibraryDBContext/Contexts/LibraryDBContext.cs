using EFLibraryDBContext.Entities;
using Microsoft.EntityFrameworkCore;
namespace EFLibraryDBContext.Contexts
{
    public class LibraryDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConStr = "Data Source=LAPTOP-46JAQGOF\\SQLEXPRESS;" +
                "Initial Catalog=LibraryDBContext;Integrated Security=True" +
                ";Connect Timeout=30;" +
                "Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(ConStr);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Author>Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
