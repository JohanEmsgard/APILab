WebApplication app = WebApplication.Create();

app.MapGet("/",Answer);

app.Run();


static string Answer()
{
    return"THERE NOT BEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAANNNNNNNNNNNNNNNNNNNNNNNS!!!";
}