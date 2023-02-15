WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

List<Villains> hero = new();

hero.Add(new(){Name="Sonic", Speed=9000});
hero.Add(new(){Name="Shadow", Speed=8500});


app.MapGet("/",Answer);

app.MapGet("/hero/", () => 
{
    return hero;
});


app.MapGet("/hero/{num}", (int num) =>
{
    if(num >= 0 && num < hero.Count)
    {
        return Results.Ok(hero[num]);
    }

    return Results.NotFound();
});

app.MapPost("/hero/",(Villains h) => 
{
    if (hero.Find(x => x.Name == h.Name) != null)
    {
        return Results.BadRequest();
    }

    hero.Add(h);
    Console.WriteLine(h.Name);
    return Results.Ok();
});

app.Run();


static string Answer()
{
    return"Sonic The Hedgehog";
}