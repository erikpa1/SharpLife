
using Microsoft.EntityFrameworkCore;
using Sl.Api.Authors;

namespace Sl.Api.Stores
{
    public static class SharpLifeDbBuilder
    {
        public static void AddSharpLifeStore(this WebApplicationBuilder builder)
        {
            var connStr = builder.Configuration.GetConnectionString("DbConnStr");
            //builder.Services.AddSqlite("")
        }
    }

    public class SharpLifeDbContext(DbContextOptions<SharpLifeDbContext> options) : DbContext(options)
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Genre> BookGenres => Set<Genre>();
        public DbSet<SubGenre> BookSubgenres => Set<SubGenre>();
        public DbSet<Category> BookCategroy => Set<Category>();
        public DbSet<Topic> BookTopics => Set<Topic>();

        public DbSet<Author> Authors => Set<Author>();

    }

}
