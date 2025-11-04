var builder = WebApplication.CreateBuilder(args); // create kistro server. 1

var app = builder.Build(); // instance of the web application  2

app.MapGet("/", () => "Hello World!");

app.Run();
