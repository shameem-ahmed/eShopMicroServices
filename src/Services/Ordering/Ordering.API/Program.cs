var builder = WebApplication.CreateBuilder(args);

//Add services to the DI container

var app = builder.Build();

//Configure the HTTP request pipeline

app.Run();
