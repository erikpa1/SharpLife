

namespace Books {
    public static class BooksDb {

        public static void AddBooksStore(this WebApplicationBuilder builder) {

            var connStr = builder.Configuration.GetConnectionString("DbConnStr");
            //builder.Services.AddSqlite("")

        }
    }
}
