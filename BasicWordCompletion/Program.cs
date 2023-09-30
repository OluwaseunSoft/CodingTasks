using BasicWordCompletion.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/GetWord", async (string stem, IHttpClientFactory httpClientFactory) =>
{
    if (summaries == null)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://raw.githubusercontent.com/qualified/challenge-data/master/words_alpha.txt");
        var httpClient = httpClientFactory.CreateClient();
        var response = await httpClient.SendAsync(request);
        var d = response.Content.ReadAsStringAsync().Result;
        summaries = d.Split('\n');
    }
    if (stem == " " || stem == null || stem == "")
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

partial class Program
{
    static string[]? summaries;
}