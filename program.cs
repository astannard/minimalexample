//global using FastEndpoints;

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.UseFastEndpoints();
//app.Run();

global using FastEndpoints;

var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints();

var app = builder.Build();
app.UseFastEndpoints();
app.Run();