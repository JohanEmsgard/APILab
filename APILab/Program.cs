WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

Villanins evil = new Villains



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