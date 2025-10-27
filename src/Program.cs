using BugStore.settings; // Adicione este using

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServerDbContext(builder.Configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
