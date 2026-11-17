using Microsoft.EntityFrameworkCore;

namespace Books {
    public static class BooksDbBuilder {

        public static void AddBooksStore(this WebApplicationBuilder builder) {
            var connStr = builder.Configuration.GetConnectionString("DbConnStr");
            //builder.Services.AddSqlite("")

        }
    }

    public class BooksDbContext(DbContextOptions<BooksDbContext> options) : DbContext(options) {

        public DbSet<Book> Books => Set<Book>();




    }
}
