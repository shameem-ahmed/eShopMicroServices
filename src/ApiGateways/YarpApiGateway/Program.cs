using Microsoft.AspNetCore.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

//Add services to DI container
//

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

builder.Services.AddRateLimiter(options => 
{
    options.AddFixedWindowLimiter("fixedPolicy", options2 => 
    {
        options2.Window = TimeSpan.FromSeconds(10);
        options2.PermitLimit = 2;
    });
});

var app = builder.Build();

//Configure the HTTP request pipeline
//

app.UseRateLimiter();

app.MapReverseProxy();

app.Run();
