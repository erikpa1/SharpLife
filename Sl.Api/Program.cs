
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Sl.Api.Stores;


WebApplication BuildApp()
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddValidation();

    //Authentification

    builder.Services
    .AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureId"));

    // Platform services

    builder.AddSharpLifeStore();
    builder.Services.AddOpenApi(); // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

    var connString = "Data Source=SharpLife.db";

    builder.Services.AddSqlite<SharpLifeDbContext>(
        connString,
        optionsAction: options => options.UseSeeding((context, _) =>
    {
        //Here you can create seedings

        if (context.Set<Genre>().Any() == false)
        {
            context.Set<Genre>().AddRange(
             new Genre { Id = 0, Name = "nonfiction" },
             new Genre { Id = 1, Name = "fiction" }
            );

            context.Set<SubGenre>().AddRange(
             new SubGenre { Id = 0, Name = "documentary" },
             new SubGenre { Id = 1, Name = "biography" }
            );


            context.Set<Category>().AddRange(
             new Category { Id = 0, Name = "nature" }
            );

            context.Set<Topic>().AddRange(
             new Topic { Id = 0, Name = "war" },
             new Topic { Id = 1, Name = "wildlife" },
             new Topic { Id = 2, Name = "tech" }
            );


        }

    }));


    return builder.Build();
}


var app = BuildApp();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<SharpLifeDbContext>();
    //db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/weatherforecast", () =>
{
    var summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
