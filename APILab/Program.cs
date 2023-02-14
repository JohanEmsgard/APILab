WebApplication app = WebApplication.Create();

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