WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

List<Villains> evil = new();

evil.Add(new(){Name="Eggman", IQ=300});
evil.Add(new(){Name="Bowser", IQ=1});


app.MapGet("/",Answer);

app.MapGet("/Villan/", () => 
{
    return evil;
});

app.Run();


static string Answer()
{
    return"Sonic The Hedgehog";
}