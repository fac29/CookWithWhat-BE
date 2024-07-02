//this object provides us with APIs for configuring the host
var builder = WebApplication.CreateBuilder(args);

//exposes a run method to "run" the app(start HTTP server). Is also how we will define the routes.
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
