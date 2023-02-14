WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

Villains evil = new Villains();

evil.Name = "Eggman";
evil.IQ = 300;

app.MapGet("/",Answer);

app.MapGet("/Villan/", () => 
{
    return "Eggman";
});

app.Run();


static string Answer()
{
    return"Sonic The Hedgehog";
}