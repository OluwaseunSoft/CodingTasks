using BasicWordCompletion.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/GetWord", async (string stem) =>
{
    if (stem == " " || stem == null)
    {
        var forecast = new Response
        {
            Data = summaries.ToArray()
        };
        return Results.Ok(forecast);
    }
    else
    {
        var forecast = new Response
        {
            Data = summaries.Where(x => x.ToLower().StartsWith(stem.ToLower())).ToArray()
        };
        if (forecast.Data.Length < 1) return Results.NotFound();
        return Results.Ok(forecast);
    }

});

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}