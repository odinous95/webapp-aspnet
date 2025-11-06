var builder = WebApplication.CreateBuilder(args); // create kistro server. 1

var app = builder.Build(); // instance of the web application  2

app.Use(async(HttpContext context, RequestDelegate next)=>
{
    await context.Response.WriteAsync("Hello, World!");
    await next(context);
    await context.Response.WriteAsync(" Goodbye, World!");
});

app.Run();
